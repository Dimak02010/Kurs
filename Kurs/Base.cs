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


    public partial class Base : Form
    {

        public Base()
        {
            InitializeComponent();
        }

        private void Base_Load(object sender, EventArgs e)
        {
            //dataGridView1.RowCount = 24;
            //dataGridView1.ColumnCount = 31;
            if (!File.Exists(@"DB.db"))
            {
                SQLiteConnection.CreateFile(@"DB.db"); 
            }
            using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=DB.db; Version=3;"))
            {
                string commandText = "CREATE TABLE IF NOT EXISTS [Mounth] " +
                    "( [Time] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    "[Mon1] STRING, " +
                    "[Tue2] STRING, " +
                    "[Wed3] STRING, " +
                    "[Thu4] STRING, " +
                    "[Fri5] STRING, " +
                    "[Sat6] STRING, " +
                    "[Sun7] STRING, " +
                    "[Mon8] STRING, " +
                    "[Tue9] STRING, " +
                    "[Wed10] STRING, " +
                    "[Thu11] STRING, " +
                    "[Fri12] STRING, " +
                    "[Sat13] STRING, " +
                    "[Sun14] STRING, " +
                    "[Mon15] STRING, " +
                    "[Tue16] STRING, " +
                    "[Wed17] STRING, " +
                    "[Thu18] STRING, " +
                    "[Fri19] STRING, " +
                    "[Sat20] STRING, " +
                    "[Sun21] STRING, " +
                    "[Mon22] STRING, " +
                    "[Tue23] STRING, " +
                    "[Wed24] STRING, " +
                    "[Thu25] STRING, " +
                    "[Fri26] STRING, " +
                    "[Sat27] STRING, " +
                    "[Sun28] STRING, " +
                    "[Mon29] STRING, " +
                    "[Tue30] STRING, " +
                    "[Sun31] STRING) ";
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                
             Connect.Open(); 
                Command.ExecuteNonQuery();
                string commandText1 = "INSERT OR IGNORE INTO Mounth ('Time') VALUES ('0')," +
                    "('1'),('2'),('3'),('4'),('5'),('6'),('7'),('8'),('9'),('10'),('11')," +
                    "('12'),('13'),('14'),('15'),('16'),('17'),('18'),('19'),('20')," +
                    "('21'),('22'),('23'),('24')";
                SQLiteCommand Command1 = new SQLiteCommand(commandText1, Connect);
                Command1.ExecuteNonQuery();
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
                        dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    }
                }
            }
            catch (Exception err)
            {
            }
            

    }
       

        private void Base_FormClosed(object sender, FormClosedEventArgs e)
        {
            Enter e1 = new Enter ();
            e1.Close();
            Environment.Exit(0);
        }
       
        private void Add_Click(object sender, EventArgs e)
        {
            Data.Value1 = dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText;
            Data.Value2 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            ADD a = new ADD();
            a.Show(); 
            

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Data.Value1 = dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText;
            Data.Value2 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            Base q = new Base();
            if (Data.Value1 == "Time") { MessageBox.Show("Выбран не верный столбец");}
            else
            {
                using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=DB.db; Version=3;"))
                {
                    dataGridView1.CurrentCell.Value = "";
                    string s = "";
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
                            dataGridView1.DataSource = ds.Tables[0].DefaultView;
                        }
                    }
                }
                catch (Exception err)
                {
                }
            }
        }

        private void Upgrade_Click(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 1)
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
            DataSet ds = new DataSet();
            string sql = "SELECT * FROM Mounth";
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=DB.db; Version=3;"))
                {
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn))
                    {
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    }
                }
            }
            catch (Exception err)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentCell.Value.ToString();
            string word ="";
            string word1 = "";
            string word2 = "";
            int a = 0;
            for (int j = 0; j < s.Length; j++)
            {
                if (s[j] != '/') { if (a == 0) word += s[j]; else if (a == 1) { word1 += s[j]; } else if (a == 2) { word2 += s[j]; } } else
                {
                    a++;
                }
            }
            IP.ip1 = word;
            IP.ip2 = word1;
            IP.ip3 = word2;
            InfoP i = new InfoP();
            i.Show();
        }
    }
    public static class IP
    {
        public static string ip1 { get; set; }
        public static string ip2 { get; set; }
        public static string ip3 { get; set; }
    }

    public static class Data
    {
        public static string Value1 { get; set; }
        public static string Value2 { get; set; }
    }
}
