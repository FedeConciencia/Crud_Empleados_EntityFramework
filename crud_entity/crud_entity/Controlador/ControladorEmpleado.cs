using crud_entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_entity.Controlador
{
    public class ControladorEmpleado
    {
        //Metodo para obtener todas los empleados:
        public List<empleado> allEmpleados()
        {

            try
            {
                //Conecta a la BD y obtiene allEmpresa:
                using (crudEntity db = new crudEntity())
                {
                    var list = from item in db.empleado where item.activo != false select item;

                    List<empleado> listaEmpleado = list.ToList();

                    return listaEmpleado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        

        //Metodo para obtener one empleado por su nombre y apellido:
        public empleado oneEmpleadoNomApell(string nom, string apell)
        {


            try
            {
                //Conecta a la BD y obtiene allEmpresa:
                using (crudEntity db = new crudEntity())
                {

                    empleado dato = new empleado();


                    dato = (from item in db.empleado where item.nombre == nom && item.apellido == apell && item.activo == true select item).FirstOrDefault<empleado>();


                    return dato;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Metodo para obtener one empleado por su nombre y apellido:
        public empleado oneEmpleadoId(int idEmpleado)
        {


            try
            {
                //Conecta a la BD y obtiene allEmpresa:
                using (crudEntity db = new crudEntity())
                {

                    empleado dato = new empleado();


                    dato = (from item in db.empleado where item.id == idEmpleado && item.activo == true select item).FirstOrDefault<empleado>();


                    return dato;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //Metodo para insertar el objeto empleado:
        public void insertEmpleado(empleado objeto)
        {
            try
            {
                //Conecta a la BD e inserta la empresa:
                using (crudEntity db = new crudEntity())
                {
                    db.empleado.Add(objeto);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //Metodo para actualizar el objeto empleado, se usa para el DeleteLogico (Atcualizacion):
        public void updateEmpleado(empleado objeto)
        {
            try
            {
                //Conecta a la BD y actualiza la empresa:
                using (crudEntity db = new crudEntity())
                {
                    db.Entry(objeto).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //Metodo para el delete Fisico de objeto empleado:
        public void deleteEmpleado(empleado objeto)
        {
            try
            {
                //Conecta a la BD y actualiza la empresa:
                using (crudEntity db = new crudEntity())
                {
                    db.empleado.Attach(objeto);
                    db.empleado.Remove(objeto);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
