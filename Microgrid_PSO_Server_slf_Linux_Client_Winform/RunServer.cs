using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics;

namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    public partial class RunServer : Form
    {
        MySqlConnection conn;//mysql连接
        MySqlDataAdapter myadp2;//mysql数据适配器
        DataSet myds2;//数据集
        MySqlDataAdapter myadp1;//mysql数据适配器
        DataSet myds1;//数据集

        //代码运行时间
        Stopwatch watch = new Stopwatch();

        public static string Selected_Algorithm_ID;

        public RunServer()
        {
            InitializeComponent();
            InsertAlgorithmID(comboBox_algorithm_id);
        }

        public int Find_Current_History_ID()
        {
            string str_find_id = "select max(history_id) from history";

            try
            {
                conn = new MySqlConnection(Global.MyConnectionString);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(str_find_id, conn);
                return Convert.ToInt16(cmd.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: {0}", ex.ToString());
                return 0;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void results_Load(object sender, EventArgs e)
        {
            try
            {//打开菜单配置数据库连接
                conn = new MySqlConnection();//实例化数据库连接
                conn.ConnectionString = Global.MyConnectionString;//配置连接
                conn.Open();//打开连接

                int current_history_id = Find_Current_History_ID();
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
            int current_history_id = Find_Current_History_ID();
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

        public delegate int PSOCAL();

        public class PSO
        {
            MySqlConnection conn;//mysql连接
            MySqlDataAdapter myadp3;//mysql数据适配器
            DataSet myds3;//数据集
            MySqlDataAdapter myadp4;//mysql数据适配器
            DataSet myds4;//数据集

            public int demethod()
            {
                conn = new MySqlConnection();//实例化数据库连接
                conn.ConnectionString = Global.MyConnectionString;//配置连接
                conn.Open();//打开连接

                string algorithmStr = string.Format("select * from algorithm where algorithm_id = {0}", Selected_Algorithm_ID);

                myadp3 = new MySqlDataAdapter(algorithmStr, conn);
                myds3 = new DataSet();//填充和绑定数据
                myadp3.Fill(myds3, "algorithm");

                myadp4 = new MySqlDataAdapter("select * from mydatabase", conn);
                myds4 = new DataSet();//填充和绑定数据
                myadp4.Fill(myds4, "mydatabase");

                string[] sysinfol = new string[7];
                sysinfol[0] = myds3.Tables["algorithm"].Rows[0]["processNum"].ToString();
                sysinfol[1] = myds4.Tables["mydatabase"].Rows[0]["host"].ToString();
                sysinfol[2] = myds4.Tables["mydatabase"].Rows[0]["user"].ToString();
                sysinfol[3] = myds4.Tables["mydatabase"].Rows[0]["password"].ToString();
                sysinfol[4] = myds4.Tables["mydatabase"].Rows[0]["dbName"].ToString();
                sysinfol[5] = myds4.Tables["mydatabase"].Rows[0]["port"].ToString();
                sysinfol[6] = myds3.Tables["algorithm"].Rows[0]["algorithm_id"].ToString();
                
                mgopf.mgopfserverPortTypeClient mgopfserver = new mgopf.mgopfserverPortTypeClient("mgopfserver", "http://210.34.23.37:9983");
                int _status = mgopfserver.mgopfserver(sysinfol[0], sysinfol[1], sysinfol[2], sysinfol[3], sysinfol[4], sysinfol[5], sysinfol[6]);
                return _status;
            }
        }

        public void decallback(IAsyncResult result)
        {
            //result 是“PSO.pso()方法”的返回值
            //AsyncResult 是IAsyncResult接口的一个实现类，空间：System.Runtime.Remoting.Messaging
            //AsyncDelegate 属性可以强制转换为用户定义的委托的实际类。
            //注意: BeginInvoke和EndInvoke必须成对调用.即使不需要返回值，但EndInvoke还是必须调用，否则可能会造成内存泄漏。
            PSOCAL decal = (PSOCAL)((AsyncResult)result).AsyncDelegate;
            if (result.IsCompleted)
            {
                watch.Stop();
                string time = watch.Elapsed.ToString();
                string tempStr01 = "Solve the Problem!\n";
                string tempStr02 = string.Format("Using time is {0}", time);
                string finalStr = tempStr01 + tempStr02;
                MessageBox.Show(finalStr);
            }
            decal.EndInvoke(result);
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            PSO pso = new PSO();
            PSOCAL psoHandle = new PSOCAL(pso.demethod);
            MessageBox.Show("Begin!");
            watch.Reset();
            watch.Start();
            IAsyncResult result = psoHandle.BeginInvoke(new AsyncCallback(decallback), null);
        }

        private void buttonFresh_Click(object sender, EventArgs e)
        {
            results_Load(null, null);
        }

        private void buttonDrawOutput_Click(object sender, EventArgs e)
        {
            int current_history_id = Find_Current_History_ID();
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
            int current_history_id = Find_Current_History_ID();
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

        public void InsertAlgorithmID(ComboBox cb)
        {
            MySqlConnection conn;//mysql连接

            conn = new MySqlConnection();//实例化数据库连接
            conn.ConnectionString = Global.MyConnectionString;//配置连接
            conn.Open();//打开连接

            cb.Items.Clear();//清空ComBox  
            MySqlCommand cmd = new MySqlCommand("select algorithm_id from algorithm", conn);//构造连接字符串并切打开数据库连接  
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cb.Items.Add(sdr[0].ToString());//循环读取数据  
            }//end block while  

            sdr.Close();//  关闭数据集  
            conn.Close();//关闭数据库连接  
        }

        private void comboBox_algorithm_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected_Algorithm_ID = comboBox_algorithm_id.SelectedItem.ToString();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }
    }
}
