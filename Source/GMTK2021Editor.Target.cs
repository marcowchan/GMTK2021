// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class GMTK2021EditorTarget : TargetRules
{
	public GMTK2021EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		bUseUnityBuild = false;
		ExtraModuleNames.AddRange( new string[] { "GMTK2021" } );
	}
}
