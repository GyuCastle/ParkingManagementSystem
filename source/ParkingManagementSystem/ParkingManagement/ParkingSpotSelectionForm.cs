using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace ParkingManagement
{
    public partial class ParkingSpotSelectionForm : Form
    {
        private string connectionString = "User Id=ParkingAdmin; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe)));";
        private OracleDataAdapter DBAdapter;
        private DataSet DS;

        public ParkingSpotSelectionForm()
        {
            InitializeComponent();
            InitializeButtonEvents(); // 각 버튼에 클릭 이벤트 설정
            LoadParkingSpotStatus();  // 폼 로드시 주차 공간 상태 로드
        }

        // 각 버튼에 클릭 이벤트 할당
        private void InitializeButtonEvents()
        {
            for (int i = 1; i <= 30; i++)
            {
                Button btn = (Button)this.Controls.Find($"btnSpot{i}", true)[0];
                btn.Click += ParkingSpotButton_Click;

                // 장애인 주차석 표시를 위한 Paint 이벤트 추가
                if (i >= 26 && i <= 30) // 장애인 전용 주차석 (26~30)
                {
                    btn.Paint += Button_Paint_DisabledSpot;
                }
            }
        }

        // 장애인 주차석 표시용 노란색 원 그리기
        private void Button_Paint_DisabledSpot(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            Graphics g = e.Graphics;

            int diameter = 8; // 원의 지름
            int x = btn.Width - diameter - 2;
            int y = 2;

            // 노란색 원 그리기
            using (SolidBrush yellowBrush = new SolidBrush(Color.Yellow))
            {
                g.FillEllipse(yellowBrush, x, y, diameter, diameter);
            }

            // 검은색 테두리 그리기
            using (Pen blackPen = new Pen(Color.Black, 1))
            {
                g.DrawEllipse(blackPen, x, y, diameter, diameter);
            }
        }

        // 주차 공간 상태를 데이터베이스에서 불러와 버튼 색상 설정
        private void LoadParkingSpotStatus()
        {
            try
            {
                string query = "SELECT spot_number, is_occupied FROM ParkingSpot";
                DBAdapter = new OracleDataAdapter(query, connectionString);
                OracleCommandBuilder commandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();

                DBAdapter.Fill(DS, "ParkingSpot");

                // DataTable에 기본 키 설정
                DataTable table = DS.Tables["ParkingSpot"];
                table.PrimaryKey = new DataColumn[] { table.Columns["spot_number"] };

                foreach (DataRow row in DS.Tables["ParkingSpot"].Rows)
                {
                    int spotNumber = Convert.ToInt32(row["spot_number"]);
                    bool isOccupied = Convert.ToInt32(row["is_occupied"]) == 1;

                    // 주차 공간 버튼 찾기
                    Button btn = (Button)this.Controls.Find($"btnSpot{spotNumber}", true)[0];
                    btn.BackColor = isOccupied ? Color.Green : DefaultBackColor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading parking spots: " + ex.Message);
            }
        }


        // 주차 공간 상태를 DataSet에 업데이트 후 DB에 반영
        private void UpdateParkingSpotStatus(int spotNumber, bool isOccupied)
        {
            try
            {
                DataRow row = DS.Tables["ParkingSpot"].Rows.Find(spotNumber);
                if (row != null)
                {
                    row["is_occupied"] = isOccupied ? 1 : 0;
                    DBAdapter.Update(DS, "ParkingSpot");
                    DS.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating parking spot status: " + ex.Message);
            }
        }

        private void ParkingSpotButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string spotNumberStr = clickedButton.Name.Replace("btnSpot", "");
            int spotNumber = int.Parse(spotNumberStr);

            // 이미 주차된 자리인지 확인
            if (clickedButton.BackColor == Color.Green)
            {
                MessageBox.Show("주차 된 주차석 입니다. 빈 주차석을 선택해주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // 이미 주차된 경우, 추가 작업 없이 종료
            }

            // 장애인 주차석(26~30번) 클릭 시 확인 메시지
            if (spotNumber >= 26 && spotNumber <= 30)
            {
                DialogResult result = MessageBox.Show($"{spotNumber}번 주차석은 장애인 주차석입니다. 주차하시겠습니까?", "장애인 주차석 경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return; // 사용자가 '취소'를 누르면 함수 종료
                }
            }

            // 주차 가능 자리라면 상태 변경
            bool isOccupied = clickedButton.BackColor == DefaultBackColor;
            clickedButton.BackColor = isOccupied ? Color.Green : DefaultBackColor;

            // 주차 상태를 DataSet과 데이터베이스에 저장
            UpdateParkingSpotStatus(spotNumber, isOccupied);

            // 메시지 박스 표시
            MessageBox.Show($"확인 버튼을 누른 뒤, {spotNumber}번 주차 공간으로 주차해주세요.", "주차 공간 안내", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 5초 동안 다른 클릭을 차단하기 위해 폼 잠금
            this.Enabled = false;

            // 5초 뒤에 ParkingStatusForm으로 화면 전환
            Task.Delay(5000).ContinueWith(t =>
            {
                // 화면 전환 코드
                this.Invoke((Action)(() =>
                {
                    ParkingStatusForm statusForm = new ParkingStatusForm();
                    statusForm.Show();
                    this.Hide(); // 현재 폼 숨기기

                    // 폼 활성화
                    this.Enabled = true;
                }));
            });
        }
    }
}
