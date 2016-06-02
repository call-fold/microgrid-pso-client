using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    public partial class DrawOutput : Form
    {
        public DrawOutput(double[] _outputBattery_, double[] _outputPV_, double[] _outputWindM_, double[] _outputExchange_, double[] _outputTotal_, double[] _SOC_)
        {
            InitializeComponent();
            ShowChart(_outputBattery_, _outputPV_, _outputWindM_, _outputExchange_, _outputTotal_, _SOC_);
            SetSize();
        }

        private void ShowChart(double[] _outputBattery, double[] _outputPV, double[] _outputWindM, double[] _outputExchange, double[] _outputTotal, double[] _SOC)
        {
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.GraphPane.GraphObjList.Clear();
            // clearing not teste  

            GraphPane myPane = zedGraphControl1.GraphPane;

            //双y轴
            //myPane.Y2Axis.IsVisible = true;
            //myPane.Y2Axis.Title.Text = "蓄电池容量";
            //myPane.Y2Axis.Scale.Min = -1;
            //myPane.Y2Axis.Scale.Max = 2.5;
            //myPane.Y2Axis.MajorTic.IsOpposite = false;
            //myPane.Y2Axis.MinorTic.IsOpposite = false;

            // Set the title and axis labels
            myPane.Title.Text = "出力分配";
            myPane.XAxis.Title.Text = "小时";
            myPane.YAxis.Title.Text = "功率";
            myPane.YAxis.Scale.Min = -2;
            myPane.YAxis.Scale.Max = 5;
            myPane.YAxis.MajorTic.IsOpposite = false;
            myPane.YAxis.MinorTic.IsOpposite = false;
            myPane.XAxis.MinorTic.IsOpposite = false;
            myPane.XAxis.MajorTic.IsOpposite = false;

            // Make up some data points
            string[] labels = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12",
                                "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" };

            PointPairList list = new PointPairList();

            PointPairList list_y2 = new PointPairList();

            for (int i = 0; i < _outputTotal.Length; i++)
            {
                double x = i;
                double y = _outputTotal[i];
                double y2 = _SOC[i];
                list.Add(x, y);
                list_y2.Add(x, y2);
            }

            // Generate a red curve with diamond
            // symbols, and "Porsche" in the legend
            LineItem myCurve2 = myPane.AddCurve("总出力", list, Color.Red, SymbolType.Circle);
            myCurve2.Line.Width = 2.0F;
            myCurve2.Symbol.Size = 8.0F;
            myCurve2.Symbol.Fill = new Fill(Color.Red);

            //LineItem myCurve3 = myPane.AddCurve("蓄电池容量", list_y2, Color.Purple, SymbolType.Diamond);
            //myCurve3.Line.Width = 2.0F;
            //myCurve3.Symbol.Size = 8.0F;
            //myCurve3.Symbol.Fill = new Fill(Color.Purple);
            //myCurve3.IsY2Axis = true;

            // Generate a blue bar with "Curve 2" in the legend
            BarItem myCurve = myPane.AddBar("光伏出力", null, _outputPV, Color.Blue);
            // Fill the bar with a Blue-white-Blue color gradient for a 3d look
            myCurve.Bar.Fill = new Fill(Color.Blue, Color.White, Color.Blue);

            // Generate a green bar with "Curve 3" in the legend
            myCurve = myPane.AddBar("风电出力", null, _outputWindM, Color.Green);
            // Fill the bar with a Green-white-Green color gradient for a 3d look
            myCurve.Bar.Fill = new Fill(Color.Green, Color.White, Color.Green);

            // Generate a red bar with "Curve 1" in the legend
            myCurve = myPane.AddBar("蓄电池出力", null, _outputBattery, Color.Purple);
            // Fill the bar with a red-white-red color gradient for a 3d look
            myCurve.Bar.Fill = new Fill(Color.Purple, Color.White, Color.Purple);

            // Generate a green bar with "Curve 3" in the legend
            myCurve = myPane.AddBar("交换功率", null, _outputExchange, Color.Yellow);
            // Fill the bar with a Green-white-Green color gradient for a 3d look
            myCurve.Bar.Fill = new Fill(Color.Yellow, Color.White, Color.Yellow);

            // Draw the X tics between the labels instead of at the labels
            myPane.XAxis.MajorTic.IsBetweenLabels = true;

            // Fill the axis background with a color gradient
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);

            // Fill the pane background with a color gradient
            myPane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);

            // Set the XAxis labels
            myPane.XAxis.Scale.TextLabels = labels;
            // Set the XAxis to Text type
            myPane.XAxis.Type = AxisType.Text;

            // Set the bar type to stack, which stacks the bars by automatically accumulating the values
            myPane.BarSettings.Type = BarType.Stack;

            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();
        }

        private void SetSize()
        {
            zedGraphControl1.Location = new Point(10, 10);
            // Leave a small margin around the outside of the control
            zedGraphControl1.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 20);
        }

        private void DrawChart_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
