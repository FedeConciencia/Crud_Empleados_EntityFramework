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
            btnInsert.Text = "AGREGAR";

        }    

        public FrmInsertEmpleado(empleado e1)
        {
            InitializeComponent();
            this.e1 = e1;
            Text = "ACTUALIZAR EMPLEADO";
            btnInsert.Text = "ACTUALIZAR";

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


        private bool validarDatos()
        {
            bool bandera = false;

            //Valida Txt Nombre:
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblErrName2.Text = "*";
                lblErrName1.Text = "Error. Debe ingresar un valor.";
                txtName.BackColor = Color.Red;
                bandera = true;
            }
            else
            {
                lblErrName1.Text = "";
                lblErrName2.Text = "";
                txtName.BackColor = Color.White;
                bandera = false;

                if (txtName.Text.Length < 4)
                {
                    lblErrName2.Text = "*";
                    lblErrName1.Text = "Error. Debe ingresar un nombre con mas caracteres.";
                    txtName.BackColor = Color.Red;
                    bandera = true;
                }
                else
                {
                    lblErrName1.Text = "";
                    lblErrName2.Text = "";
                    txtName.BackColor = Color.White;
                    bandera = false;

                }

            }

            //Valida Txt Apellido:
            if (string.IsNullOrEmpty(txtApe.Text))
            {
                lblErrApe2.Text = "*";
                lblErrApe1.Text = "Error. Debe ingresar un valor.";
                txtApe.BackColor = Color.Red;
                bandera = true;
            }
            else
            {
                lblErrApe1.Text = "";
                lblErrApe2.Text = "";
                txtApe.BackColor = Color.White;
                bandera = false;

                if (txtApe.Text.Length < 4)
                {
                    lblErrApe2.Text = "*";
                    lblErrApe1.Text = "Error. Debe ingresar un nombre con mas caracteres.";
                    txtApe.BackColor = Color.Red;
                    bandera = true;
                }
                else
                {
                    lblErrApe2.Text = "";
                    lblErrApe1.Text = "";
                    txtName.BackColor = Color.White;
                    bandera = false;

                }

            }


            //Valida ComboBox Empresa seleccionado:
            if (comboEmpresa.SelectedIndex < 0)
            {
                lblErrEmp2.Text = "*";
                lblErrEmp1.Text = "Error. Debe seleccionar un valor.";
                comboEmpresa.BackColor = Color.Red;
                bandera = true;
            }
            else
            {
                lblErrEmp2.Text = "";
                lblErrEmp1.Text = "";
                comboEmpresa.BackColor = Color.White;

            }


            return bandera;

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

                    //INSERT DE DATOS:

                    //Si existe alguna validacion erronea aborta la carga de datos:
                    if (validarDatos())
                    {
                        MessageBox.Show("Error, Verificar los datos ingresados.");
                        return;
                    }

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

                    //UPDATE DE DATOS:

                    //Si existe alguna validacion erronea aborta la carga de datos:
                    if (validarDatos())
                    {
                        MessageBox.Show("Error, Verificar los datos ingresados.");
                        return;
                    }

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
