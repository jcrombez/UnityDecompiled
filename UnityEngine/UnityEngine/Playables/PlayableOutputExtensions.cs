﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.PlayableOutputExtensions
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

namespace UnityEngine.Playables
{
  public static class PlayableOutputExtensions
  {
    public static bool IsOutputValid<U>(this U output) where U : struct, IPlayableOutput
    {
      return output.GetHandle().IsValid();
    }

    public static Object GetReferenceObject<U>(this U output) where U : struct, IPlayableOutput
    {
      return output.GetHandle().GetReferenceObject();
    }

    public static void SetReferenceObject<U>(this U output, Object value) where U : struct, IPlayableOutput
    {
      output.GetHandle().SetReferenceObject(value);
    }

    public static Object GetUserData<U>(this U output) where U : struct, IPlayableOutput
    {
      return output.GetHandle().GetUserData();
    }

    public static void SetUserData<U>(this U output, Object value) where U : struct, IPlayableOutput
    {
      output.GetHandle().SetUserData(value);
    }

    public static Playable GetSourcePlayable<U>(this U output) where U : struct, IPlayableOutput
    {
      return new Playable(output.GetHandle().GetSourcePlayable());
    }

    public static void SetSourcePlayable<U, V>(this U output, V value) where U : struct, IPlayableOutput where V : struct, IPlayable
    {
      output.GetHandle().SetSourcePlayable(value.GetHandle());
    }

    public static int GetSourceInputPort<U>(this U output) where U : struct, IPlayableOutput
    {
      return output.GetHandle().GetSourceInputPort();
    }

    public static void SetSourceInputPort<U>(this U output, int value) where U : struct, IPlayableOutput
    {
      output.GetHandle().SetSourceInputPort(value);
    }

    public static float GetWeight<U>(this U output) where U : struct, IPlayableOutput
    {
      return output.GetHandle().GetWeight();
    }

    public static void SetWeight<U>(this U output, float value) where U : struct, IPlayableOutput
    {
      output.GetHandle().SetWeight(value);
    }
  }
}
