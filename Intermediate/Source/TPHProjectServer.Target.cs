using UnrealBuildTool;

public class TPHProjectServerTarget : TargetRules
{
	public TPHProjectServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("TPHProject");
	}
}
