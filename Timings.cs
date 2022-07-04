using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_project
{
    public partial class Timings : UserControl
    {
        public Timings()
        {
            InitializeComponent();
        }

        private void Timings_Load(object sender, EventArgs e)
        {
            this.timingsTableAdapter.Fill(this.misc.Timings);
            timingsBindingSource.DataSource = this.misc.Timings;
        }
    }
}
