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
    public partial class Hiring : UserControl
    {
        public Hiring()
        {
            InitializeComponent();
            panel.Enabled = false;
        }

        private void Hiring_Load(object sender, EventArgs e)
        {
            this.instructorsTableAdapter.Fill(this.dataSet.Instructors);
            instructorsBindingSource.DataSource = this.dataSet.Instructors;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                instructorsBindingSource.EndEdit();
                instructorsTableAdapter.Update(this.dataSet.Instructors);
                panel.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                instructorsBindingSource.ResetBindings(false);
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.instructorsTableAdapter.Fill(this.dataSet.Instructors);
            instructorsBindingSource.DataSource = this.dataSet.Instructors;

            try
            {
                txtName.Text = txtAddress.Text = txtContact.Text = txtEmail.Text = txtAge.Text = "";
                panel.Enabled = true;
                txtName.Focus();
                this.dataSet.Instructors.AddInstructorsRow(this.dataSet.Instructors.NewInstructorsRow());
                instructorsBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                instructorsBindingSource.ResetBindings(false);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = txtAddress.Text = txtContact.Text = txtEmail.Text = txtAge.Text="";
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    this.instructorsTableAdapter.Fill(this.dataSet.Instructors);
                    instructorsBindingSource.DataSource = this.dataSet.Instructors;
                }
                else
                {
                    var query = from o in this.dataSet.Instructors
                                where o.I_Name.Contains(txtSearch.Text) || o.I_Contact == txtSearch.Text || o.I_Email == txtSearch.Text
                                select o;
                    instructorsBindingSource.DataSource = query.ToList();
                }
            }

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    instructorsBindingSource.RemoveCurrent();
                    instructorsBindingSource.EndEdit();
                    instructorsTableAdapter.Update(this.dataSet.Instructors);
                    this.dataSet.Instructors.AcceptChanges();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtName.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                instructorsBindingSource.RemoveCurrent();
                instructorsBindingSource.EndEdit();
                instructorsTableAdapter.Update(this.dataSet.Instructors);
                this.dataSet.Instructors.AcceptChanges();
            }
        }
    }
}
