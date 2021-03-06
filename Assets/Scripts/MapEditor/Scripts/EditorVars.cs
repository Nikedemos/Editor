﻿using UnityEngine;

namespace EditorVariables
{
    public struct Conditions
    {
        public TerrainSplat.Enum GroundConditions
        {
            get; set;
        }
        public TerrainBiome.Enum BiomeConditions
        {
            get; set;
        }
        public TerrainTopology.Enum TopologyLayers
        {
            get; set;
        }
        public AlphaTextures AlphaTextures
        {
            get; set;
        }
        public TopologyTextures TopologyTextures
        {
            get; set;
        }
        public bool CheckAlpha
        {
            get; set;
        }
        public int AlphaTexture
        {
            get; set;
        }
        public int TopologyTexture
        {
            get; set;
        }
        public bool CheckHeight
        {
            get; set;
        }
        public float HeightLow
        {
            get; set;
        }
        public float HeightHigh
        {
            get; set;
        }
        public bool CheckSlope
        {
            get; set;
        }
        public float SlopeLow
        {
            get; set;
        }
        public float SlopeHigh
        {
            get; set;
        }
        public Dimensions Dimensions
        {
            get; set;
        }
    }
    public struct TopologyLayers
    {
        public float[,,] Topologies
        {
            get; set;
        }
    }
    public struct GroundTextures
    {
        public int Texture
        {
            get; set;
        }
    }
    public struct BiomeTextures
    {
        public int Texture
        {
            get; set;
        }
    }
    public class Dimensions
    {
        public int x0 { get; set; }
        public int x1 { get; set; }
        public int z0 { get; set; }
        public int z1 { get; set; }

    }
    public enum LandLayers
    {
        Ground = 0,
        Biome = 1,
        Alpha = 2,
        Topology = 3,
    }
    public enum AlphaTextures
    {
        Visible = 0,
        InVisible = 1,
    }
    public enum TopologyTextures
    {
        Active = 0,
        InActive = 1,
    }
    public struct SlopesInfo
    {
        public bool BlendSlopes { get; set; }
        public float SlopeBlendLow { get; set; }
        public float SlopeLow { get; set; }
        public float SlopeHigh { get; set; }
        public float SlopeBlendHigh { get; set; }
    }
    public struct HeightsInfo
    {
        public bool BlendHeights { get; set; }
        public float HeightBlendLow { get; set; }
        public float HeightLow { get; set; }
        public float HeightHigh { get; set; }
        public float HeightBlendHigh { get; set; }
    }
    public class Selections
    {
        public enum Objects
        {
            Ground = 1 << 0,
            Biome = 1 << 1,
            Alpha = 1 << 2,
            Topology = 1 << 3,
            Heightmap = 1 << 4,
            Watermap = 1 << 5,
            Prefabs = 1 << 6,
            Paths = 1 << 7,
        }
        public enum Terrains
        {
            Land = 1 << 0,
            Water = 1 << 1,
        }
        public enum Layers
        {
            Ground = 1 << 0,
            Biome = 1 << 1,
            Alpha = 1 << 2,
            Topology = 1 << 3,
        }
    }
    public class PrefabExport
    {
        public int PrefabNumber
        {
            get; set;
        }
        public uint PrefabID
        {
            get; set;
        }
        public string PrefabPath
        {
            get; set;
        }
        public string PrefabPosition
        {
            get; set;
        }
        public string PrefabScale
        {
            get; set;
        }
        public string PrefabRotation
        {
            get; set;
        }
    }
    public class Layers
    {
        public TerrainSplat.Enum Ground
        {
            get; set;
        }
        public TerrainBiome.Enum Biome
        {
            get; set;
        }
        public TerrainTopology.Enum Topologies
        {
            get; set;
        }
        public LandLayers LandLayer
        {
            get; set;
        }
        public AlphaTextures AlphaTexture
        {
            get; set;
        }
        public TopologyTextures TopologyTexture
        {
            get; set;
        }
    }
    public static class ToolTips
    {
        public static GUIContent editorInfoLabel = new GUIContent("Editor Info", "Info about the current editor, when reporting bugs make sure to include a copy of these values.");
        public static GUIContent systemOS = new GUIContent("OS: " + SystemInfo.operatingSystem);
        public static GUIContent systemRAM = new GUIContent("RAM: " + SystemInfo.systemMemorySize / 1000 + "GB");
        public static GUIContent unityVersion = new GUIContent("Unity Version: " + Application.unityVersion);
        public static GUIContent editorVersion = new GUIContent("Editor Version: v2.2-prerelease");

