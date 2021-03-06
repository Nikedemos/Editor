﻿using UnityEditor;
using EditorUI;

[CustomEditor(typeof(PrefabDataHolder))]
public class PrefabDataHolderEditor : Editor
{
    public override void OnInspectorGUI()
    { 
        PrefabDataHolder script = (PrefabDataHolder)target;
        if (script.prefabData == null)
        {
            return;
        }

        Functions.PrefabCategory(script);
        Functions.PrefabID(script);
        Functions.SnapToGround(script);
    }
}