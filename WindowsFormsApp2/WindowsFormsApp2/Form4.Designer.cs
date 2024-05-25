namespace WindowsFormsApp2
{
    partial class Form4
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
            this.demoEkzDataSet = new WindowsFormsApp2.DemoEkzDataSet();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentTableAdapter = new WindowsFormsApp2.DemoEkzDataSetTableAdapters.EquipmentTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.iDEquipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameEquipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeMalfucationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionProblemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEkzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEquipmentDataGridViewTextBoxColumn,
            this.nameEquipmentDataGridViewTextBoxColumn,
            this.typeMalfucationDataGridViewTextBoxColumn,
            this.descriptionProblemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.equipmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // demoEkzDataSet
            // 
            this.demoEkzDataSet.DataSetName = "DemoEkzDataSet";
            this.demoEkzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.demoEkzDataSet;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(527, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(527, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iDEquipmentDataGridViewTextBoxColumn
            // 
            this.iDEquipmentDataGridViewTextBoxColumn.DataPropertyName = "ID_Equipment";
            this.iDEquipmentDataGridViewTextBoxColumn.HeaderText = "ID_Equipment";
            this.iDEquipmentDataGridViewTextBoxColumn.Name = "iDEquipmentDataGridViewTextBoxColumn";
            // 
            // nameEquipmentDataGridViewTextBoxColumn
            // 
            this.nameEquipmentDataGridViewTextBoxColumn.DataPropertyName = "Name_Equipment";
            this.nameEquipmentDataGridViewTextBoxColumn.HeaderText = "Name_Equipment";
            this.nameEquipmentDataGridViewTextBoxColumn.Name = "nameEquipmentDataGridViewTextBoxColumn";
            // 
            // typeMalfucationDataGridViewTextBoxColumn
            // 
            this.typeMalfucationDataGridViewTextBoxColumn.DataPropertyName = "Type_Malfucation";
            this.typeMalfucationDataGridViewTextBoxColumn.HeaderText = "Type_Malfucation";
            this.typeMalfucationDataGridViewTextBoxColumn.Name = "typeMalfucationDataGridViewTextBoxColumn";
            // 
            // descriptionProblemDataGridViewTextBoxColumn
            // 
            this.descriptionProblemDataGridViewTextBoxColumn.DataPropertyName = "Description_Problem";
            this.descriptionProblemDataGridViewTextBoxColumn.HeaderText = "Description_Problem";
            this.descriptionProblemDataGridViewTextBoxColumn.Name = "descriptionProblemDataGridViewTextBoxColumn";
            this.descriptionProblemDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 168);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEkzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DemoEkzDataSet demoEkzDataSet;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private DemoEkzDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEquipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameEquipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeMalfucationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionProblemDataGridViewTextBoxColumn;
    }
}