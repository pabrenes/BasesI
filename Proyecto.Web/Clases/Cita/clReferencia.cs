using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clReferencia
{

	[DataMember]
	public decimal IDReferencia { get; set; }
	[DataMember]
	public decimal IDCita { get; set; }
	[DataMember]
	public decimal IDEspecialidad { get; set; }
	[DataMember]
	public string Comentarios { get; set; }

	public clReferencia(
		decimal IDReferencia,
		decimal IDCita,
		decimal IDEspecialidad,
		string Comentarios)
	{
		this.IDReferencia = IDReferencia;
		this.IDCita = IDCita;
		this.IDEspecialidad = IDEspecialidad;
		this.Comentarios = Comentarios;
	}

}
