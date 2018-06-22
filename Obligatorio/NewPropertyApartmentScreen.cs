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

namespace Obligatorio.Models
{
    public partial class NewPropertyApartmentScreen : Form
    {
        private int habitaciones;
        private int dormitorios;
        private int baños;
        private int año;
        private double metros;
        private string departamento;
        private string ciudad;
        private string barrio;
        private string estado;
        private int garages;
        private string direccion;
        private bool parrillero;
        private bool jardin;
        private int precio;
        private int piso;
        private string comentarios;
        private int gastos;

        public NewPropertyApartmentScreen()
        {
            InitializeComponent();
        }

        private void FormNewProperty_Load(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            estado = cbEstado.SelectedItem.ToString();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            precio = Convert.ToInt32(txtPrecio.Text);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            direccion = txtDireccion.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            using (NewPropertyScreen House = new NewPropertyScreen())
            {
                House.ShowDialog();
                Application.Exit();
            }
        }

        
        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            dormitorios = Convert.ToInt32(txtDormitorio.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            habitaciones = Convert.ToInt32(txtHabitaciones.Text);
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            baños = Convert.ToInt32(txtBaños.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            ciudad = txtCiudad.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            barrio = txtBarrio.Text;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            departamento = txtDepartamento.Text;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            ciudad = txtCiudad.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            piso = Convert.ToInt32(txtNroPiso.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            comentarios = txtComentarios.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            gastos = Convert.ToInt32(txtNroPiso.Text);
        }
        
        private void txtConstruccion_TextChanged(object sender, EventArgs e)
        {
            año = Convert.ToInt32(txtConstruccion.Text);
        }

        private void txtMetros_TextChanged(object sender, EventArgs e)
        {
            metros = Convert.ToDouble(txtMetros.Text);
        }

        private void cbJardin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbJardin.SelectedItem.ToString() == "Si" || cbJardin.SelectedItem.ToString() == "si")
            {
                jardin = true;
            }
            else if (cbJardin.SelectedItem.ToString() == "No" || cbJardin.SelectedItem.ToString() == "no")
            {
                jardin = false;
            }
        }


        private void cbParrillero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbParrillero.SelectedItem.ToString() == "Si" || cbParrillero.SelectedItem.ToString() == "si")
            {
                parrillero = true;
            }
            else if (cbParrillero.SelectedItem.ToString() == "No" || cbParrillero.SelectedItem.ToString() == "no")
            {
                parrillero = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Apartamento apto = new Apartamento
            {
                Precio = precio, //Convert.ToInt32(textBox1),
                Habitaciones = habitaciones,//Convert.ToInt32(textBox6),
                Dormitorios = dormitorios,//Convert.ToInt32(textBox2),
                Baños = baños,//Convert.ToInt32(textBox3),
                AñoConstruccion = año,//Convert.ToInt32(textBox7),
                MetrosCuadrados = metros,//Convert.ToDouble(textBox8),
                Departamento = departamento,//textBox13.Text,
                Ciudad = ciudad,//textBox5.Text,
                Barrio = barrio,//textBox4.Text,
                EstadoFisico = estado,
                Garages = garages, //Convert.ToInt32(textBox12),
                Direccion = direccion, //textBox11.Text,
                Parrillero = parrillero,
                GastosComunes = gastos,
                NroPiso = piso,
                Comentarios = new List<string>(),
            };

            Inmobiliaria.GetInmobiliaria().AgregarPropiedad(apto);
        }
    }
}
