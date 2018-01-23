﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Video.VideoClip
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Video
{
  public sealed class VideoClip : Object
  {
    public extern string originalPath { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public extern ulong frameCount { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public extern double frameRate { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public extern double length { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public extern uint width { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public extern uint height { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public extern uint pixelAspectRatioNumerator { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public extern uint pixelAspectRatioDenominator { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public extern ushort audioTrackCount { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public ushort GetAudioChannelCount(ushort audioTrackIdx)
    {
      return VideoClip.INTERNAL_CALL_GetAudioChannelCount(this, audioTrackIdx);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern ushort INTERNAL_CALL_GetAudioChannelCount(VideoClip self, ushort audioTrackIdx);

    public uint GetAudioSampleRate(ushort audioTrackIdx)
    {
      return VideoClip.INTERNAL_CALL_GetAudioSampleRate(this, audioTrackIdx);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern uint INTERNAL_CALL_GetAudioSampleRate(VideoClip self, ushort audioTrackIdx);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern string GetAudioLanguage(ushort audioTrackIdx);
  }
}
