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
    
    public partial class Form3 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form3(int userid)
        {
            InitializeComponent();
            lbl_userid.Text = userid.ToString();
            
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\AB\source\repos\Re Track App\Re Track\ReTrackDB.accdb;Persist Security Info=False;";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Contacts";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    if (int.Parse(lbl_userid.Text) == (int)reader["RegistrationID"])
                    {
                        comboBox1.Items.Add(reader["ContactName"].ToString());
                    }
                }

             
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_saveContact_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "insert into Contacts (ContactName, RelationToUser, ContactBirthday, ContactHobbies, ContactOccupation, ContactEmail, FathersName, MothersName, ContactAddress, AdditionalContactDetails, RegistrationID) values ('" + txt_contactName.Text +"','"+ txt_relationToUser.Text +"','"+ dtp_contactDOB.Text +"','"+txt_contactHobbies.Text +"','"+ txt_contactOccupation.Text +"','"+ txt_contactEmail.Text +"','"+txt_contactsFathersName.Text +"','"+ txt_contactsMothersName.Text +"','"+ txt_contactAddress.Text +"','"+ txt_contactAdditonalDetails.Text +"', '"+lbl_userid.Text+"' )";
                command.ExecuteNonQuery();

                MessageBox.Show("Contact Saved");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btn_editContact_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Contacts set ContactName = '"+ txt_contactName.Text +"', RelationToUser = '"+ txt_relationToUser.Text +"', ContactBirthday = '"+ dtp_contactDOB.Text +"', ContactHobbies = '"+ txt_contactHobbies.Text +"', ContactOccupation = '"+ txt_contactOccupation.Text +"', ContactEmail = '"+ txt_contactEmail.Text +"', FathersName = '"+ txt_contactsFathersName.Text +"', MothersName ='"+ txt_contactsMothersName.Text +"', ContactAddress = '"+ txt_contactAddress.Text +"', AdditionalContactDetails = '"+ txt_contactAdditonalDetails.Text +"' where ContactID ="+ lbl_contactID.Text + "";
                MessageBox.Show(query);
                command.CommandText = query;
                command.ExecuteNonQuery();

                MessageBox.Show("Contact Updated");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void btn_deleteContact_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "delete from Contacts where ContactID = "+ lbl_contactID.Text +"";
                command.ExecuteNonQuery();

                MessageBox.Show("Contact Deleted");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Contacts where ContactName = '"+ comboBox1.Text + "'";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (int.Parse(lbl_userid.Text) == (int)reader["RegistrationID"])
                    {
                        txt_contactName.Text = reader["ContactName"].ToString();
                        txt_contactAddress.Text = reader["ContactAddress"].ToString();
                        dtp_contactDOB.Text = reader["ContactBirthday"].ToString();
                        txt_contactsMothersName.Text = reader["MothersName"].ToString();
                        txt_contactsFathersName.Text = reader["FathersName"].ToString();
                        txt_relationToUser.Text = reader["RelationToUser"].ToString();
                        txt_contactOccupation.Text = reader["ContactOccupation"].ToString();
                        txt_contactAdditonalDetails.Text = reader["AdditionalContactDetails"].ToString();
                        txt_contactHobbies.Text = reader["ContactHobbies"].ToString();
                        txt_contactEmail.Text = reader["ContactEmail"].ToString();
                        lbl_contactID.Text = reader["ContactID"].ToString();
                    }
                }


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void txt_relationToUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_contactOccupation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_login f4 = new Form_login();
            f4.ShowDialog();
        }
    }
}