        public static GUIContent prefabCategory = new GUIContent("Category:", "The Category group assigned to the prefab.");
        public static GUIContent prefabID = new GUIContent("ID:", "The Prefab ID assigned to the prefab.");
        public static GUIContent prefabName = new GUIContent("Name:", "The Prefab name.");

        public static GUIContent assetBundleLabel = new GUIContent("Asset Bundle");
        public static GUIContent loadBundle = new GUIContent("Load", "Loads the Rust asset bundle into memory.");
        public static GUIContent unloadBundle = new GUIContent("Unload", "Unloads the loaded bundle.");

        public static GUIContent presetsLabel = new GUIContent("Node Presets", "List of all the node presets in the project.");
        public static GUIContent openPreset = new GUIContent("Open", "Opens the Node preset.");
        public static GUIContent refreshPresets = new GUIContent("Refresh presets list.", "Refreshes the list of all the Node Presets in the project.");
        public static GUIContent noPresets = new GUIContent("No presets in list.", "Try creating a some presets first.");

        public static GUIContent editorLinksLabel = new GUIContent("Links", "Links to discord, wiki and the project GitHub.");
        public static GUIContent reportBug = new GUIContent("Report Bug", "Opens up the editor bug report in GitHub.");
        public static GUIContent requestFeature = new GUIContent("Request Feature", "Opens up the editor feature request in GitHub.");
        public static GUIContent roadMap = new GUIContent("RoadMap", "Opens up the editor roadmap in GitHub.");
        public static GUIContent wiki = new GUIContent("Wiki", "Opens up the editor wiki in GitHub.");
        public static GUIContent discord = new GUIContent("Discord", "Discord invitation link.");

        public static GUIContent toolsLabel = new GUIContent("Tools");
        public static GUIContent editorSettingsLabel = new GUIContent("Settings");
        public static GUIContent saveSettings = new GUIContent("Save", "Sets and saves the current settings.");
        public static GUIContent discardSettings = new GUIContent("Discard", "Discards the changes to the settings.");
        public static GUIContent defaultSettings = new GUIContent("Default", "Sets the settings back to the default.");
        public static GUIContent rustDirectory = new GUIContent("Rust Directory", @"The base install directory of Rust. Normally located at steamapps\common\Rust");
        public static GUIContent browseRustDirectory = new GUIContent("Browse", "Browse and select the base directory of Rust.");
        public static GUIContent rustDirectoryPath = new GUIContent(MapEditorSettings.rustDirectory, "The install directory of Rust on the local PC.");
        public static GUIContent objectQuality = new GUIContent("Object Quality", "Changes the distance objects can be seen from.");

        public static GUIContent mapInfoLabel = new GUIContent("Map Info", "General info about the currently loaded map.");
        public static GUIContent loadMap = new GUIContent("Load", "Opens a file viewer to find and open a Rust .map file.");
        public static GUIContent saveMap = new GUIContent("Save", "Opens a file viewer to find and save a Rust .map file.");
        public static GUIContent newMap = new GUIContent("New", "Creates a new map with the selected size.");
        public static GUIContent mapSize = new GUIContent("Size", "The size to create any new maps. Must be between (1000-6000)");

        public static GUIContent exportMapPrefabs = new GUIContent("Export Map Prefabs", "Exports all map prefabs to a .JSON file.");
        public static GUIContent exportMapLootCrates = new GUIContent("Export LootCrates", "Exports all lootcrates that don't yet respawn in Rust to a JSON for use with the LootCrateRespawn plugin.");
        public static GUIContent deleteOnExport = new GUIContent("Delete on Export.", "Deletes prefabs/lootcrates after exporting.");
        public static GUIContent groupRustEditPrefabs = new GUIContent("Group RustEdit Custom Prefabs", "Groups all custom prefabs saved in the map file.");
        public static GUIContent breakRustEditPrefabs = new GUIContent("Break RustEdit Custom Prefabs", "Breaks down all custom prefabs saved in the map file.");
        public static GUIContent hidePrefabsInRustEdit = new GUIContent("Hide Prefabs in RustEdit", "Changes all the prefab categories to a semi-colon. Hides all of the prefabs from appearing in RustEdit.");

