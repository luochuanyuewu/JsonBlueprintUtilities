// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class JsonBlueprintUtilities : ModuleRules
{
	//是否支持蓝图结构体?
	private bool bWithBpSupport = true; 
	public JsonBlueprintUtilities(ReadOnlyTargetRules Target) : base(Target)
	{
		
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(
			new string[] {
				"Core",
                "CoreUObject",
                "Engine", "JsonUtilities",
            });

		PrivateDependencyModuleNames.AddRange(
			new string[] {
				"Json",
			});

		if (bWithBpSupport)
		{
			PublicDefinitions.Add("WITH_BPSUPPORT=1");
		}
		else
		{
			PublicDefinitions.Add("WITH_BPSUPPORT=0");
		}

	}
}
