namespace BoardGameChooser
{
    partial class frmScrape
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnScrape = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGames = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGames)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(280, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(199, 209);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(56, 6);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(409, 20);
            this.txtUser.TabIndex = 18;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 17;
            this.lblUser.Text = "User:";
            // 
            // btnScrape
            // 
            this.btnScrape.Location = new System.Drawing.Point(471, 4);
            this.btnScrape.Name = "btnScrape";
            this.btnScrape.Size = new System.Drawing.Size(75, 23);
            this.btnScrape.TabIndex = 19;
            this.btnScrape.Text = "Scrape";
            this.btnScrape.UseVisualStyleBackColor = true;
            this.btnScrape.Click += new System.EventHandler(this.btnScrape_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGames);
            this.groupBox2.Location = new System.Drawing.Point(15, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 171);
            this.groupBox2.TabIndex = 20;
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
            this.dataGames.Size = new System.Drawing.Size(525, 152);
            this.dataGames.TabIndex = 0;
            this.dataGames.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGames_CellDoubleClick);
            this.dataGames.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGames_KeyUp);
            // 
            // frmScrape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(558, 244);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnScrape);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScrape";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Scrape from BGG";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnScrape;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGames;
    }
}