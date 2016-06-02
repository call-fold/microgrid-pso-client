using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    public partial class User : Form
    {
        MySqlConnection conn;  //mysql连接
        MySqlDataAdapter myadp;//mysql数据适配器
        DataSet myds;
        public static string user;
        public static string password;
        public User()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            user = textBox_user.Text.Trim();
            password = textBox_password.Text.Trim();
            conn = new MySqlConnection();//实例化数据库连接（instanced）
            conn.ConnectionString = Global.MyConnectionString_Login;//配置连接（configured）
            conn.Open();
            String str = String.Format("select * from user where User='{0}' and Password=PASSWORD('{1}')", user, password);
            myadp = new MySqlDataAdapter(str, conn);
            myds = new DataSet();
            //填充和绑定数据
            myadp.Fill(myds);
            DataTable dt = myds.Tables[0];
            int rows = dt.Rows.Count;
            if (rows > 0)
            {
                Main main = new Main(this);
                main.Show();
                //MessageBox.Show("用户密码正确");
            }
            else
            {
                MessageBox.Show("用户密码不正确");
            }
        }
    }
}
