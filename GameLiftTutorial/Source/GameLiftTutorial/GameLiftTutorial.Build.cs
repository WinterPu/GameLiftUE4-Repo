// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class GameLiftTutorial : ModuleRules
{
	public GameLiftTutorial(ReadOnlyTargetRules Target) : base(Target)
	{
        bEnableExceptions = true;

		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        //  https://www.youtube.com/watch?v=2I8JDeMGkgc&t=736s
        /// 1- in the project .cs file change the order of the plugins and write the client version first for example :
        ///     PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "UMG", "GameLiftClientSDK", "GameLiftServerSDK" });`
        /// 2 - You don't need to upload the client version .exe for the server so after five server files copied in WindowsNoEditor\Agar\Binaries\Win64 you can delete the default .exe & .pdb files

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "UMG", "GameLiftClientSDK", "GameLiftServerSDK" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

        //if (Target.Type == TargetRules.TargetType.Client)
        //{
        //    PublicDependencyModuleNames.Add("GameLiftClientSDK");
        //    PublicDefinitions.Add("WITH_GAMELIFT=0");
        //}
        //else if (Target.Type == TargetRules.TargetType.Server)
        //{
        //    PublicDependencyModuleNames.Add("GameLiftServerSDK");
        //    PublicDefinitions.Add("WITH_GAMELIFTCLIENTSDK=0");
        //}

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}
