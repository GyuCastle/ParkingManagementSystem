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
            this.FormClosed += VehicleNumberInputForm_FormClosed;

            // KeyDown 이벤트 연결
            txtVehicleNumber.KeyDown += txtVehicleNumber_KeyDown;
        }

        // 텍스트박스 클릭 시 가상 키보드 실행
        private void txtVehicleNumber_Click(object sender, EventArgs e)
        {
            StartVirtualKeyboard();  // 가상 키보드 실행
        }

        private void txtVehicleNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  // Enter 키를 누른 경우
            {
                e.SuppressKeyPress = true;  // Enter 키가 텍스트박스에 입력되지 않도록 방지
                CloseVirtualKeyboard();    // 가상 키보드 닫기
                btnSubmit_Click(sender, e);  // Submit 버튼 클릭 이벤트 호출
            }
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
        // 가상 키보드 닫기
        private void CloseVirtualKeyboard()
        {
            try
            {
                // 모든 osk.exe 프로세스를 종료
                foreach (var process in Process.GetProcessesByName("osk"))
                {
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("가상 키보드를 닫는 동안 문제가 발생했습니다: " + ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string vehicleNumber = txtVehicleNumber.Text?.Trim();  // 차량 번호 입력
            string vehicleType = cmbVehicleType.SelectedItem?.ToString();  // 차종 선택

            // 입력값 유효성 검사
            if (string.IsNullOrEmpty(vehicleNumber))
            {
                MessageBox.Show("차량 번호를 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(vehicleType))
            {
                MessageBox.Show("차종을 선택해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    // ParkingSpot 테이블에서 차량 번호 중복 확인
                    string parkingSpotCheckQuery = "SELECT COUNT(*) FROM ParkingSpot WHERE vehicle_number = :vehicle_number";
                    using (OracleCommand parkingSpotCheckCommand = new OracleCommand(parkingSpotCheckQuery, connection))
                    {
                        parkingSpotCheckCommand.Parameters.Add("vehicle_number", OracleDbType.Varchar2).Value = vehicleNumber;

                        int parkingSpotCount = Convert.ToInt32(parkingSpotCheckCommand.ExecuteScalar());
                        if (parkingSpotCount > 0)
                        {
                            MessageBox.Show("현재 차량이 이미 주차 중입니다.", "중복 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Vehicle 테이블에서 기존 등록된 차량인지 확인
                    string vehicleCheckQuery = "SELECT COUNT(*) FROM Vehicle WHERE vehicle_number = :vehicle_number";
                    using (OracleCommand vehicleCheckCommand = new OracleCommand(vehicleCheckQuery, connection))
                    {
                        vehicleCheckCommand.Parameters.Add("vehicle_number", OracleDbType.Varchar2).Value = vehicleNumber;

                        int vehicleCount = Convert.ToInt32(vehicleCheckCommand.ExecuteScalar());
                        if (vehicleCount > 0)
                        {
                            MessageBox.Show("환영합니다! 또 오셨군요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO Vehicle (vehicle_number, vehicle_type) VALUES (:vehicle_number, :vehicle_type)";
                            using (OracleCommand insertCommand = new OracleCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.Add("vehicle_number", OracleDbType.Varchar2).Value = vehicleNumber;
                                insertCommand.Parameters.Add("vehicle_type", OracleDbType.Varchar2).Value = vehicleType;

                                insertCommand.ExecuteNonQuery();
                            }

                            MessageBox.Show("차량 번호와 차종이 등록되었습니다.", "등록 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                // ParkingSpotSelectionForm으로 이동
                ParkingSpotSelectionForm parkingSpotSelectionForm = new ParkingSpotSelectionForm(vehicleNumber);
                parkingSpotSelectionForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // 예외 메시지 출력
                MessageBox.Show("차량 정보를 저장하는데 문제가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VehicleNumberInputForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 폼이 닫히면 애플리케이션 종료
            Application.Exit(); // 애플리케이션 종료
        }
    }
}
