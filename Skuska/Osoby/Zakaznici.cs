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
    public partial class Zakaznici : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1I7N9P7\SQLEXPRESS;Initial Catalog=DenneCentrumDB;Integrated Security=True");
        SqlDataAdapter adapter, All_adapter;
        SqlCommand cmd;
        DataSet tabulky = new DataSet();
        bool edit = false;

        public Zakaznici()
        {
            InitializeComponent();
        }

        public void Povinne_Udaje()
        {
            txMenoDietata.BackColor = Color.Gold;
            txPriezviskoDietata.BackColor = Color.Gold;
            txTelefon.BackColor = Color.Gold;
        }

        public void Lave_Buttony(int i)
        {
            txMenoDietata.ReadOnly = false;
            txPriezviskoDietata.ReadOnly = false;
            txUlica.ReadOnly = false;
            txMesto.ReadOnly = false;
            txMenoRodica.ReadOnly = false;
            txPriezviskoRodica.ReadOnly = false;
            txEmail.ReadOnly = false;
            txTelefon.ReadOnly = false;
            txZdravotnyStav.ReadOnly = false;

            if (i == 0)
            {
                txMenoDietata.Text = "";
                txPriezviskoDietata.Text = "";
                txUlica.Text = "";
                txMesto.Text = "";
                txPermanentka.Text = "";
                txMenoRodica.Text = "";
                txPriezviskoRodica.Text = "";
                txTelefon.Text = "";
                txEmail.Text = "";
                txTelefon.Text = "";
                txZdravotnyStav.Text = "";
            }

            btPridat.Enabled = false;
            btZmazat.Enabled = false;
            btEditovat.Enabled = false;
            btUlozit.Enabled = true;
            btZrusit.Enabled = true;
            dgZakaznici.Enabled = false;

            dgZakaznici.ForeColor = Color.Gray;
            dgZakaznici.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
        }

        public void Prave_Buttony()
        {
            txMenoDietata.ReadOnly = true;
            txPriezviskoDietata.ReadOnly = true;
            txUlica.ReadOnly = true;
            txMesto.ReadOnly = true;
            txMenoRodica.ReadOnly = true;
            txPriezviskoRodica.ReadOnly = true;
            txEmail.ReadOnly = true;
            txTelefon.ReadOnly = true;
            txZdravotnyStav.ReadOnly = true;

            btUlozit.Enabled = false;
            btZrusit.Enabled = false;
            btPridat.Enabled = true;
            btEditovat.Enabled = true;
            btZmazat.Enabled = true;
            dgZakaznici.Enabled = true;

            txMenoDietata.BackColor = SystemColors.Window;
            txPriezviskoDietata.BackColor = SystemColors.Window;
            txTelefon.BackColor = SystemColors.Window;
            dgZakaznici.ForeColor = Color.Black;
            dgZakaznici.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        public void Refresh_Tabulky()
        {
            tabulky.Tables["Zakaznici"].Clear();
            adapter.Fill(tabulky, "Zakaznici");

            tabulky.Tables["All_zakaznici"].Clear();
            All_adapter.Fill(tabulky, "All_zakaznici");

            for (int i = 0; i <= tabulky.Tables["Zakaznici"].Rows.Count - 1; i++)
            {
                if (i % 2 == 0)
                    dgZakaznici.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        public void Prvy_Zaznam()
        {
            txMenoDietata.Text = tabulky.Tables["All_zakaznici"].Rows[0][1].ToString(); 
            txPriezviskoDietata.Text = tabulky.Tables["All_zakaznici"].Rows[0][2].ToString(); 
            txUlica.Text = tabulky.Tables["All_zakaznici"].Rows[0][3].ToString(); 
            txMesto.Text = tabulky.Tables["All_zakaznici"].Rows[0][4].ToString(); 
            txMenoRodica.Text = tabulky.Tables["All_zakaznici"].Rows[0][6].ToString(); 
            txPriezviskoRodica.Text = tabulky.Tables["All_zakaznici"].Rows[0][7].ToString(); 
            txEmail.Text = tabulky.Tables["All_zakaznici"].Rows[0][8].ToString(); 
            txTelefon.Text = tabulky.Tables["All_zakaznici"].Rows[0][9].ToString(); 
            txZdravotnyStav.Text = tabulky.Tables["All_zakaznici"].Rows[0][10].ToString();

            txMenoDietata.ReadOnly = true;
            txPriezviskoDietata.ReadOnly = true;
            txUlica.ReadOnly = true;
            txMesto.ReadOnly = true;
            txMenoRodica.ReadOnly = true;
            txPriezviskoRodica.ReadOnly = true;
            txEmail.ReadOnly = true;
            txTelefon.ReadOnly = true;
            txZdravotnyStav.ReadOnly = true;
        }

        private void Zakaznici_Load(object sender, EventArgs e)
        {
            connection.Open();
            adapter = new SqlDataAdapter(
            "SELECT MENO_DIETATA,PRIEZVISKO_DIETATA,EMAIL,TELEFON,SUCASTNA_PERMANENTKA FROM ZAKAZNIK"
            , connection);
            adapter.Fill(tabulky, "Zakaznici");

            All_adapter = new SqlDataAdapter("SELECT ID,MENO_DIETATA,PRIEZVISKO_DIETATA,ULICA,MESTO,SUCASTNA_PERMANENTKA,MENO_RODICA,PRIEZVISKO_RODICA,EMAIL,TELEFON,ZDRAVOTNY_STAV FROM ZAKAZNIK", connection);
            All_adapter.Fill(tabulky, "All_zakaznici");

            dgZakaznici.DataSource = tabulky.Tables["Zakaznici"];

            txPermanentka.ReadOnly = true;

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
            int index = dgZakaznici.CurrentRow.Index;

            if (result == DialogResult.Yes)
            {
                cmd = new SqlCommand("DELETE FROM ZAKAZNIK WHERE ID= '" + tabulky.Tables["All_zakaznici"].Rows[index][0].ToString() + "'", connection);
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
            int index = dgZakaznici.CurrentRow.Index;

            if (txMenoDietata.Text == "" || txPriezviskoDietata.Text == "" || txTelefon.Text == "")
                result = MessageBox.Show("Nie sú vyplnené všetky povinné polia", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                if (edit == true)
                {
                    cmd = new SqlCommand(
                    "UPDATE ZAKAZNIK SET MENO_DIETATA= '" + txMenoDietata.Text + "',PRIEZVISKO_DIETATA= '" + txPriezviskoDietata.Text + "',ULICA= '" + txUlica.Text + "',MESTO= '" + txMesto.Text + "',MENO_RODICA= '" + txMenoRodica.Text + "',PRIEZVISKO_RODICA= '" + txPriezviskoRodica.Text + "',EMAIL= '" + txEmail.Text + "',TELEFON= '" + txTelefon.Text + "',ZDRAVOTNY_STAV= '" + txZdravotnyStav.Text + "' WHERE ID ='" + tabulky.Tables["All_zakaznici"].Rows[index][0] + "';"
                    , connection);
                }
                else
                {
                    cmd = new SqlCommand(
                    "INSERT INTO ZAKAZNIK (MENO_DIETATA,PRIEZVISKO_DIETATA,ULICA,MESTO,MENO_RODICA,PRIEZVISKO_RODICA,EMAIL,TELEFON,ZDRAVOTNY_STAV) " +
                    "VALUES ('" + txMenoDietata.Text + "','" + txPriezviskoDietata.Text + "','" + txUlica.Text + "','" + txMesto.Text + "','" + txMenoRodica.Text + "','" + txPriezviskoRodica.Text + "','" + txEmail.Text + "','" + txTelefon.Text + "','" + txZdravotnyStav.Text + "');"
                    , connection);
                }
                cmd.ExecuteNonQuery();

                Prave_Buttony();
                Refresh_Tabulky();
                Prvy_Zaznam();
            }
        }

        private void dgZakaznici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txMenoDietata.Text = tabulky.Tables["All_zakaznici"].Rows[e.RowIndex][1].ToString();
                txPriezviskoDietata.Text = tabulky.Tables["All_zakaznici"].Rows[e.RowIndex][2].ToString();
                txUlica.Text = tabulky.Tables["All_zakaznici"].Rows[e.RowIndex][3].ToString();
                txMesto.Text = tabulky.Tables["All_zakaznici"].Rows[e.RowIndex][4].ToString();
                txPermanentka.Text = tabulky.Tables["All_zakaznici"].Rows[e.RowIndex][5].ToString();
                txMenoRodica.Text = tabulky.Tables["All_zakaznici"].Rows[e.RowIndex][6].ToString();
                txPriezviskoRodica.Text = tabulky.Tables["All_zakaznici"].Rows[e.RowIndex][7].ToString();
                txEmail.Text = tabulky.Tables["All_zakaznici"].Rows[e.RowIndex][8].ToString();
                txTelefon.Text = tabulky.Tables["All_zakaznici"].Rows[e.RowIndex][9].ToString();
                txZdravotnyStav.Text = tabulky.Tables["All_zakaznici"].Rows[e.RowIndex][10].ToString();
            }

        }
    }
}
