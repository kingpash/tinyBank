namespace Bautista_HW_2_Tiny_Bank
{
    partial class tinyBankForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.captionLabel = new System.Windows.Forms.Label();
            this.managerLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.activityLabel = new System.Windows.Forms.Label();
            this.accountBox = new System.Windows.Forms.GroupBox();
            this.sEnd = new System.Windows.Forms.Label();
            this.cEnd = new System.Windows.Forms.Label();
            this.savingsOutTextBox = new System.Windows.Forms.TextBox();
            this.savingsInTextBox = new System.Windows.Forms.TextBox();
            this.savingsStartTextBox = new System.Windows.Forms.TextBox();
            this.checkingOutTextBox = new System.Windows.Forms.TextBox();
            this.checkingInTextBox = new System.Windows.Forms.TextBox();
            this.checkingStartTextBox = new System.Windows.Forms.TextBox();
            this.endingLabel = new System.Windows.Forms.Label();
            this.withdrawalsLabel = new System.Windows.Forms.Label();
            this.depositsLabel = new System.Windows.Forms.Label();
            this.beginningLabel = new System.Windows.Forms.Label();
            this.savingsLabel = new System.Windows.Forms.Label();
            this.checkingLabel = new System.Windows.Forms.Label();
            this.summaryBox = new System.Windows.Forms.GroupBox();
            this.accountEndLabel = new System.Windows.Forms.Label();
            this.accountGainLabel = new System.Windows.Forms.Label();
            this.accountTotalLabel = new System.Windows.Forms.Label();
            this.gainLabel = new System.Windows.Forms.Label();
            this.totalELabel = new System.Windows.Forms.Label();
            this.totalBLabel = new System.Windows.Forms.Label();
            this.balanceButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.activityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accountBox.SuspendLayout();
            this.summaryBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Orator Std", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(231, -3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(289, 64);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "TINY BANK";
            // 
            // captionLabel
            // 
            this.captionLabel.AutoSize = true;
            this.captionLabel.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionLabel.Location = new System.Drawing.Point(208, 207);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(312, 30);
            this.captionLabel.TabIndex = 1;
            this.captionLabel.Text = "We\'re Small But Safe";
            // 
            // managerLabel
            // 
            this.managerLabel.AutoSize = true;
            this.managerLabel.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerLabel.Location = new System.Drawing.Point(238, 250);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(250, 21);
            this.managerLabel.TabIndex = 2;
            this.managerLabel.Text = "PERSONAL ACCOUNT MANAGER";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(102, 304);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 21);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLabel.Location = new System.Drawing.Point(22, 336);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(140, 21);
            this.activityLabel.TabIndex = 5;
            this.activityLabel.Text = "Activity for:";
            // 
            // accountBox
            // 
            this.accountBox.Controls.Add(this.sEnd);
            this.accountBox.Controls.Add(this.cEnd);
            this.accountBox.Controls.Add(this.savingsOutTextBox);
            this.accountBox.Controls.Add(this.savingsInTextBox);
            this.accountBox.Controls.Add(this.savingsStartTextBox);
            this.accountBox.Controls.Add(this.checkingOutTextBox);
            this.accountBox.Controls.Add(this.checkingInTextBox);
            this.accountBox.Controls.Add(this.checkingStartTextBox);
            this.accountBox.Controls.Add(this.endingLabel);
            this.accountBox.Controls.Add(this.withdrawalsLabel);
            this.accountBox.Controls.Add(this.depositsLabel);
            this.accountBox.Controls.Add(this.beginningLabel);
            this.accountBox.Controls.Add(this.savingsLabel);
            this.accountBox.Controls.Add(this.checkingLabel);
            this.accountBox.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountBox.Location = new System.Drawing.Point(46, 408);
            this.accountBox.Name = "accountBox";
            this.accountBox.Size = new System.Drawing.Size(606, 158);
            this.accountBox.TabIndex = 5;
            this.accountBox.TabStop = false;
            this.accountBox.Text = "Account Information";
            // 
            // sEnd
            // 
            this.sEnd.AutoSize = true;
            this.sEnd.Location = new System.Drawing.Point(506, 123);
            this.sEnd.Name = "sEnd";
            this.sEnd.Size = new System.Drawing.Size(20, 21);
            this.sEnd.TabIndex = 5;
            this.sEnd.Text = "$";
            // 
            // cEnd
            // 
            this.cEnd.AutoSize = true;
            this.cEnd.Location = new System.Drawing.Point(506, 70);
            this.cEnd.Name = "cEnd";
            this.cEnd.Size = new System.Drawing.Size(20, 21);
            this.cEnd.TabIndex = 6;
            this.cEnd.Text = "$";
            // 
            // savingsOutTextBox
            // 
            this.savingsOutTextBox.Location = new System.Drawing.Point(360, 120);
            this.savingsOutTextBox.Name = "savingsOutTextBox";
            this.savingsOutTextBox.Size = new System.Drawing.Size(100, 27);
            this.savingsOutTextBox.TabIndex = 6;
            // 
            // savingsInTextBox
            // 
            this.savingsInTextBox.Location = new System.Drawing.Point(254, 120);
            this.savingsInTextBox.Name = "savingsInTextBox";
            this.savingsInTextBox.Size = new System.Drawing.Size(100, 27);
            this.savingsInTextBox.TabIndex = 5;
            // 
            // savingsStartTextBox
            // 
            this.savingsStartTextBox.Location = new System.Drawing.Point(148, 120);
            this.savingsStartTextBox.Name = "savingsStartTextBox";
            this.savingsStartTextBox.Size = new System.Drawing.Size(100, 27);
            this.savingsStartTextBox.TabIndex = 4;
            // 
            // checkingOutTextBox
            // 
            this.checkingOutTextBox.Location = new System.Drawing.Point(360, 67);
            this.checkingOutTextBox.Name = "checkingOutTextBox";
            this.checkingOutTextBox.Size = new System.Drawing.Size(100, 27);
            this.checkingOutTextBox.TabIndex = 2;
            // 
            // checkingInTextBox
            // 
            this.checkingInTextBox.Location = new System.Drawing.Point(254, 67);
            this.checkingInTextBox.Name = "checkingInTextBox";
            this.checkingInTextBox.Size = new System.Drawing.Size(100, 27);
            this.checkingInTextBox.TabIndex = 1;
            // 
            // checkingStartTextBox
            // 
            this.checkingStartTextBox.Location = new System.Drawing.Point(148, 67);
            this.checkingStartTextBox.Name = "checkingStartTextBox";
            this.checkingStartTextBox.Size = new System.Drawing.Size(100, 27);
            this.checkingStartTextBox.TabIndex = 0;
            // 
            // endingLabel
            // 
            this.endingLabel.AutoSize = true;
            this.endingLabel.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endingLabel.Location = new System.Drawing.Point(481, 19);
            this.endingLabel.Name = "endingLabel";
            this.endingLabel.Size = new System.Drawing.Size(80, 42);
            this.endingLabel.TabIndex = 5;
            this.endingLabel.Text = "Ending\r\nBalance";
            this.endingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // withdrawalsLabel
            // 
            this.withdrawalsLabel.AutoSize = true;
            this.withdrawalsLabel.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawalsLabel.Location = new System.Drawing.Point(354, 33);
            this.withdrawalsLabel.Name = "withdrawalsLabel";
            this.withdrawalsLabel.Size = new System.Drawing.Size(120, 21);
            this.withdrawalsLabel.TabIndex = 4;
            this.withdrawalsLabel.Text = "Withdrawals";
            // 
            // depositsLabel
            // 
            this.depositsLabel.AutoSize = true;
            this.depositsLabel.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositsLabel.Location = new System.Drawing.Point(258, 31);
            this.depositsLabel.Name = "depositsLabel";
            this.depositsLabel.Size = new System.Drawing.Size(90, 21);
            this.depositsLabel.TabIndex = 3;
            this.depositsLabel.Text = "Deposits";
            // 
            // beginningLabel
            // 
            this.beginningLabel.AutoSize = true;
            this.beginningLabel.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginningLabel.Location = new System.Drawing.Point(150, 19);
            this.beginningLabel.Name = "beginningLabel";
            this.beginningLabel.Size = new System.Drawing.Size(100, 42);
            this.beginningLabel.TabIndex = 2;
            this.beginningLabel.Text = "Beginning\r\nBalance";
            this.beginningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // savingsLabel
            // 
            this.savingsLabel.AutoSize = true;
            this.savingsLabel.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsLabel.Location = new System.Drawing.Point(19, 123);
            this.savingsLabel.Name = "savingsLabel";
            this.savingsLabel.Size = new System.Drawing.Size(90, 21);
            this.savingsLabel.TabIndex = 1;
            this.savingsLabel.Text = "Savings:";
            // 
            // checkingLabel
            // 
            this.checkingLabel.AutoSize = true;
            this.checkingLabel.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkingLabel.Location = new System.Drawing.Point(19, 67);
            this.checkingLabel.Name = "checkingLabel";
            this.checkingLabel.Size = new System.Drawing.Size(100, 21);
            this.checkingLabel.TabIndex = 0;
            this.checkingLabel.Text = "Checking:";
            // 
            // summaryBox
            // 
            this.summaryBox.Controls.Add(this.accountEndLabel);
            this.summaryBox.Controls.Add(this.accountGainLabel);
            this.summaryBox.Controls.Add(this.accountTotalLabel);
            this.summaryBox.Controls.Add(this.gainLabel);
            this.summaryBox.Controls.Add(this.totalELabel);
            this.summaryBox.Controls.Add(this.totalBLabel);
            this.summaryBox.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryBox.Location = new System.Drawing.Point(171, 582);
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.Size = new System.Drawing.Size(365, 191);
            this.summaryBox.TabIndex = 7;
            this.summaryBox.TabStop = false;
            this.summaryBox.Text = "Account Summary";
            // 
            // accountEndLabel
            // 
            this.accountEndLabel.AutoSize = true;
            this.accountEndLabel.Location = new System.Drawing.Point(223, 86);
            this.accountEndLabel.Name = "accountEndLabel";
            this.accountEndLabel.Size = new System.Drawing.Size(20, 21);
            this.accountEndLabel.TabIndex = 5;
            this.accountEndLabel.Text = "$";
            // 
            // accountGainLabel
            // 
            this.accountGainLabel.AutoSize = true;
            this.accountGainLabel.Location = new System.Drawing.Point(223, 130);
            this.accountGainLabel.Name = "accountGainLabel";
            this.accountGainLabel.Size = new System.Drawing.Size(20, 21);
            this.accountGainLabel.TabIndex = 4;
            this.accountGainLabel.Text = "$";
            // 
            // accountTotalLabel
            // 
            this.accountTotalLabel.AutoSize = true;
            this.accountTotalLabel.Location = new System.Drawing.Point(223, 47);
            this.accountTotalLabel.Name = "accountTotalLabel";
            this.accountTotalLabel.Size = new System.Drawing.Size(20, 21);
            this.accountTotalLabel.TabIndex = 1;
            this.accountTotalLabel.Text = "$";
            // 
            // gainLabel
            // 
            this.gainLabel.AutoSize = true;
            this.gainLabel.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gainLabel.Location = new System.Drawing.Point(32, 130);
            this.gainLabel.Name = "gainLabel";
            this.gainLabel.Size = new System.Drawing.Size(140, 21);
            this.gainLabel.TabIndex = 2;
            this.gainLabel.Text = "Gain (loss): ";
            // 
            // totalELabel
            // 
            this.totalELabel.AutoSize = true;
            this.totalELabel.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalELabel.Location = new System.Drawing.Point(32, 86);
            this.totalELabel.Name = "totalELabel";
            this.totalELabel.Size = new System.Drawing.Size(110, 21);
            this.totalELabel.TabIndex = 1;
            this.totalELabel.Text = "Total End:";
            // 
            // totalBLabel
            // 
            this.totalBLabel.AutoSize = true;
            this.totalBLabel.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBLabel.Location = new System.Drawing.Point(32, 47);
            this.totalBLabel.Name = "totalBLabel";
            this.totalBLabel.Size = new System.Drawing.Size(170, 21);
            this.totalBLabel.TabIndex = 0;
            this.totalBLabel.Text = "Total Beginning:";
            // 
            // balanceButton
            // 
            this.balanceButton.BackColor = System.Drawing.Color.LightGray;
            this.balanceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.balanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.balanceButton.Font = new System.Drawing.Font("Orator Std", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceButton.Location = new System.Drawing.Point(324, 801);
            this.balanceButton.Name = "balanceButton";
            this.balanceButton.Size = new System.Drawing.Size(131, 23);
            this.balanceButton.TabIndex = 6;
            this.balanceButton.Text = "Show &Balance";
            this.balanceButton.UseVisualStyleBackColor = false;
            this.balanceButton.Click += new System.EventHandler(this.balanceButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.LightGray;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Font = new System.Drawing.Font("Orator Std", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(465, 801);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(71, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightGray;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Orator Std", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(546, 801);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(71, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(171, 304);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(243, 27);
            this.nameTextBox.TabIndex = 3;
            // 
            // activityTextBox
            // 
            this.activityTextBox.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityTextBox.Location = new System.Drawing.Point(171, 337);
            this.activityTextBox.Name = "activityTextBox";
            this.activityTextBox.Size = new System.Drawing.Size(243, 27);
            this.activityTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Month, YYYY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bautista_HW_2_Tiny_Bank.Properties.Resources.bank_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(300, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 131);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tinyBankForm
            // 
            this.AcceptButton = this.balanceButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.resetButton;
            this.ClientSize = new System.Drawing.Size(728, 836);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activityTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.balanceButton);
            this.Controls.Add(this.summaryBox);
            this.Controls.Add(this.accountBox);
            this.Controls.Add(this.activityLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.managerLabel);
            this.Controls.Add(this.captionLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "tinyBankForm";
            this.Text = "tinyBankForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.accountBox.ResumeLayout(false);
            this.accountBox.PerformLayout();
            this.summaryBox.ResumeLayout(false);
            this.summaryBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label captionLabel;
        private System.Windows.Forms.Label managerLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label activityLabel;
        private System.Windows.Forms.GroupBox accountBox;
        private System.Windows.Forms.Label checkingLabel;
        private System.Windows.Forms.Label endingLabel;
        private System.Windows.Forms.Label withdrawalsLabel;
        private System.Windows.Forms.Label depositsLabel;
        private System.Windows.Forms.Label beginningLabel;
        private System.Windows.Forms.Label savingsLabel;
        private System.Windows.Forms.GroupBox summaryBox;
        private System.Windows.Forms.Label sEnd;
        private System.Windows.Forms.Label accountGainLabel;
        private System.Windows.Forms.Label accountTotalLabel;
        private System.Windows.Forms.Label gainLabel;
        private System.Windows.Forms.Label totalELabel;
        private System.Windows.Forms.Label totalBLabel;
        private System.Windows.Forms.Button balanceButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox activityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox savingsOutTextBox;
        private System.Windows.Forms.TextBox savingsInTextBox;
        private System.Windows.Forms.TextBox savingsStartTextBox;
        private System.Windows.Forms.TextBox checkingOutTextBox;
        private System.Windows.Forms.TextBox checkingInTextBox;
        private System.Windows.Forms.TextBox checkingStartTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label cEnd;
        private System.Windows.Forms.Label accountEndLabel;
    }
}

