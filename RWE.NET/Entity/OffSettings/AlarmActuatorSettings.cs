using System;

namespace RWE.NET.Entity.OffSettings
{
	public class AlarmActuatorSettings : DefaultOffSettings
	{
		public double AlarmDuration { get; set; }
		public bool IsOn { get; set; }
	}
}

