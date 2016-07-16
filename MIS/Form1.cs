using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// OleDbConnection, OleDbCommand 클래스 등 사용
using System.Data.OleDb;

namespace MIS
{
    public partial class MainForm : Form
    {
        // 데이터베이스 연결문자열
        private string StrSQL =
            @"Provider=Microsort.Jet.OLEDB.12.0;Data Source=LoginMDB.accdb;Mode=ReadWrite";
        private string Login_Id, Login_Pwd;
        String[] strArray;

        private bool loginSwitch = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            

            this.picLogin.Image = Image.FromFile(@"..\..\img\picLogin_Normal.jpg");
            this.picSALM.Image = Image.FromFile(@"..\..\img\picSALM_Disabled.jpg");
            this.picGoods.Image = Image.FromFile(@"..\..\img\picGoods_Disabled.jpg");
            //this.picStatement.Image = Image.FromFile(@"..\..\img\picStatement_Disabled.jpg");
            this.picAffairs.Image = Image.FromFile(@"..\..\img\picAffairs_Disabled.jpg");
            Control_Clear();

        }

        private void picLogin_Click(object sender, EventArgs e)
        {
            if (loginSwitch == true)
            {
                LogOut();
            }
            else if (CheckData() == true)
            {
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                string searchId = txtId.Text;
                string searchPwd = txtPwd.Text;
                string Sql = "SELECT * from LoginInfo where M_Id=" + txtId.Text + " and M_Pwd=" + txtPwd.Text;
                var Comm = new OleDbCommand(Sql, Conn);
                int i = Comm.ExecuteNonQuery();
                Conn.Close();
                if (i != 0) return;

                if (loginSwitch == false)
                {
                    LogIn();
                }
            }
        }

        // 입력 컨트롤의 입력 데이터 초기화
        private void Control_Clear()
        {
            this.txtId.Clear();
            this.txtPwd.Clear();
        }

        private String[] OleDb_view()
        {
            //String[] strArray;
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();

            var Comm = new OleDbCommand("SELECT * FROM LoginInfo", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                //var strArray = new String[] { myRead["M_Id"].ToString(), myRead["M_Pwd"].ToString() };
                strArray = new String[] { myRead["M_Id"].ToString(), myRead["M_Pwd"].ToString() };
            }
            myRead.Close();
            Conn.Close();
            return strArray;
        }

        // DB에서 해당값이 있는지 체크
        //private bool IsExist()
        //{
        //    for (int i = 0; i < strArray.Length; i++)
        //    {
        //        if(this.txtId.Text == strArray[i])
        //        {
        //        }
        //    }
        //}

