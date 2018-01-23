﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Terrain
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
  [UsedByNativeCode]
  public sealed class Terrain : Behaviour
  {
    public extern TerrainData terrainData { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern float treeDistance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern float treeBillboardDistance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern float treeCrossFadeLength { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern int treeMaximumFullLODCount { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern float detailObjectDistance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern float detailObjectDensity { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern float heightmapPixelError { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern int heightmapMaximumLOD { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern float basemapDistance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    [Obsolete("splatmapDistance is deprecated, please use basemapDistance instead. (UnityUpgradable) -> basemapDistance", true)]
    public float splatmapDistance
    {
      get
      {
        return this.basemapDistance;
      }
      set
      {
        this.basemapDistance = value;
      }
    }

    public extern int lightmapIndex { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern int realtimeLightmapIndex { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public Vector4 lightmapScaleOffset
    {
      get
      {
        Vector4 ret;
        this.get_lightmapScaleOffset_Injected(out ret);
        return ret;
      }
      set
      {
        this.set_lightmapScaleOffset_Injected(ref value);
      }
    }

    public Vector4 realtimeLightmapScaleOffset
    {
      get
      {
        Vector4 ret;
        this.get_realtimeLightmapScaleOffset_Injected(out ret);
        return ret;
      }
      set
      {
        this.set_realtimeLightmapScaleOffset_Injected(ref value);
      }
    }

    public extern bool freeUnusedRenderingResources { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern bool castShadows { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern ReflectionProbeUsage reflectionProbeUsage { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void GetClosestReflectionProbes(List<ReflectionProbeBlendInfo> result);

    public extern Terrain.MaterialType materialType { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern Material materialTemplate { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public Color legacySpecular
    {
      get
      {
        Color ret;
        this.get_legacySpecular_Injected(out ret);
        return ret;
      }
      set
      {
        this.set_legacySpecular_Injected(ref value);
      }
    }

    public extern float legacyShininess { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern bool drawHeightmap { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern bool drawTreesAndFoliage { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public Vector3 patchBoundsMultiplier
    {
      get
      {
        Vector3 ret;
        this.get_patchBoundsMultiplier_Injected(out ret);
        return ret;
      }
      set
      {
        this.set_patchBoundsMultiplier_Injected(ref value);
      }
    }

    public float SampleHeight(Vector3 worldPosition)
    {
      return this.SampleHeight_Injected(ref worldPosition);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void ApplyDelayedHeightmapModification();

    public void AddTreeInstance(TreeInstance instance)
    {
      this.AddTreeInstance_Injected(ref instance);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom);

    public extern float treeLODBiasMultiplier { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern bool collectDetailPatches { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern TerrainRenderFlags editorRenderFlags { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public Vector3 GetPosition()
    {
      Vector3 ret;
      this.GetPosition_Injected(out ret);
      return ret;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void Flush();

    internal void RemoveTrees(Vector2 position, float radius, int prototypeIndex)
    {
      this.RemoveTrees_Injected(ref position, radius, prototypeIndex);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void SetSplatMaterialPropertyBlock(MaterialPropertyBlock properties);

    public void GetSplatMaterialPropertyBlock(MaterialPropertyBlock dest)
    {
      if (dest == null)
        throw new ArgumentNullException(nameof (dest));
      this.Internal_GetSplatMaterialPropertyBlock(dest);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void Internal_GetSplatMaterialPropertyBlock(MaterialPropertyBlock dest);

    public extern bool bakeLightProbesForTrees { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    public static extern Terrain activeTerrain { [MethodImpl(MethodImplOptions.InternalCall)] get; }

    public static extern Terrain[] activeTerrains { [MethodImpl(MethodImplOptions.InternalCall)] get; }

    [UsedByNativeCode]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern GameObject CreateTerrainGameObject(TerrainData assignTerrain);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_lightmapScaleOffset_Injected(out Vector4 ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void set_lightmapScaleOffset_Injected(ref Vector4 value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_realtimeLightmapScaleOffset_Injected(out Vector4 ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void set_realtimeLightmapScaleOffset_Injected(ref Vector4 value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_legacySpecular_Injected(out Color ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void set_legacySpecular_Injected(ref Color value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_patchBoundsMultiplier_Injected(out Vector3 ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void set_patchBoundsMultiplier_Injected(ref Vector3 value);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern float SampleHeight_Injected(ref Vector3 worldPosition);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void AddTreeInstance_Injected(ref TreeInstance instance);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetPosition_Injected(out Vector3 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void RemoveTrees_Injected(ref Vector2 position, float radius, int prototypeIndex);

    public enum MaterialType
    {
      BuiltInStandard,
      BuiltInLegacyDiffuse,
      BuiltInLegacySpecular,
      Custom,
    }
  }
}
