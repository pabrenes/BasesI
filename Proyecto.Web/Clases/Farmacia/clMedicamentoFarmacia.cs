using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clMedicamentoFarmacia
{

	[DataMember]
	public decimal IDMedicamento { get; set; }
	[DataMember]
	public decimal IDFarmacia { get; set; }
	[DataMember]
	public decimal IDSede { get; set; }
	[DataMember]
	public decimal Precio { get; set; }

	public clMedicamentoFarmacia(
		decimal IDMedicamento,
		decimal IDFarmacia,
		decimal IDSede,
		decimal Precio)
	{
		this.IDMedicamento = IDMedicamento;
		this.IDFarmacia = IDFarmacia;
		this.IDSede = IDSede;
		this.Precio = Precio;
	}

}
