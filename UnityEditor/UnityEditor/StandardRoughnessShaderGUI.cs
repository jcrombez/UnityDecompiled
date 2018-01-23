﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.StandardRoughnessShaderGUI
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

using System;
using UnityEngine;

namespace UnityEditor
{
  internal class StandardRoughnessShaderGUI : ShaderGUI
  {
    private MaterialProperty blendMode = (MaterialProperty) null;
    private MaterialProperty albedoMap = (MaterialProperty) null;
    private MaterialProperty albedoColor = (MaterialProperty) null;
    private MaterialProperty alphaCutoff = (MaterialProperty) null;
    private MaterialProperty metallicMap = (MaterialProperty) null;
    private MaterialProperty metallic = (MaterialProperty) null;
    private MaterialProperty roughness = (MaterialProperty) null;
    private MaterialProperty roughnessMap = (MaterialProperty) null;
    private MaterialProperty highlights = (MaterialProperty) null;
    private MaterialProperty reflections = (MaterialProperty) null;
    private MaterialProperty bumpScale = (MaterialProperty) null;
    private MaterialProperty bumpMap = (MaterialProperty) null;
    private MaterialProperty occlusionStrength = (MaterialProperty) null;
    private MaterialProperty occlusionMap = (MaterialProperty) null;
    private MaterialProperty heigtMapScale = (MaterialProperty) null;
    private MaterialProperty heightMap = (MaterialProperty) null;
    private MaterialProperty emissionColorForRendering = (MaterialProperty) null;
    private MaterialProperty emissionMap = (MaterialProperty) null;
    private MaterialProperty detailMask = (MaterialProperty) null;
    private MaterialProperty detailAlbedoMap = (MaterialProperty) null;
    private MaterialProperty detailNormalMapScale = (MaterialProperty) null;
    private MaterialProperty detailNormalMap = (MaterialProperty) null;
    private MaterialProperty uvSetSecondary = (MaterialProperty) null;
    private ColorPickerHDRConfig m_ColorPickerHDRConfig = new ColorPickerHDRConfig(0.0f, 99f, 1f / 99f, 3f);
    private bool m_FirstTimeApply = true;
    private MaterialEditor m_MaterialEditor;

    public void FindProperties(MaterialProperty[] props)
    {
      this.blendMode = ShaderGUI.FindProperty("_Mode", props);
      this.albedoMap = ShaderGUI.FindProperty("_MainTex", props);
      this.albedoColor = ShaderGUI.FindProperty("_Color", props);
      this.alphaCutoff = ShaderGUI.FindProperty("_Cutoff", props);
      this.metallicMap = ShaderGUI.FindProperty("_MetallicGlossMap", props, false);
      this.metallic = ShaderGUI.FindProperty("_Metallic", props, false);
      this.roughness = ShaderGUI.FindProperty("_Glossiness", props);
      this.roughnessMap = ShaderGUI.FindProperty("_SpecGlossMap", props);
      this.highlights = ShaderGUI.FindProperty("_SpecularHighlights", props, false);
      this.reflections = ShaderGUI.FindProperty("_GlossyReflections", props, false);
      this.bumpScale = ShaderGUI.FindProperty("_BumpScale", props);
      this.bumpMap = ShaderGUI.FindProperty("_BumpMap", props);
      this.heigtMapScale = ShaderGUI.FindProperty("_Parallax", props);
      this.heightMap = ShaderGUI.FindProperty("_ParallaxMap", props);
      this.occlusionStrength = ShaderGUI.FindProperty("_OcclusionStrength", props);
      this.occlusionMap = ShaderGUI.FindProperty("_OcclusionMap", props);
      this.emissionColorForRendering = ShaderGUI.FindProperty("_EmissionColor", props);
      this.emissionMap = ShaderGUI.FindProperty("_EmissionMap", props);
      this.detailMask = ShaderGUI.FindProperty("_DetailMask", props);
      this.detailAlbedoMap = ShaderGUI.FindProperty("_DetailAlbedoMap", props);
      this.detailNormalMapScale = ShaderGUI.FindProperty("_DetailNormalMapScale", props);
      this.detailNormalMap = ShaderGUI.FindProperty("_DetailNormalMap", props);
      this.uvSetSecondary = ShaderGUI.FindProperty("_UVSec", props);
    }

    public override void OnGUI(MaterialEditor materialEditor, MaterialProperty[] props)
    {
      this.FindProperties(props);
      this.m_MaterialEditor = materialEditor;
      Material target = materialEditor.target as Material;
      if (this.m_FirstTimeApply)
      {
        StandardRoughnessShaderGUI.MaterialChanged(target);
        this.m_FirstTimeApply = false;
      }
      this.ShaderPropertiesGUI(target);
    }

