﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.AssetBundleRequest
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Asynchronous load request from an AssetBundle.</para>
  /// </summary>
  [RequiredByNativeCode]
  [StructLayout(LayoutKind.Sequential)]
  public sealed class AssetBundleRequest : AsyncOperation
  {
    /// <summary>
    ///   <para>Asset object being loaded (Read Only).</para>
    /// </summary>
    public extern Object asset { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Asset objects with sub assets being loaded. (Read Only)</para>
    /// </summary>
    public extern Object[] allAssets { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }
  }
}
