using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicacalificada1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        static private string cadena = "server=dataepis.uandina.pe,49157;Database=BDAcademicoGamarra;Uid=gamarrae;pwd=vacaconcaca123";
        static private SqlConnection conexion = new SqlConnection(cadena);

        private void Listar()
        {
            SqlCommand comando = new SqlCommand("spListarT", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgvTAlumnos.DataSource = tabla;
        }

        private void spEliminarT_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand("spEliminarT", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@CodAlumno", txtCodAlumno.Text);

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Alumno eliminado correctamente.");
                Listar(); // Refrescar tabla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
                conexion.Close();
            }
        }

        private void spListarT_Click(object sender, EventArgs e)
        {
          
        }

        private void spActualizarT_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand("spActualizarT", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@CodAlumno", txtCodAlumno.Text);
                comando.Parameters.AddWithValue("@APaterno", txtAPaterno.Text);
                comando.Parameters.AddWithValue("@AMaterno", txtAMaterno.Text);
                comando.Parameters.AddWithValue("@Nombres", txtNombres.Text);
                comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@CodCarrera", txtCodCarrera.Text);

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Alumno actualizado correctamente.");
                Listar(); // Refrescar la tabla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
                conexion.Close();
            }
        }

        private void spAgregarT_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand("spAgregarT", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@CodAlumno", txtCodAlumno.Text);
                comando.Parameters.AddWithValue("@APaterno", txtAPaterno.Text);
                comando.Parameters.AddWithValue("@AMaterno", txtAMaterno.Text);
                comando.Parameters.AddWithValue("@Nombres", txtNombres.Text);
                comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@CodCarrera", txtCodCarrera.Text);

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Alumno agregado correctamente.");
                Listar(); // Actualizar la tabla en pantalla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
                conexion.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