        // 올바른 아이디와 비밀번호를 찾는 bool형 메소드
        private bool CheckData()
        {
            

            if (this.txtId.Text == "")
            {
                MessageBox.Show("로그인 아이디를 입력하세요",
                    "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtId.Focus();
                return false;
            }
            else if (this.txtPwd.Text == "")
            {
                MessageBox.Show("로그인 비밀번호를 입력하세요",
                    "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPwd.Focus();
                return false;
            }
            else
            {
                //return true;

                if (this.txtId.Text == "test")
                {
                    if (this.txtPwd.Text == "1234")
                        return true;
                    else
                    {
                        this.lblResult.Text = "일치하는 비밀번호가 없습니다.";
                        this.txtPwd.Focus();
                        return false;
                    }
                }
                else
                {
                    this.lblResult.Text = "일치하는 아이디가 없습니다.";
                    this.txtId.Focus();
                    return false;
                }

                try
                {

                    //// 데이터베이스 연결 문자열을 인자로 대입하여 MySqlConnection 클래스의 인스턴스를 초기화
                    //var Conn = new OleDbConnection(StrSQL);

                    //// Open() 메서드를 이용하여 데이터베이스를 연다.
                    //Conn.Open();

                    //// SELECT 쿼리 및 MySqlConnection 개체를 사용하여 MySqlDataAdapter 클래스의 개체 MySqlAdapter 초기화
                    //var MySqlAdapter = new OleDbDataAdapter("select * from LoginInfo", Conn);

                    //var ds = new DataSet();
                    //MySqlAdapter.Fill(ds, "dsTable");

                    //// DataSet.Tables["가상 테이블"].Select() 구문을 이용하여 가상테이블에서 데이터를 선택하여 가져오는 작업 수행
                    //// 데이터베이스의 데이터 수정시 인덱스 값을 이용하기 때문에 [lvList] 컬럼의 첫 번째 값으로 데이터를 선택하여 가져온다.
                    //var dt = ds.Tables["dsTable"].Select("M_Num =" +
                    //    Convert.ToInt32(this.Data_Num), null,
                    //    DataViewRowState.CurrentRows);

                    //// DataRow 클래스의 개체 drTemp를 생성
                    //DataRow drTemp;

                    //// 생성된 drTemp 개체에 13행에서 가져온 가상테이블 데이터 행의 동일한 스키마와 데이터를 dr[0] 키워드를 이용하여 저장
                    //drTemp = dt[0];

                    //// 입력 컨트롤의 입력된 데이터를 각 drTemp 개체에 수정하여 대입
                    //drTemp["M_Id"] = this.txtId.Text;
                    //drTemp["M_Password"] = this.txtPwd.Text;

                    //// 관련 MySqlDataAdapter 개체를 MySqlCommandBuilder 클래스 생성자에 대입하여 개체를 생성
                    //var cmdBuild = new OleDbCommandBuilder(MySqlAdapter);

                    //// MySqlCommandBuilder.GetUpdateCommand() 메서드를 이용하여 데이터베이스에서 업데이트하는 데 필요한 자동으로 생성되어진 MySqlCommand 개체를 가져와 MySqladapter.UpdateCommand 속성에 대입하여 Transact-SQL 문이나 저장 프로시저를 설정
                    //MySqlAdapter.UpdateCommand = cmdBuild.GetUpdateCommand();

                    ////SqlDataAdapter.Update() 메서드를 이용하여 지정된 DataTable 이름을 갖는 DataSet에서 업데이트하여 데이터베이스 원본 데이터 소스에 반영
                    //MySqlAdapter.Update(ds, "dsTable");

                    //// MySqlCommandBuilder 클래스의 개체를 Dispose() 메서드를 이용하여 리소스를 제거하는 작업 수행
                    //cmdBuild.Dispose();

                    //// 연결된 데이터베이스를 Close() 메서드를 이용하여 닫는 작업 수행
                    //Conn.Close();

                    // 입력받은 데이터와 일치하는 아이디와 패스워드를 데이터베이스에서 검색

                    if (this.txtId.Text == "test")
                    {
                        if (this.txtPwd.Text == "1234")
                            return true;
                        else
                        {
                            MessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다",
                        "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.txtPwd.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다",
                        "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtId.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("정상적으로 데이터가 수정되지 않았습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                
            }
        }

        // 로그인 실행 메소드
        private void LogIn()
        {
            // 테스트용 메시지 박스
            //MessageBox.Show("로그인 성공", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.lblResult.Text = this.txtId.Text + " 님 로그인 되었습니다.";
            this.picLogin.Image = Image.FromFile(@"..\..\img\picLogout_Normal.jpg");
            loginSwitch = true;
            // 각 메뉴 버튼이 활성화됨을 시각적으로 표시
            this.picSALM.Image = Image.FromFile(@"..\..\img\picSALM_Normal.jpg");
            this.picGoods.Image = Image.FromFile(@"..\..\img\picGoods_Normal.jpg");
            //this.picStatement.Image = Image.FromFile(@"..\..\img\picStatement_Normal.jpg");
            this.picAffairs.Image = Image.FromFile(@"..\..\img\picAffairs_Normal.jpg");
            // 로그인 텍스트박스 잠금
            this.txtId.Text = "";
            this.txtPwd.Text = "";
            this.txtId.ReadOnly = true;
            this.txtPwd.ReadOnly = true;
        }

        // 로그아웃 실행 메소드
        private void LogOut()
        {
            // 테스트용 메시지 박스
                //MessageBox.Show("로그아웃 성공", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.lblResult.Text = "로그인하셔야 이용 가능합니다.";
                this.picLogin.Image = Image.FromFile(@"..\..\img\picLogin_Normal.jpg");
                loginSwitch = false;
                this.txtId.Text = "";
                this.txtPwd.Text = "";
                // 각 메뉴 버튼이 비활성화됨을 시각적으로 표시
                this.picSALM.Image = Image.FromFile(@"..\..\img\picSALM_Disabled.jpg");
                this.picGoods.Image = Image.FromFile(@"..\..\img\picGoods_Disabled.jpg");
                //this.picStatement.Image = Image.FromFile(@"..\..\img\picStatement_Disabled.jpg");
                this.picAffairs.Image = Image.FromFile(@"..\..\img\picAffairs_Disabled.jpg");
                // 로그인 텍스트박스 잠금해제
                this.txtId.ReadOnly = false;
                this.txtPwd.ReadOnly = false;
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CheckData() == true)
                {
                    LogIn();
                }
            }
        }

        private void picSALM_MouseMove(object sender, MouseEventArgs e)
        {
            if (loginSwitch == true)
                this.picSALM.Image = Image.FromFile(@"..\..\img\picSALM_Over.jpg");
        }

        private void picSALM_MouseLeave(object sender, EventArgs e)
        {
            if (loginSwitch == true)
                this.picSALM.Image = Image.FromFile(@"..\..\img\picSALM_Normal.jpg");
        }

        private void picGoods_MouseMove(object sender, MouseEventArgs e)
        {
            if (loginSwitch == true)
                this.picGoods.Image = Image.FromFile(@"..\..\img\picGoods_Over.jpg");
        }

        private void picGoods_MouseLeave(object sender, EventArgs e)
        {
            if (loginSwitch == true)
                this.picGoods.Image = Image.FromFile(@"..\..\img\picGoods_Normal.jpg");
        }

        private void picAffairs_MouseMove(object sender, MouseEventArgs e)
        {
            if (loginSwitch == true)
                this.picAffairs.Image = Image.FromFile(@"..\..\img\picAffairs_Over.jpg");
        }

        private void picAffairs_MouseLeave(object sender, EventArgs e)
        {
            if (loginSwitch == true)
                this.picAffairs.Image = Image.FromFile(@"..\..\img\picAffairs_Normal.jpg");
        }

        private void picSALM_Click(object sender, EventArgs e)
        {
            if (loginSwitch == true)
            {
                FormSALM frm1 = new FormSALM();
                frm1.ShowDialog();
            }
        }

        private void picAffairs_Click(object sender, EventArgs e)
        {
            if (loginSwitch == true)
            {
                FrmAffair frm4 = new FrmAffair();
                frm4.ShowDialog();
            }
        }

        private void picGoods_Click(object sender, EventArgs e)
        {
            if (loginSwitch == true)
            {
                FrmGoods frm2 = new FrmGoods();
                frm2.ShowDialog();
            }
        }
    }
}
