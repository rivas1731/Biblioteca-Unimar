using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Unimar
{
    public partial class formRegistro : Form
    {
        public formRegistro()
        {
            InitializeComponent();
        }
        String nombre;
        String apellido;
        String cedula;
        String carrera;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            apellido = textBox2.Text;
            cedula = textBox3.Text;
            carrera = comboBox1.Text;
            Alumnos alumno = new Alumnos(nombre, apellido, cedula, carrera);
            MessageBox.Show("Alumno registrado con éxito", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Validacion de texto nombre
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Sólo se permiten letras", "Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
        //Validacion de texto apellido
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
        //Validacion de numeros cedula
        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void volvermenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
