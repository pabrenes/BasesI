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

        public Citas() {
            InitializeComponent();
            servicio.getPacientesCompleted += new EventHandler<ws.getPacientesCompletedEventArgs>(cargaClientes);
            servicio.getPacientesAsync();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e) {
        }

        public void cargaClientes(object sender, ws.getPacientesCompletedEventArgs e) {
            DG_PACIENTES.ItemsSource = e.Result;
        }

    }
}
