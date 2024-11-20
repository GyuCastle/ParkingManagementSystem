using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                    // 총 잔여 공간 구하기
                    string totalQuery = "SELECT COUNT(*) FROM ParkingSpot WHERE is_occupied = 0";
                    using (OracleCommand command = new OracleCommand(totalQuery, connection))
                    {
                        int totalAvailableSpots = Convert.ToInt32(command.ExecuteScalar());
                        lblTotalAvailableSpots.Text = $"총 잔여 자리: {totalAvailableSpots}"; // 총 잔여 자리 표시
                    }

                    // 일반석 빈 자리 구하기
                    string regularQuery = "SELECT COUNT(*) FROM ParkingSpot WHERE is_occupied = 0 AND spot_number <= 25";
                    using (OracleCommand command = new OracleCommand(regularQuery, connection))
                    {
                        int regularAvailableSpots = Convert.ToInt32(command.ExecuteScalar());
                        lblRegularAvailableSpots.Text = $"일반석 빈 자리: {regularAvailableSpots}"; // 일반석 빈 자리 표시
                    }

                    // 장애석 빈 자리 구하기
                    string disabledQuery = "SELECT COUNT(*) FROM ParkingSpot WHERE is_occupied = 0 AND spot_number >= 26";
                    using (OracleCommand command = new OracleCommand(disabledQuery, connection))
                    {
                        int disabledAvailableSpots = Convert.ToInt32(command.ExecuteScalar());
                        lblDisabledAvailableSpots.Text = $"장애석 빈 자리: {disabledAvailableSpots}"; // 장애석 빈 자리 표시
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading parking status: " + ex.Message);
            }
        }

        private void lblTotalAvailableSpots_Click(object sender, EventArgs e)
        {
            // 주차 공간을 선택한 후 차량 번호 입력 폼으로 전환
            VehicleNumberInputForm vehicleInputForm = new VehicleNumberInputForm();
            vehicleInputForm.Show();  // 차량 번호 입력 폼 띄우기
            this.Hide();  // 현재 폼은 숨김
        }

        private void lblRegularAvailableSpots_Click(object sender, EventArgs e)
        {
            // 주차 공간을 선택한 후 차량 번호 입력 폼으로 전환
            VehicleNumberInputForm vehicleInputForm = new VehicleNumberInputForm();
            vehicleInputForm.Show();  // 차량 번호 입력 폼 띄우기
            this.Hide();  // 현재 폼은 숨김
        }

        private void lblDisabledAvailableSpots_Click(object sender, EventArgs e)
        {
            // 주차 공간을 선택한 후 차량 번호 입력 폼으로 전환
            VehicleNumberInputForm vehicleInputForm = new VehicleNumberInputForm();
            vehicleInputForm.Show();  // 차량 번호 입력 폼 띄우기
            this.Hide();  // 현재 폼은 숨김
        }

        private void ParkingStatusForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 폼이 닫히면 애플리케이션 종료
            Application.Exit(); // 애플리케이션 종료
        }
    }
}
