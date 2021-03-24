using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login2
{
    public partial class Form2 : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-245O333\\MSSQLSERVER01; Initial Catalog=Login1; Integrated Security=true;");
        SqlCommand comando;
        Estudiantes user = new Estudiantes();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            user.nombre = txtNombre.Text;
            user.matricula = int.Parse(txtMatri.Text);
            user.edad = int.Parse(txtEdad.Text);
            user.carrera = txtCarrera.Text;
            user.pais = txtPais.Text;
            Guardar();
            Leer();
        }

        public void Guardar()
        {
            try
            {
                //Abrir conexion
                conexion.Open();

                //Crear comando
                comando = new SqlCommand($"insert into Infoestudiantes values('{user.nombre}', '{user.matricula}', '{user.edad}', '{user.carrera}', '{user.pais}')", conexion);

                //Ejecutar el comando
                comando.ExecuteNonQuery();

                //Cerrar la conexion
                conexion.Close();

                MessageBox.Show("Datos guardados correctamente...");
            }
            catch (Exception error)
            {
                MessageBox.Show("Es tan dificil completar la informacion?...");
            }
        }

        public void Leer()
        {
            //Abrir conexion
            conexion.Open();

            //Crear comando
            comando = new SqlCommand($"select * from Infoestudiantes", conexion);

            //Ejecutar el comando
            comando.ExecuteNonQuery();

            DataTable tabla = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(tabla);
            dataGridView1.DataSource = tabla;

            //Cerrar la conexion
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 ff = new Form3();
            ff.lblPais.Text = "Pais de origen: "+txtPais.Text;
            this.Hide();
            ff.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cambio = "UPDATE Infoestudiantes SET Nombre=@nombre , Matricula=@matricula , Edad=@edad , Carrera=@carrera , Pais=@pais WHERE ID=@ID";
            conexion.Open();
            SqlCommand comando = new SqlCommand(cambio, conexion);
            comando.Parameters.AddWithValue("@nombre", txtNombre);
            comando.Parameters.AddWithValue("@matricula", txtMatri);
            comando.Parameters.AddWithValue("@edad", txtEdad);
            comando.Parameters.AddWithValue("@carrera", txtCarrera);
            comando.Parameters.AddWithValue("@pais", txtPais);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Informacion Actualizada...");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Leer();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string borrar = "DELETE FROM Infoestudiantes where Nombre=@nombre";
            conexion.Open();
            SqlCommand comando = new SqlCommand(borrar, conexion);
            comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Estudiante eliminado");
        }
    }
}
