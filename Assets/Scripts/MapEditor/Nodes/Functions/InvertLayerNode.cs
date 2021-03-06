﻿using UnityEngine;
using XNode;
using EditorVariables;

[CreateNodeMenu("Functions/Invert/Invert Layer")]
public class InvertLayerNode : Node
{
    [Input(ShowBackingValue.Never, ConnectionType.Override, TypeConstraint.Strict)] public NodeVariables.NextTask PreviousTask;
    [Output(ShowBackingValue.Never, ConnectionType.Override, TypeConstraint.Strict)] public NodeVariables.NextTask NextTask;
    [HideInInspector] public TerrainTopology.Enum topologies = TerrainTopology.NOTHING;
    [NodeEnum] public NodeVariables.Misc.DualLayerEnum layer = NodeVariables.Misc.DualLayerEnum.Topology;
    public override object GetValue(NodePort port)
    {
        return null;
    }
    public void RunNode()
    {
        switch (layer)
        {
            case NodeVariables.Misc.DualLayerEnum.Alpha:
                MapIO.InvertLayer(LandLayers.Alpha);
                break;
            case NodeVariables.Misc.DualLayerEnum.Topology:
                MapIO.InvertTopologyLayers(topologies);
                break;
        }
    }
}