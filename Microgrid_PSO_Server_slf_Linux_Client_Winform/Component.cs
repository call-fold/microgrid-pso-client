using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    public partial class Component : Form
    {
        public Component()
        {
            InitializeComponent();
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            Line line = new Line();
            line.Show();
        }

        private void buttonBus_Click(object sender, EventArgs e)
        {
            Bus bus = new Bus();
            bus.Show();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Load load = new Load();
            load.Show();
        }

        private void buttonWindM_Click(object sender, EventArgs e)
        {
            WindM windm = new WindM();
            windm.Show();
        }

        private void buttonPV_Click(object sender, EventArgs e)
        {
            PV pv = new PV();
            pv.Show();
        }

        private void buttonBat_Click(object sender, EventArgs e)
        {
            Battery battery = new Battery();
            battery.Show();
        }
    }
}
