﻿using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBimbo
{
    public partial class FormEmpleados : Form
    {
        private logEmpleado empleadoLogica;
        private Empleado empleadoSeleccionado;
        public FormEmpleados()
        {
            InitializeComponent();
            empleadoLogica = new logEmpleado();

            CargarEmpleados();
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            pickerFechaContratacion.Value = DateTime.Now;
            //comboPuesto.Text = "";
            //comboArea.Text = "";

        }

        private void CargarEmpleados()
        {
            listaEmpleados.DataSource = empleadoLogica.LeerEmpleados();
        }
        private void FormEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Empleado nuevoEmpleado = new Empleado
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaContratacion = pickerFechaContratacion.Value,
                //Puesto = Convert.ToInt32(comboPuesto.SelectedValue),
                //Area = Convert.ToInt32(comboArea.SelectedValue)
            };

            empleadoLogica.CrearEmpleado(nuevoEmpleado);

            CargarEmpleados();
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (empleadoSeleccionado != null)
            {
                // Actualizar el objeto empleadoSeleccionado con los datos modificados
                empleadoSeleccionado.Nombre = txtNombre.Text;
                empleadoSeleccionado.Apellido = txtApellido.Text;
                empleadoSeleccionado.FechaContratacion = pickerFechaContratacion.Value;
                //empleadoSeleccionado.Sueldo = Convert.ToInt32(txtSueldo.Text);
                //empleadoSeleccionado.Direccion = txtDireccion.Text;

                // Llamar al método de la lógica para editar el empleado
                empleadoLogica.ActualizarEmpleado(empleadoSeleccionado);

                // Actualizar la vista con los empleados actualizados
                CargarEmpleados();

                // Limpiar los campos después de guardar
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (empleadoSeleccionado != null)
            {
                // Mostrar un cuadro de diálogo de confirmación
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este empleado?", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Llamar al método de la lógica para eliminar el empleado
                    empleadoLogica.EliminarEmpleado(empleadoSeleccionado.IdEmpleado);

                    // Actualizar la vista con los empleados actualizados
                    CargarEmpleados();

                    // Limpiar los campos después de eliminar
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
