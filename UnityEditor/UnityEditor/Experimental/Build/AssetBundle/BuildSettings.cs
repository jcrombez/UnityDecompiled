﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.Experimental.Build.AssetBundle.BuildSettings
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

using System;
using UnityEditor.Experimental.Build.Player;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.Experimental.Build.AssetBundle
{
  [UsedByNativeCode]
  [Serializable]
  public struct BuildSettings
  {
    [NativeName("typeDB")]
    internal TypeDB m_TypeDB;
    [NativeName("target")]
    internal BuildTarget m_Target;
    [NativeName("group")]
    internal BuildTargetGroup m_Group;

    public TypeDB typeDB
    {
      get
      {
        return this.m_TypeDB;
      }
      set
      {
        this.m_TypeDB = value;
      }
    }

    public BuildTarget target
    {
      get
      {
        return this.m_Target;
      }
      set
      {
        this.m_Target = value;
      }
    }

    public BuildTargetGroup group
    {
      get
      {
        return this.m_Group;
      }
      set
      {
        this.m_Group = value;
      }
    }
  }
}
