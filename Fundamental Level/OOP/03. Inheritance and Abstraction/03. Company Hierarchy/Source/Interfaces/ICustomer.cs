using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy.Interfaces
{
	interface ICustomer
	{
		decimal NetPurchaseAmount { get; set; }
		string ToString();
	}
}
