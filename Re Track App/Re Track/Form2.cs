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
    public partial class Form_CreateAcc : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form_CreateAcc()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\AB\source\repos\Re Track App\Re Track\ReTrackDB.accdb;Persist Security Info=False;";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void Form_CreateAcc_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            connection.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;

            command.CommandText = "select * from Users where UserEmail = '" + txt_newUserEmail.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            reader.Close();
            
            
            command.CommandText = "select * from Users where UserID = '" + txt_newUserID.Text + "'";
            OleDbDataReader reader2 = command.ExecuteReader();
            int count2 = 0;
            while(reader2.Read())
            {
                count2 = count2 + 1;
            }
            reader2.Close();

            if(count == 0 && count2 == 0)
            {
                

                try
                {
                                      
                    command.CommandText = "insert into Users (UserName, UserEmail, UserID, UserPassword, UserDOB) values ('" + txt_NewUserName.Text +"', '" + txt_newUserEmail.Text +"', '" + txt_newUserID.Text +"', '" + txt_newUserPassword.Text +"', '" + dtp_newUserDOB.Text +"')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registration successful. Proceed to Login.");

                    this.Hide();
                    Form_login login1 = new Form_login();
                    login1.ShowDialog();
                    
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error  " + ex);
                }
                
                

            }
            if(count > 0)
            {
                MessageBox.Show("Email is already registered.");

            }
            if(count2 > 0)
            {
                MessageBox.Show("UserID unavailable");
            }



            
            connection.Close();
            
        }
    }
}
