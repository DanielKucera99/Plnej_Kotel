using UnrealBuildTool;

public class TPHProjectEditorTarget : TargetRules
{
	public TPHProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("TPHProject");
	}
}
