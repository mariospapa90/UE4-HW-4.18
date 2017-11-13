// @third party code - BEGIN HairWorks
using UnrealBuildTool;

public class HairWorks : ModuleRules
{
	public HairWorks(ReadOnlyTargetRules Target) : base(Target)
	{
		Type = ModuleType.External;

		// Add DLL to package
		string PlatformString = null;
		switch (Target.Platform)
		{
			case UnrealTargetPlatform.Win32:
				PlatformString = "win32";
				break;
			case UnrealTargetPlatform.Win64:
				PlatformString = "win64";
				break;
		}

		if (PlatformString != null)
		{
			// Add HairWorks DLL
			string DllPath = "$(EngineDir)/Binaries/ThirdParty/HairWorks/NvHairWorksDx11." + PlatformString + ".dll";
			RuntimeDependencies.Add(new RuntimeDependency(DllPath));

			// Add shader compiler DLL
			DllPath = "$(EngineDir)/Binaries/" + PlatformString + "/d3dcompiler_47.dll";
			RuntimeDependencies.Add(new RuntimeDependency(DllPath));
		}
	}
}
// @third party code - END HairWorks


