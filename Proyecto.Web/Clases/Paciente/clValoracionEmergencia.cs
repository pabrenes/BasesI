using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clValoracionEmergencia
{

    [DataMember]
    public string CedulaPaciente { get; set; }
    [DataMember]
    public DateTime Fecha { get; set; }
    [DataMember]
    public string Observaciones { get; set; }

    public clValoracionEmergencia(
        string CedulaPaciente,
        DateTime Fecha,
        string Observaciones)
    {
        this.CedulaPaciente = CedulaPaciente;
        this.Fecha = Fecha;
        this.Observaciones = Observaciones;
    }

}