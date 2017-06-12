using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clEmpleado
{
    [DataMember]
    public decimal IDEmpleado { get; set; }
    [DataMember]
    public decimal IDPuesto { get; set; }
    [DataMember]
    public string Nombre { get; set; }
    [DataMember]
    public string Apellidos { get; set; }
    [DataMember]
    public string Residencia { get; set; }
    [DataMember]
    public decimal Fotografia { get; set; }

    public clEmpleado(
        decimal IDEmpleado,
        decimal IDPuesto,
        string Nombre,
        string Apellidos,
        string Residencia,
        decimal Fotografia)
    {
        this.IDEmpleado = IDEmpleado;
        this.IDPuesto = IDPuesto;
        this.Nombre = Nombre;
        this.Apellidos = Apellidos;
        this.Residencia = Residencia;
        this.Fotografia = Fotografia;
    }

}