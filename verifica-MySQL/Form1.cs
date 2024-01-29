using MySql.Data.MySqlClient;
namespace verifica_MySQL
{
    public partial class Form1 : Form
    {
        string ConnectionString = "server=127.0.0.1;" +
                                    "database=catalogo;" +
                                    "uid=root;";
        public Form1()
        {
            InitializeComponent();
            PololaTabella();
        }

        public void PololaTabella()
        {
            dataGridView1.Rows.Clear();
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
                connessione.Open();
                string query = "SELECT * FROM componenti";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    dataGridView1.Rows.Add(
                        dr.GetString("CodFarnell"),
                        dr.GetString("Codproduttore"),
                        dr.GetInt32("Quantita"),
                        dr.GetDecimal("PrezzoUnitario"),
                        dr.GetInt32("ID").ToString()
                        );

                }
                connessione.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            FormModifica formModifica = new FormModifica(ID);

            formModifica.ShowDialog();

            //PololaTabella(" ");
            
            

        }
    }
}