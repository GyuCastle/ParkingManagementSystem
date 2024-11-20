using System;
using System.Data;
using Oracle.DataAccess.Client;
using System.Windows.Forms;

namespace ParkingManagement
{
    internal class StoreDiscountManager
    {
        // 필드
        private OracleDataAdapter dBAdapter;
        private DataSet dS;
        private OracleCommandBuilder myCommandBuilder;
        private DataTable discountTable;

        // 프로퍼티
        public OracleDataAdapter DBAdapter { get { return dBAdapter; } set { dBAdapter = value; } }
        public DataSet DS { get { return dS; } set { dS = value; } }
        public OracleCommandBuilder MyCommandBuilder { get { return myCommandBuilder; } set { myCommandBuilder = value; } }
        public DataTable DiscountTable { get { return discountTable; } set { discountTable = value; } }

        // 데이터베이스 열기
        public void DB_Open()
        {
            try
            {
                string connectionString = "User Id=ParkingAdmin; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe)));";
                string commandString = "SELECT * FROM StoreDiscount";

                // DataAdapter 및 CommandBuilder 초기화
                dBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(dBAdapter);

                // DataSet 생성 및 데이터 채우기
                dS = new DataSet();
                dBAdapter.Fill(dS, "StoreDiscount");

                // DataTable 가져오기
                discountTable = dS.Tables["StoreDiscount"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DB 연결 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 데이터 로드
        public DataTable GetDiscountTable()
        {
            if (discountTable == null)
            {
                DB_Open();
            }
            return discountTable;
        }

        // 데이터베이스 업데이트
        public void UpdateDatabase()
        {
            try
            {
                if (dS != null && discountTable != null)
                {
                    dBAdapter.Update(dS, "StoreDiscount");
                    dS.AcceptChanges();
                    MessageBox.Show("데이터베이스가 업데이트되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 업데이트 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}