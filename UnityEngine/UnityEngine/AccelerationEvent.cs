﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.AccelerationEvent
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

namespace UnityEngine
{
  /// <summary>
  ///   <para>Structure describing acceleration status of the device.</para>
  /// </summary>
  public struct AccelerationEvent
  {
    private float x;
    private float y;
    private float z;
    private float m_TimeDelta;

    /// <summary>
    ///   <para>Value of acceleration.</para>
    /// </summary>
    public Vector3 acceleration
    {
      get
      {
        return new Vector3(this.x, this.y, this.z);
      }
    }

    /// <summary>
    ///   <para>Amount of time passed since last accelerometer measurement.</para>
    /// </summary>
    public float deltaTime
    {
      get
      {
        return this.m_TimeDelta;
      }
    }
  }
}
