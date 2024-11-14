using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace ParkingManagement
{
    public partial class VehicleNumberInputForm : Form
    {
        private string connectionString = "User Id=ParkingAdmin; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe)));";
        public VehicleNumberInputForm()
        {
            InitializeComponent();
        }

        // 텍스트박스 클릭 시 가상 키보드 실행
        private void txtVehicleNumber_Click(object sender, EventArgs e)
        {
            StartVirtualKeyboard();  // 가상 키보드 실행
        }
        // 가상 키보드 실행
        private void StartVirtualKeyboard()
        {
            try
            {
                Process.Start("osk.exe");  // osk.exe (가상 키보드) 실행
            }
            catch (Exception ex)
            {
                MessageBox.Show("가상 키보드를 실행하는데 문제가 발생했습니다: " + ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string vehicleNumber = txtVehicleNumber.Text;  // 텍스트박스에서 차량 번호
            string vehicleType = cmbVehicleType.SelectedItem.ToString();  // 차종 선택

            if (string.IsNullOrEmpty(vehicleNumber) || string.IsNullOrEmpty(vehicleType))
            {
                MessageBox.Show("차량 번호와 차종을 모두 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 차량 번호와 차종을 Vehicle 테이블에 저장
                // 차번과 차량 타입만 저장
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Vehicle (vehicle_number, vehicle_type) VALUES (:vehicle_number, :vehicle_type)";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        // 매개변수 설정
                        command.Parameters.Add("vehicle_number", OracleDbType.Varchar2).Value = vehicleNumber;
                        command.Parameters.Add("vehicle_type", OracleDbType.Varchar2).Value = vehicleType;

                        // 쿼리 실행
                        command.ExecuteNonQuery();
                    }
                }

                // 차량 번호와 차종이 정상적으로 등록되었다는 메시지 표시
                MessageBox.Show("차량 번호와 차종이 등록되었습니다.", "등록 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ParkingSpotSelectionForm으로 이동
                ParkingSpotSelectionForm parkingSpotSelectionForm = new ParkingSpotSelectionForm();
                parkingSpotSelectionForm.Show();
                this.Hide();  // 현재 폼 숨기기
            }
            catch (Exception ex)
            {
                MessageBox.Show("차량 정보를 저장하는데 문제가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
