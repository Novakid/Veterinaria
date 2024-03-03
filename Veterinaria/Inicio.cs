using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Veterinaria
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCrearUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Creacion crearUsuario = new Creacion();

            crearUsuario.ShowDialog();

        }

        MySqlConnection conexion = new MySqlConnection("server=localhost; port=3306; database=bd_veterinaria; uid=root; pwd=''");

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                //Utilizaremos la libreria MySql.Data.MySqlClient para poder conectarnos a MySQL
                //Con dicha libreria nos dejara utilizar MySqlCommand y MySqlDataReader
                //Importante diferenciar entre System.MySql.Client y MySql.Data.MySqlqClient
                MySqlCommand comando = new MySqlCommand("SELECT nivel FROM usuarios WHERE usuario = @Usuario AND contrasena = @Contrasena", conexion);
                comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@Contrasena", txtContra.Text);

                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    
                    int nivelUsuario = lector.GetInt32(0);
                    lector.Close();
                    
                    if (nivelUsuario == 1)
                    { 

                    }
                    else if (nivelUsuario == 2)
                    {
                        Creacion nuevo = new Creacion();
                        nuevo.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Credenciales inválidas. Por favor, inténtalo de nuevo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
