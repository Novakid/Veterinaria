using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Veterinaria
{
    public partial class adminBuscar : Form
    {
        public adminBuscar()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            String enlace = "server=localhost; port=3306; database= bd_veterinaria; uid=root; pwd=''";

            using (MySqlConnection conexion = new MySqlConnection(enlace))
            {
                conexion.Open();

                String consulta = "SELECT Usuario, Nivel, Contrasena FROM usuarios WHERE Usuario LIKE @Buscar OR Nivel = @Buscar";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Buscar", "%" + txtBuscar.Text + "%");

                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        lb1.Items.Clear();

                        while (lector.Read())
                        {
                            String Usuario = lector.GetString("Usuario");
                            String Pass = lector.GetString("Contrasena");
                            int Nivel = lector.GetInt32("Nivel");

                            lb1.Items.Add($"Usuario: {Usuario},Contraseña: {Pass},Nivel: {Nivel}");
                        }
                    }
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
