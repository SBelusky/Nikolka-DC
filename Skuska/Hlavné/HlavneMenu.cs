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
    public partial class HlavneMenu : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1I7N9P7\SQLEXPRESS;Initial Catalog=DenneCentrumDB;Integrated Security=True");
        SqlDataAdapter adapter;
        DataSet tabulky = new DataSet();
        string aktivny_uzivatel;

        public HlavneMenu()
        {
            InitializeComponent();
            this.aktivny_uzivatel = Login.aktivny_uzivatel;
        }

        public void Refresh_dg()
        {
            tabulky.Tables["Rozvrh"].Clear();
            adapter.Fill(tabulky, "Rozvrh");

           /* for (int i = 0; i <= tabulky.Tables["Rozvrh"].Rows.Count - 1; i++)
            {
                if (tabulky.Tables["Rozvrh"].Rows[i][5].ToString() == "true")
                    tabulky.Tables["Rozvrh"].Rows[i][5].BackColor = Color.LightGray;
            }*/
        }

        private void HlavneMenu_Load(object sender, EventArgs e)
        {
            connection.Open();
            adapter = new SqlDataAdapter(
            "SELECT MENO_DIETATA,PRIEZVISKO_DIETATA,DATUM_CVICENIA,DLZKA_CVICENIA,POZNAMKA,PREBEHLO FROM CVICENIE where convert(date,DATUM_CVICENIA, 105) = convert(date,getdate(), 105) order by convert(date,DATUM_CVICENIA, 105) desc;"
            , connection);
            adapter.Fill(tabulky, "Rozvrh");

            dgRozvrh.DataSource = tabulky.Tables["Rozvrh"];

            lbAktivnyUzivatel.Text = aktivny_uzivatel;
        }

        private void miPouzivatelia_Click(object sender, EventArgs e)
        {
            Pouzivatelia pouzivatelia = new Pouzivatelia(); 
            pouzivatelia.ShowDialog();
        }

        private void HlavneMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void miInventar_Click(object sender, EventArgs e)
        {
            Inventar inventar = new Inventar();
            inventar.ShowDialog();
        }

        private void miSponzori_Click(object sender, EventArgs e)
        {
            SponzoriAPartneri sponzori_partneri = new SponzoriAPartneri();
            sponzori_partneri.ShowDialog();
        }

        private void zamestnanciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zamestnanci zamestnanci = new Zamestnanci();
            zamestnanci.ShowDialog();
        }

        private void podujatiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Podujatia podujatia = new Podujatia();
            podujatia.ShowDialog();
        }

        private void miZkaznici_Click(object sender, EventArgs e)
        {
            Zakaznici zakaznici = new Zakaznici();
            zakaznici.ShowDialog();
        }

        private void miRozvrh_Click(object sender, EventArgs e)
        {
            Rozvrh rozvrh = new Rozvrh(this);
            rozvrh.ShowDialog();
        }

        private void dgCvicenia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mesačnýVýkazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MesacnyVykaz mesacny_vykaz = new MesacnyVykaz();
            mesacny_vykaz.ShowDialog();
        }

        private void miOsoby_Click(object sender, EventArgs e)
        {
        }

        private void faktúryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Faktury faktura = new Faktury();
            faktura.ShowDialog();
        }
    }
}
