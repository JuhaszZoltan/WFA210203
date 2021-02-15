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

        bool isSCSet = false;

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

            if (!isSCSet)
            {
                isSCSet = true;
                dgvTanuloAdatok.SelectionChanged += DgvSelectionChanged;
            }

        }




        private void DgvSelectionChanged(object sender, EventArgs e)
        {
            selectedIndex = (int)dgvTanuloAdatok.SelectedRows[0].Cells[0].Value;

            tbNev.Text = dgvTanuloAdatok.SelectedRows[0].Cells[1].Value.ToString();
            tbEvfolyam.Text = dgvTanuloAdatok.SelectedRows[0].Cells[2].Value.ToString();
            tbOsztaly.Text = dgvTanuloAdatok.SelectedRows[0].Cells[3].Value.ToString();

            cbEvismetlo.SelectedIndex = 
                dgvTanuloAdatok.SelectedRows[0].Cells[4].Value.ToString() == "Nem" ? 0 : 1;
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
