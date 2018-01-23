﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Rendering.RasterState
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
  public struct RasterState
  {
    public static readonly RasterState Default = new RasterState(CullMode.Back, 0, 0.0f, true);
    private CullMode m_CullingMode;
    private int m_OffsetUnits;
    private float m_OffsetFactor;
    private byte m_DepthClip;

    public RasterState(CullMode cullingMode = CullMode.Back, int offsetUnits = 0, float offsetFactor = 0.0f, bool depthClip = true)
    {
      this.m_CullingMode = cullingMode;
      this.m_OffsetUnits = offsetUnits;
      this.m_OffsetFactor = offsetFactor;
      this.m_DepthClip = Convert.ToByte(depthClip);
    }

    public CullMode cullingMode
    {
      get
      {
        return this.m_CullingMode;
      }
      set
      {
        this.m_CullingMode = value;
      }
    }

    public bool depthClip
    {
      get
      {
        return Convert.ToBoolean(this.m_DepthClip);
      }
      set
      {
        this.m_DepthClip = Convert.ToByte(value);
      }
    }

    public int offsetUnits
    {
      get
      {
        return this.m_OffsetUnits;
      }
      set
      {
        this.m_OffsetUnits = value;
      }
    }

    public float offsetFactor
    {
      get
      {
        return this.m_OffsetFactor;
      }
      set
      {
        this.m_OffsetFactor = value;
      }
    }
  }
}
