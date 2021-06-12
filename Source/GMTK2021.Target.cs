// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class GMTK2021Target : TargetRules
{
	public GMTK2021Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		bUseUnityBuild = false;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "GMTK2021" } );
	}
}
