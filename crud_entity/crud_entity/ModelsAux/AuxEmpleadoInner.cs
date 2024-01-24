using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_entity.ModelsAux
{
    public class AuxEmpleadoInner
    {
        private int id;
        private string nombreEmpleado;
        private string apellidoEmpleado;
        private string nombreEmpresa;
        private string cargoEmpresa;

        public AuxEmpleadoInner()
        {
        }

        public AuxEmpleadoInner(int id, string nombreEmpleado, string apellidoEmpleado, string nombreEmpresa, string cargoEmpresa)
        {
            this.id = id;
            this.nombreEmpleado = nombreEmpleado;
            this.apellidoEmpleado = apellidoEmpleado;
            this.nombreEmpresa = nombreEmpresa;
            this.cargoEmpresa = cargoEmpresa;
        }

        public AuxEmpleadoInner(string nombreEmpleado, string apellidoEmpleado, string nombreEmpresa, string cargoEmpresa)
        {
            this.nombreEmpleado = nombreEmpleado;
            this.apellidoEmpleado = apellidoEmpleado;
            this.nombreEmpresa = nombreEmpresa;
            this.cargoEmpresa = cargoEmpresa;
        }

        [DisplayName("Id")]
        public int Id
        {
            get { return id; }
            set { id = value; }

        }

        [DisplayName("Nombre")]
        public string NombreEmpleado
        {
            get { return nombreEmpleado; }
            set { nombreEmpleado = value; }
        }

        [DisplayName("Apellido")]
        public string ApellidoEmpleado
        {
            get { return apellidoEmpleado; }
            set { apellidoEmpleado = value; }
        }

        [DisplayName("Empresa")]
        public string NombreEmpresa
        {
            get { return nombreEmpresa; }
            set { nombreEmpresa = value; }
        }

        [DisplayName("Cargo")]
        public string CargoEmpresa
        {
            get { return cargoEmpresa; }
            set { cargoEmpresa = value; }
        }

        public override string ToString()
        {
            return "Nombre: " + nombreEmpleado + "\nApellido: " + apellidoEmpleado +
                   "\nEmpresa: " + nombreEmpresa + "\nCargo:" + cargoEmpresa;
        }
    }
}
