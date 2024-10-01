using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Contracts;
using System.Security.AccessControl;
using System.Xml.Linq;


namespace MyAnimal
{
    public partial class AnimalHobbies : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=AnimalHobbbyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd, cmd1;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        public AnimalHobbies()
        {
            InitializeComponent();
  
        }

        private void hobbyGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }  

        private void label9_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }
      
        public void ViewHobby()
        {
            con.Open();
            cmd = new SqlCommand("select Id, HobbyName from Hobbies WHERE Id NOT IN (SELECT HId FROM AnimalHobby WHERE AId = @AId)", con);
            cmd.Connection = con;
            int id = Convert.ToInt32(AnimalId2.Text);
            cmd.Parameters.AddWithValue("@Aid", id);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            //ds.Clear();
            da.Fill(dt);
            hobbyGridView.DataSource = dt;
            con.Close();
        }
        void addHobby()
        {
            int hobbyid = int.Parse(HobbyId.Text);
            int animalid = int.Parse(AnimalId2.Text);

            con.Open();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO AnimalHobby (HId, AID) VALUES (@hid, @aid)", con))
            {
                cmd.Parameters.AddWithValue("@hid", hobbyid);
                cmd.Parameters.AddWithValue("@aid", animalid);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        void delHobby()
        {
            con.Open();
            cmd = new SqlCommand("delete from AnimalHobby WHERE HId = @hobby_id");
            cmd.Parameters.AddWithValue("@hobby_id", hobbyId2.Text);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void ViewAnimalHobby()
        {
            int id = int.Parse(AnimalId2.Text);
            con.Open();
            cmd1 = new SqlCommand("SELECT Hobbies.* FROM Hobbies INNER JOIN AnimalHobby  ON Hobbies.Id = AnimalHobby.HId WHERE AnimalHobby.AId = "+id);
            cmd1.Connection = con;
            da = new SqlDataAdapter(cmd1);
            ds1.Clear();
            da.Fill(ds1, "Hobbies");
            animalHobbiesDataGrid.DataSource = ds1.Tables[0];
            con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            while (hobbyGridView.Rows.Count > 0)
            {
                hobbyGridView.Rows.RemoveAt(0);
            }
            ViewHobby();
        }
      
        private void label1_Click(object sender, EventArgs e)
        {
            ViewAnimalHobby();
        }

        private void hobbyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addbt_Click(object sender, EventArgs e)
        {
            addHobby();
            ViewAnimalHobby();
            ViewHobby();
            HobbyId.Text = String.Empty;
        }

        private void hobbyGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            HobbyId.Text = hobbyGridView[0, e.RowIndex].Value.ToString();
        }

        private void delbt_Click(object sender, EventArgs e)
        {
            delHobby();
            ViewAnimalHobby();
            ViewHobby();
            HobbyId.Text = String.Empty;
        }

        private void animalHobbiesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void savehubbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void animalHobbiesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hobbyId2.Text = animalHobbiesDataGrid[0, e.RowIndex].Value.ToString();
        }

        private void hobbyGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
