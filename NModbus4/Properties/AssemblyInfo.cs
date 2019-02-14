using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("NModbus4")]
[assembly: AssemblyProduct("NSModbus4")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyCopyright("Copyright ©  2019")]
[assembly: AssemblyDescription("NModbus4 is a C# (.NetStandard 2.0) implementation of the Modbus protocol. Provides connectivity to Modbus slave compatible devices and applications. Supports ASCII, RTU, TCP, and UDP protocols. NModbus4 it's a fork of NModbus(https://github.com/NModbus4/NModbus4)")]

[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: CLSCompliant(false)]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: ComVisible(false)]
[assembly: AssemblyVersion("4.0.2.0")]
[assembly: AssemblyFileVersion("4.0.2.0")]
[assembly: AssemblyInformationalVersion("4.0.2")]

#if !SIGNED
[assembly: InternalsVisibleTo("NModbus4.UnitTests")]
[assembly: InternalsVisibleTo("NModbus4.IntegrationTests")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
#endif
