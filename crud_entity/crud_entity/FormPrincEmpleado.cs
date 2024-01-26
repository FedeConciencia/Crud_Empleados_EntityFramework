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
    public partial class FormPrincEmpleado : Form
    {
        public FormPrincEmpleado()
        {
            InitializeComponent();
        }

        private void FormPrincEmpleado_Load(object sender, EventArgs e)
        {
            cargar();

            //Cargar ComboBox Campos:
            cboCamEmp.Items.Add("Nombre");
            cboCamEmp.Items.Add("Apellido");
            cboCamEmp.Items.Add("Activo");



            //Cargar ComboBox Criterio:
            cboCritEmp.Items.Clear();
            cboCritEmp.Items.Add("Comienza con");
            cboCritEmp.Items.Add("Finaliza con");
            cboCritEmp.Items.Add("Contiene");


            //Al cargar seleccionamos el primer item de cada combo:
            cboCamEmp.SelectedIndex = 0;
            cboCritEmp.SelectedIndex = 0;

        }

        private void cargar()
        {
            try
            {

                List<empleado> list = new List<empleado>();

                ControladorEmpleado control = new ControladorEmpleado();

                list = control.allEmpleados();

                if (list.Count() > 0)
                {
                    dataGrid.DataSource = list;
                    this.dataGrid.Columns["cargoEmpleado"].Visible = false;
                    this.dataGrid.Columns["empresa"].Visible = false;
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
            FrmInsertEmpleado frm = new FrmInsertEmpleado();
            frm.ShowDialog();
            cargar();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            empleado e1 = (empleado) dataGrid.CurrentRow.DataBoundItem;
            FrmInsertEmpleado frm = new FrmInsertEmpleado(e1);
            frm.ShowDialog();
            cargar();
        }

        private void btnDeleteLog_Click(object sender, EventArgs e)
        {
            ControladorEmpleado control = new ControladorEmpleado();

            empleado e1 = (empleado) dataGrid.CurrentRow.DataBoundItem;


            try
            {

                //Permite una segunda validacion de eliminacion:
                DialogResult respuesta = MessageBox.Show("Estas seguro de continuar con la eliminacion logica del registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {

                    //Modificamos el estado del atributo activo:
                    e1.activo = false;

                    control.updateEmpleado(e1);

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
            ControladorEmpleado control = new ControladorEmpleado();

            empleado e1 = (empleado) dataGrid.CurrentRow.DataBoundItem;


            try
            {

                //Permite una segunda validacion de eliminacion:
                DialogResult respuesta = MessageBox.Show("Estas seguro de continuar con la eliminacion del registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {


                    control.deleteEmpleado(e1);

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

        private void btnSearchEmpresa_Click(object sender, EventArgs e)
        {
            //Obtenemos los campos seleccionados
            string campo = cboCamEmp.SelectedItem.ToString();
            string criterio = cboCritEmp.SelectedItem.ToString();
            string search = txtSearchEmp.Text;

            List<empleado> listEmpleado;

            try
            {
                ControladorEmpleado control = new ControladorEmpleado();

                listEmpleado = control.filtroBusqueda(campo, criterio, search);

                if (listEmpleado.Count() > 0)
                {
                    dataGrid.DataSource = listEmpleado;
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

        private void cboCamEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cboCamEmp.SelectedItem.ToString();

            if (campo.Equals("Nombre"))
            {
                //Cargar ComboBox Criterio:

                cboCritEmp.ResetText();
                cboCritEmp.Items.Clear();


                cboCritEmp.Items.Add("Comienza con");
                cboCritEmp.Items.Add("Finaliza con");
                cboCritEmp.Items.Add("Contiene");

                cboCritEmp.SelectedIndex = 0;


                txtSearchEmp.Enabled = true;
            }
            else if(campo.Equals("Apellido"))
            {
                //Cargar ComboBox Criterio:

                cboCritEmp.ResetText();
                cboCritEmp.Items.Clear();


                cboCritEmp.Items.Add("Comienza con");
                cboCritEmp.Items.Add("Finaliza con");
                cboCritEmp.Items.Add("Contiene");

                cboCritEmp.SelectedIndex = 0;


                txtSearchEmp.Enabled = true;
            }
            else
            {
                cboCritEmp.ResetText();
                cboCritEmp.Items.Clear();



                cboCritEmp.Items.Add("True");
                cboCritEmp.Items.Add("False");

                cboCritEmp.SelectedIndex = 0;


                txtSearchEmp.Enabled = false;
            }
        }
    }
}
