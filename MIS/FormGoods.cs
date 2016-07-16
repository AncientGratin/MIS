using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// OleDbConnection, OleDbCommand 클래스 등 사용
using System.Data.OleDb;

namespace MIS
{
    public partial class FrmGoods : Form
    {
        
        private string StrSQL =
            @"Provider=Microsort.Jet.OLEDB.12.0;Data Source=GoodsMDB.accdb;Mode=ReadWrite";

        private void OleDb_view()
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();

            // SqlDataAdapter 클래스 생성자에 Select 쿼리와 SqlConnection 개체를 대입하여 인스턴스 OleAdapter에 저장
            var OleAdapter1 = new OleDbDataAdapter("SELECT * FROM GoodBasis", Conn);
            var OleAdapter2 = new OleDbDataAdapter("SELECT * FROM GoodsAdd", Conn);

            // DataSet 클래스 인스턴스 ds를 생성하는 구문
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();

            // DataSet 클래스 개체에 Add() 메서드를 이용하여 dsTable이라는 소스 테이블을 추가
            DataTable dt1 = ds1.Tables.Add("dsTable1");
            DataTable dt2 = ds2.Tables.Add("dsTable2");

            // DataSqlAdapter.Fill() 메서드를 이용하여 지정된 DataTable에 데이터 소스에서 가져온 데이터를 채운다
            OleAdapter1.Fill(ds1, "dsTable");
            var query1 = dt1.AsEnumerable().
            Select(LoginInfo => new
            {
                Id = LoginInfo.Field<string>("M_Id"),
                Pwd = LoginInfo.Field<string>("M_Pwd")
            });
            foreach (var LoginData in query1)
            {
                var strArray = new String[] { LoginData.Id, LoginData.Pwd };
            }
            Conn.Close();
        }

        // 입력 컨트롤의 입력 데이터 초기화
        private void Control_Clear()
        {
        }

        public FrmGoods()
        {
            InitializeComponent();

            string[] data1 = new string[5];
            string[] data2 = new string[3] { "0", "0", "0" };

            for (int i = 0; i < 10; i++)
            {
                if (i < 3)
                {
                    data1[0] = (i + 1).ToString();
                    switch (i)
                    {
                        case 0:
                            data1[1] = "0";
                            data1[2] = "0";
                            data1[3] = "OFF";
                            data1[4] = "0";
                            break;
                        case 1:
                            data1[1] = "8";
                            data1[2] = "0";
                            data1[3] = "ON";
                            data1[4] = "10";
                            break;
                        case 2:
                            data1[1] = "20";
                            data1[2] = "0";
                            data1[3] = "OFF";
                            data1[4] = "0";
                            break;
                    }
                    dgvGoods.Rows.Add(data1);
                }
                else
                {
                    data2[0] = (i + 1).ToString();
                    dgvGoods.Rows.Add(data2);
                }
            }
            string[] data3 = new string[15];

            for (int i = 0; i < 15; i++)
            {
                data3[i] = i.ToString();
            }

            dgvGoods.Rows.Add(data3);

        }

        private void 다른이름으로저장ASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
