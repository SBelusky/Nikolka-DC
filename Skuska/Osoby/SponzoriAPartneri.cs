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
    public partial class SponzoriAPartneri : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1I7N9P7\SQLEXPRESS;Initial Catalog=DenneCentrumDB;Integrated Security=True");
        SqlDataAdapter adapter,ID_adapter;
        SqlCommand cmd;
        DataSet tabulky = new DataSet();
        bool edit = false;

        public void Povinne_Udaje()
        {
            txMeno.BackColor = Color.Gold;
            cbTyp.BackColor = Color.Gold;
        }

        public void Lave_Buttony(int i)
        {
            cbTyp.Enabled = true;
            txMeno.ReadOnly = false;
            txPriezvisko.ReadOnly = false;
            txTelefon.ReadOnly = false;
            txEmail.ReadOnly = false;
            txUlica.ReadOnly = false;
            txMesto.ReadOnly = false;

            if (i == 0)
            {
                cbTyp.Text = "";
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
            dgSponzoriAPartneri.Enabled = false;

            dgSponzoriAPartneri.ForeColor = Color.Gray;
            dgSponzoriAPartneri.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
        }

        public void Prave_Buttony()
        {
            cbTyp.Enabled = false;
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
            dgSponzoriAPartneri.Enabled = true;

            txMeno.BackColor = Color.White;
            cbTyp.BackColor = Color.White;
            dgSponzoriAPartneri.ForeColor = Color.Black;
            dgSponzoriAPartneri.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        public void Refresh_Tabulky()
        {
            tabulky.Tables["SponzoriAPartneri"].Clear();
            adapter.Fill(tabulky, "SponzoriAPartneri");

            tabulky.Tables["ID_SponzoriAPartneri"].Clear();
            ID_adapter.Fill(tabulky, "ID_SponzoriAPartneri");

            for (int i = 0; i <= tabulky.Tables["SponzoriAPartneri"].Rows.Count - 1; i++)
            {
                if (i % 2 == 0)
                    dgSponzoriAPartneri.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        public void Prvy_Zaznam()
        {
            txMeno.Text = tabulky.Tables["SponzoriAPartneri"].Rows[0][0].ToString();
            txPriezvisko.Text = tabulky.Tables["SponzoriAPartneri"].Rows[0][1].ToString();
            cbTyp.Text = tabulky.Tables["SponzoriAPartneri"].Rows[0][2].ToString();
            txEmail.Text = tabulky.Tables["SponzoriAPartneri"].Rows[0][3].ToString();
            txTelefon.Text = tabulky.Tables["SponzoriAPartneri"].Rows[0][4].ToString();
            txUlica.Text = tabulky.Tables["SponzoriAPartneri"].Rows[0][5].ToString();
            txMesto.Text = tabulky.Tables["SponzoriAPartneri"].Rows[0][6].ToString();

            cbTyp.Enabled = false;
            txMeno.ReadOnly = true;
            txPriezvisko.ReadOnly = true;
            txTelefon.ReadOnly = true;
            txEmail.ReadOnly = true;
            txUlica.ReadOnly = true;
            txMesto.ReadOnly = true;
        }

        public SponzoriAPartneri()
        {
            InitializeComponent();
        }

        private void SponzoriAPartneri_Load(object sender, EventArgs e)
        {
            connection.Open();
            adapter = new SqlDataAdapter(
            "SELECT MENO,PRIEZVISKO,TYP,EMAIL,TELEFON,ULICA,MESTO FROM OSOBA WHERE TYP='Sponzor' OR TYP='Partner'"
            , connection);
            adapter.Fill(tabulky, "SponzoriAPartneri");

            ID_adapter = new SqlDataAdapter("SELECT ID FROM OSOBA WHERE TYP='Sponzor' OR TYP='Partner'", connection);
            ID_adapter.Fill(tabulky, "ID_SponzoriAPartneri");

            dgSponzoriAPartneri.DataSource = tabulky.Tables["SponzoriAPartneri"];

            btUlozit.Enabled = false;
            btZrusit.Enabled = false;
            cbTyp.Items.Add("Sponzor");
            cbTyp.Items.Add("Partner");

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
            int index = dgSponzoriAPartneri.CurrentRow.Index;

            if (result == DialogResult.Yes)
            {
                cmd = new SqlCommand("DELETE FROM OSOBA WHERE ID= '" + tabulky.Tables["ID_SponzoriAPartneri"].Rows[index][0].ToString() + "'", connection);
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
            int index = dgSponzoriAPartneri.CurrentRow.Index;

            if (txMeno.Text == "" || cbTyp.Text == "")
                result = MessageBox.Show("Nie sú vyplnené všetky povinné polia", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                if (edit == true)
                {
                    cmd = new SqlCommand(
                    "UPDATE OSOBA SET MENO= '" + txMeno.Text + "',TYP= '" + cbTyp.Text + "',PRIEZVISKO= '" + txPriezvisko.Text + "',EMAIL= '" + txEmail.Text + "',TELEFON= '" + txTelefon.Text + "',ULICA= '" + txUlica.Text + "',MESTO= '" + txMesto.Text + "' WHERE ID ='" + tabulky.Tables["ID_SponzoriAPartneri"].Rows[index][0] + "';"
                    , connection);
                }
                else
                {
                    cmd = new SqlCommand(
                    "INSERT INTO OSOBA (MENO,TYP,PRIEZVISKO,EMAIL,TELEFON,ULICA,MESTO) " +
                    "VALUES ('" + txMeno.Text + "','" + cbTyp.Text + "','" + txPriezvisko.Text + "','" + txEmail.Text + "','" + txTelefon.Text + "','" + txUlica.Text + "','" + txMesto.Text + "');"
                    , connection);
                }
                cmd.ExecuteNonQuery();

                Prave_Buttony();
                Refresh_Tabulky();
                Prvy_Zaznam();
            }
        }

        private void dgSponzoriAPartneri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txMeno.Text = tabulky.Tables["SponzoriAPartneri"].Rows[e.RowIndex][0].ToString();
                txPriezvisko.Text = tabulky.Tables["SponzoriAPartneri"].Rows[e.RowIndex][1].ToString();
                cbTyp.Text = tabulky.Tables["SponzoriAPartneri"].Rows[e.RowIndex][2].ToString();
                txEmail.Text = tabulky.Tables["SponzoriAPartneri"].Rows[e.RowIndex][3].ToString();
                txTelefon.Text = tabulky.Tables["SponzoriAPartneri"].Rows[e.RowIndex][4].ToString();
                txUlica.Text = tabulky.Tables["SponzoriAPartneri"].Rows[e.RowIndex][5].ToString();
                txMesto.Text = tabulky.Tables["SponzoriAPartneri"].Rows[e.RowIndex][6].ToString();
            }
        }
    }
}