    public void ShaderPropertiesGUI(Material material)
    {
      EditorGUIUtility.labelWidth = 0.0f;
      EditorGUI.BeginChangeCheck();
      this.BlendModePopup();
      GUILayout.Label(StandardRoughnessShaderGUI.Styles.primaryMapsText, EditorStyles.boldLabel, new GUILayoutOption[0]);
      this.DoAlbedoArea(material);
      this.m_MaterialEditor.TexturePropertySingleLine(StandardRoughnessShaderGUI.Styles.metallicMapText, this.metallicMap, !((UnityEngine.Object) this.metallicMap.textureValue != (UnityEngine.Object) null) ? this.metallic : (MaterialProperty) null);
      this.m_MaterialEditor.TexturePropertySingleLine(StandardRoughnessShaderGUI.Styles.roughnessText, this.roughnessMap, !((UnityEngine.Object) this.roughnessMap.textureValue != (UnityEngine.Object) null) ? this.roughness : (MaterialProperty) null);
      this.m_MaterialEditor.TexturePropertySingleLine(StandardRoughnessShaderGUI.Styles.normalMapText, this.bumpMap, !((UnityEngine.Object) this.bumpMap.textureValue != (UnityEngine.Object) null) ? (MaterialProperty) null : this.bumpScale);
      this.m_MaterialEditor.TexturePropertySingleLine(StandardRoughnessShaderGUI.Styles.heightMapText, this.heightMap, !((UnityEngine.Object) this.heightMap.textureValue != (UnityEngine.Object) null) ? (MaterialProperty) null : this.heigtMapScale);
      this.m_MaterialEditor.TexturePropertySingleLine(StandardRoughnessShaderGUI.Styles.occlusionText, this.occlusionMap, !((UnityEngine.Object) this.occlusionMap.textureValue != (UnityEngine.Object) null) ? (MaterialProperty) null : this.occlusionStrength);
      this.m_MaterialEditor.TexturePropertySingleLine(StandardRoughnessShaderGUI.Styles.detailMaskText, this.detailMask);
      this.DoEmissionArea(material);
      EditorGUI.BeginChangeCheck();
      this.m_MaterialEditor.TextureScaleOffsetProperty(this.albedoMap);
      if (EditorGUI.EndChangeCheck())
        this.emissionMap.textureScaleAndOffset = this.albedoMap.textureScaleAndOffset;
      EditorGUILayout.Space();
      GUILayout.Label(StandardRoughnessShaderGUI.Styles.secondaryMapsText, EditorStyles.boldLabel, new GUILayoutOption[0]);
      this.m_MaterialEditor.TexturePropertySingleLine(StandardRoughnessShaderGUI.Styles.detailAlbedoText, this.detailAlbedoMap);
      this.m_MaterialEditor.TexturePropertySingleLine(StandardRoughnessShaderGUI.Styles.detailNormalMapText, this.detailNormalMap, this.detailNormalMapScale);
      this.m_MaterialEditor.TextureScaleOffsetProperty(this.detailAlbedoMap);
      this.m_MaterialEditor.ShaderProperty(this.uvSetSecondary, StandardRoughnessShaderGUI.Styles.uvSetLabel.text);
      GUILayout.Label(StandardRoughnessShaderGUI.Styles.forwardText, EditorStyles.boldLabel, new GUILayoutOption[0]);
      if (this.highlights != null)
        this.m_MaterialEditor.ShaderProperty(this.highlights, StandardRoughnessShaderGUI.Styles.highlightsText);
      if (this.reflections != null)
        this.m_MaterialEditor.ShaderProperty(this.reflections, StandardRoughnessShaderGUI.Styles.reflectionsText);
      if (EditorGUI.EndChangeCheck())
      {
        foreach (Material target in this.blendMode.targets)
          StandardRoughnessShaderGUI.MaterialChanged(target);
      }
      EditorGUILayout.Space();
      GUILayout.Label(StandardRoughnessShaderGUI.Styles.advancedText, EditorStyles.boldLabel, new GUILayoutOption[0]);
      this.m_MaterialEditor.EnableInstancingField();
    }

