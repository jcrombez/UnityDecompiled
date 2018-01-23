﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.RenderBuffer
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;
using UnityEngine.Rendering;

namespace UnityEngine
{
  public struct RenderBuffer
  {
    internal int m_RenderTextureInstanceID;
    internal IntPtr m_BufferPtr;

    internal void SetLoadAction(RenderBufferLoadAction action)
    {
      RenderBufferHelper.SetLoadAction(out this, (int) action);
    }

    internal void SetStoreAction(RenderBufferStoreAction action)
    {
      RenderBufferHelper.SetStoreAction(out this, (int) action);
    }

    internal RenderBufferLoadAction loadAction
    {
      get
      {
        return (RenderBufferLoadAction) RenderBufferHelper.GetLoadAction(out this);
      }
      set
      {
        this.SetLoadAction(value);
      }
    }

    internal RenderBufferStoreAction storeAction
    {
      get
      {
        return (RenderBufferStoreAction) RenderBufferHelper.GetStoreAction(out this);
      }
      set
      {
        this.SetStoreAction(value);
      }
    }

    public IntPtr GetNativeRenderBufferPtr()
    {
      return RenderBufferHelper.GetNativeRenderBufferPtr(this.m_BufferPtr);
    }
  }
}
