﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.QualitySettings
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
  ///   <para>Script interface for.</para>
  /// </summary>
  public sealed class QualitySettings : Object
  {
    /// <summary>
    ///   <para>The indexed list of available Quality Settings.</para>
    /// </summary>
    public static extern string[] names { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Returns the current graphics quality level.</para>
    /// </summary>
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern int GetQualityLevel();

    /// <summary>
    ///   <para>Sets a new graphics quality level.</para>
    /// </summary>
    /// <param name="index">Quality index to set.</param>
    /// <param name="applyExpensiveChanges">Should expensive changes be applied (Anti-aliasing etc).</param>
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SetQualityLevel(int index, [DefaultValue("true")] bool applyExpensiveChanges);

    [ExcludeFromDocs]
    public static void SetQualityLevel(int index)
    {
      bool applyExpensiveChanges = true;
      QualitySettings.SetQualityLevel(index, applyExpensiveChanges);
    }

    /// <summary>
    ///   <para>Increase the current quality level.</para>
    /// </summary>
    /// <param name="applyExpensiveChanges">Should expensive changes be applied (Anti-aliasing etc).</param>
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void IncreaseLevel([DefaultValue("false")] bool applyExpensiveChanges);

    [ExcludeFromDocs]
    public static void IncreaseLevel()
    {
      QualitySettings.IncreaseLevel(false);
    }

    /// <summary>
    ///   <para>Decrease the current quality level.</para>
    /// </summary>
    /// <param name="applyExpensiveChanges">Should expensive changes be applied (Anti-aliasing etc).</param>
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void DecreaseLevel([DefaultValue("false")] bool applyExpensiveChanges);

    [ExcludeFromDocs]
    public static void DecreaseLevel()
    {
      QualitySettings.DecreaseLevel(false);
    }

    /// <summary>
    ///   <para>The normalized cascade start position for a 4 cascade setup. Each member of the vector defines the normalized position of the coresponding cascade with respect to Zero.</para>
    /// </summary>
    public static Vector3 shadowCascade4Split
    {
      get
      {
        Vector3 vector3;
        QualitySettings.INTERNAL_get_shadowCascade4Split(out vector3);
        return vector3;
      }
      set
      {
        QualitySettings.INTERNAL_set_shadowCascade4Split(ref value);
      }
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_get_shadowCascade4Split(out Vector3 value);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_set_shadowCascade4Split(ref Vector3 value);

    /// <summary>
    ///   <para>Global anisotropic filtering mode.</para>
    /// </summary>
    public static extern AnisotropicFiltering anisotropicFiltering { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Maximum number of frames queued up by graphics driver.</para>
    /// </summary>
    public static extern int maxQueuedFrames { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Blend weights.</para>
    /// </summary>
    public static extern BlendWeights blendWeights { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    [Obsolete("Use GetQualityLevel and SetQualityLevel", false)]
    public static QualityLevel currentLevel
    {
      get
      {
        return (QualityLevel) QualitySettings.GetQualityLevel();
      }
      set
      {
        QualitySettings.SetQualityLevel((int) value, true);
      }
    }

    /// <summary>
    ///   <para>The maximum number of pixel lights that should affect any object.</para>
    /// </summary>
    public static extern int pixelLightCount { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Realtime Shadows type to be used.</para>
    /// </summary>
    public static extern ShadowQuality shadows { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Directional light shadow projection.</para>
    /// </summary>
    public static extern ShadowProjection shadowProjection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Number of cascades to use for directional light shadows.</para>
    /// </summary>
    public static extern int shadowCascades { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Shadow drawing distance.</para>
    /// </summary>
    public static extern float shadowDistance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The default resolution of the shadow maps.</para>
    /// </summary>
    public static extern ShadowResolution shadowResolution { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The rendering mode of Shadowmask.</para>
    /// </summary>
    public static extern ShadowmaskMode shadowmaskMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Offset shadow frustum near plane.</para>
    /// </summary>
    public static extern float shadowNearPlaneOffset { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The normalized cascade distribution for a 2 cascade setup. The value defines the position of the cascade with respect to Zero.</para>
    /// </summary>
    public static extern float shadowCascade2Split { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Global multiplier for the LOD's switching distance.</para>
    /// </summary>
    public static extern float lodBias { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>A texture size limit applied to all textures.</para>
    /// </summary>
    public static extern int masterTextureLimit { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>A maximum LOD level. All LOD groups.</para>
    /// </summary>
    public static extern int maximumLODLevel { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Budget for how many ray casts can be performed per frame for approximate collision testing.</para>
    /// </summary>
    public static extern int particleRaycastBudget { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Should soft blending be used for particles?</para>
    /// </summary>
    public static extern bool softParticles { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Use a two-pass shader for the vegetation in the terrain engine.</para>
    /// </summary>
    public static extern bool softVegetation { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The VSync Count.</para>
    /// </summary>
    public static extern int vSyncCount { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Set The AA Filtering option.</para>
    /// </summary>
    public static extern int antiAliasing { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///         <para>Async texture upload provides timesliced async texture upload on the render thread with tight control over memory and timeslicing. There are no allocations except for the ones which driver has to do. To read data and upload texture data a ringbuffer whose size can be controlled is re-used.
    /// 
    /// Use asyncUploadTimeSlice to set the time-slice in milliseconds for asynchronous texture uploads per
    /// frame. Minimum value is 1 and maximum is 33.</para>
    ///       </summary>
    public static extern int asyncUploadTimeSlice { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///         <para>Async texture upload provides timesliced async texture upload on the render thread with tight control over memory and timeslicing. There are no allocations except for the ones which driver has to do. To read data and upload texture data a ringbuffer whose size can be controlled is re-used.
    /// 
    /// Use asyncUploadBufferSize to set the buffer size for asynchronous texture uploads. The size is in megabytes. Minimum value is 2 and maximum is 512. Although the buffer will resize automatically to fit the largest texture currently loading, it is recommended to set the value approximately to the size of biggest texture used in the scene to avoid re-sizing of the buffer which can incur performance cost.</para>
    ///       </summary>
    public static extern int asyncUploadBufferSize { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Enables realtime reflection probes.</para>
    /// </summary>
    public static extern bool realtimeReflectionProbes { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>If enabled, billboards will face towards camera position rather than camera orientation.</para>
    /// </summary>
    public static extern bool billboardsFaceCameraPosition { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>In resolution scaling mode, this factor is used to multiply with the target Fixed DPI specified to get the actual Fixed DPI to use for this quality setting.</para>
    /// </summary>
    public static extern float resolutionScalingFixedDPIFactor { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Desired color space (Read Only).</para>
    /// </summary>
    public static extern ColorSpace desiredColorSpace { [MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Active color space (Read Only).</para>
    /// </summary>
    public static extern ColorSpace activeColorSpace { [MethodImpl(MethodImplOptions.InternalCall)] get; }
  }
}
