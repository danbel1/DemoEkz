namespace WindowsFormsApp2
{
    partial class Form9
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
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestTableAdapter = new WindowsFormsApp2.DemoEkzDataSetTableAdapters.RequestTableAdapter();
            this.iDApplicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEquipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDExecutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEkzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDApplicationDataGridViewTextBoxColumn,
            this.iDStatusDataGridViewTextBoxColumn,
            this.iDEquipmentDataGridViewTextBoxColumn,
            this.iDClientDataGridViewTextBoxColumn,
            this.iDExecutorDataGridViewTextBoxColumn,
            this.serialNumberDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.requestBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // demoEkzDataSet
            // 
            this.demoEkzDataSet.DataSetName = "DemoEkzDataSet";
            this.demoEkzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestBindingSource
            // 
            this.requestBindingSource.DataMember = "Request";
            this.requestBindingSource.DataSource = this.demoEkzDataSet;
            // 
            // requestTableAdapter
            // 
            this.requestTableAdapter.ClearBeforeFill = true;
            // 
            // iDApplicationDataGridViewTextBoxColumn
            // 
            this.iDApplicationDataGridViewTextBoxColumn.DataPropertyName = "ID_Application";
            this.iDApplicationDataGridViewTextBoxColumn.HeaderText = "ID_Application";
            this.iDApplicationDataGridViewTextBoxColumn.Name = "iDApplicationDataGridViewTextBoxColumn";
            // 
            // iDStatusDataGridViewTextBoxColumn
            // 
            this.iDStatusDataGridViewTextBoxColumn.DataPropertyName = "ID_Status";
            this.iDStatusDataGridViewTextBoxColumn.HeaderText = "ID_Status";
            this.iDStatusDataGridViewTextBoxColumn.Name = "iDStatusDataGridViewTextBoxColumn";
            // 
            // iDEquipmentDataGridViewTextBoxColumn
            // 
            this.iDEquipmentDataGridViewTextBoxColumn.DataPropertyName = "ID_Equipment";
            this.iDEquipmentDataGridViewTextBoxColumn.HeaderText = "ID_Equipment";
            this.iDEquipmentDataGridViewTextBoxColumn.Name = "iDEquipmentDataGridViewTextBoxColumn";
            // 
            // iDClientDataGridViewTextBoxColumn
            // 
            this.iDClientDataGridViewTextBoxColumn.DataPropertyName = "ID_Client";
            this.iDClientDataGridViewTextBoxColumn.HeaderText = "ID_Client";
            this.iDClientDataGridViewTextBoxColumn.Name = "iDClientDataGridViewTextBoxColumn";
            // 
            // iDExecutorDataGridViewTextBoxColumn
            // 
            this.iDExecutorDataGridViewTextBoxColumn.DataPropertyName = "ID_Executor";
            this.iDExecutorDataGridViewTextBoxColumn.HeaderText = "ID_Executor";
            this.iDExecutorDataGridViewTextBoxColumn.Name = "iDExecutorDataGridViewTextBoxColumn";
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "Serial_Number";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "Serial_Number";
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(875, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(875, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(875, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 177);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEkzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DemoEkzDataSet demoEkzDataSet;
        private System.Windows.Forms.BindingSource requestBindingSource;
        private DemoEkzDataSetTableAdapters.RequestTableAdapter requestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDApplicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEquipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDExecutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}