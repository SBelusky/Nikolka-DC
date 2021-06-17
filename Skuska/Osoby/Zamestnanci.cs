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
    public partial class Zamestnanci : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1I7N9P7\SQLEXPRESS;Initial Catalog=DenneCentrumDB;Integrated Security=True");
        SqlDataAdapter adapter, ID_adapter;
        SqlCommand cmd;
        DataSet tabulky = new DataSet();
        bool edit = false;

        public Zamestnanci()
        {
            InitializeComponent();
        }

        public void Povinne_Udaje()
        {
            txMeno.BackColor = Color.Gold;
            txPriezvisko.BackColor = Color.Gold;
        }

        public void Lave_Buttony(int i)
        {
            txMeno.ReadOnly = false;
            txPriezvisko.ReadOnly = false;
            txTelefon.ReadOnly = false;
            txEmail.ReadOnly = false;
            txUlica.ReadOnly = false;
            txMesto.ReadOnly = false;

            if (i == 0)
            {
                txMeno.Text = "";
                txPriezvisko.Text = "";
                txTelefon.Text = "";
                txEmail.Text = "";
                txUlica.Text = "";
                txMesto.Text = "";
            }

            btPridat.Enabled = false;
            btZmazat.Enabled = false;
            btEditovat.Enabled = false;
            btUlozit.Enabled = true;
            btZrusit.Enabled = true;
            dgZamestnanci.Enabled = false;

            dgZamestnanci.ForeColor = Color.Gray;
            dgZamestnanci.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
        }

        public void Prave_Buttony()
        {
            txMeno.ReadOnly = true;
            txPriezvisko.ReadOnly = true;
            txTelefon.ReadOnly = true;
            txEmail.ReadOnly = true;
            txUlica.ReadOnly = true;
            txMesto.ReadOnly = true;

            btUlozit.Enabled = false;
            btZrusit.Enabled = false;
            btPridat.Enabled = true;
            btEditovat.Enabled = true;
            btZmazat.Enabled = true;
            dgZamestnanci.Enabled = true;

            txMeno.BackColor = Color.White;
            txPriezvisko.BackColor = Color.White;
            dgZamestnanci.ForeColor = Color.Black;
            dgZamestnanci.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        public void Refresh_Tabulky()
        {
            tabulky.Tables["Zamestnanci"].Clear();
            adapter.Fill(tabulky, "Zamestnanci");

            tabulky.Tables["ID_Zamestnanci"].Clear();
            ID_adapter.Fill(tabulky, "ID_Zamestnanci");

            for (int i = 0; i <= tabulky.Tables["Zamestnanci"].Rows.Count - 1; i++)
            {
                if (i % 2 == 0)
                    dgZamestnanci.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        public void Prvy_Zaznam()
        {
            txMeno.Text = tabulky.Tables["Zamestnanci"].Rows[0][0].ToString();
            txPriezvisko.Text = tabulky.Tables["Zamestnanci"].Rows[0][1].ToString();
            txEmail.Text = tabulky.Tables["Zamestnanci"].Rows[0][2].ToString();
            txTelefon.Text = tabulky.Tables["Zamestnanci"].Rows[0][3].ToString();
            txUlica.Text = tabulky.Tables["Zamestnanci"].Rows[0][4].ToString();
            txMesto.Text = tabulky.Tables["Zamestnanci"].Rows[0][5].ToString();

            txMeno.ReadOnly = true;
            txPriezvisko.ReadOnly = true;
            txTelefon.ReadOnly = true;
            txEmail.ReadOnly = true;
            txUlica.ReadOnly = true;
            txMesto.ReadOnly = true;
        }

        private void Zamestnanci_Load(object sender, EventArgs e)
        {
            connection.Open();
            adapter = new SqlDataAdapter(
            "SELECT MENO,PRIEZVISKO,EMAIL,TELEFON,ULICA,MESTO FROM OSOBA WHERE TYP='Zamestnanec'"
            , connection);
            adapter.Fill(tabulky, "Zamestnanci");

            ID_adapter = new SqlDataAdapter("SELECT ID FROM OSOBA WHERE TYP='Zamestnanec'", connection);
            ID_adapter.Fill(tabulky, "ID_Zamestnanci");

            dgZamestnanci.DataSource = tabulky.Tables["Zamestnanci"];

            btUlozit.Enabled = false;
            btZrusit.Enabled = false;

            Refresh_Tabulky();
            Prvy_Zaznam();
        }

        private void btPridat_Click(object sender, EventArgs e)
        {
            Lave_Buttony(0);
            Povinne_Udaje();
            edit = false;
        }

        private void btEditovat_Click(object sender, EventArgs e)
        {
            Povinne_Udaje();
            Lave_Buttony(1);
            edit = true;
        }

        private void btZmazat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Určite chcete zmazať záznam ?", "Varovanie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            int index = dgZamestnanci.CurrentRow.Index;

            if (result == DialogResult.Yes)
            {
                cmd = new SqlCommand("DELETE FROM OSOBA WHERE ID= '" + tabulky.Tables["ID_Zamestnanci"].Rows[index][0].ToString() + "'", connection);
                cmd.ExecuteNonQuery();

                Refresh_Tabulky();
                Prvy_Zaznam();
            }
        }

        private void btZrusit_Click(object sender, EventArgs e)
        {
            Prave_Buttony();
            Refresh_Tabulky();
            Prvy_Zaznam();
            edit = false;
        }

        private void btUlozit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            int index = dgZamestnanci.CurrentRow.Index;

            if (txMeno.Text == "" || txPriezvisko.Text == "")
                result = MessageBox.Show("Nie sú vyplnené všetky povinné polia", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                if (edit == true)
                {
                    cmd = new SqlCommand(
                    "UPDATE OSOBA SET MENO= '" + txMeno.Text + "',TYP= 'Zamestnanec',PRIEZVISKO= '" + txPriezvisko.Text + "',EMAIL= '" + txEmail.Text + "',TELEFON= '" + txTelefon.Text + "',ULICA= '" + txUlica.Text + "',MESTO= '" + txMesto.Text + "' WHERE ID ='" + tabulky.Tables["ID_Zamestnanci"].Rows[index][0] + "';"
                    , connection);
                }
                else
                {
                    cmd = new SqlCommand(
                    "INSERT INTO OSOBA (MENO,TYP,PRIEZVISKO,EMAIL,TELEFON,ULICA,MESTO) " +
                    "VALUES ('" + txMeno.Text + "','Zamestnanec','" + txPriezvisko.Text + "','" + txEmail.Text + "','" + txTelefon.Text + "','" + txUlica.Text + "','" + txMesto.Text + "');"
                    , connection);
                }
                cmd.ExecuteNonQuery();

                Prave_Buttony();
                Refresh_Tabulky();
                Prvy_Zaznam();
            }
        }

        private void dgZamestnanci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txMeno.Text = tabulky.Tables["Zamestnanci"].Rows[e.RowIndex][0].ToString();
                txPriezvisko.Text = tabulky.Tables["Zamestnanci"].Rows[e.RowIndex][1].ToString();
                txEmail.Text = tabulky.Tables["Zamestnanci"].Rows[e.RowIndex][2].ToString();
                txTelefon.Text = tabulky.Tables["Zamestnanci"].Rows[e.RowIndex][3].ToString();
                txUlica.Text = tabulky.Tables["Zamestnanci"].Rows[e.RowIndex][4].ToString();
                txMesto.Text = tabulky.Tables["Zamestnanci"].Rows[e.RowIndex][5].ToString();
            }
        }
    }
}
