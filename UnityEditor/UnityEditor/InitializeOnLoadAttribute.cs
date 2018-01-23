﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.InitializeOnLoadAttribute
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

using System;

namespace UnityEditor
{
  /// <summary>
  ///   <para>Allow an editor class to be initialized when Unity loads without action from the user.</para>
  /// </summary>
  [AttributeUsage(AttributeTargets.Class)]
  public class InitializeOnLoadAttribute : Attribute
  {
  }
}
