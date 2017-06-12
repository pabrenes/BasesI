using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clContactoResponsable
{

    [DataMember]
    public string PacienteMenor { get; set; }
    [DataMember]
    public string Responsable { get; set; }
    [DataMember]
    public string Tipo { get; set; }

    public clContactoResponsable(
        string PacienteMenor,
        string Responsable,
        string Tipo)
    {
        this.PacienteMenor = PacienteMenor;
        this.Responsable = Responsable;
        this.Tipo = Tipo;
    }

}