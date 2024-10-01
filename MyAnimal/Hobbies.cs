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
using System.Diagnostics.Contracts;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace MyAnimal
{
    public partial class Hobbies : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=AnimalHobbbyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public Hobbies()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteHobby();
            ViewHobby();
            savehubbt.Text = String.Empty;
        }
        public void ViewHobby()
        {
            con.Open();
            cmd = new SqlCommand("select Id, HobbyName from Hobbies");
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "Hobbies");
            hobbyGridView.DataSource = ds.Tables[0];
            con.Close();
        }

        void saveHobby()
        {
            con.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "insert into Hobbies"
            + "(HobbyName)"
            + "values ('" + HName.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        void deleteHobby()
        {
            con.Open();
            cmd = new SqlCommand("delete from Hobbies WHERE Id = @hobbies_id");
            cmd.Parameters.AddWithValue("@hobbies_id", HId.Text);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void savehubbt_Click(object sender, EventArgs e)
        {
            saveHobby();
            ViewHobby();
            savehubbt.Text = String.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            while (hobbyGridView.Rows.Count > 0)
            {
                hobbyGridView.Rows.RemoveAt(0);
            }
            ViewHobby();
            savehubbt.Text = String.Empty;
        }
        private void hobbyGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HId.Text = hobbyGridView[0, e.RowIndex].Value.ToString();
            HName.Text = hobbyGridView[1, e.RowIndex].Value.ToString();     
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
