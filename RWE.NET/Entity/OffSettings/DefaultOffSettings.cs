using System;
using System.Xml.Serialization;

namespace RWE.NET.Entity.OffSettings
{
  [XmlInclude(typeof(GenericActuatorSettings))]
  [XmlInclude(typeof(SwitchActuatorSettings))]
  [XmlInclude(typeof(RoomTemperatureActuatorSettings))]
  [XmlInclude(typeof(DimmerActuatorSettings))]
	[XmlInclude(typeof(AlarmActuatorSettings))]
  public class DefaultOffSettings
  {
    [XmlElement("Id")]
    public virtual Guid Id { get; set; }
	[XmlElement("AcId")]
    public virtual Guid ActuatorId { get; set; }
  }
}
