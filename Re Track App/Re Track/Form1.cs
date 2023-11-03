using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Re_Track
{
    public partial class Form_login : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form_login()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\AB\source\repos\Re Track App\Re Track\ReTrackDB.accdb;Persist Security Info=False;";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_createAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_CreateAcc newAcc = new Form_CreateAcc();
            newAcc.ShowDialog();
            
            



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                label_checkConnection.Text = "Connection Successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
          
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            int userid = 0;
            connection.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            
            command.CommandText = "select * from Users where UserID = '" + txt_loginUserID.Text + "' and UserPassword = '" + txt_loginPassword.Text + "'";

            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
                if(count == 1)
                {
                    userid = (int)reader["RegistrationID"];               
                  
                  
                }
                    
            }
            if (count == 1)
            {
                MessageBox.Show("Login successful.");
                
                connection.Close();
                connection.Dispose();
                this.Hide();
               
                Form3 f3 = new Form3(userid);
                f3.ShowDialog(); 
            }
            else if (count > 1)
            {
                MessageBox.Show("Username and Password is correct. Duplicate UserID and Password detected");
            }
            else
            {
                MessageBox.Show("Incorrect UserID and Password.");
            }
            
            

            connection.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