    public override void AssignNewShaderToMaterial(Material material, Shader oldShader, Shader newShader)
    {
      if (material.HasProperty("_Emission"))
        material.SetColor("_EmissionColor", material.GetColor("_Emission"));
      base.AssignNewShaderToMaterial(material, oldShader, newShader);
      if ((UnityEngine.Object) oldShader == (UnityEngine.Object) null || !oldShader.name.Contains("Legacy Shaders/"))
      {
        StandardRoughnessShaderGUI.SetupMaterialWithBlendMode(material, (StandardRoughnessShaderGUI.BlendMode) material.GetFloat("_Mode"));
      }
      else
      {
        StandardRoughnessShaderGUI.BlendMode blendMode = StandardRoughnessShaderGUI.BlendMode.Opaque;
        if (oldShader.name.Contains("/Transparent/Cutout/"))
          blendMode = StandardRoughnessShaderGUI.BlendMode.Cutout;
        else if (oldShader.name.Contains("/Transparent/"))
          blendMode = StandardRoughnessShaderGUI.BlendMode.Fade;
        material.SetFloat("_Mode", (float) blendMode);
        StandardRoughnessShaderGUI.MaterialChanged(material);
      }
    }

    private void BlendModePopup()
    {
      EditorGUI.showMixedValue = this.blendMode.hasMixedValue;
      StandardRoughnessShaderGUI.BlendMode floatValue = (StandardRoughnessShaderGUI.BlendMode) this.blendMode.floatValue;
      EditorGUI.BeginChangeCheck();
      StandardRoughnessShaderGUI.BlendMode blendMode = (StandardRoughnessShaderGUI.BlendMode) EditorGUILayout.Popup(StandardRoughnessShaderGUI.Styles.renderingMode, (int) floatValue, StandardRoughnessShaderGUI.Styles.blendNames, new GUILayoutOption[0]);
      if (EditorGUI.EndChangeCheck())
      {
        this.m_MaterialEditor.RegisterPropertyChangeUndo("Rendering Mode");
        this.blendMode.floatValue = (float) blendMode;
      }
      EditorGUI.showMixedValue = false;
    }

    private void DoAlbedoArea(Material material)
    {
      this.m_MaterialEditor.TexturePropertySingleLine(StandardRoughnessShaderGUI.Styles.albedoText, this.albedoMap, this.albedoColor);
      if ((int) material.GetFloat("_Mode") != 1)
        return;
      this.m_MaterialEditor.ShaderProperty(this.alphaCutoff, StandardRoughnessShaderGUI.Styles.alphaCutoffText.text, 3);
    }

    private void DoEmissionArea(Material material)
    {
      if (!this.m_MaterialEditor.EmissionEnabledProperty())
        return;
      bool flag = (UnityEngine.Object) this.emissionMap.textureValue != (UnityEngine.Object) null;
      this.m_MaterialEditor.TexturePropertyWithHDRColor(StandardRoughnessShaderGUI.Styles.emissionText, this.emissionMap, this.emissionColorForRendering, this.m_ColorPickerHDRConfig, false);
      float maxColorComponent = this.emissionColorForRendering.colorValue.maxColorComponent;
      if ((UnityEngine.Object) this.emissionMap.textureValue != (UnityEngine.Object) null && !flag && (double) maxColorComponent <= 0.0)
        this.emissionColorForRendering.colorValue = Color.white;
      this.m_MaterialEditor.LightmapEmissionFlagsProperty(2, true);
    }

    public static void SetupMaterialWithBlendMode(Material material, StandardRoughnessShaderGUI.BlendMode blendMode)
    {
      switch (blendMode)
      {
        case StandardRoughnessShaderGUI.BlendMode.Opaque:
          material.SetOverrideTag("RenderType", "");
          material.SetInt("_SrcBlend", 1);
          material.SetInt("_DstBlend", 0);
          material.SetInt("_ZWrite", 1);
          material.DisableKeyword("_ALPHATEST_ON");
          material.DisableKeyword("_ALPHABLEND_ON");
          material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
          material.renderQueue = -1;
          break;
        case StandardRoughnessShaderGUI.BlendMode.Cutout:
          material.SetOverrideTag("RenderType", "TransparentCutout");
          material.SetInt("_SrcBlend", 1);
          material.SetInt("_DstBlend", 0);
          material.SetInt("_ZWrite", 1);
          material.EnableKeyword("_ALPHATEST_ON");
          material.DisableKeyword("_ALPHABLEND_ON");
          material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
          material.renderQueue = 2450;
          break;
        case StandardRoughnessShaderGUI.BlendMode.Fade:
          material.SetOverrideTag("RenderType", "Transparent");
          material.SetInt("_SrcBlend", 5);
          material.SetInt("_DstBlend", 10);
          material.SetInt("_ZWrite", 0);
          material.DisableKeyword("_ALPHATEST_ON");
          material.EnableKeyword("_ALPHABLEND_ON");
          material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
          material.renderQueue = 3000;
          break;
        case StandardRoughnessShaderGUI.BlendMode.Transparent:
          material.SetOverrideTag("RenderType", "Transparent");
          material.SetInt("_SrcBlend", 1);
          material.SetInt("_DstBlend", 10);
          material.SetInt("_ZWrite", 0);
          material.DisableKeyword("_ALPHATEST_ON");
          material.DisableKeyword("_ALPHABLEND_ON");
          material.EnableKeyword("_ALPHAPREMULTIPLY_ON");
          material.renderQueue = 3000;
          break;
      }
    }

