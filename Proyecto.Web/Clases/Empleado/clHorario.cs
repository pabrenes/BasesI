using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clHorario
{

	[DataMember]
	public decimal IDEmpleado { get; set; }
	[DataMember]
	public decimal IDSede { get; set; }
	[DataMember]
	public string Dia { get; set; }
	[DataMember]
	public decimal Hora { get; set; }

	public clHorario(
		decimal IDEmpleado,
		decimal IDSede,
		string Dia,
		decimal Hora)
	{
		this.IDEmpleado = IDEmpleado;
		this.IDSede = IDSede;
		this.Dia = Dia;
		this.Hora = Hora;
	}

}
