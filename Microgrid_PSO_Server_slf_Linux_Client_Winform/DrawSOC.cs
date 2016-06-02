using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    public partial class DrawSOC : Form
    {
        public DrawSOC(double[] _SOC_)
        {
            InitializeComponent();
            ShowChart(_SOC_);
            SetSize();
        }

        private void ShowChart(double[] _SOC)
        {
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.GraphPane.GraphObjList.Clear();
            // clearing not teste  

            GraphPane myPane = zedGraphControl1.GraphPane;

            // Set the title and axis labels
            myPane.Title.Text = "蓄电池容量";
            myPane.XAxis.Title.Text = "小时";
            myPane.YAxis.Title.Text = "容量";
            myPane.YAxis.Scale.Min = -1;
            myPane.YAxis.Scale.Max = 2.5;
            myPane.YAxis.MajorTic.IsOpposite = false;
            myPane.YAxis.MinorTic.IsOpposite = false;
            myPane.XAxis.MinorTic.IsOpposite = false;
            myPane.XAxis.MajorTic.IsOpposite = false;

            // Make up some data points
            string[] labels = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12",
                                "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" };

            PointPairList list = new PointPairList();

            for (int i = 0; i < _SOC.Length; i++)
            {
                double x = i;
                double y = _SOC[i];
                list.Add(x, y);
            }

            // Generate a red curve with diamond
            // symbols, and "Porsche" in the legend
            LineItem myCurve = myPane.AddCurve("蓄电池容量", list, Color.Purple, SymbolType.Circle);
            myCurve.Line.Width = 2.0F;
            myCurve.Symbol.Size = 8.0F;
            myCurve.Symbol.Fill = new Fill(Color.Purple);

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