    private static void SetMaterialKeywords(Material material)
    {
      StandardRoughnessShaderGUI.SetKeyword(material, "_NORMALMAP", (bool) ((UnityEngine.Object) material.GetTexture("_BumpMap")) || (bool) ((UnityEngine.Object) material.GetTexture("_DetailNormalMap")));
      StandardRoughnessShaderGUI.SetKeyword(material, "_SPECGLOSSMAP", (bool) ((UnityEngine.Object) material.GetTexture("_SpecGlossMap")));
      StandardRoughnessShaderGUI.SetKeyword(material, "_METALLICGLOSSMAP", (bool) ((UnityEngine.Object) material.GetTexture("_MetallicGlossMap")));
      StandardRoughnessShaderGUI.SetKeyword(material, "_PARALLAXMAP", (bool) ((UnityEngine.Object) material.GetTexture("_ParallaxMap")));
      StandardRoughnessShaderGUI.SetKeyword(material, "_DETAIL_MULX2", (bool) ((UnityEngine.Object) material.GetTexture("_DetailAlbedoMap")) || (bool) ((UnityEngine.Object) material.GetTexture("_DetailNormalMap")));
      MaterialEditor.FixupEmissiveFlag(material);
      bool state = (material.globalIlluminationFlags & MaterialGlobalIlluminationFlags.EmissiveIsBlack) == MaterialGlobalIlluminationFlags.None;
      StandardRoughnessShaderGUI.SetKeyword(material, "_EMISSION", state);
    }

    private static void MaterialChanged(Material material)
    {
      StandardRoughnessShaderGUI.SetupMaterialWithBlendMode(material, (StandardRoughnessShaderGUI.BlendMode) material.GetFloat("_Mode"));
      StandardRoughnessShaderGUI.SetMaterialKeywords(material);
    }

    private static void SetKeyword(Material m, string keyword, bool state)
    {
      if (state)
        m.EnableKeyword(keyword);
      else
        m.DisableKeyword(keyword);
    }

    public enum BlendMode
    {
      Opaque,
      Cutout,
      Fade,
      Transparent,
    }

    private static class Styles
    {
      public static GUIContent uvSetLabel = new GUIContent("UV Set");
      public static GUIContent albedoText = new GUIContent("Albedo", "Albedo (RGB) and Transparency (A)");
      public static GUIContent alphaCutoffText = new GUIContent("Alpha Cutoff", "Threshold for alpha cutoff");
      public static GUIContent metallicMapText = new GUIContent("Metallic", "Metallic (R) and Smoothness (A)");
      public static GUIContent roughnessText = new GUIContent("Roughness", "Roughness value");
      public static GUIContent highlightsText = new GUIContent("Specular Highlights", "Specular Highlights");
      public static GUIContent reflectionsText = new GUIContent("Reflections", "Glossy Reflections");
      public static GUIContent normalMapText = new GUIContent("Normal Map", "Normal Map");
      public static GUIContent heightMapText = new GUIContent("Height Map", "Height Map (G)");
      public static GUIContent occlusionText = new GUIContent("Occlusion", "Occlusion (G)");
      public static GUIContent emissionText = new GUIContent("Color", "Emission (RGB)");
      public static GUIContent detailMaskText = new GUIContent("Detail Mask", "Mask for Secondary Maps (A)");
      public static GUIContent detailAlbedoText = new GUIContent("Detail Albedo x2", "Albedo (RGB) multiplied by 2");
      public static GUIContent detailNormalMapText = new GUIContent("Normal Map", "Normal Map");
      public static string primaryMapsText = "Main Maps";
      public static string secondaryMapsText = "Secondary Maps";
      public static string forwardText = "Forward Rendering Options";
      public static string renderingMode = "Rendering Mode";
      public static string advancedText = "Advanced Options";
      public static readonly string[] blendNames = Enum.GetNames(typeof (StandardRoughnessShaderGUI.BlendMode));
    }
  }
}
