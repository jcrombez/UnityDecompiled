﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.LineRenderer
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>The line renderer is used to draw free-floating lines in 3D space.</para>
  /// </summary>
  public sealed class LineRenderer : Renderer
  {
    /// <summary>
    ///   <para>Set the curve describing the width of the line at various points along its length.</para>
    /// </summary>
    public extern AnimationCurve widthCurve { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Set the color gradient describing the color of the line at various points along its length.</para>
    /// </summary>
    public extern Gradient colorGradient { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Set the positions of all vertices in the line.</para>
    /// </summary>
    /// <param name="positions">The array of positions to set.</param>
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void SetPositions(Vector3[] positions);

    /// <summary>
    ///   <para>Get the positions of all vertices in the line.</para>
    /// </summary>
    /// <param name="positions">The array of positions to retrieve. The array passed should be of at least numPositions in size.</param>
    /// <returns>
    ///   <para>How many positions were actually stored in the output array.</para>
    /// </returns>
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern int GetPositions(Vector3[] positions);

    /// <summary>
    ///   <para>Set the line width at the start and at the end.</para>
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    [Obsolete("Use startWidth, endWidth or widthCurve instead.", false)]
    public void SetWidth(float start, float end)
    {
      this.startWidth = start;
      this.endWidth = end;
    }

    /// <summary>
    ///   <para>Set the line color at the start and at the end.</para>
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    [Obsolete("Use startColor, endColor or colorGradient instead.", false)]
    public void SetColors(Color start, Color end)
    {
      this.startColor = start;
      this.endColor = end;
    }

    /// <summary>
    ///   <para>Set the number of line segments.</para>
    /// </summary>
    /// <param name="count"></param>
    [Obsolete("Use positionCount instead.", false)]
    public void SetVertexCount(int count)
    {
      this.positionCount = count;
    }

    /// <summary>
    ///   <para>Set the number of line segments.</para>
    /// </summary>
    [Obsolete("Use positionCount instead (UnityUpgradable) -> positionCount", false)]
    public int numPositions
    {
      get
      {
        return this.positionCount;
      }
      set
      {
        this.positionCount = value;
      }
    }

    /// <summary>
    ///   <para>Set the width at the start of the line.</para>
    /// </summary>
    public extern float startWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Set the width at the end of the line.</para>
    /// </summary>
    public extern float endWidth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Set an overall multiplier that is applied to the LineRenderer.widthCurve to get the final width of the line.</para>
    /// </summary>
    public extern float widthMultiplier { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Set this to a value greater than 0, to get rounded corners between each segment of the line.</para>
    /// </summary>
    public extern int numCornerVertices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Set this to a value greater than 0, to get rounded corners on each end of the line.</para>
    /// </summary>
    public extern int numCapVertices { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>If enabled, the lines are defined in world space.</para>
    /// </summary>
    public extern bool useWorldSpace { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Connect the start and end positions of the line together to form a continuous loop.</para>
    /// </summary>
    public extern bool loop { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Set the color at the start of the line.</para>
    /// </summary>
    public Color startColor
    {
      get
      {
        Color ret;
        this.get_startColor_Injected(out ret);
        return ret;
      }
      set
      {
        this.set_startColor_Injected(ref value);
      }
    }

    /// <summary>
    ///   <para>Set the color at the end of the line.</para>
    /// </summary>
    public Color endColor
    {
      get
      {
        Color ret;
        this.get_endColor_Injected(out ret);
        return ret;
      }
      set
      {
        this.set_endColor_Injected(ref value);
      }
    }

    /// <summary>
    ///   <para>Set the number of line segments.</para>
    /// </summary>
    public extern int positionCount { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Set the position of a vertex in the line.</para>
    /// </summary>
    /// <param name="index">Which position to set.</param>
    /// <param name="position">The new position.</param>
    public void SetPosition(int index, Vector3 position)
    {
      this.SetPosition_Injected(index, ref position);
    }

    /// <summary>
    ///   <para>Get the position of a vertex in the line.</para>
    /// </summary>
    /// <param name="index">The index of the position to retrieve.</param>
    /// <returns>
    ///   <para>The position at the specified index in the array.</para>
    /// </returns>
    public Vector3 GetPosition(int index)
    {
      Vector3 ret;
      this.GetPosition_Injected(index, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Configures a line to generate Normals and Tangents. With this data, Scene lighting can affect the line via Normal Maps and the Unity Standard Shader, or your own custom-built Shaders.</para>
    /// </summary>
    public extern bool generateLightingData { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Choose whether the U coordinate of the line texture is tiled or stretched.</para>
    /// </summary>
    public extern LineTextureMode textureMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Select whether the line will face the camera, or the orientation of the Transform Component.</para>
    /// </summary>
    public extern LineAlignment alignment { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Generates a simplified version of the original line by removing points that fall within the specified tolerance.</para>
    /// </summary>
    /// <param name="tolerance">This value is used to evaluate which points should be removed from the line. A higher value results in a simpler line (less points). A positive value close to zero results in a line with little to no reduction. A value of zero or less has no effect.</param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void Simplify(float tolerance);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_startColor_Injected(out Color ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void set_startColor_Injected(ref Color value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_endColor_Injected(out Color ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void set_endColor_Injected(ref Color value);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetPosition_Injected(int index, ref Vector3 position);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetPosition_Injected(int index, out Vector3 ret);
  }
}
