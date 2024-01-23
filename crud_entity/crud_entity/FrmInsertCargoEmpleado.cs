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
            btnInsert.Text = "INSERT";

        }

        public FrmInsertCargoEmpleado(cargoEmpleado c1)
        {
            InitializeComponent();
            this.c1 = c1;
            Text = "MODIFICAR CARGA-EMPLEADO";
            btnInsert.Text = "UPDATE";

            //Actualizamos los campos con los datos:
            


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInsertCargoEmpleado_Load(object sender, EventArgs e)
        {
            cargarList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.c1 == null)
                {

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

                    /*

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

                    */

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
    }
}
