﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.DebugLogHandler
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
  internal sealed class DebugLogHandler : ILogHandler
  {
    [ThreadAndSerializationSafe]
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void Internal_Log(LogType level, string msg, [Writable] Object obj);

    [ThreadAndSerializationSafe]
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void Internal_LogException(Exception exception, [Writable] Object obj);

    public void LogFormat(LogType logType, Object context, string format, params object[] args)
    {
      DebugLogHandler.Internal_Log(logType, string.Format(format, args), context);
    }

    public void LogException(Exception exception, Object context)
    {
      DebugLogHandler.Internal_LogException(exception, context);
    }
  }
}
