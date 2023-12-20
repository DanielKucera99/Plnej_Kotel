using UnrealBuildTool;

public class TPHProjectClientTarget : TargetRules
{
	public TPHProjectClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("TPHProject");
	}
}
