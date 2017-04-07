namespace BoardGameChooser
{
    partial class frmBoardGame
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNumberofPlayers = new System.Windows.Forms.Label();
            this.numMinPlayers = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numMaxPlayers = new System.Windows.Forms.NumericUpDown();
            this.numMaxDuration = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numMinDuration = new System.Windows.Forms.NumericUpDown();
            this.lblDuration = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listTypes = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.listCategories = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listMechanisms = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(487, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblNumberofPlayers
            // 
            this.lblNumberofPlayers.AutoSize = true;
            this.lblNumberofPlayers.Location = new System.Drawing.Point(12, 34);
            this.lblNumberofPlayers.Name = "lblNumberofPlayers";
            this.lblNumberofPlayers.Size = new System.Drawing.Size(96, 13);
            this.lblNumberofPlayers.TabIndex = 2;
            this.lblNumberofPlayers.Text = "Number of Players:";
            // 
            // numMinPlayers
            // 
            this.numMinPlayers.Location = new System.Drawing.Point(114, 32);
            this.numMinPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinPlayers.Name = "numMinPlayers";
            this.numMinPlayers.Size = new System.Drawing.Size(40, 20);
            this.numMinPlayers.TabIndex = 4;
            this.numMinPlayers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "-";
            // 
            // numMaxPlayers
            // 
            this.numMaxPlayers.Location = new System.Drawing.Point(176, 32);
            this.numMaxPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxPlayers.Name = "numMaxPlayers";
            this.numMaxPlayers.Size = new System.Drawing.Size(40, 20);
            this.numMaxPlayers.TabIndex = 6;
            this.numMaxPlayers.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numMaxDuration
            // 
            this.numMaxDuration.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMaxDuration.Location = new System.Drawing.Point(399, 32);
            this.numMaxDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaxDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxDuration.Name = "numMaxDuration";
            this.numMaxDuration.Size = new System.Drawing.Size(40, 20);
            this.numMaxDuration.TabIndex = 10;
            this.numMaxDuration.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "-";
            // 
            // numMinDuration
            // 
            this.numMinDuration.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMinDuration.Location = new System.Drawing.Point(337, 32);
            this.numMinDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMinDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinDuration.Name = "numMinDuration";
            this.numMinDuration.Size = new System.Drawing.Size(40, 20);
            this.numMinDuration.TabIndex = 8;
            this.numMinDuration.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(236, 34);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(95, 13);
            this.lblDuration.TabIndex = 7;
            this.lblDuration.Text = "Duration (minutes):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Types:";
            // 
            // listTypes
            // 
            this.listTypes.FormattingEnabled = true;
            this.listTypes.Location = new System.Drawing.Point(12, 82);
            this.listTypes.Name = "listTypes";
            this.listTypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listTypes.Size = new System.Drawing.Size(172, 121);
            this.listTypes.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(277, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(196, 209);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // listCategories
            // 
            this.listCategories.FormattingEnabled = true;
            this.listCategories.Location = new System.Drawing.Point(189, 82);
            this.listCategories.Name = "listCategories";
            this.listCategories.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listCategories.Size = new System.Drawing.Size(172, 121);
            this.listCategories.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Categories:";
            // 
            // listMechanisms
            // 
            this.listMechanisms.FormattingEnabled = true;
            this.listMechanisms.Location = new System.Drawing.Point(367, 82);
            this.listMechanisms.Name = "listMechanisms";
            this.listMechanisms.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listMechanisms.Size = new System.Drawing.Size(172, 121);
            this.listMechanisms.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mechanisms:";
            // 
            // frmBoardGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(558, 245);
            this.Controls.Add(this.listMechanisms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listCategories);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.listTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMaxDuration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numMinDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.numMaxPlayers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numMinPlayers);
            this.Controls.Add(this.lblNumberofPlayers);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 283);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(574, 283);
            this.Name = "frmBoardGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Edit Board Game";
            ((System.ComponentModel.ISupportInitialize)(this.numMinPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNumberofPlayers;
        private System.Windows.Forms.NumericUpDown numMinPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMaxPlayers;
        private System.Windows.Forms.NumericUpDown numMaxDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMinDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listTypes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox listCategories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listMechanisms;
        private System.Windows.Forms.Label label5;
    }
}