﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.BitStream
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>The BitStream class represents seralized variables, packed into a stream.</para>
  /// </summary>
  [RequiredByNativeCode(Optional = true)]
  public sealed class BitStream
  {
    internal IntPtr m_Ptr;

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void Serializeb(ref int value);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void Serializec(ref char value);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void Serializes(ref short value);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void Serializei(ref int value);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void Serializef(ref float value, float maximumDelta);

    private void Serializeq(ref Quaternion value, float maximumDelta)
    {
      BitStream.INTERNAL_CALL_Serializeq(this, ref value, maximumDelta);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_Serializeq(BitStream self, ref Quaternion value, float maximumDelta);

    private void Serializev(ref Vector3 value, float maximumDelta)
    {
      BitStream.INTERNAL_CALL_Serializev(this, ref value, maximumDelta);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_Serializev(BitStream self, ref Vector3 value, float maximumDelta);

    private void Serializen(ref NetworkViewID viewID)
    {
      BitStream.INTERNAL_CALL_Serializen(this, ref viewID);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_Serializen(BitStream self, ref NetworkViewID viewID);

    public void Serialize(ref bool value)
    {
      int num = !value ? 0 : 1;
      this.Serializeb(ref num);
      value = num != 0;
    }

    public void Serialize(ref char value)
    {
      this.Serializec(ref value);
    }

    public void Serialize(ref short value)
    {
      this.Serializes(ref value);
    }

    public void Serialize(ref int value)
    {
      this.Serializei(ref value);
    }

    [ExcludeFromDocs]
    public void Serialize(ref float value)
    {
      float maxDelta = 1E-05f;
      this.Serialize(ref value, maxDelta);
    }

    public void Serialize(ref float value, [DefaultValue("0.00001F")] float maxDelta)
    {
      this.Serializef(ref value, maxDelta);
    }

    [ExcludeFromDocs]
    public void Serialize(ref Quaternion value)
    {
      float maxDelta = 1E-05f;
      this.Serialize(ref value, maxDelta);
    }

    public void Serialize(ref Quaternion value, [DefaultValue("0.00001F")] float maxDelta)
    {
      this.Serializeq(ref value, maxDelta);
    }

    [ExcludeFromDocs]
    public void Serialize(ref Vector3 value)
    {
      float maxDelta = 1E-05f;
      this.Serialize(ref value, maxDelta);
    }

    public void Serialize(ref Vector3 value, [DefaultValue("0.00001F")] float maxDelta)
    {
      this.Serializev(ref value, maxDelta);
    }

    public void Serialize(ref NetworkPlayer value)
    {
      int index = value.index;
      this.Serializei(ref index);
      value.index = index;
    }

    public void Serialize(ref NetworkViewID viewID)
    {
      this.Serializen(ref viewID);
    }

    /// <summary>
    ///   <para>Is the BitStream currently being read? (Read Only)</para>
    /// </summary>
    public extern bool isReading { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Is the BitStream currently being written? (Read Only)</para>
    /// </summary>
    public extern bool isWriting { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void Serialize(ref string value);
  }
}
