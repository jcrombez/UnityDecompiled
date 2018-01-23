﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.UIElements.EventCallbackFunctor`1
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;

namespace UnityEngine.Experimental.UIElements
{
  internal class EventCallbackFunctor<TEventType> : EventCallbackFunctorBase where TEventType : EventBase<TEventType>, new()
  {
    private EventCallback<TEventType> m_Callback;
    private long m_EventTypeId;

    public EventCallbackFunctor(EventCallback<TEventType> callback, CallbackPhase phase)
      : base(phase)
    {
      this.m_Callback = callback;
      this.m_EventTypeId = EventBase<TEventType>.TypeId();
    }

    public override void Invoke(EventBase evt)
    {
      if (evt == null)
        throw new ArgumentNullException();
      if (evt.GetEventTypeId() != this.m_EventTypeId || !this.PhaseMatches(evt))
        return;
      this.m_Callback(evt as TEventType);
    }

    public override bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase)
    {
      return this.m_EventTypeId == eventTypeId && (Delegate) this.m_Callback == callback && this.phase == phase;
    }
  }
}
