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
    public partial class Creacion : Form
    {
        public Creacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            //Establecemos la conexión y la almacenamos en una variable.
            String enlace = "server=localhost; port=3306; database=bd_veterinaria; uid=root; pwd=''";
            //Abrimos una nueva conexión con los datos almacenados anteriormente. 
            using (MySqlConnection conectar = new MySqlConnection(enlace))
            {
                conectar.Open();//Abrimos la BD

                //Hacemos la comparación de datos de la contraseña.
                if(txtCrearContra.Text != txtCompararContra.Text)
                {
                    MessageBox.Show("La contraseña no es igual. Por favor, verifique que sean iguales.");
                        return;
                }
                //Conseguimos los datos de los radioButton.
                int nivel = 0;
                if (rb1.Checked)
                {
                    nivel = 1;
                }
                else if (rb2.Checked)
                {
                    nivel = 2;
                }

                //Creamos nuestra consulta para ingresar un nuevo usuario a la Base de Datos
                String creacion = "INSERT INTO usuarios (Usuario, Contrasena, Nivel) VALUES (@Usuario, @Contrasena, @Nivel)";
                
                //Utilizando el comando MySqlCommand haremos los ingresos de datos.
                using (MySqlCommand crear = new MySqlCommand(creacion, conectar))
                {
                    //Extraemos los datos de los TextBox
                    crear.Parameters.AddWithValue("@Usuario", txtCrearUsuario.Text);
                    crear.Parameters.AddWithValue("@Contrasena", txtCrearContra.Text);
                    //Extraemos el valor de nivel que se checo en la sentencia if.
                    crear.Parameters.AddWithValue("@Nivel", nivel);

                    //Checamos si afectaron filas con ExecuteNonQuery, nos deberia regresar 0
                    //Al ser un Insert no debería darnos un valor más que 0.
                    int Check = crear.ExecuteNonQuery();

                    if (Check > 0)
                    {
                        lblResultado.Text = "Ingreso de datos Exitosa";
                        lblResultado.ForeColor = Color.Green;

                        txtCrearUsuario.Clear();
                        txtCrearContra.Clear();
                        txtCompararContra.Clear();
                    }
                    else
                    {
                        lblResultado.Text = "Error al ingresar los datos";
                        lblResultado.ForeColor = Color.Red;

                        txtCrearUsuario.Clear();
                        txtCrearContra.Clear();
                        txtCompararContra.Clear();
                    }
                }
            }
        }
    }
}
