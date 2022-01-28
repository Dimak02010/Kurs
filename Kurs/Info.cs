using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class InfoP : Form
    {
        public InfoP()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            Base b = new Base();
            FIOinp.Text = IP.ip1;
            KOLinp.Text = IP.ip2;
            Priminp.Text = IP.ip3;
        }
    }
}
