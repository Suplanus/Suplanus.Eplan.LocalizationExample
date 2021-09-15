using Eplan.EplApi.ApplicationFramework;

namespace LocalizationExample.EplAddIn.Gui
{
  public class AddInModule : IEplAddIn
  {
    // ReSharper disable once RedundantAssignment
    public bool OnRegister(ref bool bLoadOnStart)
    {
      bLoadOnStart = true;
      return true;
    }

    public bool OnUnregister()
    {
      return true;
    }

    public bool OnInit()
    {
      return true;
    }

    public bool OnInitGui()
    {
      return true;
    }

    public bool OnExit()
    {
      return true;
    }
  }
}
