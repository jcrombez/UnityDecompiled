﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.MaterialPropertyBlock
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>A block of material values to apply.</para>
  /// </summary>
  public sealed class MaterialPropertyBlock
  {
    internal IntPtr m_Ptr;

    public MaterialPropertyBlock()
    {
      this.InitBlock();
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern void InitBlock();

    [ThreadAndSerializationSafe]
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern void DestroyBlock();

    ~MaterialPropertyBlock()
    {
      this.DestroyBlock();
    }

    /// <summary>
    ///   <para>Is the material property block empty? (Read Only)</para>
    /// </summary>
    public extern bool isEmpty { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Clear material property values.</para>
    /// </summary>
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void Clear();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetFloatImpl(int nameID, float value);

    private void SetVectorImpl(int nameID, Vector4 value)
    {
      MaterialPropertyBlock.INTERNAL_CALL_SetVectorImpl(this, nameID, ref value);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_SetVectorImpl(MaterialPropertyBlock self, int nameID, ref Vector4 value);

    private void SetMatrixImpl(int nameID, Matrix4x4 value)
    {
      MaterialPropertyBlock.INTERNAL_CALL_SetMatrixImpl(this, nameID, ref value);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_SetMatrixImpl(MaterialPropertyBlock self, int nameID, ref Matrix4x4 value);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetTextureImpl(int nameID, Texture value);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetBufferImpl(int nameID, ComputeBuffer value);

    private void SetColorImpl(int nameID, Color value)
    {
      MaterialPropertyBlock.INTERNAL_CALL_SetColorImpl(this, nameID, ref value);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_SetColorImpl(MaterialPropertyBlock self, int nameID, ref Color value);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetFloatArrayImpl(int nameID, float[] values, int count);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetVectorArrayImpl(int nameID, Vector4[] values, int count);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetMatrixArrayImpl(int nameID, Matrix4x4[] values, int count);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern float GetFloatImpl(int nameID);

    private Vector4 GetVectorImpl(int nameID)
    {
      Vector4 vector4;
      MaterialPropertyBlock.INTERNAL_CALL_GetVectorImpl(this, nameID, out vector4);
      return vector4;
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_GetVectorImpl(MaterialPropertyBlock self, int nameID, out Vector4 value);

    private Color GetColorImpl(int nameID)
    {
      Color color;
      MaterialPropertyBlock.INTERNAL_CALL_GetColorImpl(this, nameID, out color);
      return color;
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_GetColorImpl(MaterialPropertyBlock self, int nameID, out Color value);

    private Matrix4x4 GetMatrixImpl(int nameID)
    {
      Matrix4x4 matrix4x4;
      MaterialPropertyBlock.INTERNAL_CALL_GetMatrixImpl(this, nameID, out matrix4x4);
      return matrix4x4;
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_GetMatrixImpl(MaterialPropertyBlock self, int nameID, out Matrix4x4 value);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern float[] GetFloatArrayImpl(int nameID);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern Vector4[] GetVectorArrayImpl(int nameID);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern Matrix4x4[] GetMatrixArrayImpl(int nameID);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetFloatArrayImplList(int nameID, object list);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetVectorArrayImplList(int nameID, object list);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetMatrixArrayImplList(int nameID, object list);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern Texture GetTextureImpl(int nameID);

    /// <summary>
    ///   <para>Set a float property.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="value">The float value to set.</param>
    public void SetFloat(string name, float value)
    {
      this.SetFloat(Shader.PropertyToID(name), value);
    }

    /// <summary>
    ///   <para>Set a float property.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="value">The float value to set.</param>
    public void SetFloat(int nameID, float value)
    {
      this.SetFloatImpl(nameID, value);
    }

    /// <summary>
    ///   <para>Set a vector property.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="value">The Vector4 value to set.</param>
    public void SetVector(string name, Vector4 value)
    {
      this.SetVector(Shader.PropertyToID(name), value);
    }

    /// <summary>
    ///   <para>Set a vector property.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="value">The Vector4 value to set.</param>
    public void SetVector(int nameID, Vector4 value)
    {
      this.SetVectorImpl(nameID, value);
    }

    /// <summary>
    ///   <para>Set a color property.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="value">The Color value to set.</param>
    public void SetColor(string name, Color value)
    {
      this.SetColor(Shader.PropertyToID(name), value);
    }

    /// <summary>
    ///   <para>Set a color property.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="value">The Color value to set.</param>
    public void SetColor(int nameID, Color value)
    {
      this.SetColorImpl(nameID, value);
    }

    /// <summary>
    ///   <para>Set a matrix property.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="value">The matrix value to set.</param>
    public void SetMatrix(string name, Matrix4x4 value)
    {
      this.SetMatrix(Shader.PropertyToID(name), value);
    }

    /// <summary>
    ///   <para>Set a matrix property.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="value">The matrix value to set.</param>
    public void SetMatrix(int nameID, Matrix4x4 value)
    {
      this.SetMatrixImpl(nameID, value);
    }

    /// <summary>
    ///   <para>Set a ComputeBuffer property.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="value">The ComputeBuffer to set.</param>
    public void SetBuffer(string name, ComputeBuffer value)
    {
      this.SetBuffer(Shader.PropertyToID(name), value);
    }

    /// <summary>
    ///   <para>Set a ComputeBuffer property.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="value">The ComputeBuffer to set.</param>
    public void SetBuffer(int nameID, ComputeBuffer value)
    {
      this.SetBufferImpl(nameID, value);
    }

    /// <summary>
    ///   <para>Set a texture property.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="value">The Texture to set.</param>
    public void SetTexture(string name, Texture value)
    {
      this.SetTexture(Shader.PropertyToID(name), value);
    }

    /// <summary>
    ///   <para>Set a texture property.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="value">The Texture to set.</param>
    public void SetTexture(int nameID, Texture value)
    {
      if ((Object) value == (Object) null)
        throw new ArgumentNullException(nameof (value));
      this.SetTextureImpl(nameID, value);
    }

    public void SetFloatArray(string name, List<float> values)
    {
      this.SetFloatArray(Shader.PropertyToID(name), values);
    }

    public void SetFloatArray(int nameID, List<float> values)
    {
      this.SetFloatArray(nameID, (float[]) NoAllocHelpers.ExtractArrayFromList((object) values), values.Count);
    }

    /// <summary>
    ///   <para>Set a float array property.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="values">The array to set.</param>
    public void SetFloatArray(string name, float[] values)
    {
      this.SetFloatArray(Shader.PropertyToID(name), values);
    }

    /// <summary>
    ///   <para>Set a float array property.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="values">The array to set.</param>
    public void SetFloatArray(int nameID, float[] values)
    {
      this.SetFloatArray(nameID, values, values.Length);
    }

    private void SetFloatArray(int nameID, float[] values, int count)
    {
      if (values == null)
        throw new ArgumentNullException(nameof (values));
      if (values.Length == 0)
        throw new ArgumentException("Zero-sized array is not allowed.");
      if (values.Length < count)
        throw new ArgumentException("array has less elements than passed count.");
      this.SetFloatArrayImpl(nameID, values, count);
    }

    public void SetVectorArray(string name, List<Vector4> values)
    {
      this.SetVectorArray(Shader.PropertyToID(name), values);
    }

    public void SetVectorArray(int nameID, List<Vector4> values)
    {
      this.SetVectorArray(nameID, (Vector4[]) NoAllocHelpers.ExtractArrayFromList((object) values), values.Count);
    }

    /// <summary>
    ///   <para>Set a vector array property.</para>
    /// </summary>
    /// <param name="nameID">The name of the property.</param>
    /// <param name="values">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The array to set.</param>
    public void SetVectorArray(string name, Vector4[] values)
    {
      this.SetVectorArray(Shader.PropertyToID(name), values);
    }

    /// <summary>
    ///   <para>Set a vector array property.</para>
    /// </summary>
    /// <param name="nameID">The name of the property.</param>
    /// <param name="values">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The array to set.</param>
    public void SetVectorArray(int nameID, Vector4[] values)
    {
      this.SetVectorArray(nameID, values, values.Length);
    }

    private void SetVectorArray(int nameID, Vector4[] values, int count)
    {
      if (values == null)
        throw new ArgumentNullException(nameof (values));
      if (values.Length == 0)
        throw new ArgumentException("Zero-sized array is not allowed.");
      if (values.Length < count)
        throw new ArgumentException("array has less elements than passed count.");
      this.SetVectorArrayImpl(nameID, values, count);
    }

    public void SetMatrixArray(string name, List<Matrix4x4> values)
    {
      this.SetMatrixArray(Shader.PropertyToID(name), values);
    }

    public void SetMatrixArray(int nameID, List<Matrix4x4> values)
    {
      this.SetMatrixArray(nameID, (Matrix4x4[]) NoAllocHelpers.ExtractArrayFromList((object) values), values.Count);
    }

    /// <summary>
    ///   <para>Set a matrix array property.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="values">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="nameID">The array to set.</param>
    public void SetMatrixArray(string name, Matrix4x4[] values)
    {
      this.SetMatrixArray(Shader.PropertyToID(name), values);
    }

    /// <summary>
    ///   <para>Set a matrix array property.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="values">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="nameID">The array to set.</param>
    public void SetMatrixArray(int nameID, Matrix4x4[] values)
    {
      this.SetMatrixArray(nameID, values, values.Length);
    }

    private void SetMatrixArray(int nameID, Matrix4x4[] values, int count)
    {
      if (values == null)
        throw new ArgumentNullException(nameof (values));
      if (values.Length == 0)
        throw new ArgumentException("Zero-sized array is not allowed.");
      if (values.Length < count)
        throw new ArgumentException("array has less elements than passed count.");
      this.SetMatrixArrayImpl(nameID, values, count);
    }

    /// <summary>
    ///   <para>Get a float from the property block.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="nameID"></param>
    public float GetFloat(string name)
    {
      return this.GetFloat(Shader.PropertyToID(name));
    }

    /// <summary>
    ///   <para>Get a float from the property block.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="nameID"></param>
    public float GetFloat(int nameID)
    {
      return this.GetFloatImpl(nameID);
    }

    /// <summary>
    ///   <para>Get a vector from the property block.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="nameID"></param>
    public Vector4 GetVector(string name)
    {
      return this.GetVector(Shader.PropertyToID(name));
    }

    /// <summary>
    ///   <para>Get a vector from the property block.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="nameID"></param>
    public Vector4 GetVector(int nameID)
    {
      return this.GetVectorImpl(nameID);
    }

    /// <summary>
    ///   <para>Get a color from the property block.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="nameID"></param>
    public Color GetColor(string name)
    {
      return this.GetColor(Shader.PropertyToID(name));
    }

    /// <summary>
    ///   <para>Get a color from the property block.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="nameID"></param>
    public Color GetColor(int nameID)
    {
      return this.GetColorImpl(nameID);
    }

    /// <summary>
    ///   <para>Get a matrix from the property block.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="nameID"></param>
    public Matrix4x4 GetMatrix(string name)
    {
      return this.GetMatrix(Shader.PropertyToID(name));
    }

    /// <summary>
    ///   <para>Get a matrix from the property block.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="nameID"></param>
    public Matrix4x4 GetMatrix(int nameID)
    {
      return this.GetMatrixImpl(nameID);
    }

    public void GetFloatArray(string name, List<float> values)
    {
      this.GetFloatArray(Shader.PropertyToID(name), values);
    }

    public void GetFloatArray(int nameID, List<float> values)
    {
      if (values == null)
        throw new ArgumentNullException(nameof (values));
      this.GetFloatArrayImplList(nameID, (object) values);
    }

    /// <summary>
    ///   <para>Get a float array from the property block.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="nameID"></param>
    public float[] GetFloatArray(string name)
    {
      return this.GetFloatArray(Shader.PropertyToID(name));
    }

    /// <summary>
    ///   <para>Get a float array from the property block.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="nameID"></param>
    public float[] GetFloatArray(int nameID)
    {
      return this.GetFloatArrayImpl(nameID);
    }

    public void GetVectorArray(string name, List<Vector4> values)
    {
      this.GetVectorArray(Shader.PropertyToID(name), values);
    }

    public void GetVectorArray(int nameID, List<Vector4> values)
    {
      if (values == null)
        throw new ArgumentNullException(nameof (values));
      this.GetVectorArrayImplList(nameID, (object) values);
    }

    /// <summary>
    ///   <para>Get a vector array from the property block.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="nameID"></param>
    public Vector4[] GetVectorArray(string name)
    {
      return this.GetVectorArray(Shader.PropertyToID(name));
    }

    /// <summary>
    ///   <para>Get a vector array from the property block.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="nameID"></param>
    public Vector4[] GetVectorArray(int nameID)
    {
      return this.GetVectorArrayImpl(nameID);
    }

    public void GetMatrixArray(string name, List<Matrix4x4> values)
    {
      this.GetMatrixArray(Shader.PropertyToID(name), values);
    }

    public void GetMatrixArray(int nameID, List<Matrix4x4> values)
    {
      if (values == null)
        throw new ArgumentNullException(nameof (values));
      this.GetMatrixArrayImplList(nameID, (object) values);
    }

    /// <summary>
    ///   <para>Get a matrix array from the property block.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="nameID"></param>
    public Matrix4x4[] GetMatrixArray(string name)
    {
      return this.GetMatrixArray(Shader.PropertyToID(name));
    }

    /// <summary>
    ///   <para>Get a matrix array from the property block.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="nameID"></param>
    public Matrix4x4[] GetMatrixArray(int nameID)
    {
      return this.GetMatrixArrayImpl(nameID);
    }

    /// <summary>
    ///   <para>Get a texture from the property block.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="nameID"></param>
    public Texture GetTexture(string name)
    {
      return this.GetTexture(Shader.PropertyToID(name));
    }

    /// <summary>
    ///   <para>Get a texture from the property block.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="nameID"></param>
    public Texture GetTexture(int nameID)
    {
      return this.GetTextureImpl(nameID);
    }

    [Obsolete("Use SetFloat instead (UnityUpgradable) -> SetFloat(*)", false)]
    public void AddFloat(string name, float value)
    {
      this.SetFloat(Shader.PropertyToID(name), value);
    }

    [Obsolete("Use SetFloat instead (UnityUpgradable) -> SetFloat(*)", false)]
    public void AddFloat(int nameID, float value)
    {
      this.SetFloat(nameID, value);
    }

    [Obsolete("Use SetVector instead (UnityUpgradable) -> SetVector(*)", false)]
    public void AddVector(string name, Vector4 value)
    {
      this.SetVector(Shader.PropertyToID(name), value);
    }

    [Obsolete("Use SetVector instead (UnityUpgradable) -> SetVector(*)", false)]
    public void AddVector(int nameID, Vector4 value)
    {
      this.SetVector(nameID, value);
    }

    [Obsolete("Use SetColor instead (UnityUpgradable) -> SetColor(*)", false)]
    public void AddColor(string name, Color value)
    {
      this.SetColor(Shader.PropertyToID(name), value);
    }

    [Obsolete("Use SetColor instead (UnityUpgradable) -> SetColor(*)", false)]
    public void AddColor(int nameID, Color value)
    {
      this.SetColor(nameID, value);
    }

    [Obsolete("Use SetMatrix instead (UnityUpgradable) -> SetMatrix(*)", false)]
    public void AddMatrix(string name, Matrix4x4 value)
    {
      this.SetMatrix(Shader.PropertyToID(name), value);
    }

    [Obsolete("Use SetMatrix instead (UnityUpgradable) -> SetMatrix(*)", false)]
    public void AddMatrix(int nameID, Matrix4x4 value)
    {
      this.SetMatrix(nameID, value);
    }

    [Obsolete("Use SetTexture instead (UnityUpgradable) -> SetTexture(*)", false)]
    public void AddTexture(string name, Texture value)
    {
      this.SetTexture(Shader.PropertyToID(name), value);
    }

    [Obsolete("Use SetTexture instead (UnityUpgradable) -> SetTexture(*)", false)]
    public void AddTexture(int nameID, Texture value)
    {
      this.SetTexture(nameID, value);
    }
  }
}
