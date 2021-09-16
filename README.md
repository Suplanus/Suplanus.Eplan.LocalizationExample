# Suplanus.Eplan.LocalizationExample

WPF not find the resource files in an API addin, which is loaded from the shadow copy directory. If the assemblies are in the EPLAN bin folder, it works, but you need admin rights.

In this example you find the [`TranslationManager.Init()`](https://github.com/Suplanus/Suplanus.Eplan.LocalizationExample/blob/23d06beadc6ee27511b8574095566129bd3409ed/src/LocalizationExample.EplAddIn.Gui/AddInModule.cs#L27) method which inits dummy object. So the build process not removing the assembly reference. It`s important to init BEFORE you access WPF objects.
