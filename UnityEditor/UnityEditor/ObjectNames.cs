﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.ObjectNames
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting;

namespace UnityEditor
{
  /// <summary>
  ///   <para>Helper class for constructing displayable names for objects.</para>
  /// </summary>
  public sealed class ObjectNames
  {
    /// <summary>
    ///   <para>Make a displayable name for a variable.</para>
    /// </summary>
    /// <param name="name"></param>
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string NicifyVariableName(string name);

    /// <summary>
    ///   <para>Class name of an object.</para>
    /// </summary>
    /// <param name="obj"></param>
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string GetClassName(UnityEngine.Object obj);

    internal static string GetTypeName(UnityEngine.Object obj)
    {
      if (obj == (UnityEngine.Object) null)
        return "Object";
      string lower = AssetDatabase.GetAssetPath(obj).ToLower();
      if (lower.EndsWith(".unity"))
        return "Scene";
      if (lower.EndsWith(".guiskin"))
        return "GUI Skin";
      if (Directory.Exists(AssetDatabase.GetAssetPath(obj)))
        return "Folder";
      if (obj.GetType() == typeof (UnityEngine.Object))
        return Path.GetExtension(lower) + " File";
      return ObjectNames.GetClassName(obj);
    }

    /// <summary>
    ///   <para>Drag and drop title for an object.</para>
    /// </summary>
    /// <param name="obj"></param>
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string GetDragAndDropTitle(UnityEngine.Object obj);

    /// <summary>
    ///   <para>Sets the name of an Object.</para>
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="name"></param>
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SetNameSmart(UnityEngine.Object obj, string name);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void SetNameSmartWithInstanceID(int instanceID, string name);

    [Obsolete("Please use NicifyVariableName instead")]
    public static string MangleVariableName(string name)
    {
      return ObjectNames.NicifyVariableName(name);
    }

    [Obsolete("Please use GetInspectorTitle instead")]
    public static string GetPropertyEditorTitle(UnityEngine.Object obj)
    {
      return ObjectNames.GetInspectorTitle(obj);
    }

    /// <summary>
    ///         <para>Make a unique name using the provided name as a base.
    /// 
    /// If the target name is in the provided list of existing names, a unique name is generated by appending the next available numerical increment.</para>
    ///       </summary>
    /// <param name="existingNames">A list of pre-existing names.</param>
    /// <param name="name">Desired name to be used as is, or as a base.</param>
    /// <returns>
    ///   <para>A name not found in the list of pre-existing names.</para>
    /// </returns>
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string GetUniqueName(string[] existingNames, string name);

    private static string GetObjectTypeName(UnityEngine.Object o)
    {
      if (o == (UnityEngine.Object) null)
        return "Nothing Selected";
      if (o is GameObject)
        return o.name;
      if (o is TagManager)
        return "Tags & Layers";
      if (o is Component)
      {
        MonoBehaviour monoBehaviour = o as MonoBehaviour;
        if ((bool) ((UnityEngine.Object) monoBehaviour))
        {
          string scriptClassName = monoBehaviour.GetScriptClassName();
          if (scriptClassName == "InvalidStateMachineBehaviour")
            return monoBehaviour.name + " (Script)";
          return scriptClassName + " (Script)";
        }
        MeshFilter meshFilter = o as MeshFilter;
        if (!(bool) ((UnityEngine.Object) meshFilter))
          return o.GetType().Name;
        Mesh sharedMesh = meshFilter.sharedMesh;
        return (!(bool) ((UnityEngine.Object) sharedMesh) ? "[none]" : sharedMesh.name) + " (MeshFilter)";
      }
      if (!(o is AssetImporter))
        return o.name + " (" + o.GetType().Name + ")";
      MonoImporter monoImporter = o as MonoImporter;
      if ((bool) ((UnityEngine.Object) monoImporter))
      {
        MonoScript script = monoImporter.GetScript();
        return "Default References (" + (!(bool) ((UnityEngine.Object) script) ? string.Empty : script.name) + ")";
      }
      SubstanceImporter substanceImporter = o as SubstanceImporter;
      if ((bool) ((UnityEngine.Object) substanceImporter))
      {
        MonoScript substanceArchive = substanceImporter.GetSubstanceArchive();
        if ((bool) ((UnityEngine.Object) substanceArchive))
          return substanceArchive.name + " (Substance Archive)";
      }
      return o.GetType().Name;
    }

    /// <summary>
    ///   <para>Inspector title for an object.</para>
    /// </summary>
    /// <param name="obj"></param>
    public static string GetInspectorTitle(UnityEngine.Object obj)
    {
      if (!(bool) obj)
        return "Nothing Selected";
      string str = ObjectNames.NicifyVariableName(ObjectNames.GetObjectTypeName(obj));
      if (Attribute.IsDefined((MemberInfo) obj.GetType(), typeof (ObsoleteAttribute)))
        str += " (Deprecated)";
      return str;
    }
  }
}
