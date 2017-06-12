using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clPacienteTelefono
{

    [DataMember]
    public string CedulaPaciente { get; set; }
    [DataMember]
    public decimal Telefono { get; set; }

    public clPacienteTelefono(
        string CedulaPaciente,
        decimal Telefono)
    {
        this.CedulaPaciente = CedulaPaciente;
        this.Telefono = Telefono;
    }

}