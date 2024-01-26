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
    public partial class FrmInsertCargoEmpleado : Form
    {

        private List<cargoEmpleado> cargoEmpleadoList;

        private List<cargo> cargoList;

        private cargoEmpleado c1 = null;

        public FrmInsertCargoEmpleado()
        {
            InitializeComponent();
            Text = "ALTA DE CARGO-EMPLEADO";
            btnInsert.Text = "AGREGAR";

        }

        public FrmInsertCargoEmpleado(cargoEmpleado c1)
        {
            InitializeComponent();
            this.c1 = c1;
            Text = "ACTUALIZAR CARGA-EMPLEADO";
            btnInsert.Text = "ACTUALIZAR";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInsertCargoEmpleado_Load(object sender, EventArgs e)
        {
            //Cargamos el combo Box:

            cargarList();


            //Actualizamos los campos con los datos:

            if(this.c1 != null)
            {
                actualizarGrilla(this.c1.idEmpleado, this.c1.idCargo);
            }
            else
            {
                
                 comboCargo.SelectedIndex = 0;
                
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
            if (comboCargo.SelectedIndex < 0)
            {
                lblErrCarg2.Text = "*";
                lblErrCarg1.Text = "Error. Debe seleccionar un valor.";
                comboCargo.BackColor = Color.Red;
                bandera = true;
            }
            else
            {
                lblErrCarg2.Text = "";
                lblErrCarg1.Text = "";
                comboCargo.BackColor = Color.White;

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

                    bool bandera = false;
                    string name = txtName.Text;
                    string apellido = txtApe.Text;
                    string cargo = comboCargo.SelectedItem.ToString();
                    bool activo = true;

                    ControladorEmpleado controlEmpleado = new ControladorEmpleado();

                    empleado empleado = controlEmpleado.oneEmpleadoNomApell(name, apellido);

                    if (empleado == null)
                    {
                        bandera = false;
                    }
                    else
                    {
                        bandera = true;
                    }

                    if (bandera)
                    {
                        ControladorCargoEmpleado controlCargoEmpleado = new ControladorCargoEmpleado();

                        cargoEmpleado c2 = new cargoEmpleado();

                        ControladorCargo controlCargo = new ControladorCargo();

                        //Obtener el objeto Cargo seleccionado:
                        cargo carg1 = controlCargo.oneCargoNombre(cargo);

                        c2.idEmpleado = empleado.id;
                        c2.idCargo = carg1.id;
                        c2.activo = activo;

                        controlCargoEmpleado.insertCargoEmpleado(c2);

                        MessageBox.Show("Registro cargoEmpleado registrado con exito.");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error. El nombre y apellido ingresado no corresponde a un empleado activo o existente en la base.");

                        this.Close();
                    }


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

                    bool bandera = false;
                    string name = txtName.Text;
                    string apellido = txtApe.Text;
                    string cargo = comboCargo.SelectedItem.ToString();
                    bool activo = true;

                    ControladorEmpleado controlEmpleado = new ControladorEmpleado();

                    empleado empleado = controlEmpleado.oneEmpleadoNomApell(name, apellido);

                    if (empleado == null)
                    {
                        bandera = false;
                    }
                    else
                    {
                        bandera = true;
                    }

                    if (bandera)
                    {
                        ControladorCargoEmpleado controlCargoEmpleado = new ControladorCargoEmpleado();

                        ControladorCargo controlCargo = new ControladorCargo();

                        //Obtener el objeto Cargo seleccionado:
                        cargo carg1 = controlCargo.oneCargoNombre(cargo);

                        c1.idEmpleado = empleado.id;
                        c1.idCargo = carg1.id;
                        c1.activo = activo;

                        controlCargoEmpleado.updateCargoEmpleado(c1);

                        MessageBox.Show("Registro cargoEmpleado actualizado con exito.");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error. El nombre y apellido ingresado no corresponde a un empleado activo o existente en la base.");

                        this.Close();

                    }


                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error. No fue posible gestionar solicitud.");
                Console.WriteLine(ex.Message);
            }
        }

        //Metodo para cargar el comboBox con Cargos:
        private void cargarList()

        {
            ControladorCargo control = new ControladorCargo();

            //Devuelve todos los cargos activo:
            cargoList = control.allCargo();

            foreach (cargo item in cargoList)
            {
                comboCargo.Items.Add(item.nombre);
            }

        }

        private void actualizarGrilla(int idEmpleado, int idCargo)
        {
            try
            {
                ControladorEmpleado controlEmpleado = new ControladorEmpleado();
                ControladorCargo controladorCargo = new ControladorCargo();

                empleado e3 = controlEmpleado.oneEmpleadoId(idEmpleado);
                cargo c3 = controladorCargo.oneCargoId(idCargo);

                Console.WriteLine("Nombre Empresa: " + c3.nombre);

                txtName.Text = e3.nombre;
                txtApe.Text = e3.apellido;
                comboCargo.SelectedIndex = comboCargo.FindStringExact(c3.nombre);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error. No fue posible gestionar solicitud.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
