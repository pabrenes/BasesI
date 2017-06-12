using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clReceta
{

	[DataMember]
	public decimal IDReceta { get; set; }
	[DataMember]
	public decimal IDFactura { get; set; }
	[DataMember]
	public decimal IDCita { get; set; }
	[DataMember]
	public DateTime FechaEntrega { get; set; }
	[DataMember]
	public decimal IDFarmaceutico { get; set; }

	public clReceta(
		decimal IDReceta,
		decimal IDFactura,
		decimal IDCita,
		DateTime FechaEntrega,
		decimal IDFarmaceutico)
	{
		this.IDReceta = IDReceta;
		this.IDFactura = IDFactura;
		this.IDCita = IDCita;
		this.FechaEntrega = FechaEntrega;
		this.IDFarmaceutico = IDFarmaceutico;
	}

}
