﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.CreateBuiltinWindows
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

using UnityEditor.Sprites;
using UnityEditor.VersionControl;

namespace UnityEditor
{
  internal class CreateBuiltinWindows
  {
    [MenuItem("Window/Scene %1", false, 2000)]
    private static void ShowSceneView()
    {
      EditorWindow.GetWindow<SceneView>();
    }

    [MenuItem("Window/Game %2", false, 2001)]
    private static void ShowGameView()
    {
      EditorWindow.GetWindow<GameView>();
    }

    [MenuItem("Window/Inspector %3", false, 2002)]
    private static void ShowInspector()
    {
      EditorWindow.GetWindow<InspectorWindow>();
    }

    [MenuItem("Window/Hierarchy %4", false, 2003)]
    private static void ShowNewHierarchy()
    {
      EditorWindow.GetWindow<SceneHierarchyWindow>();
    }

    [MenuItem("Window/Project %5", false, 2004)]
    private static void ShowProject()
    {
      EditorWindow.GetWindow<ProjectBrowser>();
    }

    [MenuItem("Window/Animation %6", false, 2006)]
    private static void ShowAnimationWindow()
    {
      EditorWindow.GetWindow<AnimationWindow>();
    }

    private static void ShowProfilerWindow()
    {
      EditorWindow.GetWindow<ProfilerWindow>();
    }

    [MenuItem("Window/Audio Mixer %8", false, 2008)]
    private static void ShowAudioMixer()
    {
      AudioMixerWindow.CreateAudioMixerWindow();
    }

    private static void ShowVersionControl()
    {
      EditorWindow.GetWindow<WindowPending>();
    }

    [MenuItem("Window/Sprite Packer", false, 2014)]
    private static void ShowSpritePackerWindow()
    {
      EditorWindow.GetWindow<PackerWindow>();
    }

    [MenuItem("Window/Console %#c", false, 2200)]
    private static void ShowConsole()
    {
      EditorWindow.GetWindow<ConsoleWindow>();
    }

    [MenuItem("Window/Experimental/Look Dev", false, 2015)]
    private static void ShowLookDevTool()
    {
      EditorWindow.GetWindow<LookDevView>();
    }
  }
}
