using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Data.SQLite;

namespace Kurs
{
    public partial class ADD : Form
    {
        public ADD()
        {
            InitializeComponent();
        }

        public void Add1_Click(object sender, EventArgs e)
        {
            Base q = new Base();
            if (Data.Value1 == "Time") { MessageBox.Show("Выбран не верный столбец"); this.Close(); }
            else
            {
                using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=DB.db; Version=3;"))
                {
                    if (FIOT.Text == "" || KolT.Text == "") { MessageBox.Show("Введите обязательные поля"); }
                    else
                    {
                        string s = FIOT.Text + " / " + KolT.Text + " / " + PrimT.Text;
                        string commandText = "UPDATE Mounth SET " + Data.Value1 + " = '" + s + "' WHERE Time = '" + Data.Value2 + "'";
                        SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                        Connect.Open();
                        Command.ExecuteNonQuery();
                        Connect.Close();
                    }
                    DataSet ds = new DataSet();
                    string sql = "SELECT * FROM Mounth";
                    try
                    {
                        using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=DB.db; Version=3;"))
                        {
                            using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn))
                            {
                                da.Fill(ds);
                                q.dataGridView1.DataSource = ds.Tables[0].DefaultView;
                            }
                        }
                    }
                    catch (Exception err)
                    {
                    }
                    this.Close();
                }
            }
        }
    }
}
