﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.Experimental.UIElements.UIElementsEntryPoint
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

using UnityEngine.Experimental.UIElements;

namespace UnityEditor.Experimental.UIElements
{
  public static class UIElementsEntryPoint
  {
    public static VisualElement GetRootVisualContainer(this EditorWindow window)
    {
      return window.rootVisualContainer;
    }
  }
}
