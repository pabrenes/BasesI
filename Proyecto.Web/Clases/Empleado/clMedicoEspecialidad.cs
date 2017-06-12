using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clMedicoEspecialidad
{
    [DataMember]
    public decimal IDMedico { get; set; }
    [DataMember]
    public decimal IDSede { get; set; }
    [DataMember]
    public decimal IDEspecialidad { get; set; }
    [DataMember]
    public decimal PrecioCita { get; set; }

    public clMedicoEspecialidad(
        decimal IDMedico, 
        decimal IDSede, 
        decimal IDEspecialidad, 
        decimal PrecioCita)
    {
        this.IDMedico = IDMedico;
        this.IDSede = IDSede;
        this.IDEspecialidad = IDEspecialidad;
        this.PrecioCita = PrecioCita;
    }
}