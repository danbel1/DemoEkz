namespace WindowsFormsApp2
{
    partial class Form7
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
            this.detailOfOrderPartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailOfOrderPartsTableAdapter = new WindowsFormsApp2.DemoEkzDataSetTableAdapters.DetailOfOrderPartsTableAdapter();
            this.iDComponentOfOrderPartsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDOrderPartsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEkzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailOfOrderPartsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDComponentOfOrderPartsDataGridViewTextBoxColumn,
            this.iDDetailDataGridViewTextBoxColumn,
            this.iDOrderPartsDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.detailOfOrderPartsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // demoEkzDataSet
            // 
            this.demoEkzDataSet.DataSetName = "DemoEkzDataSet";
            this.demoEkzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailOfOrderPartsBindingSource
            // 
            this.detailOfOrderPartsBindingSource.DataMember = "DetailOfOrderParts";
            this.detailOfOrderPartsBindingSource.DataSource = this.demoEkzDataSet;
            // 
            // detailOfOrderPartsTableAdapter
            // 
            this.detailOfOrderPartsTableAdapter.ClearBeforeFill = true;
            // 
            // iDComponentOfOrderPartsDataGridViewTextBoxColumn
            // 
            this.iDComponentOfOrderPartsDataGridViewTextBoxColumn.DataPropertyName = "ID_ComponentOfOrderParts";
            this.iDComponentOfOrderPartsDataGridViewTextBoxColumn.HeaderText = "ID_ComponentOfOrderParts";
            this.iDComponentOfOrderPartsDataGridViewTextBoxColumn.Name = "iDComponentOfOrderPartsDataGridViewTextBoxColumn";
            // 
            // iDDetailDataGridViewTextBoxColumn
            // 
            this.iDDetailDataGridViewTextBoxColumn.DataPropertyName = "ID_Detail";
            this.iDDetailDataGridViewTextBoxColumn.HeaderText = "ID_Detail";
            this.iDDetailDataGridViewTextBoxColumn.Name = "iDDetailDataGridViewTextBoxColumn";
            // 
            // iDOrderPartsDataGridViewTextBoxColumn
            // 
            this.iDOrderPartsDataGridViewTextBoxColumn.DataPropertyName = "ID_OrderParts";
            this.iDOrderPartsDataGridViewTextBoxColumn.HeaderText = "ID_OrderParts";
            this.iDOrderPartsDataGridViewTextBoxColumn.Name = "iDOrderPartsDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(583, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(583, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 175);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEkzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailOfOrderPartsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DemoEkzDataSet demoEkzDataSet;
        private System.Windows.Forms.BindingSource detailOfOrderPartsBindingSource;
        private DemoEkzDataSetTableAdapters.DetailOfOrderPartsTableAdapter detailOfOrderPartsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDComponentOfOrderPartsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOrderPartsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}