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
    public partial class Inventar : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1I7N9P7\SQLEXPRESS;Initial Catalog=DenneCentrumDB;Integrated Security=True");
        SqlDataAdapter adapter, txPoznamka_adapter;
        SqlCommand cmd;
        DataSet tabulky = new DataSet();
        Boolean edit = false;

        public Inventar()
        {
            InitializeComponent();
        }

        public void Povinne_Udaje()
        {
            txNazov.BackColor = Color.Gold;
            cbTyp.BackColor = Color.Gold;
        }

        public void Prvy_Zaznam()
        {
            string strDatumKupy = dgInventar.Rows[0].Cells[3].Value.ToString();
            string strServis = dgInventar.Rows[0].Cells[4].Value.ToString();

            dtpDatumKupy.CustomFormat = "dd. MM. yyyy";
            dtpServis.CustomFormat = "dd. MM. yyyy";

            txNazov.Text = dgInventar.Rows[0].Cells[1].Value.ToString();
            cbTyp.Text = dgInventar.Rows[0].Cells[2].Value.ToString();

            if (strDatumKupy == "")
                dtpDatumKupy.CustomFormat = " ";
            else
                dtpDatumKupy.Value = Convert.ToDateTime(dgInventar.Rows[0].Cells[3].Value.ToString());

            if (strServis == "")
                dtpServis.CustomFormat = " ";
            else
                dtpServis.Value = Convert.ToDateTime(dgInventar.Rows[0].Cells[4].Value.ToString());

            if (Convert.ToBoolean(dgInventar.Rows[0].Cells[5].Value) == true)
                chbKPrevadzke.Checked = true;

            txPoznamka.Text = tabulky.Tables["txPoznamka_Inventar"].Rows[0][5].ToString();

            txNazov.ReadOnly = true;
            cbTyp.Enabled = false;
            dtpDatumKupy.Enabled = false;
            dtpServis.Enabled = false;
            chbKPrevadzke.Enabled = false;
            chbDatumKupy.Enabled = false;
            chbServis.Enabled = false;
            txPoznamka.ReadOnly = true;

            btUlozit.Enabled = false;
            btZrusit.Enabled = false;
        }

        public void Lave_Buttony(int i)
        {
            txNazov.ReadOnly = false;
            cbTyp.Enabled = true;
            chbDatumKupy.Enabled = true;
            chbServis.Enabled = true;
            chbKPrevadzke.Enabled = true;
            txPoznamka.ReadOnly = false;

            btPridat.Enabled = false;
            btZmazat.Enabled = false;
            btEditovat.Enabled = false;
            btUlozit.Enabled = true;
            btZrusit.Enabled = true;
            dgInventar.Enabled = false;

            if (i != 1)
            {
                dtpDatumKupy.CustomFormat = " ";
                dtpServis.CustomFormat = " ";
                txPoznamka.Text = "";
                txNazov.Text = "";
                cbTyp.Text = "";
                chbKPrevadzke.Checked = false;
                chbDatumKupy.Checked = false;
                chbServis.Checked = false;

                dtpDatumKupy.Value = DateTime.Now;
                dtpServis.Value = DateTime.Now;
            }
            else
            {
                if (dtpDatumKupy.CustomFormat == "dd. MM. yyyy")
                    chbDatumKupy.Checked = true;
                else
                    dtpDatumKupy.Value = DateTime.Now;

                if (dtpServis.CustomFormat == "dd. MM. yyyy")
                    chbServis.Checked = true;
                else
                    dtpServis.Value = DateTime.Now;
            }

            dgInventar.ForeColor = Color.Gray;
            dgInventar.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
        }

        public void Prave_Buttony()
        {
            btUlozit.Enabled = false;
            btZrusit.Enabled = false;
            btPridat.Enabled = true;
            btEditovat.Enabled = true;
            btZmazat.Enabled = true;
            dgInventar.Enabled = true;

            chbDatumKupy.Checked = false;
            chbServis.Checked = false;

            txNazov.BackColor = Color.White;
            cbTyp.BackColor = Color.White;
            dgInventar.ForeColor = Color.Black;
            dgInventar.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        public void Refresh_Tabulky()
        {
            int farebne_stlpce = 0;

            tabulky.Tables["Inventar"].Clear();
            adapter.Fill(tabulky, "Inventar");

            for (int i = 0; i <= tabulky.Tables["Inventar"].Rows.Count - 1; i++)
            {

                if (dgInventar.Rows[i].Cells[4].Value.ToString() != "")
                {
                    if (Convert.ToDateTime(dgInventar.Rows[i].Cells[4].Value.ToString()).AddYears(2) < DateTime.Now)
                    {
                        dgInventar.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                        farebne_stlpce++;
                    }
                }

                if (dgInventar.Rows[i].Cells[5].Value.ToString() == "False")
                {
                    dgInventar.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                    farebne_stlpce++;
                }
            }

            if (farebne_stlpce == 0)
            {
                for (int i = 0; i <= tabulky.Tables["Inventar"].Rows.Count - 1; i++)
                {
                    if (i % 2 == 0)
                        dgInventar.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }

            tabulky.Tables["txPoznamka_Inventar"].Clear();
            txPoznamka_adapter.Fill(tabulky, "txPoznamka_Inventar");
        }

        private void Inventar_Load(object sender, EventArgs e)
        {
            connection.Open();
            adapter = new SqlDataAdapter("SELECT ID,NAZOV,TYP,DATUM_KUPY,SERVIS,K_PREVADZKE FROM INVENTAR", connection);
            adapter.Fill(tabulky, "Inventar");

            txPoznamka_adapter = new SqlDataAdapter("SELECT NAZOV,TYP,DATUM_KUPY,SERVIS,K_PREVADZKE,POZNAMKA FROM INVENTAR", connection);
            txPoznamka_adapter.Fill(tabulky, "txPoznamka_Inventar"); 

            dgInventar.DataSource = tabulky.Tables["Inventar"];

            cbTyp.Items.Add("Prístroj");
            cbTyp.Items.Add("Pomôcka");

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
            if (result == DialogResult.Yes)
            {
                cmd = new SqlCommand("DELETE FROM INVENTAR WHERE ID= '" + dgInventar.CurrentRow.Cells[0].Value + "'", connection);
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

            if (txNazov.Text == "" || cbTyp.Text == "")
                result = MessageBox.Show("Nie sú vyplnené všetky povinné polia", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                string strDatumKupy, strServis;

                if (chbDatumKupy.Checked == false)
                    strDatumKupy = null;
                else
                    strDatumKupy = dtpDatumKupy.Value.ToShortDateString();

                if (chbServis.Checked == false)
                    strServis = null;
                else
                    strServis = dtpServis.Value.ToShortDateString();

                if (edit == true)
                {
                    cmd = new SqlCommand(
                    "UPDATE INVENTAR SET NAZOV= '" + txNazov.Text + "',TYP= '" + cbTyp.Text + "',DATUM_KUPY= '" + strDatumKupy + "',SERVIS= '" + strServis + "',K_PREVADZKE= '" + (chbKPrevadzke.Checked == true) + "',POZNAMKA= '" + txPoznamka.Text + "' WHERE ID ='" + dgInventar.CurrentRow.Cells[0].Value + "';"
                    , connection);
                }
                else
                {
                    cmd = new SqlCommand(
                    "INSERT INTO INVENTAR (NAZOV,TYP,DATUM_KUPY,SERVIS,K_PREVADZKE,POZNAMKA) " +
                    "VALUES ('" + txNazov.Text + "','" + cbTyp.Text + "','" + strDatumKupy + "','" + strServis + "','" + (chbKPrevadzke.Checked == true) + "','" + txPoznamka.Text + "');"
                    , connection);
                }
                 cmd.ExecuteNonQuery();

                 Prave_Buttony();
                 Refresh_Tabulky();
                 Prvy_Zaznam();
            }
        }

        private void dgInventar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txNazov.Text = tabulky.Tables["txPoznamka_Inventar"].Rows[e.RowIndex][0].ToString();
                cbTyp.Text = tabulky.Tables["txPoznamka_Inventar"].Rows[e.RowIndex][1].ToString();

                if (tabulky.Tables["txPoznamka_Inventar"].Rows[e.RowIndex][2].ToString() == "")
                    dtpDatumKupy.CustomFormat = " ";
                else
                {
                    dtpDatumKupy.Value = Convert.ToDateTime(tabulky.Tables["txPoznamka_Inventar"].Rows[e.RowIndex][2].ToString());
                    dtpDatumKupy.CustomFormat = "dd. MM. yyyy";
                }

                if (tabulky.Tables["txPoznamka_Inventar"].Rows[e.RowIndex][3].ToString() == "")
                    dtpServis.CustomFormat = " ";
               else
                {
                    dtpServis.Value = Convert.ToDateTime(tabulky.Tables["txPoznamka_Inventar"].Rows[e.RowIndex][3].ToString());
                    dtpServis.CustomFormat = "dd. MM. yyyy";
                }

                if (Convert.ToBoolean(tabulky.Tables["txPoznamka_Inventar"].Rows[e.RowIndex][4].ToString()) == true)
                    chbKPrevadzke.Checked = true;
                else
                    chbKPrevadzke.Checked = false;

                txPoznamka.Text = tabulky.Tables["txPoznamka_Inventar"].Rows[e.RowIndex][5].ToString();
            }
        }

        private void chbDatumKupy_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbDatumKupy.Checked == true)
            {
                dtpDatumKupy.Enabled = true;
                dtpDatumKupy.CustomFormat = "dd. MM. yyyy";
            }
            else
            {
                dtpDatumKupy.Enabled = false;
                //dtpDatumKupy.CustomFormat = " ";
                //dtpDatumKupy.CustomFormat = "dd. MM. yyyy";
            }
        }

        private void chbServis_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbServis.Checked == true)
            {
                dtpServis.Enabled = true;
                dtpServis.CustomFormat = "dd. MM. yyyy";
            }
            else
            {
                dtpServis.Enabled = false;
                //dtpServis.CustomFormat = " ";
                //dtpServis.CustomFormat = "dd. MM. yyyy";
            }
        }
 }
}
