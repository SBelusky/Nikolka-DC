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
    public partial class Faktury : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1I7N9P7\SQLEXPRESS;Initial Catalog=DenneCentrumDB;Integrated Security=True");
        SqlDataAdapter adapter, All_adapter,Zakaznik_adapter,Sablona_adapter,Cvicenie_adapter;
        SqlCommand cmd,zaplatena;
        DataSet tabulky = new DataSet();
        Boolean edit = false;

        public Faktury()
        {
            InitializeComponent();
        }

        public void Povinne_Udaje()
        {
            txCisloFaktury.BackColor = Color.Gold;
            cbTyp.BackColor = Color.Gold;
            cbZakaznik.BackColor = Color.Gold;
            dtpDatumVystavenia.BackColor = Color.Gold;
            txSuma.BackColor = Color.Gold;
            cbSposobUhrady.BackColor = Color.Gold;
            cbSablona.BackColor = Color.Gold;
        }

        public void Prvy_Zaznam()
        {
            int id_sablony = int.Parse(tabulky.Tables["All_Faktury"].Rows[0][9].ToString());
            int row_tabulky_pre_sablonu = 0;

            for (int i = 0; i < tabulky.Tables["Sablona_Faktury"].Rows.Count; i++)
            {
                if (id_sablony == int.Parse(tabulky.Tables["Sablona_Faktury"].Rows[i][0].ToString()))
                    row_tabulky_pre_sablonu = i;
            }

            dtpDatumVystavenia.CustomFormat = "dd. MM. yyyy";

            txCisloFaktury.Text = tabulky.Tables["All_Faktury"].Rows[0][0].ToString();
            cbTyp.Text = tabulky.Tables["All_Faktury"].Rows[0][1].ToString();
            txMeno.Text = tabulky.Tables["All_Faktury"].Rows[0][2].ToString();
            txPriezvisko.Text = tabulky.Tables["All_Faktury"].Rows[0][3].ToString();

            dtpDatumVystavenia.Value = Convert.ToDateTime(tabulky.Tables["All_Faktury"].Rows[0][5].ToString());

            txSuma.Text = tabulky.Tables["All_Faktury"].Rows[0][6].ToString();
            cbSposobUhrady.Text = tabulky.Tables["All_Faktury"].Rows[0][7].ToString();
            cbSablona.SelectedIndex = row_tabulky_pre_sablonu;

            if (tabulky.Tables["All_Faktury"].Rows[0][10].ToString() == "")
            {
                chbCvicenie.Checked = false;
                cbCvicenie.Text = "";
            }
            else
            {
                cbCvicenie.Text = tabulky.Tables["All_Faktury"].Rows[0][4].ToString();
                chbCvicenie.Checked = true;
            }

            Prave_Buttony();
        }

        public void Refresh_Tabulky()
        {
            tabulky.Tables["Faktury"].Clear();
            adapter.Fill(tabulky, "Faktury");

            for (int i = 0; i <= tabulky.Tables["Faktury"].Rows.Count - 1; i++)
            {
                if (i % 2 == 0)
                    dgFaktury.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
            }

            tabulky.Tables["All_Faktury"].Clear();
            All_adapter.Fill(tabulky, "All_Faktury");

            tabulky.Tables["Cvicenie_Faktury"].Clear();
            Cvicenie_adapter.Fill(tabulky, "Cvicenie_Faktury");

            cbCvicenie.Items.Clear();

            for (int i = 0; i < tabulky.Tables["Cvicenie_Faktury"].Rows.Count; i++)
            {
                cbCvicenie.Items.Add(tabulky.Tables["Cvicenie_Faktury"].Rows[i][1] + " " + tabulky.Tables["Cvicenie_Faktury"].Rows[i][2] + " " + tabulky.Tables["Cvicenie_Faktury"].Rows[i][3]);
            }
        }

        public void Prave_Buttony()
        {
            txCisloFaktury.ReadOnly = true;
            cbTyp.Enabled = false;
            cbZakaznik.Enabled = false;
            chbCvicenie.Enabled = false;
            cbCvicenie.Enabled = false;
            dtpDatumVystavenia.Enabled = false;
            txSuma.ReadOnly = true;
            cbSposobUhrady.Enabled = false;
            cbSablona.Enabled = false;

            btUlozit.Enabled = false;
            btZrusit.Enabled = false;
            btPridat.Enabled = true;
            btEditovat.Enabled = true;
            btZmazat.Enabled = true;
            dgFaktury.Enabled = true;

            txCisloFaktury.BackColor = Color.White;
            cbTyp.BackColor = Color.White;
            cbZakaznik.BackColor = Color.White;
            dtpDatumVystavenia.BackColor = Color.White;
            txSuma.BackColor = Color.White;
            cbSposobUhrady.BackColor = Color.White;
            cbSablona.BackColor = Color.White;
            dgFaktury.ForeColor = Color.Black;
            dgFaktury.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        public void Lave_Buttony(int i)
        {
            txCisloFaktury.ReadOnly = false;
            cbTyp.Enabled = true;
            cbZakaznik.Enabled = true;
            chbCvicenie.Enabled = true;
            cbCvicenie.Enabled = true;
            dtpDatumVystavenia.Enabled = true;
            txSuma.ReadOnly = false;
            cbSposobUhrady.Enabled = true;
            cbSablona.Enabled = true;

            btPridat.Enabled = false;
            btZmazat.Enabled = false;
            btEditovat.Enabled = false;
            btUlozit.Enabled = true;
            btZrusit.Enabled = true;
            dgFaktury.Enabled = false;

            if (i == 0)
            {
                txMeno.Text = "";
                txPriezvisko.Text = "";
                cbCvicenie.Text = "";
                cbSablona.Text = "";
                cbSposobUhrady.Text = "";
                cbTyp.Text = "";
                cbZakaznik.Text = "";
                chbCvicenie.Checked = false;
                cbCvicenie.Enabled = false;
                txCisloFaktury.Text = "";
                dtpDatumVystavenia.Value = DateTime.Now;
                txSuma.Text = "";
            }
            else
            {
                if (cbCvicenie.Text != "")
                    chbCvicenie.Checked = true;
                cbZakaznik.Enabled = false;
                chbCvicenie.Enabled = false;
                cbCvicenie.Enabled = false;
            }

            dgFaktury.ForeColor = Color.Gray;
            dgFaktury.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
        }

        private void Faktury_Load(object sender, EventArgs e)
        {
            connection.Open();
            adapter = new SqlDataAdapter("SELECT CISLO_FAKTURY,TYP,MENO,PRIEZVISKO,DATUM_VYSTAVENIA FROM FAKTURA ORDER BY CONVERT(DATETIME,DATUM_VYSTAVENIA,103) DESC", connection);
            adapter.Fill(tabulky, "Faktury");

            All_adapter = new SqlDataAdapter(
            "SELECT CISLO_FAKTURY,TYP,MENO,PRIEZVISKO,DATUM_CVICENIA,DATUM_VYSTAVENIA,SUMA,SPOSOB_UHRADY,ZAKAZNIK_ID,SABLONA_ID,CVICENIE_ID FROM FAKTURA ORDER BY CONVERT(DATETIME,DATUM_VYSTAVENIA,103) DESC", connection);
            All_adapter.Fill(tabulky, "All_Faktury");

            Zakaznik_adapter = new SqlDataAdapter(
            "SELECT ID,MENO_DIETATA,PRIEZVISKO_DIETATA FROM ZAKAZNIK", connection);
            Zakaznik_adapter.Fill(tabulky, "Zakaznik_Faktury");

            Sablona_adapter = new SqlDataAdapter(
            "SELECT ID,NAZOV FROM SABLONA WHERE TYP='F'", connection);
            Sablona_adapter.Fill(tabulky, "Sablona_Faktury");

            Cvicenie_adapter = new SqlDataAdapter(
            "SELECT CISLO_CVICENIA,MENO_DIETATA,PRIEZVISKO_DIETATA,DATUM_CVICENIA FROM CVICENIE WHERE ZAPLATENE= 'FALSE'", connection);
            Cvicenie_adapter.Fill(tabulky, "Cvicenie_Faktury");

            dgFaktury.DataSource = tabulky.Tables["Faktury"];

            for (int i = 0; i < tabulky.Tables["Zakaznik_Faktury"].Rows.Count; i++)
            {
                cbZakaznik.Items.Add(tabulky.Tables["Zakaznik_Faktury"].Rows[i][1] + " " + tabulky.Tables["Zakaznik_Faktury"].Rows[i][2]);
            }

            for (int i = 0; i < tabulky.Tables["Cvicenie_Faktury"].Rows.Count; i++)
            {
                cbCvicenie.Items.Add(tabulky.Tables["Cvicenie_Faktury"].Rows[i][1] + " " + tabulky.Tables["Cvicenie_Faktury"].Rows[i][2] + " " + tabulky.Tables["Cvicenie_Faktury"].Rows[i][3]);
            }

            for (int i = 0; i < tabulky.Tables["Sablona_Faktury"].Rows.Count; i++)
            {
                cbSablona.Items.Add(tabulky.Tables["Sablona_Faktury"].Rows[i][1]);
            }

            cbTyp.Items.Add("Cvičenie");
            cbTyp.Items.Add("Permanentka");

            cbSposobUhrady.Items.Add("Hotovosť");
            cbSposobUhrady.Items.Add("Karta");

            dtpDatumVystavenia.CustomFormat = "dd. MM. yyyy";
            txMeno.Enabled = false;
            txPriezvisko.Enabled = false;

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
            DialogResult result = MessageBox.Show("Určite chcete zmazať záznam", "Varovanie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            int index = dgFaktury.CurrentRow.Index;

            if (result == DialogResult.Yes)
            {
                cmd = new SqlCommand("DELETE FROM FAKTURA WHERE CISLO_FAKTURY= '" + tabulky.Tables["All_Faktury"].Rows[index][0] + "'", connection);
                cmd.ExecuteNonQuery();

                Refresh_Tabulky();
                Prvy_Zaznam();
            }
        }

        private void cbZakaznik_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cbZakaznik.SelectedIndex;
            txMeno.Text = tabulky.Tables["Zakaznik_Faktury"].Rows[index][1].ToString();
            txPriezvisko.Text = tabulky.Tables["Zakaznik_Faktury"].Rows[index][2].ToString();
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
            string strDatumVystavenia = dtpDatumVystavenia.Value.ToString("dd. MM. yyyy");
            string strDatumCvicenia;
            int? intCvicenieId;
            int ZakaznikId_index = cbZakaznik.SelectedIndex;
            int SablonaId_index = cbSablona.SelectedIndex;
            int CvicenieId_index = cbCvicenie.SelectedIndex;

            if (txCisloFaktury.Text == "" || cbTyp.Text == "" || txMeno.Text == "" || txPriezvisko.Text == "" || txSuma.Text == "" || cbSposobUhrady.Text == "" || cbSablona.Text == "")
                result = MessageBox.Show("Nie sú vyplnené všetky povinné polia", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (chbCvicenie.Checked == true && cbCvicenie.Text == "")
                result = MessageBox.Show("Nie sú vyplnené všetky povinné polia", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (edit == true)
                {
                    int index = dgFaktury.CurrentRow.Index;
                    cmd = new SqlCommand(
                    "UPDATE FAKTURA SET CISLO_FAKTURY= '" + txCisloFaktury.Text + "',TYP= '" + cbTyp.Text + "',DATUM_VYSTAVENIA= '" + strDatumVystavenia + "',SUMA= '" + txSuma.Text + "',SPOSOB_UHRADY= '" + cbSposobUhrady.Text + "',SABLONA_ID= '" + tabulky.Tables["Sablona_Faktury"].Rows[SablonaId_index][0] + "' WHERE CISLO_FAKTURY ='" + tabulky.Tables["All_Faktury"].Rows[index][0] + "';"
                    , connection);
                }
                else
                {
                    if (chbCvicenie.Checked == false)
                    {
                        strDatumCvicenia = null;
                        intCvicenieId = null;
                    }
                    else
                    {
                        strDatumCvicenia = tabulky.Tables["Cvicenie_Faktury"].Rows[CvicenieId_index][3].ToString();
                        intCvicenieId = Int32.Parse(tabulky.Tables["Cvicenie_Faktury"].Rows[CvicenieId_index][0].ToString());
                    }

                    if (intCvicenieId == null)
                    {
                        cmd = new SqlCommand(
                        "INSERT INTO FAKTURA (CISLO_FAKTURY,TYP,MENO,PRIEZVISKO,DATUM_CVICENIA,DATUM_VYSTAVENIA,SUMA,SPOSOB_UHRADY,ZAKAZNIK_ID,SABLONA_ID,CVICENIE_ID) " +
                        "VALUES ('" + txCisloFaktury.Text + "','" + cbTyp.Text + "','" + txMeno.Text + "','" + txPriezvisko.Text + "',null,'" + strDatumVystavenia + "','" + txSuma.Text + "','" + cbSposobUhrady.Text + "','" + tabulky.Tables["Zakaznik_Faktury"].Rows[ZakaznikId_index][0].ToString() + "','" + tabulky.Tables["Sablona_Faktury"].Rows[SablonaId_index][0].ToString() + "',null);"
                        , connection);
                    }
                    else
                    {
                    cmd = new SqlCommand(
                        "INSERT INTO FAKTURA (CISLO_FAKTURY,TYP,MENO,PRIEZVISKO,DATUM_CVICENIA,DATUM_VYSTAVENIA,SUMA,SPOSOB_UHRADY,ZAKAZNIK_ID,SABLONA_ID,CVICENIE_ID) " +
                        "VALUES ('" + txCisloFaktury.Text + "','" + cbTyp.Text + "','" + txMeno.Text + "','" + txPriezvisko.Text + "','" + strDatumCvicenia + "','" + strDatumVystavenia + "','" + txSuma.Text + "','" + cbSposobUhrady.Text + "','" + tabulky.Tables["Zakaznik_Faktury"].Rows[ZakaznikId_index][0].ToString() + "','" + tabulky.Tables["Sablona_Faktury"].Rows[SablonaId_index][0].ToString() + "','" + intCvicenieId + "');"
                        , connection);

                    zaplatena = new SqlCommand(
                    "UPDATE CVICENIE SET ZAPLATENE= 'TRUE' WHERE DATUM_CVICENIA ='" + strDatumCvicenia + "';"
                    , connection);

                    zaplatena.ExecuteNonQuery();
                    }
                }
                cmd.ExecuteNonQuery();

                Prave_Buttony();
                Refresh_Tabulky();
                Prvy_Zaznam();
            }
        }

        private void chbCvicenie_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbCvicenie.Checked == true)
                cbCvicenie.Enabled = true;
            else
            {
                cbCvicenie.Enabled = false;
                cbCvicenie.Text = "";
            }
        }

        private void dgFaktury_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id_sablony = int.Parse(tabulky.Tables["All_Faktury"].Rows[e.RowIndex][9].ToString());
                int row_tabulky_pre_sablonu = 0;

                for (int i = 0; i < tabulky.Tables["Sablona_Faktury"].Rows.Count; i++)
                {
                    if (id_sablony == int.Parse(tabulky.Tables["Sablona_Faktury"].Rows[i][0].ToString()))
                        row_tabulky_pre_sablonu = i;
                }

                string strDatumVystavenia = tabulky.Tables["All_Faktury"].Rows[e.RowIndex][5].ToString();

                dtpDatumVystavenia.CustomFormat = "dd. MM. yyyy";

                txCisloFaktury.Text = tabulky.Tables["All_Faktury"].Rows[e.RowIndex][0].ToString();
                cbTyp.Text = tabulky.Tables["All_Faktury"].Rows[e.RowIndex][1].ToString();
                txMeno.Text = tabulky.Tables["All_Faktury"].Rows[e.RowIndex][2].ToString();
                txPriezvisko.Text = tabulky.Tables["All_Faktury"].Rows[e.RowIndex][3].ToString();

                if (strDatumVystavenia == "")
                    dtpDatumVystavenia.CustomFormat = " ";
                else
                {
                    dtpDatumVystavenia.Value = Convert.ToDateTime(tabulky.Tables["All_Faktury"].Rows[e.RowIndex][5].ToString());
                }

                txSuma.Text = tabulky.Tables["All_Faktury"].Rows[e.RowIndex][6].ToString();
                cbSposobUhrady.Text = tabulky.Tables["All_Faktury"].Rows[e.RowIndex][7].ToString();
                cbSablona.SelectedIndex = row_tabulky_pre_sablonu;

                if (tabulky.Tables["All_Faktury"].Rows[e.RowIndex][10].ToString() == "")
                {
                    chbCvicenie.Checked = false;
                    cbCvicenie.Text = "";
                }
                else
                {
                    cbCvicenie.Text = tabulky.Tables["All_Faktury"].Rows[e.RowIndex][4].ToString();
                    chbCvicenie.Checked = true;
                    cbCvicenie.Enabled = false;
                }
            }
        }

    }
}
