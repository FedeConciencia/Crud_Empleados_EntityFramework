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
    public partial class FrmInsertCargo : Form
    {
        private cargo c1 = null;

        public FrmInsertCargo()
        {
            InitializeComponent();
            Text = "ALTA DE CARGO";
            btnInsert.Text = "AGREGAR";

        }

        public FrmInsertCargo(cargo c1)
        {
            InitializeComponent();
            this.c1 = c1;
            Text = "ACTUALIZAR CARGO";
            btnInsert.Text = "ACTUALIZAR";

            //Actualizamos los campos con los datos:
            txtName.Text = c1.nombre;
            
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.c1 == null)
                {
                    //INSERT DE DATOS:

                    //Si existe alguna validacion erronea aborta la carga de datos:
                    if (validarDatos())
                    {
                        MessageBox.Show("Error, Verificar los datos ingresados.");
                        return;
                    }

                    ControladorCargo control = new ControladorCargo();

                    string name = txtName.Text;
                    bool activo = true;

                    cargo c2 = new cargo();

                    c2.nombre = name;
                    c2.activo = activo;

                    control.insertCargo(c2);

                    MessageBox.Show("Registro cargo registrado con exito.");

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

                    ControladorCargo control= new ControladorCargo();

                    string name = txtName.Text;
                    bool activo = true;

                    c1.nombre = name;
                    c1.activo = activo;

                    control.updateCargo(c1);

                    MessageBox.Show("Registro cargo actualizado con exito.");

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
