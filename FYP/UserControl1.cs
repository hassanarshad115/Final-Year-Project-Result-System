using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FYP
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sessiongroupBox1.Visible = false;
            newsemestergroupBox1.Visible = true;

            if (springradioButton1.Checked == true)
            {
                string connection = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
                SqlConnection conn = new SqlConnection(connection);
                string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "S" + "([RollNo] INT NOT NULL,[RegNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL )";
                SqlCommand cmd = new SqlCommand(q, conn);
                //string q1 = "CREATE TABLE [dbo]." + "OS" + sessiontextBox1.Text.Trim() + "([RollNo] INT NOT NULL,[RegNo] INT NOT NULL,[Name] NVARCHAR(50) NOT NULL,[FatherName] NVARCHAR(50) NOT NULL,[101] INT NOT NULL, [Q1] FLOAT NOT NULL, [102] INT NOT NULL, [Q2] FLOAT NOT NULL, [TM] INT NOT NULL, [QP] FLOAT NOT NULL, [SGPA] FLOAT NOT NULL )";
                //SqlCommand cmd1 = new SqlCommand(q1, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                //cmd1.ExecuteNonQuery();

                //MessageBox.Show("Table Create Successfully");
                toplabel6.Text = sessionmaskedTextBox1.Text + "S";//yha concatinate kia h session ko 

            }
            if (fallradioButton2.Checked == true)
            {
                string connection = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
                SqlConnection conn = new SqlConnection(connection);
                string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "F" + "([RollNo] NVARCHAR(50) NOT NULL,[RegNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL )";
                SqlCommand cmd = new SqlCommand(q, conn);
                //string q1 = "CREATE TABLE [dbo]." + "OS" + sessiontextBox1.Text.Trim() + "([RollNo] INT NOT NULL,[RegNo] INT NOT NULL,[Name] NVARCHAR(50) NOT NULL,[FatherName] NVARCHAR(50) NOT NULL,[101] INT NOT NULL, [Q1] FLOAT NOT NULL, [102] INT NOT NULL, [Q2] FLOAT NOT NULL, [TM] INT NOT NULL, [QP] FLOAT NOT NULL, [SGPA] FLOAT NOT NULL )";
                //SqlCommand cmd1 = new SqlCommand(q1, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                //cmd1.ExecuteNonQuery();

                //MessageBox.Show("Table Create Successfully");

                toplabel6.Text = sessionmaskedTextBox1.Text + "F";//yha concatinate kia h session ko 
            }
        }

        private void newsemsterbutton1_Click(object sender, EventArgs e)
        {
            sessiongroupBox1.Visible = true;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            sessiongroupBox1.Visible = false;
            newsemestergroupBox1.Visible = false;
        }

        private void savebutton1_Click(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connection);

            //string q = "INSERT INTO [dbo]."+toplabel6.Text+"([RollNo],[RegNo],[Name],[FatherName]) VALUES( "+ rollnotextBox1.Text +  " ," + regnotextBox2.Text + "," + nametextBox3.Text + "," + fathernametextBox4.Text+ ")";
            string q = "INSERT INTO [dbo]." + toplabel6.Text + "([RollNo],[RegNo],[Name],[FatherName]) VALUES( @r,@ad,@n,@f)";
            SqlCommand cmd1 = new SqlCommand(q, conn);
            cmd1.Parameters.AddWithValue("@r", rollnotextBox1.Text);
            cmd1.Parameters.AddWithValue("@ad", regnotextBox2.Text);
            cmd1.Parameters.AddWithValue("@n", nametextBox3.Text);
            cmd1.Parameters.AddWithValue("@f", fathernametextBox4.Text);
            conn.Open();
            cmd1.ExecuteNonQuery();
            //cmd1.ExecuteNonQuery();

            MessageBox.Show("Table Data Enter Successfully");
            txtBoxClearMethod();
        }
        private void txtBoxClearMethod()
        {
            regnotextBox2.Clear();
            nametextBox3.Clear();
            fathernametextBox4.Clear();
        }
    }
}
