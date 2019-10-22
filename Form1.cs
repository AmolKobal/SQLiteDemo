using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLiteDemo
{
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection.CreateFile("MyDatabase.sqlite");

                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                m_dbConnection.Open();

                string sql = "if exists(select * from highscores)";

                sql = "create table highscores (name varchar(20), score int)";
                
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();

                sql = "insert into highscores (name, score) values ('Me', 9001)";

                command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();

                m_dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "insert into highscores (name, score) values ('You', 9002)";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            m_dbConnection.Close();

            MessageBox.Show("Added");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");

            string sql = "select * from highscores";

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, m_dbConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds.Tables.Count > 0)
            {
                for (int index = 0; index < ds.Tables[0].Rows.Count; index++)
                {
                    ListViewItem item = listView1.Items.Add(new ListViewItem(ds.Tables[0].Rows[index]["name"].ToString()));
                    item.SubItems.Add(ds.Tables[0].Rows[index]["score"].ToString());
                }
            }
        }
    }
}
