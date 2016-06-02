using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    public partial class MyDatabase : Form
    {
        MySqlConnection conn;//mysql连接
        MySqlDataAdapter myadp;//mysql数据适配器
        DataSet myds;//数据集

        //public static string User;
        //public static string Password;
        //public static string DBName;
        //public static string Host;
        //public static string Port;
        
        public MyDatabase()
        {
            InitializeComponent();
        }

        private void Mysqlinformation_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection();
            conn.ConnectionString = Global.MyConnectionString;
            conn.Open();
            string str = "select * from mydatabase";
            myadp = new MySqlDataAdapter(str, conn);
            myds = new DataSet();
            myadp.Fill(myds, "mydatabase");

            textBox_user.Text = myds.Tables["mydatabase"].Rows[0]["user"].ToString();
            textBox_password.Text = myds.Tables["mydatabase"].Rows[0]["password"].ToString();
            textBox_dbName.Text = myds.Tables["mydatabase"].Rows[0]["dbName"].ToString();
            textBox_host.Text = myds.Tables["mydatabase"].Rows[0]["host"].ToString();
            textBox_port.Text = myds.Tables["mydatabase"].Rows[0]["port"].ToString();

            //User = myds.Tables["mydatabase"].Rows[0]["user"].ToString();
            //Password = myds.Tables["mydatabase"].Rows[0]["password"].ToString();
            //DBName = myds.Tables["mydatabase"].Rows[0]["dbName"].ToString();
            //Host = myds.Tables["mydatabase"].Rows[0]["host"].ToString();
            //Port = myds.Tables["mydatabase"].Rows[0]["port"].ToString();
        }

        private void button_user_Click(object sender, EventArgs e)
        {
            String str = String.Format("update mydatabase set user = '{0}'", textBox_user.Text.Trim());
            MySqlCommand sqlstr = new MySqlCommand(str, conn);
            int a = sqlstr.ExecuteNonQuery();
            if (a == 1)
            {
                MessageBox.Show("数据库名修改成功");
            }
        }

        private void button_password_Click(object sender, EventArgs e)
        {
            String str = String.Format("update mydatabase set password = '{0}'", textBox_password.Text.Trim());
            MySqlCommand sqlstr = new MySqlCommand(str, conn);
            int a = sqlstr.ExecuteNonQuery();
            if (a == 1)
            {
                MessageBox.Show("数据库名修改成功");
            }
        }

        private void button_dbName_Click(object sender, EventArgs e)
        {
            String str = String.Format("update mydatabase set dbName = '{0}'", textBox_dbName.Text.Trim());
            MySqlCommand sqlstr = new MySqlCommand(str, conn);
            int a = sqlstr.ExecuteNonQuery();
            if (a == 1)
            {
                MessageBox.Show("数据库名修改成功");
            }
        }

        private void button_host_Click(object sender, EventArgs e)
        {
            String str = String.Format("update mydatabase set host = '{0}'", textBox_host.Text.Trim());
            MySqlCommand sqlstr = new MySqlCommand(str, conn);
            int a = sqlstr.ExecuteNonQuery();
            if (a == 1)
            {
                MessageBox.Show("数据库名修改成功");
            }
        }

        private void button_port_Click(object sender, EventArgs e)
        {
            String str = String.Format("update mydatabase set port = '{0}'", textBox_port.Text.Trim());
            MySqlCommand sqlstr = new MySqlCommand(str, conn);
            int a = sqlstr.ExecuteNonQuery();
            if (a == 1)
            {
                MessageBox.Show("数据库名修改成功");
            }
        }
    }
}
