using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clExamenLaboratorio
{

	[DataMember]
	public decimal IDExamen { get; set; }
	[DataMember]
	public decimal IDLaboratorio { get; set; }
	[DataMember]
	public decimal CostoHonorario { get; set; }
	[DataMember]
	public decimal CosoEquipo { get; set; }

	public clExamenLaboratorio(
		decimal IDExamen,
		decimal IDLaboratorio,
		decimal CostoHonorario,
		decimal CosoEquipo)
	{
		this.IDExamen = IDExamen;
		this.IDLaboratorio = IDLaboratorio;
		this.CostoHonorario = CostoHonorario;
		this.CosoEquipo = CosoEquipo;
	}

}
