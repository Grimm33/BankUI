namespace BankUI
{
    partial class AddAccount
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
            this.tbClientID = new System.Windows.Forms.TextBox();
            this.tbAccAmt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.comboBoxChooseAccType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbClientID
            // 
            this.tbClientID.Location = new System.Drawing.Point(162, 39);
            this.tbClientID.Name = "tbClientID";
            this.tbClientID.Size = new System.Drawing.Size(134, 20);
            this.tbClientID.TabIndex = 0;
            // 
            // tbAccAmt
            // 
            this.tbAccAmt.Location = new System.Drawing.Point(162, 83);
            this.tbAccAmt.Name = "tbAccAmt";
            this.tbAccAmt.Size = new System.Drawing.Size(134, 20);
            this.tbAccAmt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client ID Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount of Money in Account";
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.Location = new System.Drawing.Point(95, 191);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(102, 23);
            this.btnAddAcc.TabIndex = 3;
            this.btnAddAcc.Text = "Add Account";
            this.btnAddAcc.UseVisualStyleBackColor = true;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // comboBoxChooseAccType
            // 
            this.comboBoxChooseAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseAccType.FormattingEnabled = true;
            this.comboBoxChooseAccType.Items.AddRange(new object[] {
            "Checking Account",
            "Savings Account"});
            this.comboBoxChooseAccType.Location = new System.Drawing.Point(162, 128);
            this.comboBoxChooseAccType.Name = "comboBoxChooseAccType";
            this.comboBoxChooseAccType.Size = new System.Drawing.Size(134, 21);
            this.comboBoxChooseAccType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Account Type";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 251);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxChooseAccType);
            this.Controls.Add(this.btnAddAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAccAmt);
            this.Controls.Add(this.tbClientID);
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addAccount";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addAccount_FormClosed);
            this.Load += new System.EventHandler(this.AddAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbClientID;
        private System.Windows.Forms.TextBox tbAccAmt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.ComboBox comboBoxChooseAccType;
        private System.Windows.Forms.Label label3;
    }
}