using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clSeguimiento
{

	[DataMember]
	public decimal IDCita { get; set; }
	[DataMember]
	public decimal IDCitaAnterior { get; set; }
	[DataMember]
	public string Motivo { get; set; }
	[DataMember]
	public string Observaciones { get; set; }

	public clSeguimiento(
		decimal IDCita,
		decimal IDCitaAnterior,
		string Motivo,
		string Observaciones)
	{
		this.IDCita = IDCita;
		this.IDCitaAnterior = IDCitaAnterior;
		this.Motivo = Motivo;
		this.Observaciones = Observaciones;
	}

}
