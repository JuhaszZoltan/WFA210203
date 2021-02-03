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

        public FrmMain()
        {
            connString =
                @"Server = (localdb)\MSSQLLocalDB;" +
                $"AttachDbFileName = {Program.appData}kozossegiszolgalat.mdf";
            InitializeComponent();
        }

    }
}
