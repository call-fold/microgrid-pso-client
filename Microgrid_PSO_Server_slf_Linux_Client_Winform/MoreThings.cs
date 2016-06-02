using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics;

namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    public partial class MoreThings : Form
    {
        MySqlConnection conn;//mysql连接
        MySqlDataAdapter myadp2;//mysql数据适配器
        DataSet myds2;//数据集
        MySqlDataAdapter myadp1;//mysql数据适配器
        DataSet myds1;//数据集

        int current_id = 0;

        public MoreThings(int _current_id)
        {
            InitializeComponent();
            current_id = _current_id;
        }

        private void results_power_Load(object sender, EventArgs e)
        {
            try
            {//打开菜单配置数据库连接
                conn = new MySqlConnection();//实例化数据库连接
                conn.ConnectionString = Global.MyConnectionString;//配置连接
                conn.Open();//打开连接

                int current_history_id = current_id;
                string cmd_load_power = string.Format("select * from power_distribution where history_id = {0}", current_history_id);
                string cmd_load_result = string.Format("select * from results where history_id = {0}", current_history_id);

                myadp1 = new MySqlDataAdapter(cmd_load_power, conn);
                myds1 = new DataSet();//填充和绑定数据
                myadp1.Fill(myds1, "power_distribution");
                dataGridView1.AutoGenerateColumns = false;//不生成新的列
                dataGridView1.DataSource = myds1.Tables["power_distribution"];
                //把数据赋给名称对应的列并显示

                dataGridView1.Columns["OutputTime"].DataPropertyName = myds1.Tables["power_distribution"].Columns["output_time"].ToString();
                dataGridView1.Columns["OutputBattery"].DataPropertyName = myds1.Tables["power_distribution"].Columns["output_P_Battery"].ToString();
                dataGridView1.Columns["OutputPV"].DataPropertyName = myds1.Tables["power_distribution"].Columns["output_P_PV"].ToString();
                dataGridView1.Columns["OutputWindM"].DataPropertyName = myds1.Tables["power_distribution"].Columns["output_P_WindM"].ToString();
                dataGridView1.Columns["OutputExchange"].DataPropertyName = myds1.Tables["power_distribution"].Columns["output_P_Exchange"].ToString();
                dataGridView1.Columns["OutputTotal"].DataPropertyName = myds1.Tables["power_distribution"].Columns["output_P_Total"].ToString();
                dataGridView1.Columns["SOC"].DataPropertyName = myds1.Tables["power_distribution"].Columns["SOC"].ToString();

                myadp2 = new MySqlDataAdapter(cmd_load_result, conn);
                myds2 = new DataSet();//填充和绑定数据
                myadp2.Fill(myds2, "results");
                dataGridView2.AutoGenerateColumns = false;//不生成新的列
                dataGridView2.DataSource = myds2.Tables["results"];
                //把数据赋给名称对应的列并显示

                dataGridView2.Columns["n"].DataPropertyName = myds2.Tables["results"].Columns["n"].ToString();
                dataGridView2.Columns["f"].DataPropertyName = myds2.Tables["results"].Columns["f"].ToString();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("不能连接到数据库服务器，请联系数据库管理员！"); break;
                    case 1045:
                        MessageBox.Show("无效的用户名/密码，请重试！"); break;
                    case 1049:
                        MessageBox.Show("数据库不存在，或数据库名错误"); break;
                    default:
                        MessageBox.Show(ex.Message); break;
                }
            }
        }

        private void buttonDrawResult_Click(object sender, EventArgs e)
        {
            int current_history_id = current_id;
            string cmd_load_result = string.Format("select * from results where history_id = {0}", current_history_id);

            myadp2 = new MySqlDataAdapter(cmd_load_result, conn);
            myds2 = new DataSet();
            myadp2.Fill(myds2, "results");
            int len = myds2.Tables["results"].Rows.Count;
            double[,] inputData = new double[1, len];
            for (int i = 0; i < myds2.Tables["results"].Rows.Count; i++)
            {
                inputData[0, i] = Convert.ToDouble(myds2.Tables["results"].Rows[i][4]);
            }

            string[] graphName = { "收敛曲线", "迭代次数", "经济成本" };
            string[,] inputDataName = { { "Cost", "Red", "XCross", "10" } };
            MyZedGraph.DrawMyZedGraph myZedGraphForm = new MyZedGraph.DrawMyZedGraph(inputData, inputDataName, graphName);
            myZedGraphForm.Show();
        }

        private void buttonDrawOutput_Click(object sender, EventArgs e)
        {
            int current_history_id = current_id;
            string cmd_load_power = string.Format("select * from power_distribution where history_id = {0}", current_history_id);

            myadp1 = new MySqlDataAdapter(cmd_load_power, conn);
            myds1 = new DataSet();
            myadp1.Fill(myds1, "power_distribution");
            int len = myds1.Tables["power_distribution"].Rows.Count;

            double[] outputBattery = new double[len];
            double[] outputPV = new double[len];
            double[] outputWindM = new double[len];
            double[] outputExchange = new double[len];
            double[] outputTotal = new double[len];
            double[] SOC = new double[len];

            for (int i = 0; i < len; i++)
            {
                outputBattery[i] = Convert.ToDouble(myds1.Tables["power_distribution"].Rows[i][4]);
                outputPV[i] = Convert.ToDouble(myds1.Tables["power_distribution"].Rows[i][5]);
                outputWindM[i] = Convert.ToDouble(myds1.Tables["power_distribution"].Rows[i][6]);
                outputExchange[i] = Convert.ToDouble(myds1.Tables["power_distribution"].Rows[i][7]);
                outputTotal[i] = Convert.ToDouble(myds1.Tables["power_distribution"].Rows[i][8]);
                SOC[i] = Convert.ToDouble(myds1.Tables["power_distribution"].Rows[i][9]);
            }

            DrawOutput drawOutput = new DrawOutput(outputBattery, outputPV, outputWindM, outputExchange, outputTotal, SOC);
            drawOutput.Show();
        }

        private void buttonSOC_Click(object sender, EventArgs e)
        {
            int current_history_id = current_id;
            string cmd_load_power = string.Format("select * from power_distribution where history_id = {0}", current_history_id);

            myadp1 = new MySqlDataAdapter(cmd_load_power, conn);
            myds1 = new DataSet();
            myadp1.Fill(myds1, "power_distribution");
            int len = myds1.Tables["power_distribution"].Rows.Count;

            double[] SOC = new double[len];
            for (int i = 0; i < len; i++)
            {
                SOC[i] = Convert.ToDouble(myds1.Tables["power_distribution"].Rows[i][9]);
            }

            DrawSOC drawSOC = new DrawSOC(SOC);
            drawSOC.Show();
        }
    }
}
