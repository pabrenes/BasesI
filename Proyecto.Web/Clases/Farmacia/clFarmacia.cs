using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;

[DataContract]
public class clFarmacia
{

	[DataMember]
	public decimal IDFarmacia { get; set; }
	[DataMember]
	public decimal IDSede { get; set; }

	public clFarmacia(
		decimal IDFarmacia,
		decimal IDSede)
	{
		this.IDFarmacia = IDFarmacia;
		this.IDSede = IDSede;
	}

}
