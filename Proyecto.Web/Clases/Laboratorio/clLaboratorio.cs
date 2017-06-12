using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clLaboratorio
{

	[DataMember]
	public decimal IDLaboratorio { get; set; }
	[DataMember]
	public decimal IDSede { get; set; }
	[DataMember]
	public decimal Tipo { get; set; }

	public clLaboratorio(
		decimal IDLaboratorio,
		decimal IDSede,
		decimal Tipo)
	{
		this.IDLaboratorio = IDLaboratorio;
		this.IDSede = IDSede;
		this.Tipo = Tipo;
	}

}
