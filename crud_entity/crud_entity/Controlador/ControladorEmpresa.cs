﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crud_entity.Models;

namespace crud_entity.Controlador
{
    public class ControladorEmpresa
    {

		//Metodo para obtener todas las empresas:
        public List<empresa> allEmpresas()
        {

			try
			{
				//Conecta a la BD y obtiene allEmpresa:
				using (crudEntity db = new crudEntity())
				{
					var list = from item in db.empresa where item.activo != false select item;

                    List<empresa> listaEmpresa = list.ToList();	

					return listaEmpresa;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}

        }

        //Metodo para obtener one empresa por su nombre:
        public empresa oneEmpresaNombre(string nombre)
        {
            

            try
            {
                //Conecta a la BD y obtiene allEmpresa:
                using (crudEntity db = new crudEntity())
                {

                    empresa dato = new empresa();


                    dato = (from item in db.empresa where item.nombre == nombre select item).FirstOrDefault<empresa>();

      
                    return dato;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //Metodo para obtener one empresa por su id:
        public empresa oneEmpresaId(int id)
        {


            try
            {
                //Conecta a la BD y obtiene allEmpresa:
                using (crudEntity db = new crudEntity())
                {

                    empresa dato = new empresa();


                    dato = (from item in db.empresa where item.id == id select item).FirstOrDefault<empresa>();


                    return dato;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Metodo para insertar el objeto empresa:
        public void insertEmpresa(empresa objeto)
		{
            try
            {
                //Conecta a la BD e inserta la empresa:
                using (crudEntity db = new crudEntity())
                {
                    db.empresa.Add(objeto);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //Metodo para actualizar el objeto empresa, se usa para el DeleteLogico (Atcualizacion):
        public void updateEmpresa(empresa objeto)
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


        //Metodo para el delete Fisico:
        public void deleteEmpresa(empresa objeto)
        {
            try
            {
                //Conecta a la BD y actualiza la empresa:
                using (crudEntity db = new crudEntity())
                {
                    db.empresa.Attach(objeto);
                    db.empresa.Remove(objeto);
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
