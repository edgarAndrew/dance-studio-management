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
    public partial class Enrollment : UserControl
    {
        public Enrollment()
        {
            InitializeComponent();
            panel.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                studentdetailsBindingSource.EndEdit();
                student_detailsTableAdapter.Update(this.appData.Student_details);
                panel.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentdetailsBindingSource.ResetBindings(false);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = txtAge.Text = txtContact.Text = txtAddress.Text="";
            txtDanceStyle.Text = txtDanceStyle.Items[0].ToString();
            txtTiming.Text = txtTiming.Items[0].ToString();
            panel.Enabled = false;
            studentdetailsBindingSource.ResetBindings(false);
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
            this.student_detailsTableAdapter.Fill(this.appData.Student_details);
            studentdetailsBindingSource.DataSource = this.appData.Student_details;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.student_detailsTableAdapter.Fill(this.appData.Student_details);
            studentdetailsBindingSource.DataSource = this.appData.Student_details;

            try
            {
                txtTiming.Text = txtTiming.Items[0].ToString(); txtDanceStyle.Text = txtDanceStyle.Items[0].ToString();
                panel.Enabled = true;
                txtName.Focus();
                this.appData.Student_details.AddStudent_detailsRow(this.appData.Student_details.NewStudent_detailsRow());
                studentdetailsBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentdetailsBindingSource.ResetBindings(false);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtName.Focus();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                        studentdetailsBindingSource.RemoveCurrent();
                    studentdetailsBindingSource.EndEdit();
                    student_detailsTableAdapter.Update(this.appData.Student_details);
                    this.appData.Student_details.AcceptChanges();
                }
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    this.student_detailsTableAdapter.Fill(this.appData.Student_details);
                    studentdetailsBindingSource.DataSource = this.appData.Student_details;
                }
                else
                {
                    var query = from o in this.appData.Student_details
                                where o.S_Name.Contains(txtSearch.Text) || o.Contact == txtSearch.Text
                                select o;
                    studentdetailsBindingSource.DataSource = query.ToList();
                }
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                studentdetailsBindingSource.RemoveCurrent();
                studentdetailsBindingSource.EndEdit();
                student_detailsTableAdapter.Update(this.appData.Student_details);
                this.appData.Student_details.AcceptChanges();
            }
        }
    }
}
