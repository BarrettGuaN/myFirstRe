using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace studentInforManage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void query(string mysql)
        {
            string strconn = "data source=localhost;uid=sa;pwd=123456;database=selectcourse";
            SqlConnection myconn = new SqlConnection(strconn);
            myconn.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter myadp = new SqlDataAdapter(mysql, myconn);

            myadp.Fill(ds, "t1");

            myconn.Close();
            if (ds.Tables["t1"].Rows.Count == 0)
            {
                MessageBox.Show("没有，快滚");
            }
            else
            {
                dataGridView1.DataSource = ds.Tables["t1"];
                SetHeader();
            }
        }

        private void btnSelbyNo_Click(object sender, EventArgs e)
        {
            string sno = txtNo.Text.Trim();
            if (sno == "")
            {
                MessageBox.Show("学号不能为空！");
            }
            else
            {
                string mysql = "select Sno 学号,Sname 姓名,Ssex 性别,Sage 年龄,Sdept 专业 from tbl_Student where sno='" + sno + "'";
                query(mysql);
            }            
        }

        void SetHeader()
        {
            dataGridView1.Columns[0].HeaderText = "学号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "性别";
            dataGridView1.Columns[3].HeaderText = "年龄";
            dataGridView1.Columns[4].HeaderText = "专业";
        }

        private void btnSelAll_Click(object sender, EventArgs e)
        {  
            string mysql = "select * from tbl_student";
            query(mysql);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int n = dataGridView1.CurrentCell.RowIndex;
            txtNo.Text = dataGridView1[0, n].Value.ToString();
            txtName.Text = dataGridView1[1, n].Value.ToString();
            cmbSex.Text = dataGridView1[2, n].Value.ToString();
            txtAge.Text = dataGridView1[3, n].Value.ToString();
            txtDept.Text = dataGridView1[4, n].Value.ToString();
        }

        public void addDropUpdata(string mysql)
        {
            string strconn = "data source=localhost;uid=sa;pwd=123456;database=selectcourse";
            SqlConnection myconn = new SqlConnection(strconn);
            myconn.Open();

            SqlCommand mysqlcom = myconn.CreateCommand();
            mysqlcom.CommandText = mysql;
            try
            {
                int rows = mysqlcom.ExecuteNonQuery();
                if (rows == 0)
                {
                    MessageBox.Show("目标不存在！");
                }
            }
            catch (SqlException exp)//添加为空：547，修改为空，102，添加重复，2627
            {
                int num = exp.Number;
                switch(num)
                {
                    case 102:
                        MessageBox.Show("修改不能为空！");
                        break;
                    case 547:
                        MessageBox.Show("添加不能为空！");
                        break;
                    case 2627:
                        MessageBox.Show("添加不能重复！");
                        break;
                }

                MessageBox.Show(exp.Number.ToString());
            }
            myconn.Close();
            btnSelAll.PerformClick();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sname = txtName.Text.Trim();
            string sno = txtNo.Text.Trim();
            string sdept = txtDept.Text.Trim();
            string sage = txtAge.Text.Trim();
            string ssex = cmbSex.Text.Trim();
            string mysql = "insert into tbl_student values ('" + sno + "','" + sname + "','" + ssex + "','" + sage + "','" + sdept + "')";
            addDropUpdata(mysql);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sname = txtName.Text.Trim();
            string sno = txtNo.Text.Trim();
            string sdept = txtDept.Text.Trim();
            string sage = txtAge.Text                                                      .Trim();
            string ssex = cmbSex.Text.Trim();
            string mysql = "update tbl_student set sno='"+sno+"',sname='"+sname+"',ssex='"+ssex+"',sage='"+sage+"',sdept='"+sdept+"'"+"where sno="+sno;
            addDropUpdata(mysql);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string sname = txtName.Text.Trim();
            string sno = txtNo.Text.Trim();
            string sdept = txtDept.Text.Trim();
            string sage = txtAge.Text.Trim();
            string ssex = cmbSex.Text.Trim();
            string mysql = "delete from tbl_student where Sno='"+sno+"'";
            addDropUpdata(mysql);
        }
    }
}
  

