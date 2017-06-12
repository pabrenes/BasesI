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
            servicio.getCitasCompleted += new EventHandler<ws.getCitasCompletedEventArgs>(cargaClientes);
            servicio.getCitasAsync();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e) {
        }

        public void cargaClientes(object sender, ws.getCitasCompletedEventArgs e) {
            DG_CITAS.ItemsSource = e.Result;
        }

    }
}
