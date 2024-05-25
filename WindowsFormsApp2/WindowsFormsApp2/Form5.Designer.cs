namespace WindowsFormsApp2
{
    partial class Form5
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDetailOfEquipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEquipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailOfEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoEkzDataSet = new WindowsFormsApp2.DemoEkzDataSet();
            this.detailOfEquipmentTableAdapter = new WindowsFormsApp2.DemoEkzDataSetTableAdapters.DetailOfEquipmentTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailOfEquipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEkzDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDetailOfEquipmentDataGridViewTextBoxColumn,
            this.iDDetailDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.iDEquipmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.detailOfEquipmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDetailOfEquipmentDataGridViewTextBoxColumn
            // 
            this.iDDetailOfEquipmentDataGridViewTextBoxColumn.DataPropertyName = "ID_DetailOfEquipment";
            this.iDDetailOfEquipmentDataGridViewTextBoxColumn.HeaderText = "ID_DetailOfEquipment";
            this.iDDetailOfEquipmentDataGridViewTextBoxColumn.Name = "iDDetailOfEquipmentDataGridViewTextBoxColumn";
            // 
            // iDDetailDataGridViewTextBoxColumn
            // 
            this.iDDetailDataGridViewTextBoxColumn.DataPropertyName = "ID_Detail";
            this.iDDetailDataGridViewTextBoxColumn.HeaderText = "ID_Detail";
            this.iDDetailDataGridViewTextBoxColumn.Name = "iDDetailDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // iDEquipmentDataGridViewTextBoxColumn
            // 
            this.iDEquipmentDataGridViewTextBoxColumn.DataPropertyName = "ID_Equipment";
            this.iDEquipmentDataGridViewTextBoxColumn.HeaderText = "ID_Equipment";
            this.iDEquipmentDataGridViewTextBoxColumn.Name = "iDEquipmentDataGridViewTextBoxColumn";
            // 
            // detailOfEquipmentBindingSource
            // 
            this.detailOfEquipmentBindingSource.DataMember = "DetailOfEquipment";
            this.detailOfEquipmentBindingSource.DataSource = this.demoEkzDataSet;
            // 
            // demoEkzDataSet
            // 
            this.demoEkzDataSet.DataSetName = "DemoEkzDataSet";
            this.demoEkzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailOfEquipmentTableAdapter
            // 
            this.detailOfEquipmentTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(569, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(569, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 165);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailOfEquipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEkzDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DemoEkzDataSet demoEkzDataSet;
        private System.Windows.Forms.BindingSource detailOfEquipmentBindingSource;
        private DemoEkzDataSetTableAdapters.DetailOfEquipmentTableAdapter detailOfEquipmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDetailOfEquipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEquipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}