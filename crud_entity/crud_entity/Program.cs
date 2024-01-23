using crud_entity.Controlador;
using crud_entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_entity
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Zona para gestionar pruebas de metodos CRUD:

            /*
             * 
                ControladorEmpresa control = new ControladorEmpresa();

                empresa e1 = control.oneEmpresa("Microsoft");

                Console.WriteLine("PRUEBA");

                Console.WriteLine(e1.id);
                Console.WriteLine(e1.nombre);
                Console.WriteLine(e1.activo);

            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

             
        }
    }
}
