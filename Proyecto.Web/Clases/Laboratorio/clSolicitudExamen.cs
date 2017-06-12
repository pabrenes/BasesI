using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clSolicitudExamen
{

	[DataMember]
	public decimal IDSolicitud { get; set; }
	[DataMember]
	public decimal IDLaboratorio { get; set; }
	[DataMember]
	public decimal IDExamen { get; set; }
	[DataMember]
	public decimal IDCita { get; set; }
	[DataMember]
	public DateTime FechaSolicitud { get; set; }
	[DataMember]
	public DateTime FechaAplicacion { get; set; }
	[DataMember]
	public DateTime FechaResultado { get; set; }
	[DataMember]
	public string Observaciones { get; set; }
	[DataMember]
	public decimal IDFactura { get; set; }

	public clSolicitudExamen(
		decimal IDSolicitud,
		decimal IDLaboratorio,
		decimal IDExamen,
		decimal IDCita,
		DateTime FechaSolicitud,
		DateTime FechaAplicacion,
		DateTime FechaResultado,
		string Observaciones,
		decimal IDFactura)
	{
		this.IDSolicitud = IDSolicitud;
		this.IDLaboratorio = IDLaboratorio;
		this.IDExamen = IDExamen;
		this.IDCita = IDCita;
		this.FechaSolicitud = FechaSolicitud;
		this.FechaAplicacion = FechaAplicacion;
		this.FechaResultado = FechaResultado;
		this.Observaciones = Observaciones;
		this.IDFactura = IDFactura;
	}

}
