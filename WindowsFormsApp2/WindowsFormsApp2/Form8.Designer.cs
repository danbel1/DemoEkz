namespace WindowsFormsApp2
{
    partial class Form8
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
            this.orderPartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderPartsTableAdapter = new WindowsFormsApp2.DemoEkzDataSetTableAdapters.OrderPartsTableAdapter();
            this.iDOrderPartsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDApplicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDExecutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEkzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPartsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOrderPartsDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.iDApplicationDataGridViewTextBoxColumn,
            this.iDExecutorDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderPartsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // demoEkzDataSet
            // 
            this.demoEkzDataSet.DataSetName = "DemoEkzDataSet";
            this.demoEkzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderPartsBindingSource
            // 
            this.orderPartsBindingSource.DataMember = "OrderParts";
            this.orderPartsBindingSource.DataSource = this.demoEkzDataSet;
            // 
            // orderPartsTableAdapter
            // 
            this.orderPartsTableAdapter.ClearBeforeFill = true;
            // 
            // iDOrderPartsDataGridViewTextBoxColumn
            // 
            this.iDOrderPartsDataGridViewTextBoxColumn.DataPropertyName = "ID_OrderParts";
            this.iDOrderPartsDataGridViewTextBoxColumn.HeaderText = "ID_OrderParts";
            this.iDOrderPartsDataGridViewTextBoxColumn.Name = "iDOrderPartsDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // iDApplicationDataGridViewTextBoxColumn
            // 
            this.iDApplicationDataGridViewTextBoxColumn.DataPropertyName = "ID_Application";
            this.iDApplicationDataGridViewTextBoxColumn.HeaderText = "ID_Application";
            this.iDApplicationDataGridViewTextBoxColumn.Name = "iDApplicationDataGridViewTextBoxColumn";
            // 
            // iDExecutorDataGridViewTextBoxColumn
            // 
            this.iDExecutorDataGridViewTextBoxColumn.DataPropertyName = "ID_Executor";
            this.iDExecutorDataGridViewTextBoxColumn.HeaderText = "ID_Executor";
            this.iDExecutorDataGridViewTextBoxColumn.Name = "iDExecutorDataGridViewTextBoxColumn";
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(572, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(572, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 168);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEkzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPartsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DemoEkzDataSet demoEkzDataSet;
        private System.Windows.Forms.BindingSource orderPartsBindingSource;
        private DemoEkzDataSetTableAdapters.OrderPartsTableAdapter orderPartsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOrderPartsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDApplicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDExecutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}