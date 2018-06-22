using Obligatorio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligatorio.Forms
{
    public partial class NewPropertyScreen : Form
    {
        public NewPropertyScreen()
        {
            InitializeComponent();
        }

        private void btnApartment_Click(object sender, EventArgs e)
        {
            Hide();
            using (NewPropertyApartmentScreen Apartment = new NewPropertyApartmentScreen())
            {
                Apartment.ShowDialog();
                //Environment.Exit(0);
                Application.Exit();
            }
        }

        private void btnhouse_Click(object sender, EventArgs e)
        {
            Hide();
            using (NewPropertyHouseScreen House = new NewPropertyHouseScreen())
            {
                House.ShowDialog();
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            using (LaunchScreen Home = new LaunchScreen())
            {
                Home.ShowDialog();
                Application.Exit();
            }
        }
    }
}
