using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyAnimal
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=AnimalHobbbyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        void search()
        {
            animalGridView.DataSource = null;
            con.Open();
            cmd = new SqlCommand("Select AnimalName, AnimalType, DOB, AnimalOwner, AnimalOwnerContact from Animal"
                + " where AnimalName like '" + searchtb.Text + "%'");
            cmd.Connection = con;
            ds.Clear();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Animal");
            animalGridView.DataSource = ds.Tables[0];
            con.Close();
        }
        void viewAnimal()
        {
            con.Open();
            cmd = new SqlCommand("select Id, AnimalName, AnimalType, DOB, AnimalOwner, AnimalOwnerContact from Animal");
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "Animal");
            animalGridView.DataSource = ds.Tables[0];
            con.Close();
        }
        void saveAnimal()
        {
            con.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "insert into Animal"
                + "(AnimalName, AnimalType, DOB, AnimalOwner, AnimalOwnerContact)"
                + "values ('" + AName.Text + "','" + AType.Text + "',@animal_dob,'" + OName.Text + "','" + OContact.Text + "')";
            cmd.Parameters.AddWithValue("@animal_dob", DOBTimePicker.Value.Date);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void updateAnimal()
        {
            con.Open();
            cmd = new SqlCommand("UPDATE Animal SET AnimalName = @animal_name, AnimalType = @animal_type, DOB = @animal_dob, AnimalOwner = @animal_owner, AnimalOwnerContact = @animal_owner_contact WHERE Id = @animal_id");
            cmd.Parameters.AddWithValue("@animal_id", AnimalId.Text);
            cmd.Parameters.AddWithValue("@animal_name", AName.Text);
            cmd.Parameters.AddWithValue("@animal_type", AType.Text);
            cmd.Parameters.AddWithValue("@animal_dob", DOBTimePicker.Value.Date);
            cmd.Parameters.AddWithValue("@animal_owner", OName.Text);
            cmd.Parameters.AddWithValue("@animal_owner_contact", OContact.Text);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void deleteAnimal()
        {
            con.Open();
            cmd = new SqlCommand("delete from Animal WHERE Id = @animal_id");
            cmd.Parameters.AddWithValue("@animal_id", AnimalId.Text);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void viewbt_Click(object sender, EventArgs e)
        {
            while (animalGridView.Rows.Count > 0)
            {
                animalGridView.Rows.RemoveAt(0);
            }
            viewAnimal();
        }

        private void searchtb_TextChanged(object sender, EventArgs e)
        {
            while (animalGridView.Rows.Count > 0)
            {
                animalGridView.Rows.RemoveAt(0);
            }
            search();
        }

        private void savebt_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are all entries correct? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                saveAnimal();
                MessageBox.Show("Account is added succesfully!");
                AName.Text = String.Empty;
                AType.Text = String.Empty;
                OName.Text = String.Empty;
                OContact.Text = String.Empty;
                // clearFields();
            }
            else
            {
                MessageBox.Show("Data entry cancelled!");
                // clearFields();
            }
            viewAnimal();
        }

        private void updatebt_Click(object sender, EventArgs e)
        {
            updateAnimal();
            viewAnimal();
            AName.Text = String.Empty;
            AType.Text = String.Empty;
            OName.Text = String.Empty;
            OContact.Text = String.Empty;
            AType.Enabled = true;
        }
          
        private void deletebt_Click(object sender, EventArgs e)
        {
            deleteAnimal();
            AName.Text = String.Empty;
            AType.Text = String.Empty;
            OName.Text = String.Empty;
            OContact.Text = String.Empty;
            viewAnimal();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void animalGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            listView1.Clear();
            AnimalId.Text = animalGridView[0, e.RowIndex].Value.ToString();
            AName.Text = animalGridView[1, e.RowIndex].Value.ToString();
            AType.Text = animalGridView[2, e.RowIndex].Value.ToString();
            DOBTimePicker.Text = animalGridView[3, e.RowIndex].Value.ToString();
            OName.Text = animalGridView[4, e.RowIndex].Value.ToString();
            OContact.Text = animalGridView[5, e.RowIndex].Value.ToString();
            AType.Enabled = false;

            cmd = new SqlCommand("Select Hobbies.HobbyName FROM Hobbies JOIN AnimalHobby ON Hobbies.Id = AnimalHobby.HId WHERE AnimalHobby.AId = @AID", con);
            con.Open();
            cmd.Parameters.AddWithValue("@AID", int.Parse(animalGridView.SelectedRows[0].Cells[0].Value.ToString()));
            listView1.View = View.List;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["HobbyName"].ToString());
                item.SubItems.Add(reader["HobbyName"].ToString());

                listView1.Items.Add(item);
            }
            con.Close();
        }
        
        private void edithobby_Click(object sender, EventArgs e)
        {           
            AnimalHobbies ahobbies = new AnimalHobbies();
            ahobbies.AnimalId2.Text = AnimalId.Text;
            ahobbies.ViewAnimalHobby();
            ahobbies.ViewHobby();
            ahobbies.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Hobbies hobbies = new Hobbies();
            hobbies.ViewHobby();
            hobbies.ShowDialog();
        }

        private void hobbyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}