using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWE.NET.Entity.OffSettings
{
	public class DimmerActuatorSettings : DefaultOffSettings
	{
		public virtual long Maximum { get; set; }
		public virtual long Minimum { get; set; }

	}
}