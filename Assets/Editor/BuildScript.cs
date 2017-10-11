using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class BuildScript
{
    static void Build()
    {
        string[] scenes = { "Assets/GameFolder/Scenes/BaseSceneAR.unity" };
        BuildPipeline.BuildPlayer(scenes, "SOTSKBuild", BuildTarget.iOS, BuildOptions.None);
    }
}
