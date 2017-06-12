using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clAntecedente
{

    [DataMember]
    public decimal IDAntecedente { get; set; }
    [DataMember]
    public string Nombre { get; set; }

    public clAntecedente(
        decimal IDAntecedente,
        string Nombre)
    {
        this.IDAntecedente = IDAntecedente;
        this.Nombre = Nombre;
    }

}