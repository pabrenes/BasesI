using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clSede
{

    [DataMember]
    public decimal IDSede { get; set; }
    [DataMember]
    public decimal CedulaJuridica { get; set; }
    [DataMember]
    public string RazonSocial { get; set; }
    [DataMember]
    public string Direccion { get; set; }

    public clSede(
        decimal IDSede,
        decimal CedulaJuridica,
        string RazonSocial,
        string Direccion)
    {
        this.IDSede = IDSede;
        this.CedulaJuridica = CedulaJuridica;
        this.RazonSocial = RazonSocial;
        this.Direccion = Direccion;
    }

}