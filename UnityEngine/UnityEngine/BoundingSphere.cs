﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.BoundingSphere
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

namespace UnityEngine
{
  /// <summary>
  ///   <para>Describes a single bounding sphere for use by a CullingGroup.</para>
  /// </summary>
  public struct BoundingSphere
  {
    /// <summary>
    ///   <para>The position of the center of the BoundingSphere.</para>
    /// </summary>
    public Vector3 position;
    /// <summary>
    ///   <para>The radius of the BoundingSphere.</para>
    /// </summary>
    public float radius;

    /// <summary>
    ///   <para>Initializes a BoundingSphere.</para>
    /// </summary>
    /// <param name="pos">The center of the sphere.</param>
    /// <param name="rad">The radius of the sphere.</param>
    /// <param name="packedSphere">A four-component vector containing the position (packed into the XYZ components) and radius (packed into the W component).</param>
    public BoundingSphere(Vector3 pos, float rad)
    {
      this.position = pos;
      this.radius = rad;
    }

    /// <summary>
    ///   <para>Initializes a BoundingSphere.</para>
    /// </summary>
    /// <param name="pos">The center of the sphere.</param>
    /// <param name="rad">The radius of the sphere.</param>
    /// <param name="packedSphere">A four-component vector containing the position (packed into the XYZ components) and radius (packed into the W component).</param>
    public BoundingSphere(Vector4 packedSphere)
    {
      this.position = new Vector3(packedSphere.x, packedSphere.y, packedSphere.z);
      this.radius = packedSphere.w;
    }
  }
}
