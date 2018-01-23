﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.ModelImporterNormalCalculationMode
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

using UnityEngine.Bindings;

namespace UnityEditor
{
  /// <summary>
  ///   <para>Normal generation options for ModelImporter.</para>
  /// </summary>
  [NativeType(Header = "Editor/Src/AssetPipeline/ModelImporting/ImportMesh.h")]
  public enum ModelImporterNormalCalculationMode
  {
    Unweighted_Legacy,
    Unweighted,
    AreaWeighted,
    AngleWeighted,
    AreaAndAngleWeighted,
  }
}
