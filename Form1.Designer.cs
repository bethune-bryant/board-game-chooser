namespace BoardGameChooser
{
    partial class Form1
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
            this.numPlayers = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numMinMinutes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numMaxMinutes = new System.Windows.Forms.NumericUpDown();
            this.btnChoose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addBoardgameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listMechanisms = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listCategories = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listTypes = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGames = new System.Windows.Forms.DataGridView();
            this.scrapeFromBGGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMinutes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGames)).BeginInit();
            this.SuspendLayout();
            // 
            // numPlayers
            // 
            this.numPlayers.Location = new System.Drawing.Point(15, 37);
            this.numPlayers.Name = "numPlayers";
            this.numPlayers.Size = new System.Drawing.Size(54, 20);
            this.numPlayers.TabIndex = 0;
            this.numPlayers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Players:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minimum Minutes:";
            // 
            // numMinMinutes
            // 
            this.numMinMinutes.Location = new System.Drawing.Point(15, 76);
            this.numMinMinutes.Name = "numMinMinutes";
            this.numMinMinutes.Size = new System.Drawing.Size(54, 20);
            this.numMinMinutes.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Maximum Minutes:";
            // 
            // numMaxMinutes
            // 
            this.numMaxMinutes.Location = new System.Drawing.Point(15, 115);
            this.numMaxMinutes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMaxMinutes.Name = "numMaxMinutes";
            this.numMaxMinutes.Size = new System.Drawing.Size(54, 20);
            this.numMaxMinutes.TabIndex = 4;
            this.numMaxMinutes.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(12, 141);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 6;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBoardgameToolStripMenuItem,
            this.viewSourceCodeToolStripMenuItem,
            this.scrapeFromBGGToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(659, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addBoardgameToolStripMenuItem
            // 
            this.addBoardgameToolStripMenuItem.Name = "addBoardgameToolStripMenuItem";
            this.addBoardgameToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.addBoardgameToolStripMenuItem.Text = "Add Boardgame";
            this.addBoardgameToolStripMenuItem.Click += new System.EventHandler(this.addBoardgameToolStripMenuItem_Click);
            // 
            // viewSourceCodeToolStripMenuItem
            // 
            this.viewSourceCodeToolStripMenuItem.Name = "viewSourceCodeToolStripMenuItem";
            this.viewSourceCodeToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.viewSourceCodeToolStripMenuItem.Text = "View Source Code";
            this.viewSourceCodeToolStripMenuItem.Click += new System.EventHandler(this.viewSourceCodeToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(659, 745);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listMechanisms);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listCategories);
            this.groupBox1.Controls.Add(this.btnChoose);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numMaxMinutes);
            this.groupBox1.Controls.Add(this.listTypes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numPlayers);
            this.groupBox1.Controls.Add(this.numMinMinutes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 179);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose A Board Game";
            // 
            // listMechanisms
            // 
            this.listMechanisms.FormattingEnabled = true;
            this.listMechanisms.Location = new System.Drawing.Point(468, 37);
            this.listMechanisms.Name = "listMechanisms";
            this.listMechanisms.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listMechanisms.Size = new System.Drawing.Size(172, 121);
            this.listMechanisms.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mechanisms:";
            // 
            // listCategories
            // 
            this.listCategories.FormattingEnabled = true;
            this.listCategories.Location = new System.Drawing.Point(290, 37);
            this.listCategories.Name = "listCategories";
            this.listCategories.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listCategories.Size = new System.Drawing.Size(172, 121);
            this.listCategories.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Categories:";
            // 
            // listTypes
            // 
            this.listTypes.FormattingEnabled = true;
            this.listTypes.Location = new System.Drawing.Point(112, 37);
            this.listTypes.Name = "listTypes";
            this.listTypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listTypes.Size = new System.Drawing.Size(172, 121);
            this.listTypes.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Types:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGames);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 562);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Board Games";
            // 
            // dataGames
            // 
            this.dataGames.AllowUserToAddRows = false;
            this.dataGames.AllowUserToDeleteRows = false;
            this.dataGames.AllowUserToOrderColumns = true;
            this.dataGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGames.Location = new System.Drawing.Point(3, 16);
            this.dataGames.MultiSelect = false;
            this.dataGames.Name = "dataGames";
            this.dataGames.ReadOnly = true;
            this.dataGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGames.Size = new System.Drawing.Size(653, 543);
            this.dataGames.TabIndex = 0;
            this.dataGames.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGames_CellDoubleClick);
            this.dataGames.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGames_KeyUp);
            // 
            // scrapeFromBGGToolStripMenuItem
            // 
            this.scrapeFromBGGToolStripMenuItem.Name = "scrapeFromBGGToolStripMenuItem";
            this.scrapeFromBGGToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.scrapeFromBGGToolStripMenuItem.Text = "Scrape from BGG";
            this.scrapeFromBGGToolStripMenuItem.Click += new System.EventHandler(this.scrapeFromBGGToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 769);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Board Game Chooser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMinutes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMinMinutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMaxMinutes;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addBoardgameToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGames;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listMechanisms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listCategories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listTypes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem viewSourceCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scrapeFromBGGToolStripMenuItem;
    }
}

