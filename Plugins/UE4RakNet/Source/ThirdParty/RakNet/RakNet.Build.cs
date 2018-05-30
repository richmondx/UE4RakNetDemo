// Fill out your copyright notice in the Description page of Project Settings.

using System.IO;
using UnrealBuildTool;

public class RakNet : ModuleRules
{
	public RakNet(ReadOnlyTargetRules Target) : base(Target)
    {
		Type = ModuleType.External;

		if (Target.Platform == UnrealTargetPlatform.Win64)
		{
			// Add the import library
			PublicLibraryPaths.Add(Path.Combine(ModuleDirectory, "x64", "Release"));
			PublicAdditionalLibraries.Add("RakNet_VS2015.lib");

			// Delay-load the DLL, so we can load it from the right place first
			//PublicDelayLoadDLLs.Add("RakNet_VS2015.dll");
		};

        PublicIncludePaths.AddRange(new string[]
        {
            ModuleDirectory + "/Public"
            // ... add public include paths required here ...
        });
    }
}