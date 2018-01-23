﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.EditorUpdateWindow
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

using UnityEditorInternal;
using UnityEngine;

namespace UnityEditor
{
  internal class EditorUpdateWindow : EditorWindow
  {
    private static GUIContent s_UnityLogo;
    private static GUIContent s_Title;
    private static GUIContent s_TextHasUpdate;
    private static GUIContent s_TextUpToDate;
    private static GUIContent s_CheckForNewUpdatesText;
    [SerializeField]
    private string s_ErrorString;
    [SerializeField]
    private string s_LatestVersionString;
    [SerializeField]
    private string s_LatestVersionMessage;
    [SerializeField]
    private string s_UpdateURL;
    [SerializeField]
    private bool s_HasUpdate;
    [SerializeField]
    private bool s_HasConnectionError;
    private static bool s_ShowAtStartup;
    private Vector2 m_ScrollPos;

    private static void ShowEditorErrorWindow(string errorString)
    {
      EditorUpdateWindow.LoadResources();
      EditorUpdateWindow editorUpdateWindow = EditorUpdateWindow.ShowWindow();
      editorUpdateWindow.s_ErrorString = errorString;
      editorUpdateWindow.s_HasConnectionError = true;
      editorUpdateWindow.s_HasUpdate = false;
    }

    private static void ShowEditorUpdateWindow(string latestVersionString, string latestVersionMessage, string updateURL)
    {
      EditorUpdateWindow.LoadResources();
      EditorUpdateWindow editorUpdateWindow = EditorUpdateWindow.ShowWindow();
      editorUpdateWindow.s_LatestVersionString = latestVersionString;
      editorUpdateWindow.s_LatestVersionMessage = latestVersionMessage;
      editorUpdateWindow.s_UpdateURL = updateURL;
      editorUpdateWindow.s_HasConnectionError = false;
      editorUpdateWindow.s_HasUpdate = updateURL.Length > 0;
    }

    private static EditorUpdateWindow ShowWindow()
    {
      return EditorWindow.GetWindowWithRect(typeof (EditorUpdateWindow), new Rect(100f, 100f, 570f, 400f), true, EditorUpdateWindow.s_Title.text) as EditorUpdateWindow;
    }

    private static void LoadResources()
    {
      if (EditorUpdateWindow.s_UnityLogo != null)
        return;
      EditorUpdateWindow.s_ShowAtStartup = EditorPrefs.GetBool("EditorUpdateShowAtStartup", true);
      EditorUpdateWindow.s_Title = EditorGUIUtility.TextContent("Unity Editor Update Check");
      EditorUpdateWindow.s_UnityLogo = EditorGUIUtility.IconContent("UnityLogo");
      EditorUpdateWindow.s_TextHasUpdate = EditorGUIUtility.TextContent("There is a new version of the Unity Editor available for download.\n\nCurrently installed version is {0}\nNew version is {1}");
      EditorUpdateWindow.s_TextUpToDate = EditorGUIUtility.TextContent("The Unity Editor is up to date. Currently installed version is {0}");
      EditorUpdateWindow.s_CheckForNewUpdatesText = EditorGUIUtility.TextContent("Check for Updates");
    }

    public void OnGUI()
    {
      EditorUpdateWindow.LoadResources();
      GUILayout.BeginVertical();
      GUILayout.Space(10f);
      GUI.Box(new Rect(13f, 8f, (float) EditorUpdateWindow.s_UnityLogo.image.width, (float) EditorUpdateWindow.s_UnityLogo.image.height), EditorUpdateWindow.s_UnityLogo, GUIStyle.none);
      GUILayout.Space(5f);
      GUILayout.BeginHorizontal();
      GUILayout.Space(120f);
      GUILayout.BeginVertical();
      if (this.s_HasConnectionError)
        GUILayout.Label(this.s_ErrorString, (GUIStyle) "WordWrappedLabel", new GUILayoutOption[1]
        {
          GUILayout.Width(405f)
        });
      else if (this.s_HasUpdate)
      {
        GUILayout.Label(string.Format(EditorUpdateWindow.s_TextHasUpdate.text, (object) InternalEditorUtility.GetFullUnityVersion(), (object) this.s_LatestVersionString), (GUIStyle) "WordWrappedLabel", new GUILayoutOption[1]
        {
          GUILayout.Width(300f)
        });
        GUILayout.Space(20f);
        this.m_ScrollPos = EditorGUILayout.BeginScrollView(this.m_ScrollPos, new GUILayoutOption[2]
        {
          GUILayout.Width(405f),
          GUILayout.Height(200f)
        });
        GUILayout.Label(this.s_LatestVersionMessage, (GUIStyle) "WordWrappedLabel", new GUILayoutOption[0]);
        EditorGUILayout.EndScrollView();
        GUILayout.Space(20f);
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Download new version", new GUILayoutOption[1]{ GUILayout.Width(200f) }))
          Help.BrowseURL(this.s_UpdateURL);
        if (GUILayout.Button("Skip new version", new GUILayoutOption[1]{ GUILayout.Width(200f) }))
        {
          EditorPrefs.SetString("EditorUpdateSkipVersionString", this.s_LatestVersionString);
          this.Close();
        }
        GUILayout.EndHorizontal();
      }
      else
        GUILayout.Label(string.Format(EditorUpdateWindow.s_TextUpToDate.text, (object) Application.unityVersion), (GUIStyle) "WordWrappedLabel", new GUILayoutOption[1]
        {
          GUILayout.Width(405f)
        });
      GUILayout.EndVertical();
      GUILayout.EndHorizontal();
      GUILayout.Space(8f);
      GUILayout.FlexibleSpace();
      GUILayout.BeginHorizontal(GUILayout.Height(20f));
      GUILayout.FlexibleSpace();
      GUI.changed = false;
      EditorUpdateWindow.s_ShowAtStartup = GUILayout.Toggle(EditorUpdateWindow.s_ShowAtStartup, EditorUpdateWindow.s_CheckForNewUpdatesText);
      if (GUI.changed)
        EditorPrefs.SetBool("EditorUpdateShowAtStartup", EditorUpdateWindow.s_ShowAtStartup);
      GUILayout.Space(10f);
      GUILayout.EndHorizontal();
      GUILayout.EndVertical();
    }
  }
}
