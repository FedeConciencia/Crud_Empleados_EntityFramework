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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace crud_entity
{
    public partial class FrmInsertEmpleado : Form
    {

        private List<empresa> listaEmpresa = null;

        private empleado e1 = null;

        public FrmInsertEmpleado()
        {
            InitializeComponent();
            Text = "ALTA DE EMPLEADO";
            btnInsert.Text = "INSERT";

        }    

        public FrmInsertEmpleado(empleado e1)
        {
            InitializeComponent();
            this.e1 = e1;
            Text = "MODIFICAR EMPLEADO";
            btnInsert.Text = "UPDATE";

            //Actualizamos los campos con los datos:
            txtName.Text = e1.nombre;
            txtApe.Text = e1.apellido;

            

        }

        private void FrmInsertEmpleado_Load(object sender, EventArgs e)
        {
            cargarList();

            selectCombo();
        }

        //Metodo para cargarl el comboBox:
        private void cargarList()

        {
            ControladorEmpresa control = new ControladorEmpresa();

            listaEmpresa = control.allEmpresas();

            foreach (empresa item in listaEmpresa)
            {
                comboEmpresa.Items.Add(item.nombre);
            }

        }

        //Metodo para seleccionar el item del combo:
        private void selectCombo()
        {
            
            ControladorEmpresa control = new ControladorEmpresa();

            //Si el paramentro empleado es nulo: 
            if (e1 == null)
            {
                comboEmpresa.SelectedIndex = 0;
            }
            else
            {

                empresa empresa1 = control.oneEmpresaId(e1.idEmpresa);

                //Seleccionamos Combo por el nombre del objeto empresa:
                comboEmpresa.SelectedIndex = comboEmpresa.FindStringExact(empresa1.nombre);

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.e1 == null)
                {

                    ControladorEmpresa controlEmpresa = new ControladorEmpresa();

                    string name = txtName.Text;
                    string apellido = txtApe.Text;
                    string empresa = comboEmpresa.SelectedItem.ToString();
                    bool activo = true;

                    empleado e2 = new empleado();
                
                    //Obtenemos la empresa por nombre:
                    empresa emp = controlEmpresa.oneEmpresaNombre(empresa);


                    e2.nombre = name;
                    e2.apellido = apellido;
                    e2.idEmpresa = emp.id;
                    e2.activo = activo;

                    ControladorEmpleado controlEmpleado = new ControladorEmpleado();

                    controlEmpleado.insertEmpleado(e2);

                    MessageBox.Show("Registro empleado registrado con exito.");

                    this.Close();

                }
                else
                {

                    Console.WriteLine("INGRESO EN ACTUALIZAR DATO ");

                    ControladorEmpresa controlEmpresa = new ControladorEmpresa();

                    string name = txtName.Text;
                    string apellido = txtApe.Text;
                    string empresa = comboEmpresa.SelectedItem.ToString();
                    bool activo = true;

                    //Obtenemos la empresa por nombre:
                    empresa emp = controlEmpresa.oneEmpresaNombre(empresa);

                    //Importante se debe mantener el objeto que se trae por parametro con su id correspondiente:
                    e1.nombre = name;
                    e1.apellido = apellido;
                    e1.idEmpresa = emp.id;
                    e1.activo = activo;

                    ControladorEmpleado controlEmpleado = new ControladorEmpleado();

                    controlEmpleado.updateEmpleado(e1);

                    MessageBox.Show("Registro empleado actualizado con exito.");

                    this.Close();



                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error. No fue posible gestionar solicitud.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
