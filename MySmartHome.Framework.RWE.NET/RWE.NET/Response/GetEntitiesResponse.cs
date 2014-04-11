using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace RWE.NET.Response
{
  using RWE.NET.Entity;
  using RWE.NET.Entity.Device;
  using RWE.NET.Entity.Profiles;

  public class GetEntitiesResponse : BaseResponse
  {
    [XmlArray("LCs"), XmlArrayItem(ElementName = "LC", Type = typeof(Location))]
    public virtual List<Location> Locations { get; set; }
    [XmlElement("BDs")]
    public virtual Object BaseDevices { get; set; }
    [XmlArray("LDs"), XmlArrayItem(ElementName = "LD", Type = typeof(LogicalDevice))]
    public virtual List<LogicalDevice> LogicalDevices { get; set; }
    [XmlElement("PFs")]
    public virtual List<Profile> Profiles { get; set; }
    [XmlElement("AcCts")]
    public virtual Object ActuatorContainers { get; set; }
  }
}
