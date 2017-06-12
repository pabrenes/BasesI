using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clEspecialidad
{
    [DataMember]
    public decimal IDEspecialidad { get; set; }
    [DataMember]
    public string Nombre { get; set; }
    [DataMember]
    public string Descripcion { get; set; }

    public clEspecialidad(
        decimal IDEspecialidad, 
        string Nombre, 
        string Descripcion)
    {
        this.IDEspecialidad = IDEspecialidad;
        this.Nombre = Nombre;
        this.Descripcion = Descripcion;
    }
}