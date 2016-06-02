using System;
using System.Windows.Forms;

namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    public partial class Main : Form
    {
        User user;
        public Main(User _user)
        {
            this.user = _user;
            InitializeComponent();
            user.Hide();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            user.Close();//在这里关闭主窗体，也就是登录窗体，就可以退出程序
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            RunServer runserver = new RunServer();
            runserver.Show();
        }

        private void buttonDatabase_Click(object sender, EventArgs e)
        {
            MyDatabase myDatabase = new MyDatabase();
            myDatabase.Show();
        }

        private void buttonAlgorithm_Click(object sender, EventArgs e)
        {
            Algorithm algorithm = new Algorithm();
            algorithm.Show();
        }

        private void buttonComponent_Click(object sender, EventArgs e)
        {
            Component component = new Component();
            component.Show();
        }
    }
}
