﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.Unsupported
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

namespace UnityEditor
{
  public sealed class Unsupported
  {
    private static bool s_FakeNonDeveloperBuild = EditorPrefs.GetBool("FakeNonDeveloperBuild", false);

    internal static bool fakeNonDeveloperBuild
    {
      get
      {
        return Unsupported.s_FakeNonDeveloperBuild;
      }
      set
      {
        Unsupported.s_FakeNonDeveloperBuild = value;
        EditorPrefs.SetBool("FakeNonDeveloperBuild", value);
      }
    }

    internal static Vector3 MakeNiceVector3(Vector3 vector)
    {
      Vector3 vector3;
      Unsupported.INTERNAL_CALL_MakeNiceVector3(ref vector, out vector3);
      return vector3;
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_MakeNiceVector3(ref Vector3 vector, out Vector3 value);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void CaptureScreenshotImmediate(string filePath, int x, int y, int width, int height);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string[] GetSubmenusCommands(string menuPath);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern System.Type GetTypeFromFullName(string fullName);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string[] GetSubmenus(string menuPath);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string[] GetSubmenusIncludingSeparators(string menuPath);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void PrepareObjectContextMenu(UnityEngine.Object c, int contextUserData);

    public static bool IsDeveloperBuild()
    {
      return Unsupported.IsDeveloperBuildInternal() && !Unsupported.s_FakeNonDeveloperBuild;
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool IsDeveloperBuildInternal();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool IsBleedingEdgeBuild();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool IsDestroyScriptableObject(ScriptableObject target);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool IsNativeCodeBuiltInReleaseMode();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string GetBaseUnityDeveloperFolder();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void StopPlayingImmediately();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SceneTrackerFlushDirty();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SetAllowCursorHide(bool allow);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SetAllowCursorLock(bool allow);

    internal static bool SetOverrideRenderSettings(Scene scene)
    {
      return Unsupported.SetOverrideRenderSettingsInternal(scene.handle);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern bool SetOverrideRenderSettingsInternal(int sceneHandle);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void RestoreOverrideRenderSettings();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SetRenderSettingsUseFogNoDirty(bool fog);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SetQualitySettingsShadowDistanceTemporarily(float distance);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void DeleteGameObjectSelection();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void CopyGameObjectsToPasteboard();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void PasteGameObjectsFromPasteboard();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern UnityEngine.Object GetSerializedAssetInterfaceSingleton(string className);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void DuplicateGameObjectsUsingPasteboard();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool CopyComponentToPasteboard(Component component);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool PasteComponentFromPasteboard(GameObject go);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool PasteComponentValuesFromPasteboard(Component component);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool HasStateMachineTransitionDataInPasteboard();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool AreAllParametersInDestinationInternal(UnityEngine.Object transition, AnimatorController controller, object missingParameters);

    public static bool AreAllParametersInDestination(UnityEngine.Object transition, AnimatorController controller, List<string> missingParameters)
    {
      return Unsupported.AreAllParametersInDestinationInternal(transition, controller, (object) missingParameters);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool DestinationHasCompatibleParameterTypesInternal(UnityEngine.Object transition, AnimatorController controller, object mismatchedParameters);

    public static bool DestinationHasCompatibleParameterTypes(UnityEngine.Object transition, AnimatorController controller, List<string> mismatchedParameters)
    {
      return Unsupported.DestinationHasCompatibleParameterTypesInternal(transition, controller, (object) mismatchedParameters);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool CanPasteParametersToTransition(UnityEngine.Object transition, AnimatorController controller);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void CopyStateMachineTransitionParametersToPasteboard(UnityEngine.Object transition, AnimatorController controller);

    public static void PasteToStateMachineTransitionParametersFromPasteboard(UnityEngine.Object transition, AnimatorController controller, bool conditions, bool parameters)
    {
      Undo.RegisterCompleteObjectUndo(transition, "Paste to Transition");
      Unsupported.PasteToStateMachineTransitionParametersFromPasteboardInternal(transition, controller, conditions, parameters);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void PasteToStateMachineTransitionParametersFromPasteboardInternal(UnityEngine.Object transition, AnimatorController controller, bool conditions, bool parameters);

    public static void CopyStateMachineDataToPasteboard(UnityEngine.Object stateMachineObject, AnimatorController controller, int layerIndex)
    {
      Unsupported.CopyStateMachineDataToPasteboard(new UnityEngine.Object[1]
      {
        stateMachineObject
      }, (AnimatorStateMachine) null, new Vector3[1]
      {
        new Vector3()
      }, controller, layerIndex);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void CopyStateMachineDataToPasteboard(UnityEngine.Object[] stateMachineObjects, AnimatorStateMachine context, Vector3[] monoPositions, AnimatorController controller, int layerIndex);

    public static void PasteToStateMachineFromPasteboard(AnimatorStateMachine sm, AnimatorController controller, int layerIndex, Vector3 position)
    {
      Undo.RegisterCompleteObjectUndo((UnityEngine.Object) sm, "Paste to StateMachine");
      Unsupported.PasteToStateMachineFromPasteboardInternal(sm, controller, layerIndex, position);
    }

    internal static void PasteToStateMachineFromPasteboardInternal(AnimatorStateMachine sm, AnimatorController controller, int layerIndex, Vector3 position)
    {
      Unsupported.INTERNAL_CALL_PasteToStateMachineFromPasteboardInternal(sm, controller, layerIndex, ref position);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_PasteToStateMachineFromPasteboardInternal(AnimatorStateMachine sm, AnimatorController controller, int layerIndex, ref Vector3 position);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool HasStateMachineDataInPasteboard();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SmartReset(UnityEngine.Object obj);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string ResolveSymlinks(string path);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SetApplicationSettingCompressAssetsOnImport(bool value);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool GetApplicationSettingCompressAssetsOnImport();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern int GetLocalIdentifierInFile(int instanceID);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool IsHiddenFile(string path);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void ClearSkinCache();

    internal static extern bool useScriptableRenderPipeline { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }
  }
}
