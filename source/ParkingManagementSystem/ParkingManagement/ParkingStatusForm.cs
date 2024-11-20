using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace ParkingManagement
{
    public partial class ParkingStatusForm : Form
    {
        private string connectionString = "User Id=ParkingAdmin; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe)));";
        public ParkingStatusForm()
        {
            InitializeComponent();
            LoadParkingStatus();  // 주차 공간 상태 로드
        }

        private void ParkingStatusForm_Click(object sender, EventArgs e)
        {
            // 주차 공간을 선택한 후 차량 번호 입력 폼으로 전환
            ShowVehicleInputForm();
        }
        // 라벨 클릭 시 차량 번호 입력 폼으로 이동하는 공통 메서드
        private void ShowVehicleInputForm()
        {
            VehicleNumberInputForm vehicleInputForm = new VehicleNumberInputForm();
            vehicleInputForm.Show();  // 차량 번호 입력 폼 띄우기
            this.Hide();  // 현재 폼은 숨김
        }

        // 주차 공간 상태 로드
        private void LoadParkingStatus()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    // 주차 공간별 상태 로드
                    SetParkingStatusLabel(connection, "WHERE is_occupied = 0", lblTotalAvailableSpots, "총 잔여 자리");
                    SetParkingStatusLabel(connection, "WHERE is_occupied = 0 AND spot_number <= 25", lblRegularAvailableSpots, "일반석 빈 자리");
                    SetParkingStatusLabel(connection, "WHERE is_occupied = 0 AND spot_number >= 26", lblDisabledAvailableSpots, "장애석 빈 자리");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading parking status: " + ex.Message);
            }
        }
        // 라벨에 주차 공간 상태를 설정하는 사용자 정의 함수
        private void SetParkingStatusLabel(OracleConnection connection, string condition, Label label, string labelText)
        {
            string query = $"SELECT COUNT(*) FROM ParkingSpot {condition}";
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                int availableSpots = Convert.ToInt32(command.ExecuteScalar());
                label.Text = $"{labelText}: {availableSpots}";  // 라벨에 데이터 표시
            }
        }
        // 각 라벨 클릭 시 차량 번호 입력 폼으로 전환
        private void lblTotalAvailableSpots_Click(object sender, EventArgs e) => ShowVehicleInputForm();
        private void lblRegularAvailableSpots_Click(object sender, EventArgs e) => ShowVehicleInputForm();
        private void lblDisabledAvailableSpots_Click(object sender, EventArgs e) => ShowVehicleInputForm();

        private void ParkingStatusForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 폼이 닫히면 애플리케이션 종료
            Application.Exit(); // 애플리케이션 종료
        }
    }
}
