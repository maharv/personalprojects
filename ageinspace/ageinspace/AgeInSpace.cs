using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ageinspace
{
    public partial class AgeInSpace : Form
    {
        public AgeInSpace()
        {
            InitializeComponent();
            this.Text = "Your Age In Space";
        }

        private void cboPlanets_SelectedIndexChanged(object sender, EventArgs e)
        {
            planetValue.Text = cboPlanets.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userAgeValue;
            double finalAge;
            string planetEarthDays;
            int ageInEarthDays;

            planetEarthDays = cboPlanets.SelectedValue.ToString();
            double.TryParse(planetEarthDays, out double numberPlanetEarthDays);
            userAgeValue = Convert.ToInt32(userAge.Text);
            ageInEarthDays = userAgeValue * 365;
            finalAge = ageInEarthDays / numberPlanetEarthDays;
            Math.Round(finalAge, 2).ToString();
            lblFinalAge.Text = Math.Round(finalAge, 2).ToString();
            
           
            
         
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Planets> List = new List<Planets>();
            List.Add (new Planets() {ID = 88, Name="Mercury"});
            List.Add(new Planets() { ID = 225, Name = "Venus" });
            List.Add(new Planets() { ID = 365, Name = "Earth" });
            List.Add(new Planets() { ID = 678, Name = "Mars" });
            List.Add(new Planets() { ID = 4380, Name = "Jupiter" });
            List.Add(new Planets() { ID = 10950, Name = "Saturn" });
            List.Add(new Planets() { ID = 30660, Name = "Uranus" });
            List.Add(new Planets() { ID = 60225, Name = "Neptune" });
            cboPlanets.DataSource = List;
            cboPlanets.ValueMember = "ID";
            cboPlanets.DisplayMember = "Name";

        }

        private void cboPlanets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Planets obj = cboPlanets.SelectedItem as Planets;
            if (obj != null)
                MessageBox.Show(string.Format("Days planet takes to revolve around sun = {0}, Planet name = {1}" ,obj.ID, obj.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information));
            

        }
    }
}
