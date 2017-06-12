using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clSignoVitalValoracion
{

    [DataMember]
    public string CedulaPaciente { get; set; }
    [DataMember]
    public DateTime Fecha { get; set; }
    [DataMember]
    public string TipoSignoVital { get; set; }
    [DataMember]
    public string Resultado { get; set; }

    public clSignoVitalValoracion(
        string CedulaPaciente,
        DateTime Fecha,
        string TipoSignoVital,
        string Resultado)
    {
        this.CedulaPaciente = CedulaPaciente;
        this.Fecha = Fecha;
        this.TipoSignoVital = TipoSignoVital;
        this.Resultado = Resultado;
    }

}