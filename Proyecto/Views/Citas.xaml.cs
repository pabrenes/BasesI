using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace Proyecto.Views
{
    public partial class Citas : Page
    {
        ws.wsCentroMedicoClient servicio = new ws.wsCentroMedicoClient();
        List<ws.clSede> Sedes = null;
        List<ws.clEmpleadoANNII> Medicos = null;
        List<ws.clPacienteCNA> Pacientes = null;
        List<ws.clHorario> Horarios = null;
        bool isSedeAvailable = false;

        public Citas() {
            InitializeComponent();
            servicio.getSedesCompleted += new EventHandler<ws.getSedesCompletedEventArgs>(cargaSedes);
            servicio.getSedesAsync();
            servicio.getPacientesCompleted += new EventHandler<ws.getPacientesCompletedEventArgs>(cargaPacientes);
            servicio.getPacientesAsync();
            servicio.getMedicosCompleted += new EventHandler<ws.getMedicosCompletedEventArgs>(cargaMedicos);
            servicio.getHorariosCompleted += new EventHandler<ws.getHorariosCompletedEventArgs>(cargaHorarios);

            DP_Fecha.DisplayDateStart = DateTime.Now;
            DP_Fecha.DisplayDateEnd = DateTime.MaxValue;
            DP_Fecha.SelectedDate = DateTime.Now;
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e) {

        }

        //Evento que se ejecuta luego de que getPacientesAsync() obtenga los datos de pacientes de la BD
        public void cargaPacientes(object sender, ws.getPacientesCompletedEventArgs e) {
            Pacientes = e.Result.ToList();
            CB_Pacientes.Items.Clear();
            foreach (var paciente in Pacientes) {
               CB_Pacientes.Items.Add(paciente.forUI);
            }
        }

        //Evento que se ejecuta luego de que getSedesAsync() obtenga los datos de sedes de la BD
        public void cargaSedes(object sender, ws.getSedesCompletedEventArgs e) {
            Sedes = e.Result.ToList();
            CB_Sede.Items.Clear();
            foreach (var sede in Sedes) {
                CB_Sede.Items.Add(sede.forUI);
            }
            if (Sedes.Count > 0) {
                isSedeAvailable = true;
                actualizarMedicos(Sedes.First().IDSede);
            }
        }

        //Actualiza los médicos disponibles en base a una sede
        public void actualizarMedicos(decimal sede) {
            try {
                servicio.getMedicosAsync(Convert.ToInt32(sede));
            } catch {

            }
        }

        //Evento que se ejecuta luego de que getMedicosAsync() obtenga los datos de medicos de la BD
        public void cargaMedicos(object sender, ws.getMedicosCompletedEventArgs e) {
            Medicos = e.Result.ToList();
            CB_Medicos.Items.Clear();
            foreach (var medico in Medicos) {
                CB_Medicos.Items.Add(medico.forUI);
            }
        }

        //Se acciona cuando el usuario cambia el elemento seleccionado del ComboBox de sedes
        public void CB_Sede_ItemChanged(object sender, EventArgs e) {
            decimal sede = Sedes[CB_Sede.SelectedIndex].IDSede;
            actualizarMedicos(sede);
        }

        //Evento que se ejecuta luego de que getHorariosAsync() obtenga los datos de horarios de la BD
        public void cargaHorarios(object sender, ws.getHorariosCompletedEventArgs e) {
            Horarios = e.Result.ToList();
            CB_Horarios.Items.Clear();
            foreach (var horario in Horarios) {
                CB_Horarios.Items.Add(horario.forUI);
            }
        }

        //Actualiza los horarios disponibles en base a un médico para una sede, en un día, para una fecha
        public void actualizarHorarios(decimal Medico, decimal Sede, string Dia, DateTime Fecha) {
            servicio.getHorariosAsync(Medico, Sede, Dia, Fecha);
        }

        //Eveno que se ejecuta luego de que el usuario seleccione un médico en el ComboBox de médicos
        public void CB_Medicos_ItemChanged(object sender, EventArgs e) {
            try {
                decimal Medico = Medicos[CB_Medicos.SelectedIndex].IDEmpleado;
                decimal Sede = Sedes[CB_Sede.SelectedIndex].IDSede;
                DateTime Fecha = DP_Fecha.SelectedDate ?? DateTime.Now;
                string Dia = getDia((int)Fecha.DayOfWeek);
                actualizarHorarios(Medico, Sede, Dia, Fecha);
            } catch {

            }
        }

        //Evento que se acciona luego de que el usuario seleccione una fecha en el DatePicker
        private void DP_Fecha_ItemChanged(object sender, EventArgs e) {
            try {
                decimal Medico = Medicos[CB_Medicos.SelectedIndex].IDEmpleado;
                decimal Sede = Sedes[CB_Sede.SelectedIndex].IDSede;
                DateTime Fecha = DP_Fecha.SelectedDate ?? DateTime.Now;
                string Dia = getDia((int)Fecha.DayOfWeek);
                actualizarHorarios(Medico, Sede, Dia, Fecha);
            } catch {

            }
        }

        //Dado un día [0, 6] retorna la letra correspondiente 0 -> D | 2 -> K | 6 -> S 
        private string getDia(int dia) {
            return "DLKMJVS"[dia].ToString();
        }

    }
}
