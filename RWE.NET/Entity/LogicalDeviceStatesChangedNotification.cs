﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace RWE.NET.Entity
{
  public class LogicalDeviceStatesChangedNotification
  {
    [XmlAttribute(AttributeName = "NotificationId")]
    public virtual Guid NotificationId { get; set; }

 //   [XmlAttribute(AttributeName = "Version")]
 //   public virtual string Version { get; set; }

    public List<LogicalDeviceState> LogicalDeviceStates { get; set; }
  }
}
