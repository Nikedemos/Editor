﻿using UnityEngine;
using XNode;
using EditorVariables;

[CreateNodeMenu("Paint/Paint Rivers")]
public class PaintRiversNode : Node
{
    [Input(ShowBackingValue.Never, ConnectionType.Override, TypeConstraint.Strict)] public NodeVariables.Texture Texture;
    [Input(ShowBackingValue.Never, ConnectionType.Override, TypeConstraint.Strict)] public NodeVariables.NextTask PreviousTask;
    [Output(ShowBackingValue.Never, ConnectionType.Override, TypeConstraint.Strict)] public NodeVariables.NextTask NextTask;
    [HideInInspector] public bool aboveTerrain = false;
    public override object GetValue(NodePort port)
    {
        NodeVariables.Texture Texture = GetInputValue("Texture", this.Texture);
        return Texture;
    }
    public object GetValue()
    {
        return GetInputValue<object>("Texture");
    }
    public void RunNode()
    {
        var layer = (NodeVariables.Texture)GetValue();
        switch (layer.LandLayer)
        {
            case 0:
                MapIO.PaintRiver(LandLayers.Ground, aboveTerrain, TerrainSplat.TypeToIndex(layer.GroundTexture));
                break;
            case 1: 
                MapIO.PaintRiver(LandLayers.Biome, aboveTerrain, TerrainBiome.TypeToIndex(layer.BiomeTexture));
                break;
            case 2:
                MapIO.PaintRiver(LandLayers.Alpha, aboveTerrain, layer.AlphaTexture);
                break;
            case 3:
                MapIO.PaintRiver(LandLayers.Topology, aboveTerrain, layer.TopologyTexture, layer.TopologyLayer);
                break;
        }
    }
}