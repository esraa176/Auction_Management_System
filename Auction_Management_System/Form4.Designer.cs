namespace Auction_Management_System
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
            this.viewTransaction_btn = new System.Windows.Forms.Button();
            this.categoryName_cmb = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.viewItems_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAuctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAuctionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewTransaction_btn
            // 
            this.viewTransaction_btn.BackColor = System.Drawing.Color.Gray;
            this.viewTransaction_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTransaction_btn.ForeColor = System.Drawing.Color.White;
            this.viewTransaction_btn.Location = new System.Drawing.Point(824, 36);
            this.viewTransaction_btn.Name = "viewTransaction_btn";
            this.viewTransaction_btn.Size = new System.Drawing.Size(173, 63);
            this.viewTransaction_btn.TabIndex = 0;
            this.viewTransaction_btn.Text = "View Transactions";
            this.viewTransaction_btn.UseVisualStyleBackColor = false;
            this.viewTransaction_btn.Click += new System.EventHandler(this.viewTransaction_btn_Click);
            // 
            // categoryName_cmb
            // 
            this.categoryName_cmb.FormattingEnabled = true;
            this.categoryName_cmb.Location = new System.Drawing.Point(417, 75);
            this.categoryName_cmb.Name = "categoryName_cmb";
            this.categoryName_cmb.Size = new System.Drawing.Size(137, 24);
            this.categoryName_cmb.TabIndex = 2;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 120);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1239, 514);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // viewItems_btn
            // 
            this.viewItems_btn.BackColor = System.Drawing.Color.Gray;
            this.viewItems_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewItems_btn.ForeColor = System.Drawing.Color.White;
            this.viewItems_btn.Location = new System.Drawing.Point(575, 37);
            this.viewItems_btn.Name = "viewItems_btn";
            this.viewItems_btn.Size = new System.Drawing.Size(166, 62);
            this.viewItems_btn.TabIndex = 4;
            this.viewItems_btn.Text = "View Items";
            this.viewItems_btn.UseVisualStyleBackColor = false;
            this.viewItems_btn.Click += new System.EventHandler(this.viewItems_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Category";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Auction_Management_System.Properties.Resources.wide_auctiontext_inarticle;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1263, 43);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackgroundImage = global::Auction_Management_System.Properties.Resources.wide_auctiontext_inarticle;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAuctionToolStripMenuItem,
            this.createAuctionToolStripMenuItem1,
            this.showHistoryToolStripMenuItem,
            this.searchForItemToolStripMenuItem,
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(95, 39);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // createAuctionToolStripMenuItem
            // 
            this.createAuctionToolStripMenuItem.BackgroundImage = global::Auction_Management_System.Properties.Resources.wide_auctiontext_inarticle;
            this.createAuctionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.createAuctionToolStripMenuItem.Name = "createAuctionToolStripMenuItem";
            this.createAuctionToolStripMenuItem.Size = new System.Drawing.Size(278, 40);
            this.createAuctionToolStripMenuItem.Text = "Main Form";
            this.createAuctionToolStripMenuItem.Click += new System.EventHandler(this.createAuctionToolStripMenuItem_Click);
            // 
            // createAuctionToolStripMenuItem1
            // 
            this.createAuctionToolStripMenuItem1.BackgroundImage = global::Auction_Management_System.Properties.Resources.wide_auctiontext_inarticle;
            this.createAuctionToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.createAuctionToolStripMenuItem1.Name = "createAuctionToolStripMenuItem1";
            this.createAuctionToolStripMenuItem1.Size = new System.Drawing.Size(278, 40);
            this.createAuctionToolStripMenuItem1.Text = "Create Auction";
            this.createAuctionToolStripMenuItem1.Click += new System.EventHandler(this.createAuctionToolStripMenuItem1_Click);
            // 
            // showHistoryToolStripMenuItem
            // 
            this.showHistoryToolStripMenuItem.BackgroundImage = global::Auction_Management_System.Properties.Resources.wide_auctiontext_inarticle;
            this.showHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.showHistoryToolStripMenuItem.Name = "showHistoryToolStripMenuItem";
            this.showHistoryToolStripMenuItem.Size = new System.Drawing.Size(278, 40);
            this.showHistoryToolStripMenuItem.Text = "Show History";
            this.showHistoryToolStripMenuItem.Click += new System.EventHandler(this.showHistoryToolStripMenuItem_Click);
            // 
            // searchForItemToolStripMenuItem
            // 
            this.searchForItemToolStripMenuItem.BackgroundImage = global::Auction_Management_System.Properties.Resources.wide_auctiontext_inarticle;
            this.searchForItemToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.searchForItemToolStripMenuItem.Name = "searchForItemToolStripMenuItem";
            this.searchForItemToolStripMenuItem.Size = new System.Drawing.Size(278, 40);
            this.searchForItemToolStripMenuItem.Text = "Search for Item";
            this.searchForItemToolStripMenuItem.Click += new System.EventHandler(this.searchForItemToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackgroundImage = global::Auction_Management_System.Properties.Resources.wide_auctiontext_inarticle;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(220)))), ((int)(((byte)(205)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(278, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.BackgroundImage = global::Auction_Management_System.Properties.Resources.wide_auctiontext_inarticle;
            this.backToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(278, 40);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Auction_Management_System.Properties.Resources.wide_auctiontext_inarticle;
            this.ClientSize = new System.Drawing.Size(1263, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewItems_btn);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.categoryName_cmb);
            this.Controls.Add(this.viewTransaction_btn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewTransaction_btn;
        private System.Windows.Forms.ComboBox categoryName_cmb;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button viewItems_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAuctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAuctionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchForItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}