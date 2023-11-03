
namespace Re_Track
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_contactName = new System.Windows.Forms.TextBox();
            this.txt_relationToUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_contactOccupation = new System.Windows.Forms.TextBox();
            this.txt_contactHobbies = new System.Windows.Forms.TextBox();
            this.txt_contactAddress = new System.Windows.Forms.TextBox();
            this.txt_contactAdditonalDetails = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_contactsFathersName = new System.Windows.Forms.TextBox();
            this.txt_contactsMothersName = new System.Windows.Forms.TextBox();
            this.txt_contactEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_saveContact = new System.Windows.Forms.Button();
            this.dtp_contactDOB = new System.Windows.Forms.DateTimePicker();
            this.reTrackDBDataSet = new Re_Track.ReTrackDBDataSet();
            this.btn_editContact = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_deleteContact = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_userid = new System.Windows.Forms.Label();
            this.lbl_contactID = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reTrackDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Relation to User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Birth";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_contactName
            // 
            this.txt_contactName.Location = new System.Drawing.Point(15, 25);
            this.txt_contactName.Name = "txt_contactName";
            this.txt_contactName.Size = new System.Drawing.Size(145, 20);
            this.txt_contactName.TabIndex = 3;
            // 
            // txt_relationToUser
            // 
            this.txt_relationToUser.Location = new System.Drawing.Point(15, 64);
            this.txt_relationToUser.Name = "txt_relationToUser";
            this.txt_relationToUser.Size = new System.Drawing.Size(145, 20);
            this.txt_relationToUser.TabIndex = 5;
            this.txt_relationToUser.TextChanged += new System.EventHandler(this.txt_relationToUser_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hobbies";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Occupation";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_contactOccupation
            // 
            this.txt_contactOccupation.Location = new System.Drawing.Point(15, 181);
            this.txt_contactOccupation.Name = "txt_contactOccupation";
            this.txt_contactOccupation.Size = new System.Drawing.Size(145, 20);
            this.txt_contactOccupation.TabIndex = 16;
            this.txt_contactOccupation.TextChanged += new System.EventHandler(this.txt_contactOccupation_TextChanged);
            // 
            // txt_contactHobbies
            // 
            this.txt_contactHobbies.Location = new System.Drawing.Point(15, 142);
            this.txt_contactHobbies.Name = "txt_contactHobbies";
            this.txt_contactHobbies.Size = new System.Drawing.Size(145, 20);
            this.txt_contactHobbies.TabIndex = 17;
            // 
            // txt_contactAddress
            // 
            this.txt_contactAddress.Location = new System.Drawing.Point(15, 337);
            this.txt_contactAddress.Name = "txt_contactAddress";
            this.txt_contactAddress.Size = new System.Drawing.Size(145, 20);
            this.txt_contactAddress.TabIndex = 27;
            // 
            // txt_contactAdditonalDetails
            // 
            this.txt_contactAdditonalDetails.Location = new System.Drawing.Point(15, 376);
            this.txt_contactAdditonalDetails.Name = "txt_contactAdditonalDetails";
            this.txt_contactAdditonalDetails.Size = new System.Drawing.Size(145, 20);
            this.txt_contactAdditonalDetails.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Additional Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Address";
            // 
            // txt_contactsFathersName
            // 
            this.txt_contactsFathersName.Location = new System.Drawing.Point(15, 259);
            this.txt_contactsFathersName.Name = "txt_contactsFathersName";
            this.txt_contactsFathersName.Size = new System.Drawing.Size(145, 20);
            this.txt_contactsFathersName.TabIndex = 23;
            // 
            // txt_contactsMothersName
            // 
            this.txt_contactsMothersName.Location = new System.Drawing.Point(15, 298);
            this.txt_contactsMothersName.Name = "txt_contactsMothersName";
            this.txt_contactsMothersName.Size = new System.Drawing.Size(145, 20);
            this.txt_contactsMothersName.TabIndex = 22;
            // 
            // txt_contactEmail
            // 
            this.txt_contactEmail.Location = new System.Drawing.Point(15, 220);
            this.txt_contactEmail.Name = "txt_contactEmail";
            this.txt_contactEmail.Size = new System.Drawing.Size(145, 20);
            this.txt_contactEmail.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mother\'s Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Father\'s Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "E-mail";
            // 
            // btn_saveContact
            // 
            this.btn_saveContact.Location = new System.Drawing.Point(15, 402);
            this.btn_saveContact.Name = "btn_saveContact";
            this.btn_saveContact.Size = new System.Drawing.Size(69, 22);
            this.btn_saveContact.TabIndex = 28;
            this.btn_saveContact.Text = "Save";
            this.btn_saveContact.UseVisualStyleBackColor = true;
            this.btn_saveContact.Click += new System.EventHandler(this.btn_saveContact_Click);
            // 
            // dtp_contactDOB
            // 
            this.dtp_contactDOB.Location = new System.Drawing.Point(15, 104);
            this.dtp_contactDOB.Name = "dtp_contactDOB";
            this.dtp_contactDOB.Size = new System.Drawing.Size(145, 20);
            this.dtp_contactDOB.TabIndex = 29;
            // 
            // reTrackDBDataSet
            // 
            this.reTrackDBDataSet.DataSetName = "ReTrackDBDataSet";
            this.reTrackDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_editContact
            // 
            this.btn_editContact.Location = new System.Drawing.Point(15, 456);
            this.btn_editContact.Name = "btn_editContact";
            this.btn_editContact.Size = new System.Drawing.Size(76, 26);
            this.btn_editContact.TabIndex = 30;
            this.btn_editContact.Text = "Edit Contact";
            this.btn_editContact.UseVisualStyleBackColor = true;
            this.btn_editContact.Click += new System.EventHandler(this.btn_editContact_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 440);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Contact ID";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btn_deleteContact
            // 
            this.btn_deleteContact.Location = new System.Drawing.Point(97, 456);
            this.btn_deleteContact.Name = "btn_deleteContact";
            this.btn_deleteContact.Size = new System.Drawing.Size(63, 26);
            this.btn_deleteContact.TabIndex = 33;
            this.btn_deleteContact.Text = "Delete";
            this.btn_deleteContact.UseVisualStyleBackColor = true;
            this.btn_deleteContact.Click += new System.EventHandler(this.btn_deleteContact_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(195, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(192, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "User Registration ID";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lbl_userid
            // 
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.Location = new System.Drawing.Point(300, 25);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(0, 13);
            this.lbl_userid.TabIndex = 36;
            // 
            // lbl_contactID
            // 
            this.lbl_contactID.AutoSize = true;
            this.lbl_contactID.Location = new System.Drawing.Point(80, 440);
            this.lbl_contactID.Name = "lbl_contactID";
            this.lbl_contactID.Size = new System.Drawing.Size(0, 13);
            this.lbl_contactID.TabIndex = 37;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(15, 488);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(145, 31);
            this.btn_logout.TabIndex = 39;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 546);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_contactID);
            this.Controls.Add(this.lbl_userid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_deleteContact);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_editContact);
            this.Controls.Add(this.dtp_contactDOB);
            this.Controls.Add(this.btn_saveContact);
            this.Controls.Add(this.txt_contactAddress);
            this.Controls.Add(this.txt_contactAdditonalDetails);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_contactsFathersName);
            this.Controls.Add(this.txt_contactsMothersName);
            this.Controls.Add(this.txt_contactEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_contactHobbies);
            this.Controls.Add(this.txt_contactOccupation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_relationToUser);
            this.Controls.Add(this.txt_contactName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reTrackDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_contactName;
        private System.Windows.Forms.TextBox txt_relationToUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_contactOccupation;
        private System.Windows.Forms.TextBox txt_contactHobbies;
        private System.Windows.Forms.TextBox txt_contactAddress;
        private System.Windows.Forms.TextBox txt_contactAdditonalDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_contactsFathersName;
        private System.Windows.Forms.TextBox txt_contactsMothersName;
        private System.Windows.Forms.TextBox txt_contactEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_saveContact;
        private System.Windows.Forms.DateTimePicker dtp_contactDOB;
        private ReTrackDBDataSet reTrackDBDataSet;
        private System.Windows.Forms.Button btn_editContact;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_deleteContact;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_userid;
        private System.Windows.Forms.Label lbl_contactID;
        private System.Windows.Forms.Button btn_logout;
    }
}