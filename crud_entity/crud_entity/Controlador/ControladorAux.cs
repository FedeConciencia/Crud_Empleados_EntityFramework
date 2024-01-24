using crud_entity.Models;
using crud_entity.ModelsAux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace crud_entity.Controlador
{
    public class ControladorAux
    {
        //Metodo para obtener todas los empleados inner join empresa, cargoEmpleado, cargo:
        public List<AuxEmpleadoInner> allEmpleadosInnerJoin()
        {

            try
            {
                //Conecta a la BD y obtiene allEmpresa:
                using (crudEntity db = new crudEntity())
                {
                    var list = from a in db.empleado
                               join s in db.empresa on a.idEmpresa equals s.id
                               join d in db.cargoEmpleado on a.id equals d.idEmpleado
                               join g in db.cargo on d.idCargo equals g.id
                               select new AuxEmpleadoInner
                               {
                                   Id = a.id,
                                   NombreEmpleado = a.nombre,
                                   ApellidoEmpleado = a.apellido,
                                   NombreEmpresa = s.nombre,
                                   CargoEmpresa = g.nombre,

                               };

                    List<AuxEmpleadoInner> listaAux = list.ToList();

                    return listaAux;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //Metodo para obtener todas los empleados inner join empresa, cargoEmpleado, cargo:
        public List<AuxEmpleadoInner> filtroBusqueda(string campo, string criterio, string search)
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
                            var list = from a in db.empleado
                                       join s in db.empresa on a.idEmpresa equals s.id
                                       join d in db.cargoEmpleado on a.id equals d.idEmpleado
                                       join g in db.cargo on d.idCargo equals g.id
                                       where a.nombre.StartsWith(search)
                                       select new AuxEmpleadoInner
                                       {
                                           Id = a.id,
                                           NombreEmpleado = a.nombre,
                                           ApellidoEmpleado = a.apellido,
                                           NombreEmpresa = s.nombre,
                                           CargoEmpresa = g.nombre,

                                       };

                            List<AuxEmpleadoInner> listaAux = list.ToList();

                            return listaAux;
                        }

                    }
                    else if (criterio.Equals("Finaliza con"))
                    {

                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from a in db.empleado
                                       join s in db.empresa on a.idEmpresa equals s.id
                                       join d in db.cargoEmpleado on a.id equals d.idEmpleado
                                       join g in db.cargo on d.idCargo equals g.id
                                       where a.nombre.EndsWith(search)
                                       select new AuxEmpleadoInner
                                       {
                                           Id = a.id,
                                           NombreEmpleado = a.nombre,
                                           ApellidoEmpleado = a.apellido,
                                           NombreEmpresa = s.nombre,
                                           CargoEmpresa = g.nombre,

                                       };

                            List<AuxEmpleadoInner> listaAux = list.ToList();

                            return listaAux;
                        }

                    }
                    else
                    {
                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from a in db.empleado
                                       join s in db.empresa on a.idEmpresa equals s.id
                                       join d in db.cargoEmpleado on a.id equals d.idEmpleado
                                       join g in db.cargo on d.idCargo equals g.id
                                       where a.nombre.Contains(search)
                                       select new AuxEmpleadoInner
                                       {
                                           Id = a.id,
                                           NombreEmpleado = a.nombre,
                                           ApellidoEmpleado = a.apellido,
                                           NombreEmpresa = s.nombre,
                                           CargoEmpresa = g.nombre,

                                       };

                            List<AuxEmpleadoInner> listaAux = list.ToList();

                            return listaAux;
                        }

                    }

                }else if (campo.Equals("Apellido"))
                {

                    if (criterio.Equals("Comienza con"))
                    {
                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from a in db.empleado
                                       join s in db.empresa on a.idEmpresa equals s.id
                                       join d in db.cargoEmpleado on a.id equals d.idEmpleado
                                       join g in db.cargo on d.idCargo equals g.id
                                       where a.apellido.StartsWith(search)
                                       select new AuxEmpleadoInner
                                       {
                                           Id = a.id,
                                           NombreEmpleado = a.nombre,
                                           ApellidoEmpleado = a.apellido,
                                           NombreEmpresa = s.nombre,
                                           CargoEmpresa = g.nombre,

                                       };

                            List<AuxEmpleadoInner> listaAux = list.ToList();

                            return listaAux;
                        }

                    }
                    else if (criterio.Equals("Finaliza con"))
                    {
                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from a in db.empleado
                                       join s in db.empresa on a.idEmpresa equals s.id
                                       join d in db.cargoEmpleado on a.id equals d.idEmpleado
                                       join g in db.cargo on d.idCargo equals g.id
                                       where a.apellido.EndsWith(search)
                                       select new AuxEmpleadoInner
                                       {
                                           Id = a.id,
                                           NombreEmpleado = a.nombre,
                                           ApellidoEmpleado = a.apellido,
                                           NombreEmpresa = s.nombre,
                                           CargoEmpresa = g.nombre,

                                       };

                            List<AuxEmpleadoInner> listaAux = list.ToList();

                            return listaAux;
                        }

                    }
                    else
                    {

                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from a in db.empleado
                                       join s in db.empresa on a.idEmpresa equals s.id
                                       join d in db.cargoEmpleado on a.id equals d.idEmpleado
                                       join g in db.cargo on d.idCargo equals g.id
                                       where a.apellido.Contains(search)
                                       select new AuxEmpleadoInner
                                       {
                                           Id = a.id,
                                           NombreEmpleado = a.nombre,
                                           ApellidoEmpleado = a.apellido,
                                           NombreEmpresa = s.nombre,
                                           CargoEmpresa = g.nombre,

                                       };

                            List<AuxEmpleadoInner> listaAux = list.ToList();

                            return listaAux;

                        }

                    }

                }
                else if (campo.Equals("Empresa"))
                {

                    if (criterio.Equals("Comienza con"))
                    {
                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from a in db.empleado
                                       join s in db.empresa on a.idEmpresa equals s.id
                                       join d in db.cargoEmpleado on a.id equals d.idEmpleado
                                       join g in db.cargo on d.idCargo equals g.id
                                       where s.nombre.StartsWith(search)
                                       select new AuxEmpleadoInner
                                       {
                                           Id = a.id,
                                           NombreEmpleado = a.nombre,
                                           ApellidoEmpleado = a.apellido,
                                           NombreEmpresa = s.nombre,
                                           CargoEmpresa = g.nombre,

                                       };

                            List<AuxEmpleadoInner> listaAux = list.ToList();

                            return listaAux;
                        }

                    }
                    else if (criterio.Equals("Finaliza con"))
                    {
                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from a in db.empleado
                                       join s in db.empresa on a.idEmpresa equals s.id
                                       join d in db.cargoEmpleado on a.id equals d.idEmpleado
                                       join g in db.cargo on d.idCargo equals g.id
                                       where s.nombre.EndsWith(search)
                                       select new AuxEmpleadoInner
                                       {
                                           Id = a.id,
                                           NombreEmpleado = a.nombre,
                                           ApellidoEmpleado = a.apellido,
                                           NombreEmpresa = s.nombre,
                                           CargoEmpresa = g.nombre,

                                       };

                            List<AuxEmpleadoInner> listaAux = list.ToList();

                            return listaAux;
                        }

                    }
                    else
                    {

                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from a in db.empleado
                                       join s in db.empresa on a.idEmpresa equals s.id
                                       join d in db.cargoEmpleado on a.id equals d.idEmpleado
                                       join g in db.cargo on d.idCargo equals g.id
                                       where s.nombre.Contains(search)
                                       select new AuxEmpleadoInner
                                       {
                                           Id = a.id,
                                           NombreEmpleado = a.nombre,
                                           ApellidoEmpleado = a.apellido,
                                           NombreEmpresa = s.nombre,
                                           CargoEmpresa = g.nombre,

                                       };

                            List<AuxEmpleadoInner> listaAux = list.ToList();

                            return listaAux;

                        }

                    }

                }
                else
                {

                    if (criterio.Equals("Comienza con"))
                    {
                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from a in db.empleado
                                       join s in db.empresa on a.idEmpresa equals s.id
                                       join d in db.cargoEmpleado on a.id equals d.idEmpleado
                                       join g in db.cargo on d.idCargo equals g.id
                                       where g.nombre.StartsWith(search)
                                       select new AuxEmpleadoInner
                                       {
                                           Id = a.id,
                                           NombreEmpleado = a.nombre,
                                           ApellidoEmpleado = a.apellido,
                                           NombreEmpresa = s.nombre,
                                           CargoEmpresa = g.nombre,

                                       };

                            List<AuxEmpleadoInner> listaAux = list.ToList();

                            return listaAux;
                        }

                    }
                    else if (criterio.Equals("Finaliza con"))
                    {
                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from a in db.empleado
                                       join s in db.empresa on a.idEmpresa equals s.id
                                       join d in db.cargoEmpleado on a.id equals d.idEmpleado
                                       join g in db.cargo on d.idCargo equals g.id
                                       where g.nombre.EndsWith(search)
                                       select new AuxEmpleadoInner
                                       {
                                           Id = a.id,
                                           NombreEmpleado = a.nombre,
                                           ApellidoEmpleado = a.apellido,
                                           NombreEmpresa = s.nombre,
                                           CargoEmpresa = g.nombre,

                                       };

                            List<AuxEmpleadoInner> listaAux = list.ToList();

                            return listaAux;
                        }

                    }
                    else
                    {

                        //Conecta a la BD y obtiene AuxEmpleadoInner:
                        using (crudEntity db = new crudEntity())
                        {
                            var list = from a in db.empleado
                                       join s in db.empresa on a.idEmpresa equals s.id
                                       join d in db.cargoEmpleado on a.id equals d.idEmpleado
                                       join g in db.cargo on d.idCargo equals g.id
                                       where g.nombre.Contains(search)
                                       select new AuxEmpleadoInner
                                       {
                                           Id = a.id,
                                           NombreEmpleado = a.nombre,
                                           ApellidoEmpleado = a.apellido,
                                           NombreEmpresa = s.nombre,
                                           CargoEmpresa = g.nombre,

                                       };

                            List<AuxEmpleadoInner> listaAux = list.ToList();

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