        public static GUIContent deleteMapPrefabs = new GUIContent("Delete All Map Prefabs", "Removes all the prefabs from the map.");
        public static GUIContent deleteMapPaths = new GUIContent("Delete All Map Paths", "Removes all the paths from the map.");

        public static GUIContent snapToGround = new GUIContent("Snap To Ground", "Snap the selected prefab to the terrain height.");

        public static GUIContent toggleBlend = new GUIContent("Blend", "Blends out the active texture to create a smooth transition the surrounding textures.");
        public static GUIContent rangeLow = new GUIContent("From:", "The lowest value to paint the active texture.");
        public static GUIContent rangeHigh = new GUIContent("To:", "The highest value to paint the active texture.");
        public static GUIContent blendLow = new GUIContent("Blend Low:", "The lowest value to blend out to.");
        public static GUIContent blendHigh = new GUIContent("Blend High:", "The highest value to blend out to.");

        public static GUIContent areaToolsLabel = new GUIContent("Area Tools");
        public static GUIContent fromZ = new GUIContent("From Z", "The starting point of the area.");
        public static GUIContent toZ = new GUIContent("To Z", "The ending point of the area.");
        public static GUIContent fromX = new GUIContent("From X", "The starting point of the area.");
        public static GUIContent toX = new GUIContent("To X", "The ending point of the area.");
        public static GUIContent paintArea = new GUIContent("Paint Area", "Paints the selected area with the active texture.");
        public static GUIContent eraseArea = new GUIContent("Erase Area", "Paints the selected area with the inactive texture.");

        public static GUIContent riverToolsLabel = new GUIContent("River Tools");
        public static GUIContent paintRivers = new GUIContent("Paint Rivers", "Paints the active texture wherever the water is above 500.");
        public static GUIContent eraseRivers = new GUIContent("Erase Rivers", "Paints the inactive texture wherever the water is above 500.");
        public static GUIContent aboveTerrain = new GUIContent("Above Terrain", "Paint only where there is water above sea level and above the terrain.");

        public static GUIContent slopeToolsLabel = new GUIContent("Slope Tools");
        public static GUIContent paintSlopes = new GUIContent("Paint Slopes", "Paints the active texture within the slope range.");
        public static GUIContent paintSlopesBlend = new GUIContent("Paint Slopes Blend", "Paints the active texture within the slope range, whilst blending out to the blend range.");
        public static GUIContent eraseSlopes = new GUIContent("Erase Slopes", "Paints the inactive texture within the slope range.");

        public static GUIContent heightsLabel = new GUIContent("Heights");
        public static GUIContent heightToolsLabel = new GUIContent("Height Tools");
        public static GUIContent paintHeights = new GUIContent("Paint Heights", "Paints the active texture within the height range.");
        public static GUIContent paintHeightsBlend = new GUIContent("Paint Heights Blend", "Paints the active texture within the height range, whilst blending out to the blend range.");
        public static GUIContent eraseHeights = new GUIContent("Erase Heights", "Paints the inactive texture within the height range.");


        public static GUIContent miscLabel = new GUIContent("Misc");

        public static GUIContent rotateMapLabel = new GUIContent("Rotate Map");
        public static GUIContent rotateSelection = new GUIContent("Rotation Selection:", "The items to rotate.");
        public static GUIContent rotate90 = new GUIContent("Rotate 90°", "Rotate the layer 90°.");
        public static GUIContent rotate270 = new GUIContent("Rotate 270°", "Rotate the layer 270°.");
        public static GUIContent rotateAll90 = new GUIContent("Rotate All 90°", "Rotate all Topology layers 90°");
        public static GUIContent rotateAll270 = new GUIContent("Rotate All 270°", "Rotate all Topology layers 270°");

        public static GUIContent terraceLabel = new GUIContent("Terrace");
        public static GUIContent featureSize = new GUIContent("Feature Size", "The higher the value the more terrace levels generated.");
        public static GUIContent cornerWeight = new GUIContent("Corner Weight", "The strength of the corners of the terrace.");
        public static GUIContent terraceMap = new GUIContent("Terrace Map", "Terraces the terrain.");

