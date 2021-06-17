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
    public partial class MesacnyVykaz : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1I7N9P7\SQLEXPRESS;Initial Catalog=DenneCentrumDB;Integrated Security=True");
        SqlDataAdapter adapter, all_adapter;
        SqlCommand cmd;
        DataSet tabulky = new DataSet();
        Boolean edit = false;

        public MesacnyVykaz()
        {
            InitializeComponent();
        }

        public void Povinne_Udaje()
        {
            dtpMesiac.BackColor = Color.Gold;
        }

        public void Prvy_Zaznam()
        {
            dtpMesiac.CustomFormat = "yyyyMM";

            dtpMesiac.Value = DateTime.ParseExact(dgMesacnyVykaz.Rows[0].Cells[0].Value.ToString(), "yyyyMM", null); 
            txNajom.Text = tabulky.Tables["All_Mesacny_Vykaz"].Rows[0][1].ToString(); 

            if (Convert.ToBoolean(tabulky.Tables["All_Mesacny_Vykaz"].Rows[0][2].ToString()) == true)
                chbNajomZaplatene.Checked = true;

            txOdvody.Text = tabulky.Tables["All_Mesacny_Vykaz"].Rows[0][3].ToString(); ;

            if (Convert.ToBoolean(tabulky.Tables["All_Mesacny_Vykaz"].Rows[0][4].ToString()) == true)
                chbOdvodyZaplatene.Checked = true;

            txCelkovoCviceni.Text = tabulky.Tables["All_Mesacny_Vykaz"].Rows[0][5].ToString();
            txVyzbieranePeniaze.Text = tabulky.Tables["All_Mesacny_Vykaz"].Rows[0][6].ToString();

            dtpMesiac.Enabled = false;
            txNajom.ReadOnly = true;
            chbNajomZaplatene.Enabled = false;
            txOdvody.ReadOnly = true;
            chbOdvodyZaplatene.Enabled = false;
            txCelkovoCviceni.ReadOnly = true;
            txVyzbieranePeniaze.ReadOnly = true;

            btUlozit.Enabled = false;
            btZrusit.Enabled = false;
            btUpdate.Enabled = false;
        }

        public void Lave_Buttony(int i)
        {
            dtpMesiac.Enabled = true;
            txNajom.ReadOnly = false;
            chbNajomZaplatene.Enabled = true;
            txOdvody.ReadOnly = false;
            chbOdvodyZaplatene.Enabled = true;
            txCelkovoCviceni.ReadOnly = true;
            txVyzbieranePeniaze.ReadOnly = true;

            btPridat.Enabled = false;
            btZmazat.Enabled = false;
            btEditovat.Enabled = false;
            btUlozit.Enabled = true;
            btZrusit.Enabled = true;
            btUpdate.Enabled = true;
            dgMesacnyVykaz.Enabled = false;

            if (i != 1)
            {
                dtpMesiac.Value = DateTime.Now;
                txNajom.Text = "";
                chbNajomZaplatene.Checked = false;
                txOdvody.Text = "";
                chbOdvodyZaplatene.Checked = false;
                txCelkovoCviceni.Text = "";
                txVyzbieranePeniaze.Text = "";

                btUpdate.Enabled = false;
            }

            dgMesacnyVykaz.ForeColor = Color.Gray;
            dgMesacnyVykaz.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
        }

        public void Prave_Buttony()
        {
            btUlozit.Enabled = false;
            btZrusit.Enabled = false;
            btPridat.Enabled = true;
            btEditovat.Enabled = true;
            btZmazat.Enabled = true;
            dgMesacnyVykaz.Enabled = true;

            dtpMesiac.BackColor = Color.White;
            dgMesacnyVykaz.ForeColor = Color.Black;
            dgMesacnyVykaz.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        public void Refresh_Tabulky()
        {
            tabulky.Tables["Mesacny_Vykaz"].Clear();
            adapter.Fill(tabulky, "Mesacny_Vykaz");
 
            for (int i = 0; i <= tabulky.Tables["Mesacny_Vykaz"].Rows.Count - 1; i++)
            {
            if (i % 2 == 0)
                dgMesacnyVykaz.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
            }
            
            tabulky.Tables["All_Mesacny_Vykaz"].Clear();
            all_adapter.Fill(tabulky, "All_Mesacny_Vykaz");
        }

        private void MesacnyVykaz_Load(object sender, EventArgs e)
        {
            connection.Open();
            adapter = new SqlDataAdapter("SELECT MESIAC,NAJOM,ODVODY,CVICENI_CELKOVO FROM MESACNY_VYKAZ ORDER BY MESIAC DESC", connection);
            adapter.Fill(tabulky, "Mesacny_Vykaz");

            all_adapter = new SqlDataAdapter("SELECT MESIAC,NAJOM,NAJOM_ZAPLATENE,ODVODY,ODVODY_ZAPLATENE,CVICENI_CELKOVO, VYZBIERANE_PENIAZE_CELKOVO FROM MESACNY_VYKAZ ORDER BY MESIAC DESC", connection);
            all_adapter.Fill(tabulky, "All_Mesacny_Vykaz");

            dgMesacnyVykaz.DataSource = tabulky.Tables["Mesacny_Vykaz"];

            dtpMesiac.Format = DateTimePickerFormat.Custom;
            dtpMesiac.CustomFormat = "yyyyMM";

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
                cmd = new SqlCommand("DELETE FROM MESACNY_VYKAZ WHERE MESIAC= '" + dgMesacnyVykaz.CurrentRow.Cells[0].Value + "'", connection);
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
            string strMesiac = dtpMesiac.Value.ToString("yyyyMM");

            for (int i = 0; i <= tabulky.Tables["Mesacny_Vykaz"].Rows.Count - 1; i++)
            {
                if (strMesiac == tabulky.Tables["Mesacny_Vykaz"].Rows[i][0].ToString() && edit == false)
                {
                    result = MessageBox.Show("Mesačný výkaz pre daný mesiac " + strMesiac + " už existuje", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (edit == true)
            {
                int index = dgMesacnyVykaz.CurrentRow.Index;
                cmd = new SqlCommand(
                "UPDATE MESACNY_VYKAZ SET MESIAC= '" + strMesiac + "',NAJOM= '" + txNajom.Text + "',NAJOM_ZAPLATENE= '" + (chbNajomZaplatene.Checked == true) + "',ODVODY= '" + txOdvody.Text + "',ODVODY_ZAPLATENE= '" + (chbOdvodyZaplatene.Checked == true) + "',CVICENI_CELKOVO= '" + txCelkovoCviceni.Text + "',VYZBIERANE_PENIAZE_CELKOVO= '" + txVyzbieranePeniaze.Text + "' WHERE MESIAC ='" + tabulky.Tables["All_Mesacny_Vykaz"].Rows[index][0] + "';"
                , connection);
            }
            else
            {
                cmd = new SqlCommand(
                "INSERT INTO MESACNY_VYKAZ (MESIAC,NAJOM,NAJOM_ZAPLATENE,ODVODY,ODVODY_ZAPLATENE,CVICENI_CELKOVO,VYZBIERANE_PENIAZE_CELKOVO) " +
                "VALUES ('" + strMesiac + "','" + txNajom.Text + "','" + (chbNajomZaplatene.Checked == true) + "','" + txOdvody.Text + "','" + (chbOdvodyZaplatene.Checked == true) + "','" + txCelkovoCviceni.Text + "','" + txVyzbieranePeniaze.Text + "');"
                , connection);
            }
                cmd.ExecuteNonQuery();

                Prave_Buttony();
                Refresh_Tabulky();
                Prvy_Zaznam();
            
        }
              
        private void dgMesacnyVykaz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dtpMesiac.Value = DateTime.ParseExact(tabulky.Tables["All_Mesacny_Vykaz"].Rows[e.RowIndex][0].ToString(), "yyyyMM", null);
                txNajom.Text = tabulky.Tables["All_Mesacny_Vykaz"].Rows[e.RowIndex][1].ToString();

                if (Convert.ToBoolean(tabulky.Tables["All_Mesacny_Vykaz"].Rows[e.RowIndex][2].ToString()) == true)
                    chbNajomZaplatene.Checked = true;
                else
                    chbNajomZaplatene.Checked = false;

                txOdvody.Text = tabulky.Tables["All_Mesacny_Vykaz"].Rows[e.RowIndex][3].ToString();

                if (Convert.ToBoolean(tabulky.Tables["All_Mesacny_Vykaz"].Rows[e.RowIndex][4].ToString()) == true)
                    chbOdvodyZaplatene.Checked = true;
                else
                    chbOdvodyZaplatene.Checked = false;

                txCelkovoCviceni.Text = tabulky.Tables["All_Mesacny_Vykaz"].Rows[e.RowIndex][5].ToString();
                txVyzbieranePeniaze.Text = tabulky.Tables["All_Mesacny_Vykaz"].Rows[e.RowIndex][6].ToString();
            }
        }

    }
}
