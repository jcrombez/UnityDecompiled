﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.CurveRenderer
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

using UnityEngine;

namespace UnityEditor
{
  internal interface CurveRenderer
  {
    void DrawCurve(float minTime, float maxTime, Color color, Matrix4x4 transform, Color wrapColor);

    AnimationCurve GetCurve();

    float RangeStart();

    float RangeEnd();

    void SetWrap(WrapMode wrap);

    void SetWrap(WrapMode preWrap, WrapMode postWrap);

    void SetCustomRange(float start, float end);

    float EvaluateCurveSlow(float time);

    float EvaluateCurveDeltaSlow(float time);

    Bounds GetBounds();

    Bounds GetBounds(float minTime, float maxTime);

    float ClampedValue(float value);

    void FlushCache();
  }
}
