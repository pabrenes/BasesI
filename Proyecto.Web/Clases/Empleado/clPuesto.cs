using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clPuesto
{
    [DataMember]
    public decimal IDPuesto { get; set; }
    [DataMember]
    public string Nombre { get; set; }
    [DataMember]
    public string Descripcion { get; set; }

    public clPuesto(
        decimal IDPuesto, 
        string Nombre, 
        string Descripcion)
    {
        this.IDPuesto = IDPuesto;
        this.Nombre = Nombre;
        this.Descripcion = Descripcion;
    }
}