using crud_entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_entity.Controlador
{
    public class ControladorCargoEmpleado
    {
        //Metodo para obtener todas los cargoEmpleado:
        public List<cargoEmpleado> allCargoEmpleado()
        {

            try
            {
                //Conecta a la BD y obtiene allEmpresa:
                using (crudEntity db = new crudEntity())
                {
                    var list = from item in db.cargoEmpleado where item.activo != false select item;

                    List<cargoEmpleado> listaCargoEmpleado = list.ToList();

                    return listaCargoEmpleado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //Metodo para insertar el objeto cargoEmpleado:
        public void insertCargoEmpleado(cargoEmpleado objeto)
        {
            try
            {
                //Conecta a la BD e inserta la empresa:
                using (crudEntity db = new crudEntity())
                {
                    db.cargoEmpleado.Add(objeto);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //Metodo para actualizar el objeto cargoEmpleado, se usa para el DeleteLogico (Atcualizacion):
        public void updateCargoEmpleado(cargoEmpleado objeto)
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
        public void deleteCargoEmpleado(cargoEmpleado objeto)
        {
            try
            {
                //Conecta a la BD y actualiza la empresa:
                using (crudEntity db = new crudEntity())
                {
                    db.cargoEmpleado.Attach(objeto);
                    db.cargoEmpleado.Remove(objeto);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Metodo para obtener todas los cargos por busqueda de filtro:
        public List<cargoEmpleado> filtroBusqueda(string campo, string criterio, string search)
        {

            try
            {

                if (campo.Equals("Activo"))
                {

                    if (criterio.Equals("True"))
                    {

                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from item in db.cargoEmpleado
                                       where item.activo != false
                                       select item;

                            List<cargoEmpleado> listaAux = list.ToList();

                            return listaAux;
                        }

                    }
                    else
                    {

                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from item in db.cargoEmpleado
                                       where item.activo != true
                                       select item;

                            List<cargoEmpleado> listaAux = list.ToList();

                            return listaAux;
                        }

                    }

                }
                else
                {
                    //Conecta a la BD y obtiene allEmpresa:
                    using (crudEntity db = new crudEntity())
                    {
                        var list = from item in db.cargoEmpleado where item.activo != false select item;

                        List<cargoEmpleado> listaCargoEmpleado = list.ToList();

                        return listaCargoEmpleado;
                    }
                }
                

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
