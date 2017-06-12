using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clEmpleadoSede
{

	[DataMember]
	public decimal IDEmpleado { get; set; }
	[DataMember]
	public decimal IDSede { get; set; }
	[DataMember]
	public decimal VigenciaFechaInicio { get; set; }
	[DataMember]
	public DateTime VigenciaFechaFinal { get; set; }

	public clEmpleadoSede(
		decimal IDEmpleado,
		decimal IDSede,
		decimal VigenciaFechaInicio,
		DateTime VigenciaFechaFinal)
	{
		this.IDEmpleado = IDEmpleado;
		this.IDSede = IDSede;
		this.VigenciaFechaInicio = VigenciaFechaInicio;
		this.VigenciaFechaFinal = VigenciaFechaFinal;
	}

}
