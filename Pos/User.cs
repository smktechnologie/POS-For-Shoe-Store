﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class User : Form
    {
        string selectedusername = "";
        public User()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void load_data()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=Password@11";
                string Query = "select username,password,isactive,isadmin ,datetime from `pos`.`users` where username like '%" + txtbx_name_search.Text + "%';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dg_users.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=Password@11";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into  `pos`.`users`(username,password,isactive,isadmin,DateTime) values('" + this.txtbx_username.Text + "','" + this.txtbxpassword.Text + "'," + (chkbxactive.Checked ? "1" : "0") + ","
                    + (chkbxisadmin.Checked ? "1" : "0") + ",'" + System.DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.

                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_data();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=Password@11";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "update `pos`.`users` set username='" + txtbx_username.Text + "' ,password = '" + txtbxpassword.Text + "',isactive = " + (chkbxactive.Checked ? "1" : "0") + ",isadmin = " + (chkbxisadmin.Checked ? "1" : "0") + " where username = '" + selectedusername + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.

                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_data();
        }

        private void dg_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgrow = dg_users.Rows[e.RowIndex];
                selectedusername = dgrow.Cells[0].Value.ToString(); ;
                txtbx_username.Text = dgrow.Cells[0].Value.ToString();
                txtbxpassword.Text = dgrow.Cells[1].Value.ToString();
                chkbxactive.Checked = dgrow.Cells[2].Value.ToString() == "1" ? true : false;
                chkbxisadmin.Checked = dgrow.Cells[3].Value.ToString() == "1" ? true : false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=Password@11";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "Delete from `pos`.`users` where username = '" + selectedusername + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.

                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_data();
        }
    }
}
