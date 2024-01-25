using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crud_entity.Controlador;
using crud_entity.Models;
using crud_entity.ModelsAux;

namespace crud_entity
{
    public partial class FormPrincEmpresa : Form
    {
        public FormPrincEmpresa()
        {
            InitializeComponent();
        }

        //Evento Carga del Formulario:
        private void FormPrincEmpresa_Load(object sender, EventArgs e)
        {
            cargar();

            //Cargar ComboBox Campos:
            cboCampoEmpr.Items.Add("Nombre");
            cboCampoEmpr.Items.Add("Activo");


            //Cargar ComboBox Criterio:
            cboCritEmpresa.Items.Clear();
            cboCritEmpresa.Items.Add("Comienza con");
            cboCritEmpresa.Items.Add("Finaliza con");
            cboCritEmpresa.Items.Add("Contiene");



            //Al cargar seleccionamos el primer item de cada combo:
            cboCampoEmpr.SelectedIndex = 0;
            cboCritEmpresa.SelectedIndex = 0;


        }

        private void cargar()
        {
            try
            {

                List<empresa> list = new List<empresa>();

                ControladorEmpresa control = new ControladorEmpresa();

                list = control.allEmpresas();

                if (list.Count() > 0)
                {

                    dataGrid.DataSource = list;
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
            FrmInsertEmpresa frm = new FrmInsertEmpresa();
            frm.ShowDialog();
            cargar();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            empresa e1 = (empresa) dataGrid.CurrentRow.DataBoundItem;
            FrmInsertEmpresa frm = new FrmInsertEmpresa(e1);
            frm.ShowDialog();
            cargar();
        }

        private void btnDeleteLog_Click(object sender, EventArgs e)
        {

            ControladorEmpresa control = new ControladorEmpresa();

            empresa e1 = (empresa) dataGrid.CurrentRow.DataBoundItem;


            try
            {

                //Permite una segunda validacion de eliminacion:
                DialogResult respuesta = MessageBox.Show("Estas seguro de continuar con la eliminacion logica del registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {

                    //Modificamos el estado del atributo activo:
                    e1.activo = false;

                    control.updateEmpresa(e1);

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
            ControladorEmpresa control = new ControladorEmpresa();

            empresa e1 = (empresa)dataGrid.CurrentRow.DataBoundItem;


            try
            {

                //Permite una segunda validacion de eliminacion:
                DialogResult respuesta = MessageBox.Show("Estas seguro de continuar con la eliminacion del registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {

                   
                    control.deleteEmpresa(e1);

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


        private void btnSearchEmpre_Click(object sender, EventArgs e)
        {
            //Obtenemos los campos seleccionados
            string campo = cboCampoEmpr.SelectedItem.ToString();
            string criterio = cboCritEmpresa.SelectedItem.ToString();
            string search = txtSearchEmpresa.Text;

            Console.WriteLine("CAMPO => " + campo);
            Console.WriteLine("CRITERIO => " + criterio);
            Console.WriteLine("SEARCH => " + search);

            List<empresa> listEmpresa;

            try
            {
                ControladorEmpresa control = new ControladorEmpresa();

                listEmpresa = control.filtroBusqueda(campo, criterio, search);

                if (listEmpresa.Count() > 0)
                {
                    dataGrid.DataSource = listEmpresa;
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

        //Metodo Completa el ComboBox Criterio dependiendo de la seleccion:
        private void cboCampoEmpr_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cboCampoEmpr.SelectedItem.ToString();

            if (campo.Equals("Nombre"))
            {
                //Cargar ComboBox Criterio:

                cboCritEmpresa.ResetText();
                cboCritEmpresa.Items.Clear();


                cboCritEmpresa.Items.Add("Comienza con");
                cboCritEmpresa.Items.Add("Finaliza con");
                cboCritEmpresa.Items.Add("Contiene");

                cboCritEmpresa.SelectedIndex = 0;


                txtSearchEmpresa.Enabled = true;
            }
            else
            {
                cboCritEmpresa.ResetText();
                cboCritEmpresa.Items.Clear();

                

                cboCritEmpresa.Items.Add("True");
                cboCritEmpresa.Items.Add("False");

                cboCritEmpresa.SelectedIndex = 0;


                txtSearchEmpresa.Enabled = false;
            }

        }

        
    }
}
