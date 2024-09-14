using Evaluacion2.clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2
{
    public partial class Form1 : Form
    {
        int index = 0;
        Usuario usu = new Usuario();
        public Form1()
        {
            InitializeComponent();
        }
        //funcionamiento del boton
        private void button1_Click(object sender, EventArgs e)
        {
            string contra, nic;
            if(string.IsNullOrEmpty(tbContra.Text) || string.IsNullOrEmpty(tbNIck.Text))
            {
                //se piden los datos
                MessageBox.Show("Ingrese datos");
            }
            else
            {
                contra= tbContra.Text;
                nic= tbNIck.Text;
                //verifica

                if(usu.Buscar(nic, "nick") == "NO")
                {
                    usu.Agregar(nic, index, "nick");
                    usu.Agregar(contra, index, "CONTRASENNA");
                    index++;

                    lbSalida.Text = "";
                }
                else {
                    if ((usu.Buscar(contra, "CONTRASENNA") == "Contraseña encontrada"))
                    {
                        lbSalida.Text = "Usuario Encontrado " + usu.Buscar(nic, "NIck");
                    }
                    else { lbSalida.Text = "Usuario Encontrado, pero contraseña incorrecta"; } 
                    }
                
            tbContra.Text = "";
            tbNIck.Text = "";
            }
        }
    }
}
