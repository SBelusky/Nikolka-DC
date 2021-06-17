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
    public partial class Pouzivatelia : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1I7N9P7\SQLEXPRESS;Initial Catalog=DenneCentrumDB;Integrated Security=True");
        SqlDataAdapter adapter, adapter_cbZamestnanec;
        SqlCommand cmd;
        DataSet tabulky = new DataSet();
        string aktivny_uzivatel;

        public void PovinneUdaje()
        {
            txLogin.BackColor = Color.Gold;
            txHeslo.BackColor = Color.Gold;
            cbZamestnanec.BackColor = Color.Gold;
        }

        public void Lave_Buttony(int i)
        {
            cbZamestnanec.Enabled = true;
            txMeno.Enabled = false;
            txPriezvisko.Enabled = false;

            txLogin.ReadOnly = false;
            txHeslo.ReadOnly = false;

            if (i == 0)
            {
                txMeno.Text = "";
                txPriezvisko.Text = "";
                txLogin.Text = "";
                txHeslo.Text = "";
            }
            
            btPridat.Enabled = false;
            btZmazat.Enabled = false;
            btEditovat.Enabled = false;
            btUlozit.Enabled = true;
            btZrusit.Enabled = true;
            dgPouzivatelia.Enabled = false;

            dgPouzivatelia.ForeColor = Color.Gray;
            dgPouzivatelia.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
        }

        public void Prave_Buttony()
        {
            cbZamestnanec.Enabled = false;
            txMeno.Enabled = true;
            txPriezvisko.Enabled = true;

            btUlozit.Enabled = false;
            btZrusit.Enabled = false;
            btPridat.Enabled = true;
            btEditovat.Enabled = true;
            btZmazat.Enabled = true;
            dgPouzivatelia.Enabled = true;

            cbZamestnanec.Text = "";
            txMeno.Text = "";
            txPriezvisko.Text = "";
            txLogin.Text = "";
            txHeslo.Text = "";

            txLogin.BackColor = Color.White;
            txHeslo.BackColor = Color.White;
            cbZamestnanec.BackColor = Color.White;
            dgPouzivatelia.ForeColor = Color.Black;
            dgPouzivatelia.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        public void Refresh_Tabulky()
        {
            tabulky.Tables["Pouzivatelia"].Clear();
            adapter.Fill(tabulky, "Pouzivatelia");

            for (int i = 0; i <= tabulky.Tables["Pouzivatelia"].Rows.Count - 1; i++)
            {
                if (i % 2 == 0)
                    dgPouzivatelia.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
            }

            tabulky.Tables["MenoPriezvisko"].Clear();
            adapter_cbZamestnanec.Fill(tabulky, "MenoPriezvisko");
        }

        public void Prvy_Zaznam()
        {
            txMeno.Text = dgPouzivatelia.Rows[0].Cells[0].Value.ToString();
            txPriezvisko.Text = dgPouzivatelia.Rows[0].Cells[1].Value.ToString();
            txLogin.Text = dgPouzivatelia.Rows[0].Cells[2].Value.ToString();
            txHeslo.Text = dgPouzivatelia.Rows[0].Cells[3].Value.ToString();

            txMeno.ReadOnly = true;
            txPriezvisko.ReadOnly = true;
            txLogin.ReadOnly = true;
            txHeslo.ReadOnly = true;
        }

        public Pouzivatelia()
        {
            InitializeComponent();
            this.aktivny_uzivatel = Login.aktivny_uzivatel;
        }

        private void Pouzivatelia_Load(object sender, EventArgs e)
        {
            connection.Open();

            adapter = new SqlDataAdapter(
            "SELECT MENO,PRIEZVISKO,LOGIN_MENO,LOGIN_HESLO FROM OSOBA WHERE LOGIN_HESLO IS NOT NULL AND LOGIN_MENO IS NOT NULL"
            , connection);
            adapter.Fill(tabulky, "Pouzivatelia");

            adapter_cbZamestnanec = new SqlDataAdapter(
            "SELECT MENO,PRIEZVISKO FROM OSOBA WHERE LOGIN_MENO IS NULL AND LOGIN_HESLO IS NULL AND TYP= 'Zamestnanec'"
            , connection);
            adapter_cbZamestnanec.Fill(tabulky, "MenoPriezvisko");

            dgPouzivatelia.DataSource = tabulky.Tables["Pouzivatelia"];
            Refresh_Tabulky();

            cbZamestnanec.Enabled = false;
            btUlozit.Enabled = false;
            btZrusit.Enabled = false;

            lbAktivyUzivatel.Text = aktivny_uzivatel;

            Prvy_Zaznam();
        }

        private void btPridat_Click(object sender, EventArgs e) 
        {
            PovinneUdaje();
            cbZamestnanec.Items.Clear();

            for (int i = 0; i < tabulky.Tables["MenoPriezvisko"].Rows.Count; i++)
            {
                cbZamestnanec.Items.Add(tabulky.Tables["MenoPriezvisko"].Rows[i][0] + " , " + tabulky.Tables["MenoPriezvisko"].Rows[i][1]);
            }

            Lave_Buttony(0);
        }

        private void btEditovat_Click(object sender, EventArgs e)
        {
            PovinneUdaje();
            Lave_Buttony(1);
            cbZamestnanec.Enabled = false;
        }

        private void btZmazat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Určite chcete zmazať záznam", "Varovanie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                cmd = new SqlCommand("UPDATE OSOBA SET LOGIN_MENO= NULL,LOGIN_HESLO= NULL WHERE LOGIN_MENO='" + txLogin.Text + "' AND LOGIN_HESLO= '" + txHeslo.Text + "'", connection);
                cmd.ExecuteNonQuery();

                txMeno.Text = "";
                txPriezvisko.Text = "";
                txLogin.Text = "";
                txHeslo.Text = "";

                Refresh_Tabulky();
                Prvy_Zaznam();
            }
        }

        private void btUlozit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            bool existuje_login = false;

            for (int i = 0; i < tabulky.Tables["Pouzivatelia"].Rows.Count; i++)
            {
                if (txLogin.Text == tabulky.Tables["Pouzivatelia"].Rows[i][2].ToString() && i != dgPouzivatelia.CurrentRow.Index)
                    existuje_login = true;
            }

            if (txMeno.Text == "" || txPriezvisko.Text == "" || txLogin.Text == "" || txHeslo.Text == "")
                result = MessageBox.Show("Nie sú vyplnené všetky povinné polia", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            if (existuje_login == true)
                result = MessageBox.Show("Zadaný login už existuje ", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                cmd = new SqlCommand("UPDATE OSOBA SET LOGIN_MENO= '" + txLogin.Text + "',LOGIN_HESLO= '" + txHeslo.Text + "' WHERE MENO='" + txMeno.Text + "' AND PRIEZVISKO= '" + txPriezvisko.Text + "'", connection);
                cmd.ExecuteNonQuery();

                Prave_Buttony();
                Refresh_Tabulky();
                Prvy_Zaznam();
            }    
        }

        private void btZrusit_Click(object sender, EventArgs e)
        {
            Prave_Buttony();
            Refresh_Tabulky();
            Prvy_Zaznam();
        }

        private void cbZamestnanec_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cbZamestnanec.SelectedIndex;
            txMeno.Text = tabulky.Tables["MenoPriezvisko"].Rows[index][0].ToString();
            txPriezvisko.Text = tabulky.Tables["MenoPriezvisko"].Rows[index][1].ToString();
        }

        private void dgPouzivatelia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txMeno.Text = tabulky.Tables["Pouzivatelia"].Rows[e.RowIndex][0].ToString();
                txPriezvisko.Text = tabulky.Tables["Pouzivatelia"].Rows[e.RowIndex][1].ToString();
                txLogin.Text = tabulky.Tables["Pouzivatelia"].Rows[e.RowIndex][2].ToString();
                txHeslo.Text = tabulky.Tables["Pouzivatelia"].Rows[e.RowIndex][3].ToString();
            }
        }
    }
}
