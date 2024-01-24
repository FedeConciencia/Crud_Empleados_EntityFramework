using crud_entity.Controlador;
using crud_entity.ModelsAux;
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

                ControladorAux controladorAux = new ControladorAux();

                List<AuxEmpleadoInner> auxList = controladorAux.allEmpleadosInnerJoin();

                foreach (AuxEmpleadoInner item in auxList)
                {
                    Console.WriteLine(item);
                }

            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());

             
        }
    }
}
