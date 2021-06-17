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
    public partial class Rozvrh : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1I7N9P7\SQLEXPRESS;Initial Catalog=DenneCentrumDB;Integrated Security=True");
        SqlDataAdapter adapter, all_adapter, MenoPriezvisko_adapter;
        SqlCommand cmd;
        DataSet tabulky = new DataSet();
        Boolean edit = false;
        HlavneMenu _spojovnik;

        public Rozvrh(HlavneMenu spojovnik)
        {
            _spojovnik = spojovnik;
            InitializeComponent();
        }

        public void Povinne_Udaje()
        {
            cbZakaznik.BackColor = Color.Gold;
            dtpDatumCvicenia.BackColor = Color.Gold;
            txDlzkaCvicenia.BackColor = Color.Gold;
        }

        public void Prvy_Zaznam()
        {
            dtpDatumCvicenia.CustomFormat = "dd. MM. yyyy hh:mm";

            txMeno.Text = tabulky.Tables["All_Cvicenie"].Rows[0][1].ToString();
            txPriezvisko.Text = tabulky.Tables["All_Cvicenie"].Rows[0][2].ToString();
            dtpDatumCvicenia.Value = DateTime.ParseExact(tabulky.Tables["All_Cvicenie"].Rows[0][3].ToString(), "dd. MM. yyyy hh:mm", null);
            txDlzkaCvicenia.Text = tabulky.Tables["All_Cvicenie"].Rows[0][4].ToString();

            if (Convert.ToBoolean(tabulky.Tables["All_Cvicenie"].Rows[0][5].ToString()) == true)
                chbPrebehlo.Checked = true;

            txPokrok.Text = tabulky.Tables["All_Cvicenie"].Rows[0][6].ToString();
            txPoznamka.Text = tabulky.Tables["All_Cvicenie"].Rows[0][7].ToString();

            cbZakaznik.Enabled = false;
            txMeno.ReadOnly = true;
            txPriezvisko.ReadOnly = true;
            dtpDatumCvicenia.Enabled = false;
            txDlzkaCvicenia.ReadOnly = true;
            chbPrebehlo.Enabled = false;
            txPokrok.ReadOnly = true;
            txPoznamka.ReadOnly = true;
           
            btUlozit.Enabled = false;
            btZrusit.Enabled = false;
        }

        public void Lave_Buttony(int i)
        {
            cbZakaznik.Enabled = false;
            txMeno.ReadOnly = true;
            txPriezvisko.ReadOnly = true;
            dtpDatumCvicenia.Enabled = true;
            txDlzkaCvicenia.ReadOnly = false;
            chbPrebehlo.Enabled = true;
            txPokrok.ReadOnly = false;
            txPoznamka.ReadOnly = false;

            btPridat.Enabled = false;
            btZmazat.Enabled = false;
            btEditovat.Enabled = false;
            btUlozit.Enabled = true;
            btZrusit.Enabled = true;
            dgCvicenie.Enabled = false;

            if (i != 1)
            {
                cbZakaznik.Enabled = true;
                txMeno.Text = "";
                txPriezvisko.Text = "";
                dtpDatumCvicenia.Value = DateTime.Now;
                txDlzkaCvicenia.Text = "60";
                chbPrebehlo.Checked = false;
                txPokrok.Text = "";
                txPoznamka.Text = "";
            }

            dgCvicenie.ForeColor = Color.Gray;
            dgCvicenie.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
        }

        public void Prave_Buttony()
        {
            btUlozit.Enabled = false;
            btZrusit.Enabled = false;
            btPridat.Enabled = true;
            btEditovat.Enabled = true;
            btZmazat.Enabled = true;
            dgCvicenie.Enabled = true;
 
            cbZakaznik.BackColor = Color.White;
            dtpDatumCvicenia.BackColor = Color.White;
            txDlzkaCvicenia.BackColor = Color.White;
            dgCvicenie.ForeColor = Color.Black;
            dgCvicenie.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        public void Refresh_Tabulky()
        {
            tabulky.Tables["Cvicenie"].Clear();
            adapter.Fill(tabulky, "Cvicenie");

            for (int i = 0; i <= tabulky.Tables["Cvicenie"].Rows.Count - 1; i++)
            {
                if (i % 2 == 0)
                    dgCvicenie.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
            }

            tabulky.Tables["All_Cvicenie"].Clear();
            all_adapter.Fill(tabulky, "All_Cvicenie");

            tabulky.Tables["MenoPriezvisko_Cvicenie"].Clear();
            MenoPriezvisko_adapter.Fill(tabulky, "MenoPriezvisko_Cvicenie");
        }

        private void Rozvrh_Load(object sender, EventArgs e)
        {
            connection.Open();
            adapter = new SqlDataAdapter(
            "SELECT MENO_DIETATA,PRIEZVISKO_DIETATA,DATUM_CVICENIA,DLZKA_CVICENIA,PREBEHLO FROM CVICENIE ORDER BY convert(datetime,DATUM_CVICENIA,105) DESC"
            , connection);
            adapter.Fill(tabulky, "Cvicenie");

            all_adapter = new SqlDataAdapter(
            "SELECT CISLO_CVICENIA,MENO_DIETATA,PRIEZVISKO_DIETATA,DATUM_CVICENIA,DLZKA_CVICENIA,PREBEHLO,POKROK,POZNAMKA FROM CVICENIE ORDER BY convert(datetime,DATUM_CVICENIA,105) DESC"
            , connection);
            all_adapter.Fill(tabulky, "All_Cvicenie");

            MenoPriezvisko_adapter = new SqlDataAdapter(
            "SELECT ID,MENO_DIETATA,PRIEZVISKO_DIETATA FROM ZAKAZNIK"
            , connection);
            MenoPriezvisko_adapter.Fill(tabulky, "MenoPriezvisko_Cvicenie");

            dgCvicenie.DataSource = tabulky.Tables["Cvicenie"];
            Refresh_Tabulky();

            cbZakaznik.Enabled = false;
            btUlozit.Enabled = false;
            btZrusit.Enabled = false;

            cbZakaznik.Items.Clear();
            for (int i = 0; i < tabulky.Tables["MenoPriezvisko_Cvicenie"].Rows.Count; i++)
            {
                cbZakaznik.Items.Add(tabulky.Tables["MenoPriezvisko_Cvicenie"].Rows[i][1] + " , " + tabulky.Tables["MenoPriezvisko_Cvicenie"].Rows[i][2]);
            }

            Prvy_Zaznam();
        }

        private void btPridat_Click(object sender, EventArgs e)
        {           
            Povinne_Udaje();
            edit = false;

            /*cbZakaznik.Items.Clear();
            for (int i = 0; i < tabulky.Tables["MenoPriezvisko_Cvicenie"].Rows.Count; i++)
            {
                cbZakaznik.Items.Add(tabulky.Tables["MenoPriezvisko_Cvicenie"].Rows[i][1] + " , " + tabulky.Tables["MenoPriezvisko_Cvicenie"].Rows[i][2]);
            }*/

            Lave_Buttony(0);
        }

        private void btEditovat_Click(object sender, EventArgs e)
        {
            Povinne_Udaje();
            Lave_Buttony(1);
            edit = true;

            /*cbZakaznik.Items.Clear();
            for (int i = 0; i < tabulky.Tables["MenoPriezvisko_Cvicenie"].Rows.Count; i++)
            {
                cbZakaznik.Items.Add(tabulky.Tables["MenoPriezvisko_Cvicenie"].Rows[i][1] + " , " + tabulky.Tables["MenoPriezvisko_Cvicenie"].Rows[i][2]);
            }*/
        }

        private void btZmazat_Click(object sender, EventArgs e)
        {
            int index = dgCvicenie.CurrentCell.RowIndex;

            DialogResult result = MessageBox.Show("Určite chcete zmazať záznam ?", "Varovanie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                cmd = new SqlCommand("DELETE FROM CVICENIE WHERE CISLO_CVICENIA= '" + tabulky.Tables["All_Cvicenie"].Rows[index][0].ToString() + "'", connection);
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
            string strDatumCvicenia = dtpDatumCvicenia.Value.ToString("dd. MM. yyyy hh:mm");
            int index = dgCvicenie.CurrentRow.Index;

            for (int i = 0; i <= tabulky.Tables["Cvicenie"].Rows.Count - 1; i++)
            {
                if (strDatumCvicenia == tabulky.Tables["Cvicenie"].Rows[i][2].ToString() && i != dgCvicenie.CurrentRow.Index)
                {
                    result = MessageBox.Show("Pre zadaný dátum a čas existuje už cvičenie", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (edit == true)
            {
                cmd = new SqlCommand(
                "UPDATE CVICENIE SET MENO_DIETATA= '" + txMeno.Text + "',PRIEZVISKO_DIETATA= '" + txPriezvisko.Text + "',DATUM_CVICENIA= '" + strDatumCvicenia + "',DLZKA_CVICENIA= '" + txDlzkaCvicenia.Text + "',PREBEHLO= '" + (chbPrebehlo.Checked == true) + "',POKROK= '" + txPokrok.Text + "',POZNAMKA= '" + txPoznamka.Text + "' WHERE CISLO_CVICENIA ='" + tabulky.Tables["All_Cvicenie"].Rows[index][0] + "';"
                , connection);
            }
            else
            {
                int id_index = cbZakaznik.SelectedIndex;
                cmd = new SqlCommand(
                "INSERT INTO CVICENIE (MENO_DIETATA,PRIEZVISKO_DIETATA,DATUM_CVICENIA,DLZKA_CVICENIA,PREBEHLO,POKROK,POZNAMKA,ZAKAZNIK_ID) " +
                "VALUES ('" + txMeno.Text + "','" + txPriezvisko.Text + "','" + strDatumCvicenia + "','" + txDlzkaCvicenia.Text + "','" + (chbPrebehlo.Checked == true) + "','" + txPokrok.Text + "','" + txPoznamka.Text + "','" + tabulky.Tables["MenoPriezvisko_Cvicenie"].Rows[id_index][0] + "');"
                , connection);
            }
            cmd.ExecuteNonQuery();

            Prave_Buttony();
            Refresh_Tabulky();
            Prvy_Zaznam();

        }

        private void dgCvicenie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txMeno.Text = tabulky.Tables["All_Cvicenie"].Rows[e.RowIndex][1].ToString();
                txPriezvisko.Text = tabulky.Tables["All_Cvicenie"].Rows[e.RowIndex][2].ToString();
                dtpDatumCvicenia.Value = DateTime.ParseExact(tabulky.Tables["All_Cvicenie"].Rows[e.RowIndex][3].ToString(), "dd. MM. yyyy hh:mm", null);
                txDlzkaCvicenia.Text = tabulky.Tables["All_Cvicenie"].Rows[e.RowIndex][4].ToString();

                if (Convert.ToBoolean(tabulky.Tables["All_Cvicenie"].Rows[e.RowIndex][5].ToString()) == true)
                    chbPrebehlo.Checked = true;

                txPokrok.Text = tabulky.Tables["All_Cvicenie"].Rows[e.RowIndex][6].ToString();
                txPoznamka.Text = tabulky.Tables["All_Cvicenie"].Rows[e.RowIndex][7].ToString();
            }
        }

        private void cbZakaznik_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cbZakaznik.SelectedIndex;
            txMeno.Text = tabulky.Tables["MenoPriezvisko_Cvicenie"].Rows[index][1].ToString();
            txPriezvisko.Text = tabulky.Tables["MenoPriezvisko_Cvicenie"].Rows[index][2].ToString();
        }

        private void Rozvrh_FormClosing(object sender, FormClosingEventArgs e)
        {
            _spojovnik.Refresh_dg();
        }
    }
}
