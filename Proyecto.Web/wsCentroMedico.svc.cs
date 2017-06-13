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
        public ObservableCollection<clCita> getCitas() {
            var lista = new ObservableCollection<clCita>();
            var dataBase = new dcCentroMedico();
            var vCita = from s in dataBase.CITAs select s;
            clCita tempCita;

            foreach(var fila in vCita) {
                tempCita = new clCita(
                    fila.IDCITA,
                    fila.SEDE,
                    fila.MEDICO,
                    fila.ESPECIALIDAD,
                    fila.CEDULAPACIENTE,
                    fila.DIACITA.ToString(),
                    fila.HORACITA,
                    fila.FECHACITA,
                    fila.OBSERVACIONES,
                    fila.ESTADO.ToString(),
                    fila.IDFACTURA ?? -1
                );
                lista.Add(tempCita);
            }
            return lista;
        }

        [OperationContract]
        public ObservableCollection<string> getPacientes() {
            var lista = new ObservableCollection<string>();
            var dataBase = new dcCentroMedico();
            var vPaciente = dataBase.obtenerCedulaNombrePacientes();
            clPacienteCNA tempPaciente;

            foreach (var fila in vPaciente) {
                tempPaciente = new clPacienteCNA(
                    fila.CEDULA,
                    fila.NOMBRE,
                    fila.APELLIDO
                );
                lista.Add(tempPaciente.toString());
            }
            return lista;
        }

    }
}
