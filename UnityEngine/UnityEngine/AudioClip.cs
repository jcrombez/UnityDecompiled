﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.AudioClip
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
  public sealed class AudioClip : Object
  {
    public extern float length { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public extern int samples { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public extern int channels { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public extern int frequency { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    [Obsolete("Use AudioClip.loadState instead to get more detailed information about the loading process.")]
    public extern bool isReadyToPlay { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public extern AudioClipLoadType loadType { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern bool LoadAudioData();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern bool UnloadAudioData();

    public extern bool preloadAudioData { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public extern bool ambisonic { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public extern AudioDataLoadState loadState { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public extern bool loadInBackground { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern bool GetData(float[] data, int offsetSamples);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern bool SetData(float[] data, int offsetSamples);

    [Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
    public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream)
    {
      return AudioClip.Create(name, lengthSamples, channels, frequency, stream);
    }

    [Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
    public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback)
    {
      return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, (AudioClip.PCMSetPositionCallback) null);
    }

    [Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
    public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback)
    {
      return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, pcmsetpositioncallback);
    }

    public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream)
    {
      return AudioClip.Create(name, lengthSamples, channels, frequency, stream, (AudioClip.PCMReaderCallback) null, (AudioClip.PCMSetPositionCallback) null);
    }

    public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback)
    {
      return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, (AudioClip.PCMSetPositionCallback) null);
    }

    public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback)
    {
      if (name == null)
        throw new NullReferenceException();
      if (lengthSamples <= 0)
        throw new ArgumentException("Length of created clip must be larger than 0");
      if (channels <= 0)
        throw new ArgumentException("Number of channels in created clip must be greater than 0");
      if (frequency <= 0)
        throw new ArgumentException("Frequency in created clip must be greater than 0");
      AudioClip audioClip = AudioClip.Construct_Internal();
      if (pcmreadercallback != null)
        audioClip.m_PCMReaderCallback += pcmreadercallback;
      if (pcmsetpositioncallback != null)
        audioClip.m_PCMSetPositionCallback += pcmsetpositioncallback;
      audioClip.Init_Internal(name, lengthSamples, channels, frequency, stream);
      return audioClip;
    }

    private event AudioClip.PCMReaderCallback m_PCMReaderCallback = null;

    private event AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback = null;

    [RequiredByNativeCode]
    private void InvokePCMReaderCallback_Internal(float[] data)
    {
      // ISSUE: reference to a compiler-generated field
      if (this.m_PCMReaderCallback == null)
        return;
      // ISSUE: reference to a compiler-generated field
      this.m_PCMReaderCallback(data);
    }

    [RequiredByNativeCode]
    private void InvokePCMSetPositionCallback_Internal(int position)
    {
      // ISSUE: reference to a compiler-generated field
      if (this.m_PCMSetPositionCallback == null)
        return;
      // ISSUE: reference to a compiler-generated field
      this.m_PCMSetPositionCallback(position);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern AudioClip Construct_Internal();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void Init_Internal(string name, int lengthSamples, int channels, int frequency, bool stream);

    public delegate void PCMReaderCallback(float[] data);

    public delegate void PCMSetPositionCallback(int position);
  }
}
