﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.U2D.Interface.ITexturePlatformSettingsController
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

using System.Collections.Generic;

namespace UnityEditor.U2D.Interface
{
  internal interface ITexturePlatformSettingsController
  {
    bool HandleDefaultSettings(List<TextureImporterPlatformSettings> platformSettings, ITexturePlatformSettingsView view);

    bool HandlePlatformSettings(BuildTarget buildTarget, List<TextureImporterPlatformSettings> platformSettings, ITexturePlatformSettingsView view, ITexturePlatformSettingsFormatHelper formatHelper);
  }
}
