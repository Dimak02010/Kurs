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
    public partial class Enter : Form
    {
        private string log = "admin";
        private string pas = "1234";
        public Enter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LostLogPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Логин: admin \nПароль: 1234");
        }

        private void EnterLog_Click(object sender, EventArgs e)
        {
            string text1 = Login.Text;
            string text2 = Password.Text;
            Base b1 = new Base ();
            Enter e1 = new Enter ();
            if (text1 == log && text2 == pas) { e1.Visible = false; b1.Show();  } else { MessageBox.Show("Неверный логин или пароль"); }
        }
    }
}
