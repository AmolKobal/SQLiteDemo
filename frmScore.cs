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
    public partial class frmScores : Form
    {
        public frmScores()
        {
            InitializeComponent();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection();
            string sql;

            try
            {
                LoadScoreDetails();

                MessageBox.Show("Connected to Database successfuly!");
            }
            catch (Exception ex)
            {
                try
                {
                    sql = "create table highscores (name varchar(20), score int)";
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                }
                catch
                {
                }
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "insert into highscores (name, score) values ('" + txtName.Text + "', '" + txtScore.Text + "')";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            m_dbConnection.Close();

            MessageBox.Show("Added");

            LoadScoreDetails();

            txtName.Text = "";
            txtScore.Text = "";
            txtName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadScoreDetails();
        }

        private void LoadScoreDetails()
        {
            lstScore.Items.Clear();

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");

            string sql = "select * from highscores";

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, m_dbConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds.Tables.Count > 0)
            {
                for (int index = 0; index < ds.Tables[0].Rows.Count; index++)
                {
                    ListViewItem item = lstScore.Items.Add(new ListViewItem(ds.Tables[0].Rows[index]["name"].ToString()));
                    item.SubItems.Add(ds.Tables[0].Rows[index]["score"].ToString());
                }
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if(lstScore.SelectedItems.Count < 1)
            {
                MessageBox.Show("Select Record to remove.");
                return;
            }

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();

            string name = lstScore.SelectedItems[0].SubItems[0].Text;
            string score = lstScore.SelectedItems[0].SubItems[1].Text;

            string sql = "Delete from highscores where name = '" + name + "' and score = '" + score + "'";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            m_dbConnection.Close();

            MessageBox.Show("Removed");

            LoadScoreDetails();
        }
    }
}
