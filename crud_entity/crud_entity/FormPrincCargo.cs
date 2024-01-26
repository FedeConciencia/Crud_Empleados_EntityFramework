using crud_entity.Controlador;
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
    public partial class FormPrincCargo : Form
    {
        public FormPrincCargo()
        {
            InitializeComponent();
        }

        private void FormPrincCargo_Load(object sender, EventArgs e)
        {
            cargar();

            //Cargar ComboBox Campos:
            cboCampCarg.Items.Add("Nombre");
            cboCampCarg.Items.Add("Activo");


            //Cargar ComboBox Criterio:
            cboCritCarg.Items.Clear();
            cboCritCarg.Items.Add("Comienza con");
            cboCritCarg.Items.Add("Finaliza con");
            cboCritCarg.Items.Add("Contiene");



            //Al cargar seleccionamos el primer item de cada combo:
            cboCampCarg.SelectedIndex = 0;
            cboCritCarg.SelectedIndex = 0;
        }

        private void cargar()
        {
            try
            {

                List<cargo> list = new List<cargo>();

                ControladorCargo control = new ControladorCargo();

                list = control.allCargo();

                if (list.Count() > 0)
                {
                    dataGrid.DataSource = list;
                    this.dataGrid.Columns["cargoEmpleado"].Visible = false;

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
            FrmInsertCargo frm = new FrmInsertCargo();
            frm.ShowDialog();
            cargar();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cargo c1 = (cargo)dataGrid.CurrentRow.DataBoundItem;
            FrmInsertCargo frm = new FrmInsertCargo(c1);
            frm.ShowDialog();
            cargar();
            

        }

        private void btnDeleteLog_Click(object sender, EventArgs e)
        {
            ControladorCargo control = new ControladorCargo();

            cargo c1 = (cargo) dataGrid.CurrentRow.DataBoundItem;


            try
            {

                //Permite una segunda validacion de eliminacion:
                DialogResult respuesta = MessageBox.Show("Estas seguro de continuar con la eliminacion logica del registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {

                    //Modificamos el estado del atributo activo:
                    c1.activo = false;

                    control.updateCargo(c1);

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
            ControladorCargo control = new ControladorCargo();

            cargo c1 = (cargo) dataGrid.CurrentRow.DataBoundItem;


            try
            {

                //Permite una segunda validacion de eliminacion:
                DialogResult respuesta = MessageBox.Show("Estas seguro de continuar con la eliminacion del registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {


                    control.deleteCargo(c1);

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

        private void btnSearchCargo_Click(object sender, EventArgs e)
        {
            //Obtenemos los campos seleccionados
            string campo = cboCampCarg.SelectedItem.ToString();
            string criterio = cboCritCarg.SelectedItem.ToString();
            string search = txtSearchCarg.Text;

            List<cargo> listCargo;

            try
            {
                ControladorCargo control = new ControladorCargo();
                listCargo = control.filtroBusqueda(campo, criterio, search);

                if (listCargo.Count() > 0)
                {
                    dataGrid.DataSource = listCargo;
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

        private void cboCampCarg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cboCampCarg.SelectedItem.ToString();

            if (campo.Equals("Nombre"))
            {
                //Cargar ComboBox Criterio:

                cboCritCarg.ResetText();
                cboCritCarg.Items.Clear();


                cboCritCarg.Items.Add("Comienza con");
                cboCritCarg.Items.Add("Finaliza con");
                cboCritCarg.Items.Add("Contiene");

                cboCritCarg.SelectedIndex = 0;


                txtSearchCarg.Enabled = true;
            }
            else
            {
                cboCritCarg.ResetText();
                cboCritCarg.Items.Clear();



                cboCritCarg.Items.Add("True");
                cboCritCarg.Items.Add("False");

                cboCritCarg.SelectedIndex = 0;


                txtSearchCarg.Enabled = false;
            }
        }
    }
}
