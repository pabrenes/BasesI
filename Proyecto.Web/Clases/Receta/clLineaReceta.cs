using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clLineaReceta
{

	[DataMember]
	public decimal IDReceta { get; set; }
	[DataMember]
	public decimal IDLinea { get; set; }
	[DataMember]
	public decimal IDMedicamento { get; set; }
	[DataMember]
	public decimal IDFarmacia { get; set; }
	[DataMember]
	public decimal IDSede { get; set; }
	[DataMember]
	public decimal Cantidad { get; set; }
	[DataMember]
	public string Instrucciones { get; set; }

	public clLineaReceta(
		decimal IDReceta,
		decimal IDLinea,
		decimal IDMedicamento,
		decimal IDFarmacia,
		decimal IDSede,
		decimal Cantidad,
		string Instrucciones)
	{
		this.IDReceta = IDReceta;
		this.IDLinea = IDLinea;
		this.IDMedicamento = IDMedicamento;
		this.IDFarmacia = IDFarmacia;
		this.IDSede = IDSede;
		this.Cantidad = Cantidad;
		this.Instrucciones = Instrucciones;
	}

}
