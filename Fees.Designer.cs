
namespace SE_project
{
    partial class Fees
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
            this.danceStyleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feesperMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.misc = new SE_project.Misc();
            this.feesTableAdapter = new SE_project.MiscTableAdapters.FeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesBindingSource)).BeginInit();
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
            this.danceStyleDataGridViewTextBoxColumn,
            this.feesperMonthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.feesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(815, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 75;
            // 
            // danceStyleDataGridViewTextBoxColumn
            // 
            this.danceStyleDataGridViewTextBoxColumn.DataPropertyName = "Dance Style";
            this.danceStyleDataGridViewTextBoxColumn.HeaderText = "Dance Style";
            this.danceStyleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.danceStyleDataGridViewTextBoxColumn.Name = "danceStyleDataGridViewTextBoxColumn";
            this.danceStyleDataGridViewTextBoxColumn.ReadOnly = true;
            this.danceStyleDataGridViewTextBoxColumn.Width = 200;
            // 
            // feesperMonthDataGridViewTextBoxColumn
            // 
            this.feesperMonthDataGridViewTextBoxColumn.DataPropertyName = "Fees (per month)";
            this.feesperMonthDataGridViewTextBoxColumn.HeaderText = "Fees (per month)";
            this.feesperMonthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feesperMonthDataGridViewTextBoxColumn.Name = "feesperMonthDataGridViewTextBoxColumn";
            this.feesperMonthDataGridViewTextBoxColumn.ReadOnly = true;
            this.feesperMonthDataGridViewTextBoxColumn.Width = 200;
            // 
            // feesBindingSource
            // 
            this.feesBindingSource.DataMember = "Fees";
            this.feesBindingSource.DataSource = this.misc;
            // 
            // misc
            // 
            this.misc.DataSetName = "Misc";
            this.misc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feesTableAdapter
            // 
            this.feesTableAdapter.ClearBeforeFill = true;
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "Fees";
            this.Size = new System.Drawing.Size(850, 430);
            this.Load += new System.EventHandler(this.Fees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.misc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource feesBindingSource;
        private Misc misc;
        private MiscTableAdapters.FeesTableAdapter feesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danceStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feesperMonthDataGridViewTextBoxColumn;
    }
}
