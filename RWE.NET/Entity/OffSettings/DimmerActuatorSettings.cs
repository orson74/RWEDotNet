using System;
using System.Xml.Serialization;

namespace RWE.NET.Entity.OffSettings
{
	public class DimmerActuatorSettings : DefaultOffSettings
	{
		[XmlElement("TMxV")]
		public virtual long Maximum { get; set; }
		[XmlElement("TMnV")]
		public virtual long Minimum { get; set; }

	}
}