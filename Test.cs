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
    public partial class Test : UserControl
    {
        public Test()
        {
            InitializeComponent();
        }

        private void student_detailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.student_detailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appData);

        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
