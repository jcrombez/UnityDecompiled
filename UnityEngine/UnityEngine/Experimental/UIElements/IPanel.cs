﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.UIElements.IPanel
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System.Collections.Generic;

namespace UnityEngine.Experimental.UIElements
{
  public interface IPanel
  {
    VisualElement visualTree { get; }

    IEventDispatcher dispatcher { get; }

    ContextType contextType { get; }

    /// <summary>
    ///   <para>Return the focus controller for this panel.</para>
    /// </summary>
    FocusController focusController { get; }

    VisualElement Pick(Vector2 point);

    VisualElement LoadTemplate(string path, Dictionary<string, VisualElement> slots = null);

    VisualElement PickAll(Vector2 point, List<VisualElement> picked);

    BasePanelDebug panelDebug { get; set; }
  }
}
