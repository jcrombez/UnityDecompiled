﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.NetworkView
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>The network view is the binding material of multiplayer games.</para>
  /// </summary>
  [Obsolete("Unity Multiplayer and NetworkIdentity component instead.")]
  public sealed class NetworkView : Behaviour
  {
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_RPC(NetworkView view, string name, RPCMode mode, object[] args);

    private static void Internal_RPC_Target(NetworkView view, string name, NetworkPlayer target, object[] args)
    {
      NetworkView.INTERNAL_CALL_Internal_RPC_Target(view, name, ref target, args);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_Internal_RPC_Target(NetworkView view, string name, ref NetworkPlayer target, object[] args);

    /// <summary>
    ///   <para>Call a RPC function on all connected peers.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="mode"></param>
    /// <param name="args"></param>
    [Obsolete("NetworkView RPC functions are deprecated. Refer to the new Multiplayer Networking system.")]
    public void RPC(string name, RPCMode mode, params object[] args)
    {
      NetworkView.Internal_RPC(this, name, mode, args);
    }

    /// <summary>
    ///   <para>Call a RPC function on a specific player.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="target"></param>
    /// <param name="args"></param>
    [Obsolete("NetworkView RPC functions are deprecated. Refer to the new Multiplayer Networking system.")]
    public void RPC(string name, NetworkPlayer target, params object[] args)
    {
      NetworkView.Internal_RPC_Target(this, name, target, args);
    }

    /// <summary>
    ///   <para>The component the network view is observing.</para>
    /// </summary>
    public extern Component observed { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The type of NetworkStateSynchronization set for this network view.</para>
    /// </summary>
    public extern NetworkStateSynchronization stateSynchronization { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void Internal_GetViewID(out NetworkViewID viewID);

    private void Internal_SetViewID(NetworkViewID viewID)
    {
      NetworkView.INTERNAL_CALL_Internal_SetViewID(this, ref viewID);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_Internal_SetViewID(NetworkView self, ref NetworkViewID viewID);

    /// <summary>
    ///   <para>The ViewID of this network view.</para>
    /// </summary>
    public NetworkViewID viewID
    {
      get
      {
        NetworkViewID viewID;
        this.Internal_GetViewID(out viewID);
        return viewID;
      }
      set
      {
        this.Internal_SetViewID(value);
      }
    }

    /// <summary>
    ///   <para>The network group number of this network view.</para>
    /// </summary>
    public extern int group { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Is the network view controlled by this object?</para>
    /// </summary>
    public bool isMine
    {
      get
      {
        return this.viewID.isMine;
      }
    }

    /// <summary>
    ///   <para>The NetworkPlayer who owns this network view.</para>
    /// </summary>
    public NetworkPlayer owner
    {
      get
      {
        return this.viewID.owner;
      }
    }

    /// <summary>
    ///   <para>Set the scope of the network view in relation to a specific network player.</para>
    /// </summary>
    /// <param name="player"></param>
    /// <param name="relevancy"></param>
    public bool SetScope(NetworkPlayer player, bool relevancy)
    {
      return NetworkView.INTERNAL_CALL_SetScope(this, ref player, relevancy);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool INTERNAL_CALL_SetScope(NetworkView self, ref NetworkPlayer player, bool relevancy);

    /// <summary>
    ///   <para>Find a network view based on a NetworkViewID.</para>
    /// </summary>
    /// <param name="viewID"></param>
    public static NetworkView Find(NetworkViewID viewID)
    {
      return NetworkView.INTERNAL_CALL_Find(ref viewID);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern NetworkView INTERNAL_CALL_Find(ref NetworkViewID viewID);
  }
}
