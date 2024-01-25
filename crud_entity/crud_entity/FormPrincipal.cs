using crud_entity.Controlador;
using crud_entity.ModelsAux;
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
    public partial class FormPrincipal : Form
    {

        private List<AuxEmpleadoInner> listAux;

        public FormPrincipal()
        {
            InitializeComponent();
            
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPrincEmpresa form = new FormPrincEmpresa();
            form.ShowDialog();
            cargar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPrincEmpleado form = new FormPrincEmpleado();
            form.ShowDialog();
            cargar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPrincCargo form = new FormPrincCargo();
            form.ShowDialog();
            cargar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmPrincCargoEmpleado form = new FrmPrincCargoEmpleado();
            form.ShowDialog();
            cargar();
        }

        private void cargar()
        {
            try
            {

                ControladorAux controladorAux = new ControladorAux();

                listAux = controladorAux.allEmpleadosInnerJoin();

                dataGrid.DataSource = listAux;

                //Cargar ComboBox Campos:
                cboCampo.Items.Add("Nombre");
                cboCampo.Items.Add("Apellido");
                cboCampo.Items.Add("Empresa");
                cboCampo.Items.Add("Cargo");

                //Cargar ComboBox Criterio:
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Finaliza con");
                cboCriterio.Items.Add("Contiene");

                //Al cargar seleccionamos el primer item de cada combo:
                cboCampo.SelectedIndex = 0;
                cboCriterio.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. No es posible procesar la solicitud.");
                Console.WriteLine(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string campo = cboCampo.SelectedItem.ToString();
            string criterio = cboCriterio.SelectedItem.ToString();
            string search = txtSearch.Text;

            List<AuxEmpleadoInner> listAux;

            try
            {
                ControladorAux controlAux = new ControladorAux();

                listAux = controlAux.filtroBusqueda(campo, criterio, search);

                if (listAux.Count() > 0)
                {
                    dataGrid.DataSource = listAux;
                }
                else
                {
                    MessageBox.Show("No se encontraron registros con las opciones de busqueda ingresadas.");
                    cargar();
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error. No es posible procesar la solicitud.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
