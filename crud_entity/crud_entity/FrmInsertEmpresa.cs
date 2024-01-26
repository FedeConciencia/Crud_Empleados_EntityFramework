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
    public partial class FrmInsertEmpresa : Form
    {
        private empresa e1 = null;
        public FrmInsertEmpresa()
        {
            InitializeComponent();
            Text = "ALTA DE EMPRESA";
            btnInsert.Text = "AGREGAR";
        }

        public FrmInsertEmpresa(empresa e1)
        {
            InitializeComponent();
            this.e1 = e1;
            Text = "ACTUALIZAR EMPRESA";
            btnInsert.Text = "ACTUALIZAR";

            //Actualizamos los campos con los datos:
            txtName.Text = e1.nombre;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
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

           
            return bandera;

        }

        //Validar que no se ingresen numeros:
        private bool soloNumeros(string name)
        {
            //Devuelve False, si el numero ingresado contiene caracteres:
            int numericValue;
            bool isNumber = int.TryParse(name, out numericValue);
            return isNumber;

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

                    string name = txtName.Text;
                    bool activo = true;

                    empresa e2 = new empresa();

                    e2.nombre = name;
                    e2.activo = activo;

                    ControladorEmpresa control = new ControladorEmpresa();

                    control.insertEmpresa(e2);

                    MessageBox.Show("Registro empresa ingresado con exito.");

                    this.Close();

                }
                else
                {

                    //ACTUALIZACION DE DATOS:

                    //Si existe alguna validacion erronea aborta la carga de datos:
                    if (validarDatos())
                    {
                        MessageBox.Show("Error, Verificar los datos ingresados.");
                        return;
                    }

                    string name = txtName.Text;
                    bool activo = true;

                    //Importante se debe mantener el objeto que se trae por parametro con su id correspondiente:
                    e1.nombre = name;
                    e1.activo = activo;

                    ControladorEmpresa control = new ControladorEmpresa();

                    control.updateEmpresa(e1);

                    MessageBox.Show("Registro empresa actualizado con exito.");

                    this.Close();


                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error. No fue posible gestionar la solicitud.");
                Console.WriteLine(ex.Message);
            }
        }

        private void FrmInsertEmpresa_Load(object sender, EventArgs e)
        {

        }

        
    }
}
