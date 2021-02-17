using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA210203
{
    public partial class FrmMain : Form
    {
        public readonly string connString;

        private int selectedIndex = -1;

        public FrmMain()
        {
            connString =
                @"Server = (localdb)\MSSQLLocalDB;" +
                $"AttachDbFileName = {Program.appData}kozossegiszolgalat.mdf";

            InitializeComponent();

            cbEvismetlo.SelectedIndex = 0;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DgvBetolt();
        }

        private void DgvBetolt()
        {
            dgvTanuloAdatok.Rows.Clear();
            using SqlConnection conn = new(connString);
            conn.Open();
            var r = new SqlCommand("SELECT * FROM gyak_tanulo", conn)
                .ExecuteReader();
            while (r.Read())
                dgvTanuloAdatok.Rows.Add(
                    r[0], r[1], r[2], r[3],
                    r.GetBoolean(4) ? "Igen" : "Nem");
        }

        private void DgvTanuloAdatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = (int)dgvTanuloAdatok.SelectedRows[0].Cells[0].Value;

            #region módosító űrlap
            tbNev.Text = dgvTanuloAdatok.SelectedRows[0].Cells[1].Value.ToString();
            tbEvfolyam.Text = dgvTanuloAdatok.SelectedRows[0].Cells[2].Value.ToString();
            tbOsztaly.Text = dgvTanuloAdatok.SelectedRows[0].Cells[3].Value.ToString();
            cbEvismetlo.SelectedIndex =
                dgvTanuloAdatok.SelectedRows[0].Cells[4].Value.ToString() == "Nem" ? 0 : 1;
            #endregion

            #region összegzés
            rtbMunkak.Clear();
            rtbMunkak.Text = "Szervezetek, ahol teljesített(név, óra):\n";

            using SqlConnection conn = new(connString);

            conn.Open();
            var r = new SqlCommand(
                $"SELECT szervezet, oraszam " +
                $"FROM gyak_munka " +
                $"WHERE tanuloId = {selectedIndex};", conn)
                .ExecuteReader();
            while (r.Read()) rtbMunkak.Text += $"{r[0]} ({r[1]} óra)\n";
            r.Close();

            r = new SqlCommand(
                $"SELECT SUM(oraszam) " +
                $"FROM gyak_munka " +
                $"WHERE tanuloId = {selectedIndex};", conn)
                .ExecuteReader();
            r.Read();
            if (int.TryParse(r[0].ToString(), out int osszOra))
            {
                tbOsszOra.Text = $"{osszOra}";
                tbMegvan50.Text = osszOra == 50 ? "igen" : "nem";
            }
            else
            {
                tbOsszOra.Text = "0";
                tbMegvan50.Text = "nem";
            }
            #endregion
        }

        private void btnUjTanulo_Click(object sender, EventArgs e)
        {
            //másik ablak
            DgvBetolt();
        }

        private void BtnModosit(object sender, EventArgs e)
        {
            using SqlConnection conn = new(connString);

            conn.Open();

            new SqlCommand(
                "UPDATE gyak_tanulo SET " +
                $"nev = '{tbNev.Text}', " +
                $"evfolyam = {tbEvfolyam.Text}, " +
                $"osztaly = '{tbOsztaly.Text}', " +
                $"evismetlo = {cbEvismetlo.SelectedIndex} " +
                $"WHERE id = {selectedIndex}", conn)
                .ExecuteNonQuery();

            DgvBetolt();
        }
    }
}