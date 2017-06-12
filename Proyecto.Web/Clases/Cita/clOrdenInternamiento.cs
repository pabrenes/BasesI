using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clOrdenInternamiento
{

	[DataMember]
	public decimal IDOrden { get; set; }
	[DataMember]
	public decimal IDCita { get; set; }
	[DataMember]
	public decimal Sede { get; set; }
	[DataMember]
	public string Motivo { get; set; }
	[DataMember]
	public string Observaciones { get; set; }

	public clOrdenInternamiento(
		decimal IDOrden,
		decimal IDCita,
		decimal Sede,
		string Motivo,
		string Observaciones)
	{
		this.IDOrden = IDOrden;
		this.IDCita = IDCita;
		this.Sede = Sede;
		this.Motivo = Motivo;
		this.Observaciones = Observaciones;
	}

}
