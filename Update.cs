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
    public partial class Update : UserControl
    {
        public Update()
        {
            InitializeComponent();
            
        }


        private void Update_Load(object sender, EventArgs e)
        {
            this.student_detailsTableAdapter.Fill(this.appData.Student_details);
            studentdetailsBindingSource.DataSource = this.appData.Student_details;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    this.student_detailsTableAdapter.Fill(this.appData.Student_details);
                    studentdetailsBindingSource.DataSource = this.appData.Student_details;
                    dataGridView1.DataSource = studentdetailsBindingSource;
                }
                else
                {
                    var query = from o in this.appData.Student_details
                                where o.S_Name.Contains(txtSearch.Text) || o.Contact == txtSearch.Text
                                select o;
                    //studentdetailsBindingSource.DataSource = query.ToList();
                    dataGridView1.DataSource = query.ToList();
                }
            }
        }
    }
}
