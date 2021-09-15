using Eplan.EplApi.ApplicationFramework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalizationExample.EplAddIn.Gui.Views;

namespace LocalizationExample.EplAddIn.Gui.Actions
{
  public class LocalizationExampleAction : IEplAction
  {
    [SuppressMessage("ReSharper", "RedundantAssignment")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public bool OnRegister(ref string Name, ref int Ordinal)
    {
      Name = nameof(LocalizationExampleAction);
      Ordinal = 20;
      return true;
    }

    public bool Execute(ActionCallingContext actionCallingContext)
    {
      var window = new Window1();
      window.ShowDialog();

      return true;
    }

    public void GetActionProperties(ref ActionProperties actionProperties) { }
  }
}