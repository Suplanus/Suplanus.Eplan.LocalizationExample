using System;

namespace LocalizationExample.Translations
{
  public class TranslationManager
  {
    public static void Init()
    {
      // Have to access the class that the resource file is loaded
      Action<Type> dummyAction = _ => {};
      var dummy = typeof(TranslationManager);
      dummyAction(dummy);
    }
  }
}