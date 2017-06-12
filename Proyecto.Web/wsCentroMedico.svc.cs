using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;
using cnCentroMedico;

namespace Proyecto.Web
{
    [ServiceContract(Namespace = "http://tempuri.org")]
    [SilverlightFaultBehavior]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class wsCentroMedico
    {

        [OperationContract]
        public ObservableCollection<clPaciente> getPacientes() {
            var lista = new ObservableCollection<clPaciente>();
            var dataBase = new dcCentroMedico();
            var vPaciente = from s in dataBase.PACIENTEs select s;
            clPaciente tempPaciente;

            foreach(var fila in vPaciente) {
                tempPaciente = new clPaciente(
                    fila.CEDULA,
                    fila.NOMBRE,
                    fila.APELLIDO,
                    fila.FCHNACIMIENTO,
                    fila.ESTADOCIVIL.ToString(),
                    fila.OCUPACION,
                    fila.FOTO,
                    fila.DIRECCION,
                    fila.TIPO.ToString()
                );
                lista.Add(tempPaciente);
            }
            return lista;
        }

    }
}
