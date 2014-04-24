using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWE.NET.Entity.OffSettings
{
	public class AlarmActuatorSettings : DefaultOffSettings
	{
		public double AlarmDuration { get; set; }
		public bool IsOn { get; set; }
	}
}

