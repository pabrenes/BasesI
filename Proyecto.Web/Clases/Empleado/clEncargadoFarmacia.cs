using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clEncargadoFarmacia
{
    [DataMember]
    public decimal IDEmpleado { get; set; }
    [DataMember]
    public decimal IDFarmacia { get; set; }
    [DataMember]
    public decimal IDSede { get; set; }

    public clEncargadoFarmacia(
        decimal IDEmpleado, 
        decimal IDFarmacia, 
        decimal IDSede)
    {
        this.IDEmpleado = IDEmpleado;
        this.IDFarmacia = IDFarmacia;
        this.IDSede = IDSede;
    }
}