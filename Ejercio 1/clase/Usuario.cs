using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2.clase
{
    //se inicializa una clase
    internal class Usuario
    {
        string[] Nick = new string[100];
        string[] Contrasenna = new string[100];

        public void Agregar (string st, int i, string tipo)
        {
            //Para agregar usuarios y la contrase;a
            if (tipo== "CONTRASEÑA")
            {
                Contrasenna[i]= st;
            }
            else
            {
                Nick[i]= st;
            }
        }

        public string Buscar (string st, string tipo)
        {
            //busca por usuario, si el usuario ya esta se notifica, pero si la contraseña no coincide notifica
            if (tipo == "CONTRASENNA")
            {
                for(int i = 0; i < Contrasenna.Length; i++)
                {
                    if (st == Contrasenna[i])
                    {
                        return "Contraseña encontrada";
                    }
                }
                return "NO";
            }
            else
            {
                for (int i = 0; i < Nick.Length; i++)
                {
                    if (st == Nick[i])
                    {
                        return Nick[i];
                    }
                }
                return "NO";
            }
        }
    }
}
