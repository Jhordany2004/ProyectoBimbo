using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogicaNegocio;

namespace ProyectoBimbo
{
    public partial class FormDetalleEvaluacionDesempeño : Form
    {
        public FormDetalleEvaluacionDesempeño()
        {
            InitializeComponent();
        }

        public void ListarDetEvaDesempeño()
        {
            List<entDetEvaDesempeño> listaDetEvaDesempeño = logDetEvaDesempeño.Instancia.ListarDetEvaDesempeño();
            if (listaDetEvaDesempeño.Count > 0) // para verificar si existen filas
            {

                dgvDetEvaDesempeño.Columns.Clear(); // se eliminan todas las columnas existentes del DataGridView antes de mostrar el resultado de la consulta
                BindingSource datosEnlazados = new BindingSource(); // objeto para vincular el resultado de la consulta al DataGridView
                datosEnlazados.DataSource = listaDetEvaDesempeño;
                dgvDetEvaDesempeño.DataSource = datosEnlazados; // se vincula el resultado de la consulta al DataGridView y se mostran los registros
                                                                //configurarColumnasDataGridView();
                dgvDetEvaDesempeño.Rows[0].Selected = false; // permite que la primera fila del DataGridView no esté seleccionada
            }
        }
        private void LimpiarVariables()
        {
            txtidPregEvaDesempeño.Text = " ";
            txtidDetalleEva.Text = " ";
            NudNota.Text = "0";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtidDetalleEva.Enabled = false;
            btnAgregar.Enabled = true;
            gbCalificarPregunta.Enabled = true;
            btnModificar.Enabled = false;
            LimpiarVariables();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtidDetalleEva.Enabled = true;
            gbCalificarPregunta.Enabled = true;
            btnModificar.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entDetEvaDesempeño nota = new entDetEvaDesempeño();
            nota.Nota = int.Parse(NudNota.Text);
            nota.idPreguntasEvaluacionDesempeño = int.Parse(txtidPregEvaDesempeño.Text);
            logDetEvaDesempeño.Instancia.InsertarDetEvaDesempeño(nota);
            LimpiarVariables();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entDetEvaDesempeño nota = new entDetEvaDesempeño();
                nota.idDetalleEvaluacionDesempeño = int.Parse(txtidDetalleEva.Text);
                nota.Nota = int.Parse(NudNota.Text);
                nota.idPreguntasEvaluacionDesempeño = int.Parse(txtidPregEvaDesempeño.Text);
                logDetEvaDesempeño.Instancia.EditarDetEvaDesempeño(nota);
                LimpiarVariables();
            }
            catch (Exception ex)
            {
                MessageBox.Show("err" + ex);
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbCalificarPregunta.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDetalleEvaluacionDesempeño_Load(object sender, EventArgs e)
        {

        }
    }
}
