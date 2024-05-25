namespace WindowsFormsApp2
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailEquipmentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderPartsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.titleToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(313, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executeToolStripMenuItem,
            this.clientToolStripMenuItem1,
            this.equipmentToolStripMenuItem,
            this.detailToolStripMenuItem,
            this.requstToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.clientToolStripMenuItem.Text = "Data";
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.executeToolStripMenuItem.Text = "Execute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.executeToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem1
            // 
            this.clientToolStripMenuItem1.Name = "clientToolStripMenuItem1";
            this.clientToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clientToolStripMenuItem1.Text = "Client";
            this.clientToolStripMenuItem1.Click += new System.EventHandler(this.clientToolStripMenuItem1_Click);
            // 
            // equipmentToolStripMenuItem
            // 
            this.equipmentToolStripMenuItem.Name = "equipmentToolStripMenuItem";
            this.equipmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.equipmentToolStripMenuItem.Text = "Equipment";
            this.equipmentToolStripMenuItem.Click += new System.EventHandler(this.equipmentToolStripMenuItem_Click);
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailToolStripMenuItem1,
            this.orderPartsToolStripMenuItem1,
            this.orderPartsToolStripMenuItem,
            this.detailEquipmentToolStripMenuItem1});
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detailToolStripMenuItem.Text = "Detail";
            // 
            // detailToolStripMenuItem1
            // 
            this.detailToolStripMenuItem1.Name = "detailToolStripMenuItem1";
            this.detailToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.detailToolStripMenuItem1.Text = "Detail";
            this.detailToolStripMenuItem1.Click += new System.EventHandler(this.detailToolStripMenuItem1_Click);
            // 
            // orderPartsToolStripMenuItem
            // 
            this.orderPartsToolStripMenuItem.Name = "orderPartsToolStripMenuItem";
            this.orderPartsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orderPartsToolStripMenuItem.Text = "Detail Order Parts";
            this.orderPartsToolStripMenuItem.Click += new System.EventHandler(this.orderPartsToolStripMenuItem_Click);
            // 
            // requstToolStripMenuItem
            // 
            this.requstToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestToolStripMenuItem,
            this.statusToolStripMenuItem});
            this.requstToolStripMenuItem.Name = "requstToolStripMenuItem";
            this.requstToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.requstToolStripMenuItem.Text = "Request/Status";
            // 
            // requestToolStripMenuItem
            // 
            this.requestToolStripMenuItem.Name = "requestToolStripMenuItem";
            this.requestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.requestToolStripMenuItem.Text = "Request";
            this.requestToolStripMenuItem.Click += new System.EventHandler(this.requestToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // titleToolStripMenuItem
            // 
            this.titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            this.titleToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.titleToolStripMenuItem.Text = "title";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // detailEquipmentToolStripMenuItem1
            // 
            this.detailEquipmentToolStripMenuItem1.Name = "detailEquipmentToolStripMenuItem1";
            this.detailEquipmentToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.detailEquipmentToolStripMenuItem1.Text = "Detail Equipment";
            this.detailEquipmentToolStripMenuItem1.Click += new System.EventHandler(this.detailEquipmentToolStripMenuItem1_Click_1);
            // 
            // orderPartsToolStripMenuItem1
            // 
            this.orderPartsToolStripMenuItem1.Name = "orderPartsToolStripMenuItem1";
            this.orderPartsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.orderPartsToolStripMenuItem1.Text = "Order Parts";
            this.orderPartsToolStripMenuItem1.Click += new System.EventHandler(this.orderPartsToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 156);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem equipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderPartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailEquipmentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderPartsToolStripMenuItem1;
    }
}