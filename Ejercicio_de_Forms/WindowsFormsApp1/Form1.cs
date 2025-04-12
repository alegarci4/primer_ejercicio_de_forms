using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Clases;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Crud miCrud = new Crud();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSaludar_Click(object sender, EventArgs e)
        {
            string saludo = "Hola {textBoxNombre.Text} tesaludo desde el formulario";
            MessageBox.Show(saludo,"Hola holaaaaaaa");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = miCrud.MostrarInformacion(textBoxCarnet.Text);
            textBoxSeccion.Text= miCrud.MostrarInformacionSeccion(textBoxCarnet.Text);
            textBoxCorreo.Text= miCrud.MostrarInformacionCorreo(textBoxCarnet.Text);
            
            
        }

        private void buttonNotas_Click(object sender, EventArgs e)
        {
            textBoxnota1.Text = miCrud.MostrarNotas(textBoxCarnet.Text);
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text;
            string nombre = textBoxNombre.Text;
            string seccion = textBoxSeccion.Text;
            string email = textBoxCorreo.Text;
            int resultado = miCrud.AgregarAlumno(carnet, nombre, seccion, email);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
