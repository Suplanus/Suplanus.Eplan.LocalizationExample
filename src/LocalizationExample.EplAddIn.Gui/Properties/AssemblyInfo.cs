using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;

#if SIGN
using Eplan.EplApi.Starter;
[assembly: EplanSignedAssembly(true)]
[assembly: AssemblyKeyFile(@"\\Mac\Home\Documents\GitHub\ibKastl.CodingStandards\Keyfiles\2161_Public.snk")]
[assembly: AssemblyDelaySign(true)]
#endif

[assembly: AssemblyTitle("LocalizationExample.EplAddIn.Gui")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("LocalizationExample.EplAddIn.Gui")]
[assembly: AssemblyCopyright("Copyright © ibKastl 2021")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: Guid("8bc7ac49-dd95-489f-bdde-3b41210cd96d")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Revision
//      Build Number
//
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0.0")]