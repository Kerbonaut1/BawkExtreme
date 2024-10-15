using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(BawkExtreme.BuildInfo.Description)]
[assembly: AssemblyDescription(BawkExtreme.BuildInfo.Description)]
[assembly: AssemblyCompany(BawkExtreme.BuildInfo.Company)]
[assembly: AssemblyProduct(BawkExtreme.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + BawkExtreme.BuildInfo.Author)]
[assembly: AssemblyTrademark(BawkExtreme.BuildInfo.Company)]
[assembly: AssemblyVersion(BawkExtreme.BuildInfo.Version)]
[assembly: AssemblyFileVersion(BawkExtreme.BuildInfo.Version)]
[assembly: MelonInfo(typeof(BawkExtreme.TestMod), BawkExtreme.BuildInfo.Name, BawkExtreme.BuildInfo.Version, BawkExtreme.BuildInfo.Author, BawkExtreme.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]