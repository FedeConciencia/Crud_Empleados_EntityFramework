﻿using crud_entity.Controlador;
using crud_entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_entity
{
    public partial class FrmPrincCargoEmpleado : Form
    {
        public FrmPrincCargoEmpleado()
        {
            InitializeComponent();
        }

        private void FrmPrincCargoEmpleado_Load(object sender, EventArgs e)
        {
            cargar();

            //Cargar ComboBox Campos:
            cboCamp1.Items.Add("Activo");


            //Cargar ComboBox Criterio:
            cboCrit1.Items.Clear();
            cboCrit1.Items.Add("True");
            cboCrit1.Items.Add("False");

            //Al cargar seleccionamos el primer item de cada combo:
            cboCamp1.SelectedIndex = 0;
            cboCrit1.SelectedIndex = 0;
        }

        private void cargar()
        {
            try
            {

                List<cargoEmpleado> list = new List<cargoEmpleado>();

                ControladorCargoEmpleado control = new ControladorCargoEmpleado();

                list = control.allCargoEmpleado();

                if (list.Count() > 0)
                {
                    dataGrid.DataSource = list;
                    this.dataGrid.Columns["cargo"].Visible = false;
                    this.dataGrid.Columns["empleado"].Visible = false;
                }
                else
                {
                    MessageBox.Show("No existen datos disponibles.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error. No es posible procesar la solicitud.");
                Console.WriteLine(ex.Message);

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmInsertCargoEmpleado frm = new FrmInsertCargoEmpleado();
            frm.ShowDialog();
            cargar();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cargoEmpleado c1 = (cargoEmpleado) dataGrid.CurrentRow.DataBoundItem;
            FrmInsertCargoEmpleado frm = new FrmInsertCargoEmpleado(c1);
            frm.ShowDialog();
            cargar();

        }

        private void btnDeleteLog_Click(object sender, EventArgs e)
        {
            ControladorCargoEmpleado control = new ControladorCargoEmpleado();

            cargoEmpleado c1 = (cargoEmpleado) dataGrid.CurrentRow.DataBoundItem;


            try
            {

                //Permite una segunda validacion de eliminacion:
                DialogResult respuesta = MessageBox.Show("Estas seguro de continuar con la eliminacion logica del registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {

                    //Modificamos el estado del atributo activo:
                    c1.activo = false;

                    control.updateCargoEmpleado(c1);

                    MessageBox.Show("Registro seleccionado eliminado logicamente con Exito");

                    cargar(); //Cargamos nuevamente el form:

                }
                else
                {
                    MessageBox.Show("Se procede a cancelar la operacion de borrado fisico.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. No fue posible gestionar solicitud.");
                Console.WriteLine(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ControladorCargoEmpleado control = new ControladorCargoEmpleado();

            cargoEmpleado c1 = (cargoEmpleado) dataGrid.CurrentRow.DataBoundItem;


            try
            {

                //Permite una segunda validacion de eliminacion:
                DialogResult respuesta = MessageBox.Show("Estas seguro de continuar con la eliminacion del registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {


                    control.deleteCargoEmpleado(c1);

                    MessageBox.Show("Registro seleccionado eliminado con Exito");

                    cargar(); //Cargamos nuevamente el form:

                }
                else
                {
                    MessageBox.Show("Se procede a cancelar la operacion de borrado fisico.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. No fue posible gestionar solicitud.");
                Console.WriteLine(ex.Message);
            }
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            //Obtenemos los campos seleccionados
            string campo = cboCamp1.SelectedItem.ToString();
            string criterio = cboCrit1.SelectedItem.ToString();
            string search = textSearch1.Text;

            List<cargoEmpleado> listCargoEmpleado;

            try
            {
                ControladorCargoEmpleado control = new ControladorCargoEmpleado();
                listCargoEmpleado = control.filtroBusqueda(campo, criterio, search);

                if (listCargoEmpleado.Count() > 0)
                {
                    dataGrid.DataSource = listCargoEmpleado;
                }
                else
                {
                    MessageBox.Show("No se encontraron registros con las opciones de busqueda ingresadas.");
                    cargar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. No es posible procesar la solicitud.");
                Console.WriteLine(ex.Message);
            }
        }

        private void cboCamp1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cboCamp1.SelectedItem.ToString();

            if (campo.Equals("Activo"))
            {
                //Cargar ComboBox Criterio:

                cboCrit1.ResetText();
                cboCrit1.Items.Clear();


                cboCrit1.Items.Add("True");
                cboCrit1.Items.Add("False");


                cboCrit1.SelectedIndex = 0;


                textSearch1.Enabled = false;

            }
           
        }
    }
}