        public static GUIContent smoothLabel = new GUIContent("Smooth");
        public static GUIContent smoothStrength = new GUIContent("Strength", "The strength of the smoothing operation.");
        public static GUIContent blurDirection = new GUIContent("Blur Direction", "The direction the terrain should blur towards. Negative is down, positive is up.");
        public static GUIContent smoothMap = new GUIContent("Smooth Map", "Smoothes the terrain the selected amount of times.");

        public static GUIContent normaliseLabel = new GUIContent("Normalise");
        public static GUIContent normaliseLow = new GUIContent("Low", "The lowest point on the map after being normalised.");
        public static GUIContent normaliseHigh = new GUIContent("High", "The highest point on the map after being normalised.");
        public static GUIContent normaliseMap = new GUIContent("Normalise", "Scales the terrain between these heights.");
        public static GUIContent autoUpdateNormalise = new GUIContent("Auto Update", "Automatically normalises the changes to the terrain on value change.");

        public static GUIContent setHeightLabel = new GUIContent("Height Set");
        public static GUIContent heightToSet = new GUIContent("Height", "The height to set.");
        public static GUIContent setLandHeight = new GUIContent("Set Land Height", "Sets the terrain height to the height selected.");
        public static GUIContent setWaterHeight = new GUIContent("Set Water Height", "Sets the water height to the height selected.");

        public static GUIContent minMaxHeightLabel = new GUIContent("Min/Max Height");
        public static GUIContent setMinHeight = new GUIContent("Set Minimum Height", "Raises any of the terrain below the minimum height to the minimum height.");
        public static GUIContent setMaxHeight = new GUIContent("Set Maximum Height", "Lowers any of the terrain above the maximum height to the maximum height.");

        public static GUIContent offsetLabel = new GUIContent("Offset");
        public static GUIContent offsetHeight = new GUIContent("Height", "The height to offset.");
        public static GUIContent clampOffset = new GUIContent("Clamp Offset", "Prevents the flattening effect if you raise or lower the terrain too far.");
        public static GUIContent offsetLand = new GUIContent("Offset Land", "Adds the offset height to the terrain. Negative values lower the height.");
        public static GUIContent offsetWater = new GUIContent("Offset Water", "Adds the offset height to the water. Negative values lower the height.");

        public static GUIContent invertLabel = new GUIContent("Invert");
        public static GUIContent invertLand = new GUIContent("Invert Land", "Inverts the terrain heights. The heighest point becomes the lowest point.");
        public static GUIContent invertWater = new GUIContent("Invert Water", "Inverts the water heights. The heighest point becomes the lowest point.");

        public static GUIContent conditionalPaintLabel = new GUIContent("Conditional Paint");
        public static GUIContent conditionsLabel = new GUIContent("Conditions");
        public static GUIContent textureCheck = new GUIContent("Textures To Check:", "Check for all the selected textures before painting.");
        public static GUIContent checkAlpha = new GUIContent("Check Alpha", "If toggled the Alpha will be checked on the selected texture.");
        public static GUIContent checkSlopes = new GUIContent("Check Slopes", "If toggled the Slopes will be checked within the selected range.");
        public static GUIContent checkHeights = new GUIContent("Check Heights", "If toggled the Height will be checked within the selected range.");
        public static GUIContent paintConditional = new GUIContent("Paint Conditional", "Paints the selected texture if it matches all of the conditions set.");

        public static GUIContent textureToPaintLabel = new GUIContent("Texture To Paint");
        public static GUIContent textureSelectLabel = new GUIContent("Texture Select");
        public static GUIContent textureSelect = new GUIContent("Texture:", "The texture to paint with.");
        public static GUIContent layerSelectLabel = new GUIContent("Layer Select");
        public static GUIContent layerSelect = new GUIContent("Layer:", "The layer to display.");
        public static GUIContent topologyLayerSelect = new GUIContent("Topology Layer:", "The Topology layer the tools will use.");

        public static GUIContent layerToolsLabel = new GUIContent("Layer Tools");
        public static GUIContent paintLayer = new GUIContent("Paint Layer", "Paints the active texture on the entire terrain.");
        public static GUIContent clearLayer = new GUIContent("Clear Layer", "Paints the inactive texture on the entire terrain.");
        public static GUIContent invertLayer = new GUIContent("Invert Layer", "Inverts the active and inactive textures over the entire terrain.");
        public static GUIContent invertAll = new GUIContent("Invert All", "Invert all Topology layers.");
        public static GUIContent clearAll = new GUIContent("Clear All", "Clear all Topology layers.");
    }
}