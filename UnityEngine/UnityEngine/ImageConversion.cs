﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.ImageConversion
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
  public static class ImageConversion
  {
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern byte[] EncodeToPNG(this Texture2D tex);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern byte[] EncodeToJPG(this Texture2D tex, int quality);

    public static byte[] EncodeToJPG(this Texture2D tex)
    {
      return tex.EncodeToJPG(75);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern byte[] EncodeToEXR(this Texture2D tex, [DefaultValue("Texture2D.EXRFlags.None")] Texture2D.EXRFlags flags);

    [ExcludeFromDocs]
    public static byte[] EncodeToEXR(this Texture2D tex)
    {
      Texture2D.EXRFlags flags = Texture2D.EXRFlags.None;
      return tex.EncodeToEXR(flags);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool LoadImage(this Texture2D tex, byte[] data, [DefaultValue("false")] bool markNonReadable);

    [ExcludeFromDocs]
    public static bool LoadImage(this Texture2D tex, byte[] data)
    {
      bool markNonReadable = false;
      return tex.LoadImage(data, markNonReadable);
    }
  }
}
