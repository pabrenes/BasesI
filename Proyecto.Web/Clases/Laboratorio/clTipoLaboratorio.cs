using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clTipoLaboratorio
{

	[DataMember]
	public decimal IDTipo { get; set; }
	[DataMember]
	public string Nombre { get; set; }

	public clTipoLaboratorio(
		decimal IDTipo,
		string Nombre)
	{
		this.IDTipo = IDTipo;
		this.Nombre = Nombre;
	}

}
