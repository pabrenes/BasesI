using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clEncargadoLaboratorio
{

	[DataMember]
	public decimal IDEmpleado { get; set; }
	[DataMember]
	public decimal IDLaboratorio { get; set; }
	[DataMember]
	public decimal IDSede { get; set; }

	public clEncargadoLaboratorio(
		decimal IDEmpleado,
		decimal IDLaboratorio,
		decimal IDSede)
	{
		this.IDEmpleado = IDEmpleado;
		this.IDLaboratorio = IDLaboratorio;
        this.IDSede = IDSede;
	}

}
