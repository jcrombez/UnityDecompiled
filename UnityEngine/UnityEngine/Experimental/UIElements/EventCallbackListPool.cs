﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.UIElements.EventCallbackListPool
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System.Collections.Generic;

namespace UnityEngine.Experimental.UIElements
{
  internal class EventCallbackListPool
  {
    private readonly Stack<EventCallbackList> m_Stack = new Stack<EventCallbackList>();

    public EventCallbackList Get(EventCallbackList initializer)
    {
      EventCallbackList eventCallbackList;
      if (this.m_Stack.Count == 0)
      {
        eventCallbackList = initializer == null ? new EventCallbackList() : new EventCallbackList(initializer);
      }
      else
      {
        eventCallbackList = this.m_Stack.Pop();
        if (initializer != null)
          eventCallbackList.AddRange(initializer);
      }
      return eventCallbackList;
    }

    public void Release(EventCallbackList element)
    {
      element.Clear();
      this.m_Stack.Push(element);
    }
  }
}
