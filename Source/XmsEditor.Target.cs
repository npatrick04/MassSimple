// Copyright (c) 2025 Xist.GG LLC

using UnrealBuildTool;

public class XmsEditorTarget : TargetRules
{
	public XmsEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V7;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_8;
		ExtraModuleNames.Add("Xms");
	}
}
