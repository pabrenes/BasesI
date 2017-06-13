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
        bool isSedeAvailable = false;

        public Citas() {
            InitializeComponent();
            servicio.getSedesCompleted += new EventHandler<ws.getSedesCompletedEventArgs>(cargaSedes);
            servicio.getSedesAsync();
            servicio.getPacientesCompleted += new EventHandler<ws.getPacientesCompletedEventArgs>(cargaPacientes);
            servicio.getPacientesAsync();
            servicio.getMedicosCompleted += new EventHandler<ws.getMedicosCompletedEventArgs>(cargaMedicos);

            DP_Fecha.DisplayDateStart = DateTime.Now;
            DP_Fecha.DisplayDateEnd = DateTime.MaxValue;
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e) {
        }

        public void cargaPacientes(object sender, ws.getPacientesCompletedEventArgs e) {
            Pacientes = e.Result.ToList();
            CB_Pacientes.Items.Clear();
            foreach (var paciente in Pacientes) {
               CB_Pacientes.Items.Add(paciente.forUI);
            }
        }

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

        public void actualizarMedicos(decimal sede) {
            try {
                servicio.getMedicosAsync(Convert.ToInt32(sede));
            } catch {

            }
        }

        public void cargaMedicos(object sender, ws.getMedicosCompletedEventArgs e) {
            Medicos = e.Result.ToList();
            CB_Medicos.Items.Clear();
            foreach (var medico in Medicos) {
                CB_Medicos.Items.Add(medico.forUI);
            }
        }

        public void CB_Sede_ItemChanged(object sender, EventArgs e) {
            decimal sede = Sedes[CB_Sede.SelectedIndex].IDSede;
            actualizarMedicos(sede);
        }

    }
}
