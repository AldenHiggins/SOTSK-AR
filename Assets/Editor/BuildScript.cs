using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class BuildScript
{
    static void Build()
    {
        string[] scenes = { "Assets/GameFolder/Scenes/BaseScene.unity", "Assets/GameFolder/Scenes/RoomLightMap.unity", "Assets/GameFolder/Scenes/FieldLevel1.unity" };
        BuildPipeline.BuildPlayer(scenes, "SOTSKBuild", BuildTarget.iOS, BuildOptions.None);
    }
}
