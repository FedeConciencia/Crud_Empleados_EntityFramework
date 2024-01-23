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
            btnInsert.Text = "INSERT";
        }

        public FrmInsertEmpresa(empresa e1)
        {
            InitializeComponent();
            this.e1 = e1;
            Text = "MODIFICAR EMPRESA";
            btnInsert.Text = "UPDATE";

            //Actualizamos los campos con los datos:
            txtName.Text = e1.nombre;
          
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
                    string name = txtName.Text;
                    bool activo = true;

                    empresa e2 = new empresa();

                    e2.nombre = name;
                    e2.activo = activo;

                    ControladorEmpresa control = new ControladorEmpresa();

                    control.insertEmpresa(e2);

                    MessageBox.Show("Registro empresa registrado con exito.");

                    this.Close();

                }
                else
                {



                    Console.WriteLine("INGRESO EN ACTUALIZAR DATO ");

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

                MessageBox.Show("Error. No fue posible gestionar solicitud.");
                Console.WriteLine(ex.Message);
            }
        }

        private void FrmInsertEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}
