using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clItemSolicitud
{

	[DataMember]
	public decimal IDExamen { get; set; }
	[DataMember]
	public decimal IDItem { get; set; }
	[DataMember]
	public decimal IDSolicitud { get; set; }
	[DataMember]
	public string Resultado { get; set; }
	[DataMember]
	public string Observaciones { get; set; }

	public clItemSolicitud(
		decimal IDExamen,
		decimal IDItem,
		decimal IDSolicitud,
		string Resultado,
		string Observaciones)
	{
		this.IDExamen = IDExamen;
		this.IDItem = IDItem;
		this.IDSolicitud = IDSolicitud;
		this.Resultado = Resultado;
		this.Observaciones = Observaciones;
	}

}
