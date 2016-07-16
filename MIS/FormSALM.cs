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
    public partial class FormSALM : Form
    {

        private string StrSQL =
            @"Provider=Microsort.Jet.OLEDB.12.0;Data Source=AssetMDB.accdb;Mode=ReadWrite";
        private string Asset_Maker, Asset_SetPlace, Asset_ConsultNo, Asset_Use, Asset_RegNum, Asset_RegContent, Asset_StaticAsset, Asset_ModelNum, Asset_EtcMemo;
        private bool Asset_DepWay, Asset_WAC;
        private long Asset_Quantity, Asset_Warrant, Asset_DurYr, Asset_Ledge, Asset_Measure, Asset_Judg, Asset_Finance;
        private double Asset_Size;
        private DateTime Asset_TestDate, Asset_RegDate, Asset_SellDate, Asset_FinAmoDate;
        private CurrencyManager Asset_Price, Asset_UtilBill, Asset_AccCharge, Asset_GetSum, Asset_AmoSum, Asset_NotAmo;

        bool flag = false;

        private void OleDb_View()
        {
            this.rbAsset.Checked = false;
            this.rbAssetOOB.Checked = false;
            this.rbFPM.Checked = false;
            this.rbSLM.Checked = false;
            this.rbNotAmo.Checked = false;
            this.rbAmoCom.Checked = false;
            this.txtMaker.Clear();
            this.txtQuantity.Clear();
            this.txtTestDate.Clear();
            this.txtWarrant.Clear();
            this.txtSetPlace.Clear();
            this.txtConsultNo.Clear();
            this.txtUse.Clear();
            this.txtRegDate.Clear();
            this.txtRegNum.Clear();
            this.txtRegContent.Clear();
            this.txtGetDate.Clear();
            this.txtPrice.Clear();
            this.txtUtilBill.Clear();
            this.txtAccCharge.Clear();
            this.txtDurYr.Clear();
            this.txtDepRate.Clear();
            this.txtStaticAsset.Clear();
            this.txtModelNum.Clear();
            this.txtSize.Clear();
            this.txtEtcMemo.Clear();
            this.txtSellDate.Clear();
            this.txtGetSum.Clear();
            this.txtAmoSum.Clear();
            this.txtNotAmo.Clear();
            this.txtFinAmoDate.Clear();

            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();

            var Comm = new OleDbCommand("SELECT * FROM Asset", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                var strArray = new String[] {
                    myRead["M_Ledge"].ToString(),       // strArray[0]
                    myRead["M_Fpm"].ToString(),         // strArray[1]
                    myRead["M_IsAmo"].ToString(),       // strArray[2]
                    myRead["M_Maker"].ToString(),       // strArray[3]
                    myRead["M_Qntt"].ToString(),        // strArray[4]
                    myRead["M_TestDate"].ToString(),    // strArray[5]
                    myRead["M_Warrant"].ToString(),     // strArray[6]
                    myRead["M_SetPlc"].ToString(),      // strArray[7]
                    myRead["M_CnsltNo"].ToString(),     // strArray[8]
                    myRead["M_Use"].ToString(),         // strArray[9]
                    myRead["M_RegDate"].ToString(),     // strArray[10]
                    myRead["M_RegNum"].ToString(),      // strArray[11]
                    myRead["M_Price"].ToString(),       // strArray[12]
                    myRead["M_UtilBill"].ToString(),    // strArray[13]
                    myRead["M_AccCharge"].ToString(),   // strArray[14]
                    myRead["M_DurYr"].ToString(),       // strArray[15]
                    myRead["M_DepRate"].ToString(),     // strArray[16]
                    myRead["M_StaticAsset"].ToString(), // strArray[17]
                    myRead["M_ModelNum"].ToString(),    // strArray[18]
                    myRead["M_Size"].ToString(),        // strArray[19]
                    myRead["M_EtcMemo"].ToString(),     // strArray[20]
                    myRead["M_SellDate"].ToString(),    // strArray[21]
                    myRead["M_GetSum"].ToString(),      // strArray[22]
                    myRead["M_AmoSum"].ToString(),      // strArray[23]
                    myRead["M_NotAmo"].ToString(),      // strArray[24]
                    myRead["M_FinAmoDate"].ToString(),  // strArray[25]
                    myRead["M_Measure"].ToString(),     // strArray[26]
                    myRead["M_Judg"].ToString(),        // strArray[27]
                    myRead["M_Finance"].ToString()      // strArray[28]
                };
                this.txtLedge.Text = strArray[0];
                if (strArray[1] == "true")
                {
                    this.rbFPM.Checked = true;
                    this.rbSLM.Checked = false;
                }
                else
                {
                    this.rbFPM.Checked = false;
                    this.rbSLM.Checked = true;
                }
                if (strArray[2] == "true")
                {
                    this.rbAmoCom.Checked = true;
                    this.rbNotAmo.Checked = false;
                }
                else
                {
                    this.rbAmoCom.Checked = false;
                    this.rbNotAmo.Checked = true;
                }
                this.txtMaker.Text = strArray[3];
                this.txtQuantity.Text = strArray[4];
                this.txtTestDate.Text = strArray[5];
                this.txtWarrant.Text = strArray[6];
                this.txtSetPlace.Text = strArray[7];
                this.txtConsultNo.Text = strArray[8];
                this.txtUse.Text = strArray[9];
                this.txtRegDate.Text = strArray[10];
                this.txtRegNum.Text = strArray[11];
                this.txtPrice.Text = strArray[12];
                this.txtUtilBill.Text = strArray[13];
                this.txtAccCharge.Text = strArray[14];
                this.txtDurYr.Text = strArray[15];
                this.txtDepRate.Text = strArray[16];
                this.txtStaticAsset.Text = strArray[17];
                this.txtModelNum.Text = strArray[18];
                this.txtSize.Text = strArray[19];
                this.txtEtcMemo.Text = strArray[20];
                this.txtSellDate.Text = strArray[21];
                this.txtGetSum.Text = strArray[22];
                this.txtAmoSum.Text = strArray[23];
                this.txtNotAmo.Text = strArray[24];
                this.txtFinAmoDate.Text = strArray[25];
                //
            }
            myRead.Close();
            Conn.Close();

        }

        bool DB_Open(string query)
        {
            OleDbConnection conn = new OleDbConnection();
            // db 연결에 필요한 OleDbConnection 객체 conn 생성
            OleDbCommand comm = new OleDbCommand();

            // 데이터 입력, 수정, 삭제 등의 모든 명령 처리
            // 데이터 소스에 대한 SQL문 등을 표시
            conn.ConnectionString =
                "Provider=Microsoft.ACE.OLECB.12.0;" +  // 공급자
                "Data Source = /AssetDB.accdb;" +
                // db파일 경로
                "Persist Security Info=False";  // 보안정보
            try
            {
                conn.Open();    // db연결
                comm.Connection = conn; // db와 명령문을 연결
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                // 오류발생시 오류정보 출력
            }

            try
            {
                comm.CommandText = query;
                if (comm.ExecuteNonQuery() == 1)
                {
                    // 쿼리를 이용해 db를 실행하면서 실행결과를 통해
                    // 제대로 실행됐는지 확인

                    // 제대로 실행이 된경우
                    conn.Close();   // db연결끊음
                    comm = null;    // null로 초기화
                    conn = null;    // null로 초기화
                    return true;    // 제대로 싱행된 경우 true 리턴
                }
                MessageBox.Show("DB가 연결되지 않았습니다."); // 오류 출력
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return false;   // 제대로 실행 안된 경우 false 리턴

        }

        public FormSALM()
        {
            InitializeComponent();
        }

        private void 설정CToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string strTmp = this.cbLedge.Text;
            //OleDbConnection conn = new OleDbConnection();
            //OleDbCommand comm = new OleDbCommand();
            //OleDbDataReader read = null;
            //// 데이터 소스에서 데이터 행의 앞으로만 이동 가능한 스트림을 읽는 방법을 제공
            //// DB 연결
            //try
            //{
            //    conn.ConnectionString =
            //        "Provider=Microsoft.ACE.OLEDB.12.0;" +
            //        "Data Source=AssetMDB.accdb;" +
            //        "Persist Security Info = False";

            //    conn.Open();
            //    comm.Connection = conn;
            //}
            //catch (Exception ee)
            //{
            //    MessageBox.Show(ee.Message);
            //    return;
            //}

            //// 쿼리 명령 문자열
            //string query = "select *from Asset";

            //// DB 읽기
            //try
            //{
            //    comm.CommandText = query;
            //    // sql문인 query와 comm 객체와 연결
            //    read = comm.ExecuteReader();
            //    // CommandText를 Connection에 보내고,
            //    // SqlDataReader (SQL Server 데이터베이스에서 행의 앞으로만 이동 가능한 스트림을 읽을 수 있게
            //    // 빌드
            //}
            //catch (Exception ee)
            //{
            //    MessageBox.Show(ee.Message);
            //    return;
            //}

            //Control_Clear();    // 정보창 초기화

            //// 출력
            //while (read.Read())
            //{
            //    if (read["M_Ledge"].ToString().Equals(strTmp))
            //    {
            //        this.txtAccCharge.Text = read["M_AccCharge"].ToString();
            //        this.txtAmoSum.Text = read["M_AmoSum"].ToString();
            //        this.txtConsultNo.Text = read["M_ConsultNo"].ToString();
            //        this.txtDepRate.Text = read["M_DepRate"].ToString();
            //        this.txtDurYr.Text = read["M_DurYr"].ToString();
            //        this.txtEtcMemo.Text = read["M_EtcMemo"].ToString();
            //        this.txtFinAmoDate.Text = read["M_FinAmoDate"].ToString();
            //        this.txtGetDate.Text = read["M_GetDate"].ToString();
            //        this.txtGetSum.Text = read["M_GetSum"].ToString();
            //        this.txtMaker.Text = read["M_Maker"].ToString();
            //        this.txtModelNum.Text = read["M_ModelNum"].ToString();
            //        this.txtNotAmo.Text = read["M_NotAmo"].ToString();
            //        this.txtPrice.Text = read["M_Price"].ToString();
            //        this.txtQuantity.Text = read["M_Quantity"].ToString();
            //        this.txtRegContent.Text = read["M_RegContent"].ToString();
            //        this.txtRegDate.Text = read["M_RegDate"].ToString();
            //        this.txtRegNum.Text = read["M_RegNum"].ToString();
            //        this.txtSellDate.Text = read["M_SellDate"].ToString();
            //        this.txtSetPlace.Text = read["M_SetPlace"].ToString();
            //        this.txtSize.Text = read["M_Size"].ToString();
            //        this.txtStaticAsset.Text = read["M_StaticAsset"].ToString();
            //        this.txtTestDate.Text = read["M_TestDate"].ToString();
            //        this.txtUse.Text = read["M_Use"].ToString();
            //        this.txtUtilBill.Text = read["M_UtilBill"].ToString();
            //        this.txtWarrant.Text = read["M_Warrant"].ToString();

            //        flag = true;    // 자료가 있는지 없는지
            //        //gp(read["M_Ledge"].ToString());
            //    }
            //}
            //if (!flag)
            //{
            //    //Control_Clear();
            //    MessageBox.Show("해당하는 자산이 없습니다.");
            //}
            //flag = false;
        }

        //private void gp(string str)
        //{
        //    string strTmp = str;    // 현재 입력된 대장번호
        //    OleDbConnection conn = new OleDbConnection();
        //    OleDbCommand comm = new OleDbCommand();
        //    OleDbDataReader read = null;
        //    // 데이터 소스에서 데이터 행의 앞으로만 이동 가능한 스트림을 읽는 방법을 제공
        //    // DB 연결
        //    try
        //    {
        //        conn.ConnectionString =
        //            "Provider=Microsort.ACE.OLEDB.12.0;" +
        //            "Data Source=AssetDB.accdb;" +
        //            "Persist Security Info=False";

        //        conn.Open();
        //        comm.Connection = conn;
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        return;
        //    }

        //    // 쿼리 명령 문자열
        //    string query = "select * from Asset";

        //    // DB읽기
        //    try
        //    {
        //        comm.CommandText = query;

        //        // sql문인 query와 comm객체와 연결
        //        read = comm.ExecuteReader();

        //        //CommandText를 Connection에 보내고
        //        //SqlDataReader(SQL Server 데이터베이스에서 행의 앞으로만 이동 가능한 스트림을 읽을 수 있게
        //        // 빌드
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        return;
        //    }

        //    //

        //    while (read.Read())
        //    {
        //        if (read["M_Ledge"].ToString().Equals(strTmp))
        //        {
        //            string[] data = new string[25];
        //            int i = 0;

        //            // 여기서부터 각 차트에 
        //        /}
        //    }

        //}

        // 입력 컨트롤의 입력 데이터 초기화
        private void Control_Clear()
        {
            this.rbAsset.Checked = false;
            this.rbAssetOOB.Checked = false;
            this.rbFPM.Checked = false;
            this.rbSLM.Checked = false;
            this.rbNotAmo.Checked = false;
            this.rbAmoCom.Checked = false;
            this.txtMaker.Clear();
            this.txtQuantity.Clear();
            this.txtTestDate.Clear();
            this.txtWarrant.Clear();
            this.txtSetPlace.Clear();
            this.txtConsultNo.Clear();
            this.txtUse.Clear();
            this.txtRegDate.Clear();
            this.txtRegNum.Clear();
            this.txtRegContent.Clear();
            this.txtGetDate.Clear();
            this.txtPrice.Clear();
            this.txtUtilBill.Clear();
            this.txtAccCharge.Clear();
            this.txtDurYr.Clear();
            this.txtDepRate.Clear();
            this.txtStaticAsset.Clear();
            this.txtModelNum.Clear();
            this.txtSize.Clear();
            this.txtEtcMemo.Clear();
            this.txtSellDate.Clear();
            this.txtGetSum.Clear();
            this.txtAmoSum.Clear();
            this.txtNotAmo.Clear();
            this.txtFinAmoDate.Clear();
        }

        // OleDb보기
        private void OleDb_view()
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();

            // SqlDataAdapter 클래스 생성자에 Select 쿼리와 SqlConnection 개체를 대입하여 인스턴스 OleAdapter에 저장
            var OleAdapter = new OleDbDataAdapter("SELECT * FROM Asset", Conn);

            // DataSet 클래스 인스턴스 ds를 생성하는 구문
            DataSet ds = new DataSet();

            // DataSet 클래스 개체에 Add() 메서드를 이용하여 dsTable이라는 소스 테이블을 추가
            DataTable dt = ds.Tables.Add("dsTable");

            // DataSqlAdapter.Fill() 메서드를 이용하여 지정된 DataTable에 데이터 소스에서 가져온 데이터를 채운다
            OleAdapter.Fill(ds, "dsTable");
            var query = dt.AsEnumerable().
            Select(Asset => new
            {
                Ledge = Asset.Field<long>("M_Ledge"),                       // 대장번호
                Fpm = Asset.Field<bool>("M_Fpm"),                           // 정률법/정액법
                IsAmo = Asset.Field<bool>("M_IsAmo"),                       // 상각완료여부
                Maker = Asset.Field<string>("M_Maker"),                     // 제조업체
                Qntt = Asset.Field<long>("M_Qntt"),                         // 수량
                TestDate = Asset.Field<DateTime>("M_TestDate"),             // 검수일자
                Warrant = Asset.Field<long>("M_Warrant"),                   // Warrant기간
                SetPlc = Asset.Field<string>("M_SetPlc"),                   // 설치장소
                CnsltNo = Asset.Field<string>("M_CnsltNo"),                 // 품의번호
                Use = Asset.Field<string>("M_Use"),                         // 용도
                RegDate = Asset.Field<DateTime>("M_RegDate"),               // 등기일자
                RegNum = Asset.Field<string>("M_RegNum"),                   // 등기번호
                Price = Asset.Field<CurrencyManager>("M_Price"),            // 구입단가
                UtilBill = Asset.Field<CurrencyManager>("M_UtilBill"),      // 공과금
                AccCharge = Asset.Field<CurrencyManager>("M_AccCharge"),    // 부대비용
                DurYr = Asset.Field<long>("M_DurYr"),                     // 내용년수
                DepRate = Asset.Field<double>("M_DepRate"),               // 상각률
                StaticAsset = Asset.Field<string>("M_StaticAsset"),        // 고정자산명
                ModelNum = Asset.Field<string>("M_ModelNum"),             // 모델번호
                Size = Asset.Field<long>("M_Size"),                      // 규격   
                EtcMemo = Asset.Field<string>("M_EtcMemo"),               // 기타메모
                SellDate = Asset.Field<DateTime>("M_SellDate"),            // 처분일자
                GetSum = Asset.Field<CurrencyManager>("M_GetSum"),         // 취득금액
                AmoSum = Asset.Field<CurrencyManager>("M_AmoSum"),         // 상각액누계
                NotAmo = Asset.Field<CurrencyManager>("M_NotAmo"),         // 미상각액
                FinAmoDate = Asset.Field<DateTime>("M_FinAmoDate"),        // 최종상각일자
                Measure = Asset.Field<long>("M_Measure"),                 // 단위
                Judg = Asset.Field<long>("M_Judg"),                      // 분개처리여부
                Finance = Asset.Field<long>("M_Finance")                  // 구입재원구분
            });
            foreach (var Asset in query)
            {
                var strArray = new String[] { Asset.Maker, Asset.SetPlc, Asset.CnsltNo, Asset.Use, Asset.RegNum, Asset.StaticAsset, Asset.ModelNum };
                var longArray = new long[] { Asset.Ledge, Asset.Qntt, Asset.Warrant, Asset.DurYr, Asset.Size, Asset.Measure, Asset.Judg, Asset.Finance };
                var doubleArray = new double[] { Asset.DepRate };
                var boolArray = new bool[] { Asset.Fpm, Asset.IsAmo };
                var dateArray = new DateTime[] { Asset.TestDate, Asset.RegDate, Asset.SellDate, Asset.FinAmoDate };
                var curArray = new CurrencyManager[] { Asset.Price, Asset.UtilBill, Asset.AccCharge, Asset.GetSum, Asset.AmoSum, Asset.NotAmo };
            }
            Conn.Close();
        }

        private void FormSALM_Load(object sender, EventArgs e)
        {
            FormSALM_OleDb_View();
        }

        private void FormSALM_OleDb_View()
        {
            
        }

        // 파일 메뉴스트립의 저장 툴스트립
        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var conn = new OleDbConnection(StrSQL);
            OleDbCommand comm = new OleDbCommand();
            OleDbDataReader read = null;
            OleDbDataAdapter adptr = null;
            conn.Open();

            string Sql = "INSERT INTO Asset(M_Ledge, M_Fpm, M_IsAmo, M_Maker, M_Qntt, M_TestDate, M_Warrant, M_SetPlc, M_CnsltNo, M_Use, M_RegDate, M_RegNum, M_Price, M_UtilBill, M_AccCharge, M_DurYr, M_DepRate, M_StaticAsset, M_ModelNum, M_Size, M_EtcMemo, M_SellDate, M_GetSum, M_AmoSum, M_NotAmo, M_FinAmoDate, M_Measure, M_Judg, M_Finance";

            try
            {
                conn.ConnectionString =
                    "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=AssetMDB.accdb;" +
                    "Persist Security Info = False";

                conn.Open();
                comm.Connection = conn;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }
            // 쿼리 명령 문자열
            string query = "select *from Asset";

            // DB 읽기
            try
            {
                comm.CommandText = query;
                // sql문인 query와 comm 객체와 연결
                read = comm.ExecuteReader();
                // CommandText를 Connection에 보내고,
                // SqlDataReader (SQL Server 데이터베이스에서 행의 앞으로만 이동 가능한 스트림을 읽을 수 있게
                // 빌드
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }

            Control_Clear();    // 정보창 초기화
            
            // 데이터 갱신
            //adptr["M_AccCharge"]


        }



        //private void txtLedge_TextChanged(object sender, EventArgs e)
        //{
            
        //}

        // 대장번호 읽기 버튼
        private void btnRdLedge_Click(object sender, EventArgs e)
        {
            string strTmp = this.txtLedge.Text;
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand comm = new OleDbCommand();
            OleDbDataReader read = null;
            // 데이터 소스에서 데이터 행의 앞으로만 이동 가능한 스트림을 읽는 방법을 제공
            // DB 연결
            try
            {
                conn.ConnectionString =
                    "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=AssetMDB.accdb;" +
                    "Persist Security Info = False";

                conn.Open();
                comm.Connection = conn;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }

            // 쿼리 명령 문자열
            string query = "select *from Asset";

            // DB 읽기
            try
            {
                comm.CommandText = query;
                // sql문인 query와 comm 객체와 연결
                read = comm.ExecuteReader();
                // CommandText를 Connection에 보내고,
                // SqlDataReader (SQL Server 데이터베이스에서 행의 앞으로만 이동 가능한 스트림을 읽을 수 있게
                // 빌드
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }

            Control_Clear();    // 정보창 초기화

            // 출력
            while (read.Read())
            {
                if (read["M_Ledge"].ToString().Equals(strTmp))
                {
                    this.txtAccCharge.Text = read["M_AccCharge"].ToString();
                    this.txtAmoSum.Text = read["M_AmoSum"].ToString();
                    this.txtConsultNo.Text = read["M_ConsultNo"].ToString();
                    this.txtDepRate.Text = read["M_DepRate"].ToString();
                    this.txtDurYr.Text = read["M_DurYr"].ToString();
                    this.txtEtcMemo.Text = read["M_EtcMemo"].ToString();
                    this.txtFinAmoDate.Text = read["M_FinAmoDate"].ToString();
                    this.txtGetDate.Text = read["M_GetDate"].ToString();
                    this.txtGetSum.Text = read["M_GetSum"].ToString();
                    this.txtMaker.Text = read["M_Maker"].ToString();
                    this.txtModelNum.Text = read["M_ModelNum"].ToString();
                    this.txtNotAmo.Text = read["M_NotAmo"].ToString();
                    this.txtPrice.Text = read["M_Price"].ToString();
                    this.txtQuantity.Text = read["M_Quantity"].ToString();
                    this.txtRegContent.Text = read["M_RegContent"].ToString();
                    this.txtRegDate.Text = read["M_RegDate"].ToString();
                    this.txtRegNum.Text = read["M_RegNum"].ToString();
                    this.txtSellDate.Text = read["M_SellDate"].ToString();
                    this.txtSetPlace.Text = read["M_SetPlace"].ToString();
                    this.txtSize.Text = read["M_Size"].ToString();
                    this.txtStaticAsset.Text = read["M_StaticAsset"].ToString();
                    this.txtTestDate.Text = read["M_TestDate"].ToString();
                    this.txtUse.Text = read["M_Use"].ToString();
                    this.txtUtilBill.Text = read["M_UtilBill"].ToString();
                    this.txtWarrant.Text = read["M_Warrant"].ToString();

                    flag = true;    // 자료가 있는지 없는지
                    //gp(read["M_Ledge"].ToString());
                }
            }
            if (!flag)
            {
                //Control_Clear();
                MessageBox.Show("해당하는 자산이 없습니다.");
            }
            flag = false;
        }

        // 자산/부외자산 ---> 자산
        private void rbAsset_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
