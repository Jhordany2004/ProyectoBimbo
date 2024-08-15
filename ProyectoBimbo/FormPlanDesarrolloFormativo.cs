using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBimbo
{
    public partial class FormPlanDesarrolloFormativo : Form
    {
        private readonly string cadenaConexion = "Data Source=.;Initial Catalog=bdProyectoBimbo;Integrated Security=True;";
        private NecesidadesFormativasLogica necesidadesFormativasLogica;
        private logCronograma cronogramaLogica;
        private logPlanDesarrolloFormativo planDesarrolloFormativoLogica;
        private PlanDesarrolloFormativo planDesarrolloFormativo;
        private entCronograma cronograma;
        public FormPlanDesarrolloFormativo()
        {
            InitializeComponent();
            planDesarrolloFormativoLogica = new logPlanDesarrolloFormativo();
            planDesarrolloFormativo = new PlanDesarrolloFormativo();
            necesidadesFormativasLogica = new NecesidadesFormativasLogica();
            cronogramaLogica = new logCronograma();
            cronograma = new entCronograma();
        }
        private void CargarPlanDesarrollo()
        {
            listadoPlanDesarrollo.DataSource = planDesarrolloFormativoLogica.LeerPlanDesarrolloFormativo();
        }

        private void CargarComboCronograma()
        {
            // Obtener la lista de categorías desde la lógica de negocios
            List<entCronograma> cronograma = cronogramaLogica.LeerCronograma();

            // Mostrar la lista en el ComboBox
            comboCronograma.DataSource = cronograma;
            comboCronograma.DisplayMember = "Titulo"; // Ajusta esto según la propiedad que represente el nombre de la categoría
            comboCronograma.ValueMember = "idCronograma"; // Ajusta esto según la propiedad que represente el ID de la categoría
        }

        private void CargarComboNecesidades()
        {
            // Obtener la lista de categorías desde la lógica de negocios
            List<NecesidadesFormativas> necesidades = necesidadesFormativasLogica.LeerNecesidadesFormativas();

            // Mostrar la lista en el ComboBox
            comboNecesidades.DataSource = necesidades;
            comboNecesidades.DisplayMember = "Necesidades"; // Ajusta esto según la propiedad que represente el nombre de la categoría
            comboNecesidades.ValueMember = "idNecesidadesFormativas"; // Ajusta esto según la propiedad que represente el ID de la categoría
        }
        private void btnVerificarCronograma_Click(object sender, EventArgs e)
        {
            // Obtener el título del cronograma desde el TextBox
            string tituloCronograma = txtTituloCronograma.Text;

            // Realizar la consulta SQL para verificar la existencia del título
            string consulta = $"SELECT * FROM Cronograma WHERE Titulo = '{tituloCronograma}'";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    // Ejecutar la consulta
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Si hay filas en el resultado, mostrar en el DataGridView
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        // Si no hay filas, mostrar un mensaje indicando que no se encontró
                        MessageBox.Show("Cronograma no encontrado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que pueda ocurrir durante la consulta
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void btnVerificarNecesidadesFormativas_Click(object sender, EventArgs e)
        {
            // Obtener el título del cronograma desde el TextBox
            string Necesidades = txtNecesidades.Text;

            // Realizar la consulta SQL para verificar la existencia del título
            string consulta = $"SELECT * FROM NecesidadesFormativas WHERE Necesidades = '{Necesidades}'";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    // Ejecutar la consulta
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Si hay filas en el resultado, mostrar en el DataGridView
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView2.DataSource = dataTable;
                    }
                    else
                    {
                        // Si no hay filas, mostrar un mensaje indicando que no se encontró
                        MessageBox.Show("Necesidades no encontradas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que pueda ocurrir durante la consulta
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones de datos antes de guardar (puedes personalizar según tus necesidades)
            if (string.IsNullOrEmpty(txtObjetivos.Text) || fechaCreacionPicker.Value == null ||
                fechaInicioPicker.Value == null || fechaFinPicker.Value == null || comboCronograma.SelectedIndex == -1 ||
                comboNecesidades.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el producto seleccionado
            NecesidadesFormativas NecesidadesFormativasSeleccionada = (NecesidadesFormativas)comboNecesidades.SelectedItem;


            // Crear un nuevo objeto Venta con los datos del formulario
            PlanDesarrolloFormativo nuevoPlanDesarrolloFormativo = new PlanDesarrolloFormativo
            {
                Objetivos = Convert.ToString(txtObjetivos.Text),
                FechaCreacion = fechaCreacionPicker.Value,
                FechaInicio = fechaInicioPicker.Value,
                FechaFin = fechaFinPicker.Value,
                idCronograma = Convert.ToInt32(comboCronograma.SelectedValue),
                idNecesidadesFormativas = Convert.ToInt32(comboNecesidades.SelectedValue),
                //idNecesidadesFormativas = NecesidadesFormativasSeleccionada.idNecesidadesFormativas
            };

            // Llamar al método de la lógica para insertar la nueva venta
            planDesarrolloFormativoLogica.CrearPlanDesarrolloFormativo(nuevoPlanDesarrolloFormativo);

            // Actualizar la vista con las ventas actualizadas


            CargarComboNecesidades();

            CargarComboCronograma();

            CargarPlanDesarrollo();

            // Limpiar los campos después de guardar
            LimpiarCampos();
        }

        private void FormPlanDesarrolloFormativo_Load(object sender, EventArgs e)
        {
            CargarComboNecesidades();
            CargarComboCronograma();
            CargarPlanDesarrollo();
        }
        private void LimpiarCampos()
        {
            txtObjetivos.Text = "";
            fechaCreacionPicker.Value = DateTime.Now;
            fechaFinPicker.Value = DateTime.Now;
            fechaInicioPicker.Value = DateTime.Now;
            comboCronograma.Text = "";
            comboNecesidades.Text = "";
            //comboPuesto.Text = "";
            //comboArea.Text = "";

        }
    }
}
