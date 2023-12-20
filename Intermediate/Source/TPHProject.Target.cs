using UnrealBuildTool;

public class TPHProjectTarget : TargetRules
{
	public TPHProjectTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TPHProject");
	}
}
