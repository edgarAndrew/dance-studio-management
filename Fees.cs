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
    public partial class Fees : UserControl
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void Fees_Load(object sender, EventArgs e)
        { 
            this.feesTableAdapter.Fill(this.misc.Fees);
            feesBindingSource.DataSource = this.misc.Fees;
        }
    }
}
