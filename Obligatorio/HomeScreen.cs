using Obligatorio.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligatorio
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();


            //private void findButton_Click(object sender, System.EventArgs e)
            //{
            //    int index = comboBox1.FindString(textBox2.Text);
            //    comboBox1.SelectedIndex = index;
            //}

            //comboBoxDepartamento.Items.Add("Ciudad de la Costa");
            //comboBoxDepartamento.Items.Add("Las Piedras");
            //comboBoxDepartamento.Items.Add("Maldonado");
            //comboBoxDepartamento.Items.Add("Montevideo");
            //comboBoxDepartamento.Items.Add("Pando");
            //comboBoxDepartamento.Items.Add("Paysandú");
            //comboBoxDepartamento.Items.Add("Piriápolis");
            //comboBoxDepartamento.Items.Add("Punta del Este");
            //comboBoxDepartamento.Items.Add("Rivera");
            //comboBoxDepartamento.Items.Add("Salto");
            //comboBoxDepartamento.Items.Add("Tacuarembó");

            #region ComboBoxDepartamento
            

            List<String> listaDepartamentos = new List<String>
            {
                "Artigas", "Canelones", "Cerro Largo", "Colonia", "Durazno", "Flores", "Florida", "Lavalleja", "Maldonado", "Montevideo",
                "Paysandú", "Río Negro", "Rivera", "Rocha", "Salto", "San José", "Soriano", "Tacuarembó", "Treinta y Tres"
            };

            comboBoxDepartamento.DataSource = listaDepartamentos;
            comboBoxDepartamento.Text = "";

            #endregion
                       
        }

        //private void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    comboBoxBarrio.Items.Clear();
        //    for (int i = 0; i < 5; i++)
        //    {
        //        comboBoxBarrio.Items.Add(String.Format("Item_{0}_{1}",
        //                  comboBoxDepartamento.SelectedItem, i.ToString()));
        //    }
        //    comboBoxBarrio.SelectedIndex = 0;

        //    //switch (((ComboBox)sender).SelectedItem as string)
        //    //{
        //    //    case "Artigas":
        //    //        comboBoxBarrio.SelectedIndex = 1;
        //    //        break;
        //    //    case "Canelones":
        //    //        comboBoxBarrio.SelectedIndex = 2;
        //    //        break;
        //    //}
        //}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxBarrio.Items.Clear();

            #region ComboBoxBarrio
            #region Artigas
            if (comboBoxDepartamento.SelectedItem.ToString() == "Artigas")//comboBoxDepartamento.FindStringExact("Artigas").ToString())
            {
                comboBoxBarrio.Items.Add("Artigas");
                comboBoxBarrio.Items.Add("Bella Unión");
                comboBoxBarrio.Items.Add("Las Piedras");
                comboBoxBarrio.Items.Add("Tomás Gomensoro");
                comboBoxBarrio.Items.Add("Baltasar Brum");
                comboBoxBarrio.Items.Add("Pintadito");
                comboBoxBarrio.Items.Add("Sequeira");
            }
            #endregion
            #region Canelones

            else if (comboBoxDepartamento.SelectedItem.ToString() == "Canelones")
            {
                comboBoxBarrio.Items.Add("Ciudad de la Costa");
                comboBoxBarrio.Items.Add("Las Piedras");
                comboBoxBarrio.Items.Add("Barros Blancos");
                comboBoxBarrio.Items.Add("Pando");
                comboBoxBarrio.Items.Add("La Paz");
                comboBoxBarrio.Items.Add("Canelones");
                comboBoxBarrio.Items.Add("Santa Lucía");
                comboBoxBarrio.Items.Add("Progreso");
                comboBoxBarrio.Items.Add("Villa Crespo y San Andrés");
                comboBoxBarrio.Items.Add("Colonia Nicolich");
                comboBoxBarrio.Items.Add("Salinas");
                comboBoxBarrio.Items.Add("Parque del Plata");
                comboBoxBarrio.Items.Add("San Ramón");
                comboBoxBarrio.Items.Add("Joaquín Suárez");
                comboBoxBarrio.Items.Add("Sauce");
                comboBoxBarrio.Items.Add("Atlántida");
                comboBoxBarrio.Items.Add("Tala");
                comboBoxBarrio.Items.Add("Neptunia");
                comboBoxBarrio.Items.Add("Pinamar - Pinepark");
                comboBoxBarrio.Items.Add("San Jacinto");
                comboBoxBarrio.Items.Add("Toledo");
                comboBoxBarrio.Items.Add("Marindia");
                comboBoxBarrio.Items.Add("Las Toscas");
                comboBoxBarrio.Items.Add("San Luis");
            }
            #endregion
            #region Cerro Largo
            else if (comboBoxDepartamento.SelectedItem.ToString() == "Cerro Largo")
            {
                List<String> listaBarrios = new List<String>
            {
                "Artigas", "Canelones", "Cerro Largo", "Colonia", "Durazno", "Flores", "Florida", "Lavalleja", "Maldonado", "Montevideo",
                "Paysandú", "Río Negro", "Rivera", "Rocha", "Salto", "San José", "Soriano", "Tacuarembó", "Treinta y Tres"
            };

                comboBoxBarrio.DataSource = listaBarrios;
            }
            #endregion

            #endregion
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();            
            using (LaunchScreen ls = new LaunchScreen())
            {
                ls.ShowDialog();
                //Environment.Exit(0);
                Application.Exit();
            }
            //Volver atras
        }
    }
}
