using crud_entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_entity.Controlador
{
    public class ControladorCargo
    {
        //Metodo para obtener todas los cargo:
        public List<cargo> allCargo()
        {

            try
            {
                //Conecta a la BD y obtiene allEmpresa:
                using (crudEntity db = new crudEntity())
                {
                    var list = from item in db.cargo where item.activo != false select item;

                    List<cargo> listaCargo = list.ToList();

                    return listaCargo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Metodo para obtener one cargo por su nombre:
        public cargo oneCargoNombre(string nombre)
        {


            try
            {
                //Conecta a la BD y obtiene allEmpresa:
                using (crudEntity db = new crudEntity())
                {

                    cargo dato = new cargo();


                    dato = (from item in db.cargo where item.nombre == nombre && item.activo == true select item).FirstOrDefault<cargo>();


                    return dato;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //Metodo para obtener one cargo por su Id:
        public cargo oneCargoId(int idCargo)
        {


            try
            {
                //Conecta a la BD y obtiene allEmpresa:
                using (crudEntity db = new crudEntity())
                {

                    cargo dato = new cargo();


                    dato = (from item in db.cargo where item.id == idCargo && item.activo == true select item).FirstOrDefault<cargo>();


                    return dato;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Metodo para insertar el objeto cargo:
        public void insertCargo(cargo objeto)
        {
            try
            {
                //Conecta a la BD e inserta la empresa:
                using (crudEntity db = new crudEntity())
                {
                    db.cargo.Add(objeto);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //Metodo para actualizar el objeto cargo, se usa para el DeleteLogico (Atcualizacion):
        public void updateCargo(cargo objeto)
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


        //Metodo para el delete Fisico de objeto cargo:
        public void deleteCargo(cargo objeto)
        {
            try
            {
                //Conecta a la BD y actualiza la empresa:
                using (crudEntity db = new crudEntity())
                {
                    db.cargo.Attach(objeto);
                    db.cargo.Remove(objeto);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Metodo para obtener todas los cargos por busqueda de filtro:
        public List<cargo> filtroBusqueda(string campo, string criterio, string search)
        {

            try
            {

                if (campo.Equals("Nombre"))
                {

                    if (criterio.Equals("Comienza con"))
                    {

                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from item in db.cargo
                                       where item.nombre.StartsWith(search)
                                       select item;

                            List<cargo> listaAux = list.ToList();

                            return listaAux;
                        }

                    }
                    else if (criterio.Equals("Finaliza con"))
                    {

                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from item in db.cargo
                                       where item.nombre.EndsWith(search)
                                       select item;

                            List<cargo> listaAux = list.ToList();

                            return listaAux;
                        }

                    }
                    else
                    {
                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from item in db.cargo
                                       where item.nombre.Contains(search)
                                       select item;


                            List<cargo> listaAux = list.ToList();

                            return listaAux;
                        }
                    }

                }
                else
                {

                    if (criterio.Equals("True"))
                    {

                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from item in db.cargo
                                       where item.activo != false
                                       select item;

                            List<cargo> listaAux = list.ToList();

                            return listaAux;
                        }

                    }
                    else
                    {

                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from item in db.cargo
                                       where item.activo != true
                                       select item;

                            List<cargo> listaAux = list.ToList();

                            return listaAux;
                        }

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
