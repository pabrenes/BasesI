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
        public ObservableCollection<clPacienteCNA> getPacientes() {
            var lista = new ObservableCollection<clPacienteCNA>();
            var dataBase = new dcCentroMedico();
            var vPaciente = dataBase.obtenerCedulaNombrePacientes();
            clPacienteCNA tempPaciente;

            foreach (var fila in vPaciente) {
                tempPaciente = new clPacienteCNA(
                    fila.CEDULA,
                    fila.NOMBRE,
                    fila.APELLIDO
                );
                lista.Add(tempPaciente);
            }
            return lista;
        }

        [OperationContract]
        public ObservableCollection<clEmpleadoANNII> getMedicos(int sede) {
            var lista = new ObservableCollection<clEmpleadoANNII>();
            var dataBase = new dcCentroMedico();
            var vMedico = dataBase.obtenerMedicosEspecialiadPorSede(sede);
            clEmpleadoANNII tempMedico;

            foreach (var fila in vMedico) {
                tempMedico = new clEmpleadoANNII(
                    fila.APELLIDOS,
                    fila.NOMBRE,
                    fila.ESPECIALIDAD,
                    fila.IDEMPLEADO,
                    fila.IDESPECIALIDAD
                );
                lista.Add(tempMedico);
            }
            return lista;
        }

        [OperationContract]
        public ObservableCollection<clSede> getSedes() {
            var lista = new ObservableCollection<clSede>();
            var dataBase = new dcCentroMedico();
            var vSede = dataBase.obtenerSedes();
            clSede tempSede;

            foreach (var fila in vSede) {
                tempSede = new clSede(
                    fila.IDSEDE,
                    fila.RAZONSOCIAL
                );
                lista.Add(tempSede);
            }
            return lista;
        }

        [OperationContract]
        public ObservableCollection<clHorario> getHorarios(decimal Medico, decimal Sede, string Dia, DateTime Fecha) {
            var lista = new ObservableCollection<clHorario>();
            var dataBase = new dcCentroMedico();
            var vHorario = dataBase.obtenerDisponibilidadMedicoPorDia(Medico, Sede, Dia, Fecha);
            clHorario tempHorario;

            foreach (var fila in vHorario) {
                tempHorario = new clHorario(
                    fila.DIA.ToString(),
                    fila.HORA
                );
                lista.Add(tempHorario);
            }
            return lista;
        }

    }
}
