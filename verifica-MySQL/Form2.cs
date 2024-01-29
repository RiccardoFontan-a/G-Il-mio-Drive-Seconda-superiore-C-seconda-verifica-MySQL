using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verifica_MySQL
{
    public partial class FormModifica : Form
    {
        public string ID_componenti;
        public FormModifica(string ID)
        {
            InitializeComponent();
            ID_componenti= ID;
            PopolaForm();
        }

        public void PopolaForm()
        {
            string ConnectionString = "server=127.0.0.1;" +
                                    "database=catalogo;" +
                                    "uid=root;";
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            
            
            try
            {
                connessione.Open();
                string query = $"SELECT * FROM componenti WHERE ID = '{ID_componenti.Trim()}' ";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                MySqlDataReader dr = cmd.ExecuteReader();
           
                dr.Read();
                textBoxFarnell.Text = dr.GetString("CodFarnell");
                textBoxDescrizione.Text = dr.GetString("Descrizione");
                textBoxProduttore.Text = dr.GetString("Produttore");
                textBoxCodProd.Text = dr.GetString("CodProduttore");
                textBoxQuantita.Text = dr.GetInt32("Quantita").ToString();
                textBoxPrezzo.Text = dr.GetDecimal("PrezzoUnitario").ToString();

                dr.Close();

                connessione.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }



        private void FormModifica_Load(object sender, EventArgs e)
        {

        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
           
            string ConnectionString = "server=127.0.0.1;" +
                                    "database=catalogo;" +
                                    "uid=root;";
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
                connessione.Open();

                


                string query = $"UPDATE componenti " +
                    $"SET " +
                    $"CodFarnell = '{textBoxFarnell.Text}', " +
                    $"Descrizione = '{textBoxDescrizione.Text}', " +
                    $"Produttore = '{textBoxProduttore.Text}', " +
                    $"CodProduttore = '{textBoxCodProd.Text}', " +
                    $"Quantita = '{textBoxQuantita.Text}', " +
                    $"PrezzoUnitario = '{textBoxPrezzo.Text}', " +
                    $"WHERE ID = {ID_componenti}";


                MySqlCommand cmd = new MySqlCommand(query, connessione);
                cmd.ExecuteNonQuery();

                connessione.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();


        }
    }
}
