using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clCentro
{

    [DataMember]
    public decimal CedulaJuridica { get; set; }
    [DataMember]
    public string RazonSocial { get; set; }

    public clCentro(
        decimal CedulaJuridica,
        string RazonSocial)
    {
        this.CedulaJuridica = CedulaJuridica;
        this.RazonSocial = RazonSocial;
    }

}