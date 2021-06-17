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
    public partial class Podujatia : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1I7N9P7\SQLEXPRESS;Initial Catalog=DenneCentrumDB;Integrated Security=True");
        SqlDataAdapter adapter, ID_adapter;
        SqlCommand cmd;
        DataSet tabulky = new DataSet();
        Boolean edit = false;

        public Podujatia()
        {
            InitializeComponent();
        }

        public void Povinne_Udaje()
        {
            txNazov.BackColor = Color.Gold;
        }

        public void Prvy_Zaznam()
        {
            string strDatumPodujatia = tabulky.Tables["ID_Podujatia"].Rows[0][4].ToString();
            string strCasZacatia = tabulky.Tables["ID_Podujatia"].Rows[0][5].ToString();

            dtpDatumPodujatia.CustomFormat = "dd. MM. yyyy";
            dtpCasZacatia.CustomFormat = "HH:mm:ss";

            txNazov.Text = tabulky.Tables["ID_Podujatia"].Rows[0][1].ToString();

            if (strDatumPodujatia == "")
                dtpDatumPodujatia.CustomFormat = " ";
            else
                dtpDatumPodujatia.Value = Convert.ToDateTime(tabulky.Tables["ID_Podujatia"].Rows[0][4].ToString());

            if (strCasZacatia == "")
                dtpCasZacatia.CustomFormat = " ";
            else
                dtpCasZacatia.Value = Convert.ToDateTime(tabulky.Tables["ID_Podujatia"].Rows[0][5].ToString());

            txDobaTrvania.Text = tabulky.Tables["ID_Podujatia"].Rows[0][6].ToString();
            txUlica.Text = tabulky.Tables["ID_Podujatia"].Rows[0][2].ToString();
            txMesto.Text = tabulky.Tables["ID_Podujatia"].Rows[0][3].ToString();
            txVyhradenePeniaze.Text = tabulky.Tables["ID_Podujatia"].Rows[0][7].ToString();
            txPocetOsob.Text = tabulky.Tables["ID_Podujatia"].Rows[0][8].ToString();
            txVyzbieranePeniaze.Text = tabulky.Tables["ID_Podujatia"].Rows[0][9].ToString();
            txPoznamka.Text = tabulky.Tables["ID_Podujatia"].Rows[0][10].ToString();

            txNazov.ReadOnly = true;
            dtpDatumPodujatia.Enabled = false;
            chbDatumPodujatia.Enabled = false;
            dtpCasZacatia.Enabled = false;
            chbCasZacatia.Enabled = false;
            txDobaTrvania.ReadOnly = true;
            txUlica.ReadOnly = true;
            txMesto.ReadOnly = true;
            txVyhradenePeniaze.ReadOnly = true;
            txPocetOsob.ReadOnly = true;
            txVyzbieranePeniaze.ReadOnly = true;
            txPoznamka.ReadOnly = true;

            btUlozit.Enabled = false;
            btZrusit.Enabled = false;

        }

        public void Refresh_Tabulky()
        {
            tabulky.Tables["Podujatia"].Clear();
            adapter.Fill(tabulky, "Podujatia");

            for (int i = 0; i <= tabulky.Tables["Podujatia"].Rows.Count - 1; i++)
            {

                if((dgPodujatia.Rows[i].Cells[1].Value.ToString()) != "")
                {
                    if (Convert.ToDateTime(dgPodujatia.Rows[i].Cells[1].Value.ToString()) < DateTime.Now)
                        dgPodujatia.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }

                if ((dgPodujatia.Rows[i].Cells[1].Value.ToString()) == "")
                {
                        dgPodujatia.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                }
            }

            tabulky.Tables["ID_Podujatia"].Clear();
            ID_adapter.Fill(tabulky, "ID_Podujatia");
        }

        public void Prave_Buttony()
        {
            btUlozit.Enabled = false;
            btZrusit.Enabled = false;
            btPridat.Enabled = true;
            btEditovat.Enabled = true;
            btZmazat.Enabled = true;
            dgPodujatia.Enabled = true;
            chbDatumPodujatia.Checked = false;
            chbCasZacatia.Checked = false;

            txNazov.BackColor = Color.White;
            dgPodujatia.ForeColor = Color.Black;
            dgPodujatia.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        public void Lave_Buttony(int i)
        {
            txNazov.ReadOnly = false;
            dtpDatumPodujatia.Enabled = true;
            chbDatumPodujatia.Enabled = true;
            dtpCasZacatia.Enabled = true;
            chbCasZacatia.Enabled = true;
            txDobaTrvania.ReadOnly = false;
            txUlica.ReadOnly = false;
            txMesto.ReadOnly = false;
            txVyhradenePeniaze.ReadOnly = false;
            txPocetOsob.ReadOnly = false;
            txVyzbieranePeniaze.ReadOnly = false;
            txPoznamka.ReadOnly = false;

            btPridat.Enabled = false;
            btZmazat.Enabled = false;
            btEditovat.Enabled = false;
            btUlozit.Enabled = true;
            btZrusit.Enabled = true;
            dgPodujatia.Enabled = false;

            if (i == 0)
            {
                txNazov.Text = "";
                dtpDatumPodujatia.CustomFormat = " ";
                dtpCasZacatia.CustomFormat = " ";
                txDobaTrvania.Text = "";
                txUlica.Text = "";
                txMesto.Text = "";
                txVyhradenePeniaze.Text = "";
                txPocetOsob.Text = "";
                txVyzbieranePeniaze.Text = "";
                txPoznamka.Text = "";

                chbDatumPodujatia.Checked = false;
                chbCasZacatia.Checked = false;

                dtpDatumPodujatia.Value = DateTime.Now;
                dtpCasZacatia.Value = Convert.ToDateTime("00:00");
            }
            else
            {
                if (dtpDatumPodujatia.CustomFormat == "dd. MM. yyyy")
                    chbDatumPodujatia.Checked = true;
                else
                    dtpDatumPodujatia.Value = DateTime.Now;

                if (dtpCasZacatia.CustomFormat == "HH:mm:ss")
                    chbCasZacatia.Checked = true;
                else
                    dtpCasZacatia.Value = Convert.ToDateTime("00:00");
            }

            dgPodujatia.ForeColor = Color.Gray;
            dgPodujatia.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
        }

        private void Podujatia_Load(object sender, EventArgs e)
        {
            connection.Open();
            adapter = new SqlDataAdapter("SELECT NAZOV,DATUM_PODUJATIA,CAS_ZACATIA FROM PODUJATIE ORDER BY CONVERT(DATETIME,DATUM_PODUJATIA,103) DESC", connection);
            adapter.Fill(tabulky, "Podujatia");

            ID_adapter = new SqlDataAdapter(
            "SELECT ID,NAZOV,ULICA,MESTO,DATUM_PODUJATIA,CAS_ZACATIA,DOBA_TRVANIA,VYHRADENE_PENIAZE,POCET_OSOB,VYZBIERANE_PENIAZE,POZNAMKA FROM PODUJATIE ORDER BY CONVERT(DATETIME,DATUM_PODUJATIA,103) DESC", connection);
            ID_adapter.Fill(tabulky, "ID_Podujatia");

            dgPodujatia.DataSource = tabulky.Tables["Podujatia"];

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
            int index = dgPodujatia.CurrentRow.Index;

            if (result == DialogResult.Yes)
            {
                cmd = new SqlCommand("DELETE FROM PODUJATIE WHERE ID= '" + tabulky.Tables["ID_Podujatia"].Rows[index][0] + "'", connection);
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

            if (txNazov.Text == "")
                result = MessageBox.Show("Nie sú vyplnené všetky povinné polia", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                string strDatumPodujatia, strCasZacatia;

                if (chbDatumPodujatia.Checked == false)
                    strDatumPodujatia = null;
                else
                    strDatumPodujatia = dtpDatumPodujatia.Value.ToShortDateString();

                if (chbCasZacatia.Checked == false)
                    strCasZacatia = null;
                else
                    strCasZacatia = dtpCasZacatia.Value.ToShortTimeString();

                if (edit == true)
                {
                    int index = dgPodujatia.CurrentRow.Index;
                    cmd = new SqlCommand(
                    "UPDATE PODUJATIE SET NAZOV= '" + txNazov.Text + "',ULICA= '" + txUlica.Text + "',MESTO= '" + txMesto.Text + "',DATUM_PODUJATIA= '" + strDatumPodujatia + "',CAS_ZACATIA= '" + strCasZacatia + "',DOBA_TRVANIA= '" + txDobaTrvania.Text + "',VYHRADENE_PENIAZE= '" + txVyhradenePeniaze.Text + "',POCET_OSOB= '" + txPocetOsob.Text + "',VYZBIERANE_PENIAZE= '" + txVyzbieranePeniaze.Text + "',POZNAMKA= '" + txPoznamka.Text + "' WHERE ID ='" + tabulky.Tables["ID_PODUJATIA"].Rows[index][0] + "';"
                    , connection);
                }
                else
                {
                    cmd = new SqlCommand(
                    "INSERT INTO PODUJATIE (NAZOV,ULICA,MESTO,DATUM_PODUJATIA,CAS_ZACATIA,DOBA_TRVANIA,VYHRADENE_PENIAZE,POCET_OSOB,VYZBIERANE_PENIAZE,POZNAMKA) " +
                    "VALUES ('" + txNazov.Text + "','" + txUlica.Text + "','" + txMesto.Text + "','" + strDatumPodujatia + "','" + strCasZacatia + "','" + txDobaTrvania.Text + "','" + txVyhradenePeniaze.Text + "','" + txPocetOsob.Text + "','" + txVyzbieranePeniaze.Text + "','" + txPoznamka.Text + "');"
                    , connection);
                }
                cmd.ExecuteNonQuery();

                Prave_Buttony();
                Refresh_Tabulky();
                Prvy_Zaznam();
            }
        }

        private void chbDatumPodujatia_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbDatumPodujatia.Checked == true)
            {
                dtpDatumPodujatia.Enabled = true;
                dtpDatumPodujatia.CustomFormat = "dd. MM. yyyy";
            }
            else
            {
                dtpDatumPodujatia.Enabled = false;
            }
        }

        private void chbCasZacatia_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbCasZacatia.Checked == true)
            {
                dtpCasZacatia.Enabled = true;
                dtpCasZacatia.CustomFormat = "HH:mm:ss";
            }
            else
            {
                dtpCasZacatia.Enabled = false;
            }
        }

        private void dgPodujatia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strDatumPodujatia = tabulky.Tables["ID_Podujatia"].Rows[e.RowIndex][4].ToString();
                string strCasZacatia = tabulky.Tables["ID_Podujatia"].Rows[e.RowIndex][5].ToString();

                dtpDatumPodujatia.CustomFormat = "dd. MM. yyyy";
                dtpCasZacatia.CustomFormat = "HH:mm:ss";

                txNazov.Text = tabulky.Tables["ID_Podujatia"].Rows[e.RowIndex][1].ToString();

                if (strDatumPodujatia == "")
                    dtpDatumPodujatia.CustomFormat = " ";
                else
                    dtpDatumPodujatia.Value = Convert.ToDateTime(tabulky.Tables["ID_Podujatia"].Rows[e.RowIndex][4].ToString());

                if (strCasZacatia == "")
                    dtpCasZacatia.CustomFormat = " ";
                else
                    dtpCasZacatia.Value = Convert.ToDateTime(tabulky.Tables["ID_Podujatia"].Rows[e.RowIndex][5].ToString());

                txDobaTrvania.Text = tabulky.Tables["ID_Podujatia"].Rows[e.RowIndex][6].ToString();
                txUlica.Text = tabulky.Tables["ID_Podujatia"].Rows[e.RowIndex][2].ToString();
                txMesto.Text = tabulky.Tables["ID_Podujatia"].Rows[e.RowIndex][3].ToString();
                txVyhradenePeniaze.Text = tabulky.Tables["ID_Podujatia"].Rows[e.RowIndex][7].ToString();
                txPocetOsob.Text = tabulky.Tables["ID_Podujatia"].Rows[e.RowIndex][8].ToString();
                txVyzbieranePeniaze.Text = tabulky.Tables["ID_Podujatia"].Rows[e.RowIndex][9].ToString();
                txPoznamka.Text = tabulky.Tables["ID_Podujatia"].Rows[e.RowIndex][10].ToString();
            }
        }
    }
}
