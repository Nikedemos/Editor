﻿using System;
using UnityEditor;
using UnityEngine;

[Serializable]

public static class LandData 
{
    public static float[,,] groundArray;
    public static float[,,] biomeArray;
    public static float[,,] alphaArray;
    public static float[][,,] topologyArray = new float[TerrainTopology.COUNT][,,];

    [HideInInspector]
    public static TerrainLayer[] groundTextures = null;
    [HideInInspector]
    public static TerrainLayer[] biomeTextures = null;
    [HideInInspector]
    public static TerrainLayer[] miscTextures = null;

    static Terrain terrain = GameObject.FindGameObjectWithTag("LandData").transform.parent.GetComponent<Terrain>();
    static string layerName = "";

    public static void SetData(float[,,] floatArray, string name, int topology = 0)
    {
        switch (name.ToLower())
        {
            case "ground":
                groundArray = floatArray;
                break;
            case "biome":
                biomeArray = floatArray;
                break;
            case "alpha":
                alphaArray = floatArray;
                break;
            case "topology":
                topologyArray[topology] = floatArray; 
                break;
        }
        layerName = name;
    }
    public static void GetTextures()
    {
        groundTextures = GetGroundTextures();
        biomeTextures = GetBiomeTextures();
        miscTextures = GetAlphaTextures();
        AssetDatabase.SaveAssets();
    }
    public static void SetLayer(string layer, int topology = 0)
    {
        if (groundTextures == null || biomeTextures == null || miscTextures == null)
        {
            GetTextures();
        }
        Selection.activeGameObject = null;
        switch (layer.ToLower())
        {
            case "ground":
                layerName = "ground";
                terrain.terrainData.terrainLayers = groundTextures;
                terrain.terrainData.SetAlphamaps(0, 0, groundArray);
                break;
            case "biome":
                layerName = "biome";
                terrain.terrainData.terrainLayers = biomeTextures;
                terrain.terrainData.SetAlphamaps(0, 0, biomeArray);
                break;
            case "alpha":
                layerName = "alpha";
                terrain.terrainData.terrainLayers = miscTextures;
                terrain.terrainData.SetAlphamaps(0, 0, alphaArray);
                break;
            case "topology":
                layerName = "topology";
                terrain.terrainData.terrainLayers = miscTextures;
                terrain.terrainData.SetAlphamaps(0, 0, topologyArray[topology]);
                break;
        }
    }
    public static void Save(int topologyLayer = 0)
    {
        switch (layerName)
        {
            case "ground":
                groundArray = terrain.terrainData.GetAlphamaps(0, 0, terrain.terrainData.alphamapWidth, terrain.terrainData.alphamapHeight);
                break;
            case "biome":
                biomeArray = terrain.terrainData.GetAlphamaps(0, 0, terrain.terrainData.alphamapWidth, terrain.terrainData.alphamapHeight);
                break;
            case "alpha":
                alphaArray = terrain.terrainData.GetAlphamaps(0, 0, terrain.terrainData.alphamapWidth, terrain.terrainData.alphamapHeight);
                break;
            case "topology":
                topologyArray[topologyLayer] = terrain.terrainData.GetAlphamaps(0, 0, terrain.terrainData.alphamapWidth, terrain.terrainData.alphamapHeight);
                break;
        }
    }
    public static TerrainLayer[] GetAlphaTextures()
    {
        TerrainLayer[] textures = new TerrainLayer[2];
        textures[0] = AssetDatabase.LoadAssetAtPath<TerrainLayer>("Assets/Resources/Textures/Misc/Active.terrainlayer");
        textures[0].diffuseTexture = Resources.Load<Texture2D>("Textures/Misc/active");
        textures[1] = AssetDatabase.LoadAssetAtPath<TerrainLayer>("Assets/Resources/Textures/Misc/InActive.terrainlayer");
        textures[1].diffuseTexture = Resources.Load<Texture2D>("Textures/Misc/inactive");
        return textures;
    }
    public static TerrainLayer[] GetBiomeTextures()
    {
        TerrainLayer[] textures = new TerrainLayer[4];
        textures[0] = AssetDatabase.LoadAssetAtPath<TerrainLayer>("Assets/Resources/Textures/Biome/Tundra.terrainlayer");
        textures[0].diffuseTexture = Resources.Load<Texture2D>("Textures/Biome/tundra");
        textures[1] = AssetDatabase.LoadAssetAtPath<TerrainLayer>("Assets/Resources/Textures/Biome/Temperate.terrainlayer");
        textures[1].diffuseTexture = Resources.Load<Texture2D>("Textures/Biome/temperate");
        textures[2] = AssetDatabase.LoadAssetAtPath<TerrainLayer>("Assets/Resources/Textures/Biome/Arid.terrainlayer");
        textures[2].diffuseTexture = Resources.Load<Texture2D>("Textures/Biome/arid");
        textures[3] = AssetDatabase.LoadAssetAtPath<TerrainLayer>("Assets/Resources/Textures/Biome/Arctic.terrainlayer");
        textures[3].diffuseTexture = Resources.Load<Texture2D>("Textures/Biome/arctic");
        return textures;
    }
    public static TerrainLayer[] GetGroundTextures()
    {
        TerrainLayer[] textures = new TerrainLayer[8];
        textures[0] = AssetDatabase.LoadAssetAtPath<TerrainLayer>("Assets/Resources/Textures/Ground/Dirt.terrainlayer");
        textures[0].diffuseTexture = Resources.Load<Texture2D>("Textures/Ground/dirt");
        textures[1] = AssetDatabase.LoadAssetAtPath<TerrainLayer>("Assets/Resources/Textures/Ground/Snow.terrainlayer");
        textures[1].diffuseTexture = Resources.Load<Texture2D>("Textures/Ground/snow");
        textures[2] = AssetDatabase.LoadAssetAtPath<TerrainLayer>("Assets/Resources/Textures/Ground/Sand.terrainlayer");
        textures[2].diffuseTexture = Resources.Load<Texture2D>("Textures/Ground/sand");
        textures[3] = AssetDatabase.LoadAssetAtPath<TerrainLayer>("Assets/Resources/Textures/Ground/Rock.terrainlayer");
        textures[3].diffuseTexture = Resources.Load<Texture2D>("Textures/Ground/rock");
        textures[4] = AssetDatabase.LoadAssetAtPath<TerrainLayer>("Assets/Resources/Textures/Ground/Grass.terrainlayer");
        textures[4].diffuseTexture = Resources.Load<Texture2D>("Textures/Ground/grass");
        textures[5] = AssetDatabase.LoadAssetAtPath<TerrainLayer>("Assets/Resources/Textures/Ground/Forest.terrainlayer");
        textures[5].diffuseTexture = Resources.Load<Texture2D>("Textures/Ground/forest");
        textures[6] = AssetDatabase.LoadAssetAtPath<TerrainLayer>("Assets/Resources/Textures/Ground/Stones.terrainlayer");
        textures[6].diffuseTexture = Resources.Load<Texture2D>("Textures/Ground/stones");
        textures[7] = AssetDatabase.LoadAssetAtPath<TerrainLayer>("Assets/Resources/Textures/Ground/Gravel.terrainlayer");
        textures[7].diffuseTexture = Resources.Load<Texture2D>("Textures/Ground/gravel");
        return textures;
    }
}
