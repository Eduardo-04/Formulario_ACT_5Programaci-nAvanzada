using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Formulario_ACT_5ProgramaciónAvanzada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombres = textBox1.Text;
            string apellidos = textBox2.Text;
            string estatura = textBox3.Text;
            string edad = textBox4.Text;
            string telefono = textBox5.Text;

            //Obtener el genero seleccionado 
            string genero = "";
            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }
            //Crear una cadena con los datos

            string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nTelefono:{telefono} kg\r\nEsatura: {estatura} cm\r\nEdad: {edad} años\r\nGenero: {genero}";

            //Guardar datos en un archivo de texto
            string rutaArchivo = "C:\\Users\\Eduardo\\Documents\\datos3.txt";
            File.WriteAllText(rutaArchivo, datos);

            //Verificar si el achivo ya existe
            bool archivoExiste = File.Exists(rutaArchivo);
            //Verificar si el el archcivo ya existe 
            bool archivoExistes = File.Exists(rutaArchivo);
            if (archivoExistes == false)
            {
                File.WriteAllText(rutaArchivo, datos);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                {
                    if (archivoExistes == true)
                    {
                        writer.WriteLine(datos);

                    }

                    //Mostrar un mensaje con los datos capturados
                    MessageBox.Show("Datos guardados con exito:\n\n" + datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
                {
                    //Limpiar los controles después de guardar
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    rbHombre.Checked = false;
                    rbMujer.Checked = false;
                }
            }
        }
