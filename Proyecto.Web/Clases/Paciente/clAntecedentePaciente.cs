using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clAntecedentePaciente
{

    [DataMember]
    public string CedulaPaciente { get; set; }
    [DataMember]
    public decimal IDAntecedente { get; set; }
    [DataMember]
    public string Observacion { get; set; }

    public clAntecedentePaciente(
        string CedulaPaciente,
        decimal IDAntecedente,
        string Observacion)
    {
        this.CedulaPaciente = CedulaPaciente;
        this.IDAntecedente = IDAntecedente;
        this.Observacion = Observacion;
    }

}