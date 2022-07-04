
namespace SE_project
{
    partial class Timings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stylesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.misc = new SE_project.Misc();
            this.timingsTableAdapter = new SE_project.MiscTableAdapters.TimingsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.misc)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.stylesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.timingsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(730, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 65;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 200;
            // 
            // stylesDataGridViewTextBoxColumn
            // 
            this.stylesDataGridViewTextBoxColumn.DataPropertyName = "Styles";
            this.stylesDataGridViewTextBoxColumn.HeaderText = "Styles";
            this.stylesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stylesDataGridViewTextBoxColumn.Name = "stylesDataGridViewTextBoxColumn";
            this.stylesDataGridViewTextBoxColumn.ReadOnly = true;
            this.stylesDataGridViewTextBoxColumn.Width = 200;
            // 
            // timingsBindingSource
            // 
            this.timingsBindingSource.DataMember = "Timings";
            this.timingsBindingSource.DataSource = this.misc;
            // 
            // misc
            // 
            this.misc.DataSetName = "Misc";
            this.misc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timingsTableAdapter
            // 
            this.timingsTableAdapter.ClearBeforeFill = true;
            // 
            // Timings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "Timings";
            this.Size = new System.Drawing.Size(850, 430);
            this.Load += new System.EventHandler(this.Timings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.misc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource timingsBindingSource;
        private Misc misc;
        private MiscTableAdapters.TimingsTableAdapter timingsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stylesDataGridViewTextBoxColumn;
    }
}
