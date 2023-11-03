
namespace Re_Track
{
    partial class Form_login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_loginUserID = new System.Windows.Forms.TextBox();
            this.txt_loginPassword = new System.Windows.Forms.TextBox();
            this.label_userid = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.btn_createAcc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_checkConnection = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(4, 187);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(304, 43);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // txt_loginUserID
            // 
            this.txt_loginUserID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loginUserID.Location = new System.Drawing.Point(5, 72);
            this.txt_loginUserID.Name = "txt_loginUserID";
            this.txt_loginUserID.Size = new System.Drawing.Size(303, 28);
            this.txt_loginUserID.TabIndex = 1;
            this.txt_loginUserID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_loginPassword
            // 
            this.txt_loginPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loginPassword.Location = new System.Drawing.Point(5, 125);
            this.txt_loginPassword.Name = "txt_loginPassword";
            this.txt_loginPassword.PasswordChar = '-';
            this.txt_loginPassword.Size = new System.Drawing.Size(304, 28);
            this.txt_loginPassword.TabIndex = 2;
            this.txt_loginPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_userid
            // 
            this.label_userid.AutoSize = true;
            this.label_userid.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userid.Location = new System.Drawing.Point(2, 55);
            this.label_userid.Name = "label_userid";
            this.label_userid.Size = new System.Drawing.Size(44, 14);
            this.label_userid.TabIndex = 3;
            this.label_userid.Text = "User ID";
            this.label_userid.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(2, 109);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(56, 14);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Password";
            this.label_password.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_createAcc
            // 
            this.btn_createAcc.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createAcc.Location = new System.Drawing.Point(4, 271);
            this.btn_createAcc.Name = "btn_createAcc";
            this.btn_createAcc.Size = new System.Drawing.Size(304, 40);
            this.btn_createAcc.TabIndex = 5;
            this.btn_createAcc.Text = "Create Account";
            this.btn_createAcc.UseVisualStyleBackColor = true;
            this.btn_createAcc.Click += new System.EventHandler(this.button_createAcc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "OR";
            // 
            // label_checkConnection
            // 
            this.label_checkConnection.AutoSize = true;
            this.label_checkConnection.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkConnection.Location = new System.Drawing.Point(189, 47);
            this.label_checkConnection.Name = "label_checkConnection";
            this.label_checkConnection.Size = new System.Drawing.Size(75, 16);
            this.label_checkConnection.TabIndex = 8;
            this.label_checkConnection.Text = "connection ";
            this.label_checkConnection.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_checkConnection);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_createAcc);
            this.groupBox1.Controls.Add(this.label_password);
            this.groupBox1.Controls.Add(this.label_userid);
            this.groupBox1.Controls.Add(this.txt_loginPassword);
            this.groupBox1.Controls.Add(this.txt_loginUserID);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 356);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 378);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_login";
            this.Text = "Re Track Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_loginUserID;
        private System.Windows.Forms.TextBox txt_loginPassword;
        private System.Windows.Forms.Label label_userid;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button btn_createAcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_checkConnection;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

