﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.PlayableExtensions
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;

namespace UnityEngine.Playables
{
  public static class PlayableExtensions
  {
    public static bool IsValid<U>(this U playable) where U : struct, IPlayable
    {
      return playable.GetHandle().IsValid();
    }

    public static void Destroy<U>(this U playable) where U : struct, IPlayable
    {
      playable.GetHandle().Destroy();
    }

    public static PlayableGraph GetGraph<U>(this U playable) where U : struct, IPlayable
    {
      return playable.GetHandle().GetGraph();
    }

    [Obsolete("SetPlayState() has been deprecated. Use Play(), Pause() or SetDelay() instead", false)]
    public static void SetPlayState<U>(this U playable, PlayState value) where U : struct, IPlayable
    {
      if (value == PlayState.Delayed)
        throw new ArgumentException("Can't set Delayed: use SetDelay() instead");
      if (value != PlayState.Playing)
      {
        if (value != PlayState.Paused)
          return;
        playable.GetHandle().Pause();
      }
      else
        playable.GetHandle().Play();
    }

    public static PlayState GetPlayState<U>(this U playable) where U : struct, IPlayable
    {
      return playable.GetHandle().GetPlayState();
    }

    public static void Play<U>(this U playable) where U : struct, IPlayable
    {
      playable.GetHandle().Play();
    }

    public static void Pause<U>(this U playable) where U : struct, IPlayable
    {
      playable.GetHandle().Pause();
    }

    public static void SetSpeed<U>(this U playable, double value) where U : struct, IPlayable
    {
      playable.GetHandle().SetSpeed(value);
    }

    public static double GetSpeed<U>(this U playable) where U : struct, IPlayable
    {
      return playable.GetHandle().GetSpeed();
    }

    public static void SetDuration<U>(this U playable, double value) where U : struct, IPlayable
    {
      playable.GetHandle().SetDuration(value);
    }

    public static double GetDuration<U>(this U playable) where U : struct, IPlayable
    {
      return playable.GetHandle().GetDuration();
    }

    public static void SetTime<U>(this U playable, double value) where U : struct, IPlayable
    {
      playable.GetHandle().SetTime(value);
    }

    public static double GetTime<U>(this U playable) where U : struct, IPlayable
    {
      return playable.GetHandle().GetTime();
    }

    public static double GetPreviousTime<U>(this U playable) where U : struct, IPlayable
    {
      return playable.GetHandle().GetPreviousTime();
    }

    public static void SetDone<U>(this U playable, bool value) where U : struct, IPlayable
    {
      playable.GetHandle().SetDone(value);
    }

    public static bool IsDone<U>(this U playable) where U : struct, IPlayable
    {
      return playable.GetHandle().IsDone();
    }

    public static void SetPropagateSetTime<U>(this U playable, bool value) where U : struct, IPlayable
    {
      playable.GetHandle().SetPropagateSetTime(value);
    }

    public static bool GetPropagateSetTime<U>(this U playable) where U : struct, IPlayable
    {
      return playable.GetHandle().GetPropagateSetTime();
    }

    public static bool CanChangeInputs<U>(this U playable) where U : struct, IPlayable
    {
      return playable.GetHandle().CanChangeInputs();
    }

    public static bool CanSetWeights<U>(this U playable) where U : struct, IPlayable
    {
      return playable.GetHandle().CanSetWeights();
    }

    public static bool CanDestroy<U>(this U playable) where U : struct, IPlayable
    {
      return playable.GetHandle().CanDestroy();
    }

    public static void SetInputCount<U>(this U playable, int value) where U : struct, IPlayable
    {
      playable.GetHandle().SetInputCount(value);
    }

    public static int GetInputCount<U>(this U playable) where U : struct, IPlayable
    {
      return playable.GetHandle().GetInputCount();
    }

    public static void SetOutputCount<U>(this U playable, int value) where U : struct, IPlayable
    {
      playable.GetHandle().SetOutputCount(value);
    }

    public static int GetOutputCount<U>(this U playable) where U : struct, IPlayable
    {
      return playable.GetHandle().GetOutputCount();
    }

    public static Playable GetInput<U>(this U playable, int inputPort) where U : struct, IPlayable
    {
      return playable.GetHandle().GetInput(inputPort);
    }

    public static Playable GetOutput<U>(this U playable, int outputPort) where U : struct, IPlayable
    {
      return playable.GetHandle().GetOutput(outputPort);
    }

    public static void SetInputWeight<U>(this U playable, int inputIndex, float weight) where U : struct, IPlayable
    {
      playable.GetHandle().SetInputWeight(inputIndex, weight);
    }

    public static void SetInputWeight<U, V>(this U playable, V input, float weight) where U : struct, IPlayable where V : struct, IPlayable
    {
      playable.GetHandle().SetInputWeight(input.GetHandle(), weight);
    }

    public static float GetInputWeight<U>(this U playable, int inputIndex) where U : struct, IPlayable
    {
      return playable.GetHandle().GetInputWeight(inputIndex);
    }

    public static void ConnectInput<U, V>(this U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex) where U : struct, IPlayable where V : struct, IPlayable
    {
      playable.ConnectInput<U, V>(inputIndex, sourcePlayable, sourceOutputIndex, 0.0f);
    }

    public static void ConnectInput<U, V>(this U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex, float weight) where U : struct, IPlayable where V : struct, IPlayable
    {
      playable.GetGraph<U>().Connect<V, U>(sourcePlayable, sourceOutputIndex, playable, inputIndex);
      playable.SetInputWeight<U>(inputIndex, weight);
    }

    public static int AddInput<U, V>(this U playable, V sourcePlayable, int sourceOutputIndex, float weight = 0.0f) where U : struct, IPlayable where V : struct, IPlayable
    {
      int inputCount = playable.GetInputCount<U>();
      playable.SetInputCount<U>(inputCount + 1);
      playable.ConnectInput<U, V>(inputCount, sourcePlayable, sourceOutputIndex, weight);
      return inputCount;
    }

    public static void SetDelay<U>(this U playable, double delay) where U : struct, IPlayable
    {
      playable.GetHandle().SetDelay(delay);
    }

    public static double GetDelay<U>(this U playable) where U : struct, IPlayable
    {
      return playable.GetHandle().GetDelay();
    }

    public static bool IsDelayed<U>(this U playable) where U : struct, IPlayable
    {
      return playable.GetHandle().IsDelayed();
    }
  }
}
