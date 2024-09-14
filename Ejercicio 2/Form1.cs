using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluacion.clase;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        Alumno[] al = new Alumno[10]; // Arreglo para un tal de 10m alumno.
        int index = 0; // Índice .

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            double not;

            // Entrada
            if (string.IsNullOrEmpty(tbNom.Text) || string.IsNullOrEmpty(tbPuntaje.Text))
            {
                MessageBox.Show("Error de validaciones");
            }
            else
            {
                try
                {
                    nombre = tbNom.Text;
                    not= double.Parse(tbPuntaje.Text);

                    // Entrada del puntaje
                    if (not <= 1000 && not >= 0)
                    {
                        // Verificar que el índice no sobrepase el límite del arreglo
                        if (index < al.Length)
                        {
                            al[index] = new Alumno(nombre, not); 
                            Mostrar(); 
                            index++; 
                        }
                        else
                        {
                            MessageBox.Show("   Ya no se puede agregar lista está llena.");
                        }

                        
                        tbNom.Clear();
                        tbPuntaje.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error de rango");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        // Actualisacion del ListBox
        void Mostrar()
        {
            double promedio = 0;

            // Limpiar ListBox antes de agregar los elementos actualizados
            lbEstudiantes.Items.Clear();

            
            if (index >= 1)
            {
                for (int i = 0; i <= index - 1; i++)
                {
                    for (int j = 0; j <= index - i - 1; j++)
                    {
                        if (al[j].Puntaje < al[j + 1].Puntaje) 
                        {
                            Alumno temp = al[j];
                            al[j] = al[j + 1];
                            al[j + 1] = temp;
                        }
                    }
                }
            }

            // Agregar estudiantes al ListBox 
            for (int i = 0; i <= index; i++)
            {
                lbEstudiantes.Items.Add("Estudiante: " + al[i].Nombre + " - Nota: " + al[i].Puntaje);
                promedio += al[i].Puntaje;
            }

            promedio /= index + 1;

            // Reiniciar los textos 
            lblPrimero.Text = " ";
            lbSegundo.Text = "";
            lbTercero.Text = " ";
            lblPromedio.Text = " " + promedio;

            // Verificar de alumnos 
            if (index >= 0)
                lblPrimero.Text += al[0].Nombre + " " + al[0].Puntaje;

            if (index >= 1)
                lbSegundo.Text += al[1].Nombre + " " + al[1].Puntaje;

            if (index >= 2)
                lbTercero.Text += al[2].Nombre + " " + al[2].Puntaje;
        }
    }
}
