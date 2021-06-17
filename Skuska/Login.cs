using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Skuska
{

    public partial class Login : Form
    {
        public static string aktivny_uzivatel;

        public Login()
        {
            InitializeComponent();           
        }

        private void Prihlasovanie_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1I7N9P7\SQLEXPRESS;Initial Catalog=DenneCentrumDB;Integrated Security=True");
            connection.Open();
     
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT COUNT(*) FROM OSOBA WHERE LOGIN_MENO = '"+ txMeno.Text +"' AND LOGIN_HESLO= '"+ txHeslo.Text +"'",connection);
            SqlDataAdapter aktivy_uzivatel_adapter = new SqlDataAdapter("SELECT MENO,PRIEZVISKO FROM OSOBA WHERE LOGIN_MENO = '" + txMeno.Text + "' AND LOGIN_HESLO= '" + txHeslo.Text + "'", connection);

            DataTable db_table = new DataTable();
            DataTable aktivny_uzivatel_db_table = new DataTable();

            adapter.Fill(db_table);
            aktivy_uzivatel_adapter.Fill(aktivny_uzivatel_db_table);

            if (db_table.Rows[0][0].ToString() == "1")
            {
                aktivny_uzivatel = aktivny_uzivatel_db_table.Rows[0][0].ToString() + " " + aktivny_uzivatel_db_table.Rows[0][1].ToString();

                this.Hide();
                HlavneMenu hlavne_menu = new HlavneMenu();
                hlavne_menu.Show();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Nesprávne meno alebo heslo", "Chyba!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txMeno.Text = "";
                txHeslo.Text = "";
                this.ActiveControl = txMeno;
            }
        }

        private void txMeno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btLogin_Click(sender, e);
        }

        private void txHeslo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btLogin_Click(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
