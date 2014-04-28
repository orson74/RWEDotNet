using System;
using System.Collections.Generic;

namespace RWE.NET.Entity.Device
{
	/// <summary>
	/// Temperature sensor.
	/// </summary>
    public class TemperatureSensor : LogicalDevice
    {
        public List<Guid> UnderlyingDevicesIds { get; set; }
    }
}
