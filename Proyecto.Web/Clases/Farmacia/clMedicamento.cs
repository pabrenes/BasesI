using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clMedicamento
{

	[DataMember]
	public decimal IDMedicamento { get; set; }
	[DataMember]
	public string Nombre { get; set; }
	[DataMember]
	public string Descripcion { get; set; }

	public clMedicamento(
		decimal IDMedicamento,
		string Nombre,
		string Descripcion)
	{
		this.IDMedicamento = IDMedicamento;
		this.Nombre = Nombre;
		this.Descripcion = Descripcion;
	}

}
