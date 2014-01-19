
namespace RWE.NET.Entity
{
  public class SwitchActuatorState : LogicalDeviceState
  {
    bool isOn;
    public virtual bool IsOn
    {
      get
      {
        return isOn;
      }

      set
      {
        isOn = value;
        OnPropertyChanged(value);
      }
    }
  }
}
