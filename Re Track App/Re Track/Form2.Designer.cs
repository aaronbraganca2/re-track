
namespace Re_Track
{
    partial class Form_CreateAcc
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
            this.txt_newUserEmail = new System.Windows.Forms.TextBox();
            this.txt_newUserID = new System.Windows.Forms.TextBox();
            this.txt_NewUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_newUserPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_newUserDOB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_newUserEmail
            // 
            this.txt_newUserEmail.Location = new System.Drawing.Point(31, 124);
            this.txt_newUserEmail.Name = "txt_newUserEmail";
            this.txt_newUserEmail.Size = new System.Drawing.Size(201, 20);
            this.txt_newUserEmail.TabIndex = 1;
            this.txt_newUserEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_newUserID
            // 
            this.txt_newUserID.Location = new System.Drawing.Point(31, 177);
            this.txt_newUserID.Name = "txt_newUserID";
            this.txt_newUserID.Size = new System.Drawing.Size(201, 20);
            this.txt_newUserID.TabIndex = 2;
            // 
            // txt_NewUserName
            // 
            this.txt_NewUserName.Location = new System.Drawing.Point(31, 74);
            this.txt_NewUserName.Name = "txt_NewUserName";
            this.txt_NewUserName.Size = new System.Drawing.Size(201, 20);
            this.txt_NewUserName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "User ID";
            // 
            // txt_newUserPassword
            // 
            this.txt_newUserPassword.Location = new System.Drawing.Point(31, 227);
            this.txt_newUserPassword.Name = "txt_newUserPassword";
            this.txt_newUserPassword.Size = new System.Drawing.Size(201, 20);
            this.txt_newUserPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // dtp_newUserDOB
            // 
            this.dtp_newUserDOB.Location = new System.Drawing.Point(32, 277);
            this.dtp_newUserDOB.Name = "dtp_newUserDOB";
            this.dtp_newUserDOB.Size = new System.Drawing.Size(200, 20);
            this.dtp_newUserDOB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date of Birth";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(32, 327);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(200, 53);
            this.btn_confirm.TabIndex = 15;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 27);
            this.label6.TabIndex = 16;
            this.label6.Text = "Register";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // Form_CreateAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 411);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_newUserDOB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_newUserPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NewUserName);
            this.Controls.Add(this.txt_newUserID);
            this.Controls.Add(this.txt_newUserEmail);
            this.Name = "Form_CreateAcc";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.Form_CreateAcc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_newUserEmail;
        private System.Windows.Forms.TextBox txt_newUserID;
        private System.Windows.Forms.TextBox txt_NewUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_newUserPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_newUserDOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label6;
    }
}