// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RPG_GAME : ModuleRules
{
	public RPG_GAME(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { "GameplayAbilities","GameplayTasks", "GameplayTags" });

		PublicIncludePaths.AddRange(new string[] {
			"RPG_GAME",
			"RPG_GAME/Variant_Platforming",
			"RPG_GAME/Variant_Platforming/Animation",
			"RPG_GAME/Variant_Combat",
			"RPG_GAME/Variant_Combat/AI",
			"RPG_GAME/Variant_Combat/Animation",
			"RPG_GAME/Variant_Combat/Gameplay",
			"RPG_GAME/Variant_Combat/Interfaces",
			"RPG_GAME/Variant_Combat/UI",
			"RPG_GAME/Variant_SideScrolling",
			"RPG_GAME/Variant_SideScrolling/AI",
			"RPG_GAME/Variant_SideScrolling/Gameplay",
			"RPG_GAME/Variant_SideScrolling/Interfaces",
			"RPG_GAME/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
