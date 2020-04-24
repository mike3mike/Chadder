using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace Chadder
{
    public partial class Privileges : Form
    {
        public Privileges()
        {
            InitializeComponent();
            valuesToList();
        }

        public void valuesToList()
        {
            checkBox3.Checked = true;
            opslaan2();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
        }

        public List<string> getList
        {
            get { return List1; }
        }

        private void opslaan2()
        {
            foreach (CheckBox control in panel1.Controls)
            {
                CheckBox checkbox = ((CheckBox)control);
                if (checkbox.Checked)
                {
                    //count++;
                    List1.Add(checkbox.Name.ToString());
                }
            }

            string myConnectionString = "server=192.168.2.156;uid=newuser;" +
    "pwd=test;database=chadder";
            var conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            MySqlCommand cmd;
            foreach (string naam in List1)
            {
                cmd = new MySqlCommand($"INSERT INTO privileges(naam)VALUE('{naam}')", conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        List<string> List1 = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            opslaan2();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
