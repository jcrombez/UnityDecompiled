﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.UnityLogWriter
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine.Scripting;

namespace UnityEngine
{
  internal sealed class UnityLogWriter : TextWriter
  {
    [ThreadAndSerializationSafe]
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void WriteStringToUnityLog(string s);

    public static void Init()
    {
      Console.SetOut((TextWriter) new UnityLogWriter());
    }

    public override Encoding Encoding
    {
      get
      {
        return Encoding.UTF8;
      }
    }

    public override void Write(char value)
    {
      UnityLogWriter.WriteStringToUnityLog(value.ToString());
    }

    public override void Write(string s)
    {
      UnityLogWriter.WriteStringToUnityLog(s);
    }
  }
}
