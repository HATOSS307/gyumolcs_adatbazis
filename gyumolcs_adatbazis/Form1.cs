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

namespace gyumolcs_adatbazis
{
    public partial class Form1 : Form
    {
        MySqlConnection connect = null;
        MySqlCommand cmd = null;
      

        public Form1()
        {
            InitializeComponent();
        }

        private void data_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1_nev.Text))
            {
                MessageBox.Show("Adja meg a nevet");
                textBox1_nev.Focus();
                return;
            }
            if (numericUpDown1_egysegar.Value < 0 )
            {
                MessageBox.Show("Érvénytelen egységár!");             
                numericUpDown1_mennyiseg.Focus();
                return;
            }
            if (numericUpDown1_mennyiseg.Value < 0)
            {
                MessageBox.Show("Érvénytelen mennyiésg");
                numericUpDown1_mennyiseg.Focus();
                return;
            }
            cmd.CommandText = "INSERT INTO `gyümölcsök` (`id`, `nev`, `egysegar`, `mennyiseg`) VALUES (NULL, @nev, @egysegar, @mennyiseg);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nev", textBox1_nev.Text);
            cmd.Parameters.AddWithValue("@egysegar", numericUpDown1_egysegar.Text);
            cmd.Parameters.AddWithValue("@mennyiseg", numericUpDown1_mennyiseg.Text);
            connect.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeres adat rögzítés");
                    textBox1_id.Text = "";
                    textBox1_nev.Text = "";
                    numericUpDown1_mennyiseg.Value = numericUpDown1_mennyiseg.Minimum;
                    numericUpDown1_egysegar.Value = numericUpDown1_egysegar.Minimum;

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            connect.Close();
            gyumolcs_list_update();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "gyumolcsok";
            connect = new MySqlConnection(builder.ConnectionString);
            try
            {
                //terv szerint
                connect.Open();
                cmd = connect.CreateCommand();
            }
            catch (MySqlException ex)
            {
                //terv megbukott
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leált");
                Environment.Exit(0);
            }
            finally
            {
                connect.Close();
            }
            gyumolcs_list_update();
        }

        private void gyumolcs_list_update()
        {
            list_adatok.Items.Clear();
            cmd.CommandText = "SELECT `id`, `nev`,`egysegar`,`mennyiseg` FROM `gyümölcsök`";
            connect.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    gyumolcs uj = new gyumolcs(dr.GetInt32("Id"), dr.GetString("nev"), dr.GetDouble("egysegar"), dr.GetDouble("mennyiseg"));
                    list_adatok.Items.Add(uj);
                }
            }
            connect.Close();
        }

        private void listBox1_Autok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_adatok.SelectedIndex < 0)
            {
                return;
            }
            gyumolcs kivalasztott_gyumolcs = (gyumolcs)list_adatok.SelectedItem;
            textBox1_id.Text = kivalasztott_gyumolcs.Id.ToString();
            textBox1_nev.Text = kivalasztott_gyumolcs.Nev.ToString();
            numericUpDown1_egysegar.Value = Convert.ToDecimal(kivalasztott_gyumolcs.Egysegar);
            numericUpDown1_mennyiseg.Value = Convert.ToDecimal(kivalasztott_gyumolcs.Mennyiseg);
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (list_adatok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kijelölve gyümölcs!");
                return;
            }
            gyumolcs kivalasztott_gyumolcs = (gyumolcs)list_adatok.SelectedItem;
            cmd.CommandText = "UPDATE `gyümölcsök` SET nev = @nev, egysegar = @egysegar , mennyiseg = @mennyiseg  WHERE id = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBox1_id.Text);
            cmd.Parameters.AddWithValue("@nev", textBox1_nev.Text);
            cmd.Parameters.AddWithValue("@egysegar", numericUpDown1_egysegar.Value);
            cmd.Parameters.AddWithValue("@mennyiseg", numericUpDown1_egysegar.Value);
            connect.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Módosítás sikeres");
                connect.Close();
                textBox1_id.Text = "";
                textBox1_nev.Text = "";
                numericUpDown1_egysegar.Value = numericUpDown1_egysegar.Minimum;
                numericUpDown1_mennyiseg.Value = numericUpDown1_mennyiseg.Minimum;
                gyumolcs_list_update();
            }
            else
            {
                MessageBox.Show("Az adatok Módosítása sikertelen!");

            }
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (list_adatok.SelectedIndex < 0)
            {
                return;
            }
            cmd.CommandText = "DELETE FROM autok WHERE id = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBox1_id.Text);
            connect.Open();
            connect.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("A törlés sikeres!");
                connect.Close();
                textBox1_id.Text = "";
                textBox1_nev.Text = "";
                numericUpDown1_egysegar.Value = numericUpDown1_egysegar.Minimum;
                numericUpDown1_mennyiseg.Value = numericUpDown1_mennyiseg.Minimum;
                gyumolcs_list_update();
            }
            else
            {
                MessageBox.Show("A törlés sikertelen!");
            }
        }
    }
}
