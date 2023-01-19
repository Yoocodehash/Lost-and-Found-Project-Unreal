using UnrealBuildTool;

public class HorrorGameTarget : TargetRules
{
	public HorrorGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("HorrorGame");
	}
}
