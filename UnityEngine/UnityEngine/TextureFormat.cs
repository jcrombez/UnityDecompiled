﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.TextureFormat
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;
using System.ComponentModel;

namespace UnityEngine
{
  public enum TextureFormat
  {
    [EditorBrowsable(EditorBrowsableState.Never), Obsolete("Enum member TextureFormat.PVRTC_2BPP_RGB has been deprecated. Use PVRTC_RGB2 instead (UnityUpgradable) -> PVRTC_RGB2", true)] PVRTC_2BPP_RGB = -127, // -0x0000007F
    [EditorBrowsable(EditorBrowsableState.Never), Obsolete("Enum member TextureFormat.PVRTC_2BPP_RGBA has been deprecated. Use PVRTC_RGBA2 instead (UnityUpgradable) -> PVRTC_RGBA2", true)] PVRTC_2BPP_RGBA = -127, // -0x0000007F
    [EditorBrowsable(EditorBrowsableState.Never), Obsolete("Enum member TextureFormat.PVRTC_4BPP_RGB has been deprecated. Use PVRTC_RGB4 instead (UnityUpgradable) -> PVRTC_RGB4", true)] PVRTC_4BPP_RGB = -127, // -0x0000007F
    [EditorBrowsable(EditorBrowsableState.Never), Obsolete("Enum member TextureFormat.PVRTC_4BPP_RGBA has been deprecated. Use PVRTC_RGBA4 instead (UnityUpgradable) -> PVRTC_RGBA4", true)] PVRTC_4BPP_RGBA = -127, // -0x0000007F
    Alpha8 = 1,
    ARGB4444 = 2,
    RGB24 = 3,
    RGBA32 = 4,
    ARGB32 = 5,
    RGB565 = 7,
    R16 = 9,
    DXT1 = 10, // 0x0000000A
    DXT5 = 12, // 0x0000000C
    RGBA4444 = 13, // 0x0000000D
    BGRA32 = 14, // 0x0000000E
    RHalf = 15, // 0x0000000F
    RGHalf = 16, // 0x00000010
    RGBAHalf = 17, // 0x00000011
    RFloat = 18, // 0x00000012
    RGFloat = 19, // 0x00000013
    RGBAFloat = 20, // 0x00000014
    YUY2 = 21, // 0x00000015
    RGB9e5Float = 22, // 0x00000016
    BC6H = 24, // 0x00000018
    BC7 = 25, // 0x00000019
    BC4 = 26, // 0x0000001A
    BC5 = 27, // 0x0000001B
    DXT1Crunched = 28, // 0x0000001C
    DXT5Crunched = 29, // 0x0000001D
    PVRTC_RGB2 = 30, // 0x0000001E
    PVRTC_RGBA2 = 31, // 0x0000001F
    PVRTC_RGB4 = 32, // 0x00000020
    PVRTC_RGBA4 = 33, // 0x00000021
    ETC_RGB4 = 34, // 0x00000022
    ATC_RGB4 = 35, // 0x00000023
    ATC_RGBA8 = 36, // 0x00000024
    EAC_R = 41, // 0x00000029
    EAC_R_SIGNED = 42, // 0x0000002A
    EAC_RG = 43, // 0x0000002B
    EAC_RG_SIGNED = 44, // 0x0000002C
    ETC2_RGB = 45, // 0x0000002D
    ETC2_RGBA1 = 46, // 0x0000002E
    ETC2_RGBA8 = 47, // 0x0000002F
    ASTC_RGB_4x4 = 48, // 0x00000030
    ASTC_RGB_5x5 = 49, // 0x00000031
    ASTC_RGB_6x6 = 50, // 0x00000032
    ASTC_RGB_8x8 = 51, // 0x00000033
    ASTC_RGB_10x10 = 52, // 0x00000034
    ASTC_RGB_12x12 = 53, // 0x00000035
    ASTC_RGBA_4x4 = 54, // 0x00000036
    ASTC_RGBA_5x5 = 55, // 0x00000037
    ASTC_RGBA_6x6 = 56, // 0x00000038
    ASTC_RGBA_8x8 = 57, // 0x00000039
    ASTC_RGBA_10x10 = 58, // 0x0000003A
    ASTC_RGBA_12x12 = 59, // 0x0000003B
    ETC_RGB4_3DS = 60, // 0x0000003C
    ETC_RGBA8_3DS = 61, // 0x0000003D
    RG16 = 62, // 0x0000003E
    R8 = 63, // 0x0000003F
    ETC_RGB4Crunched = 64, // 0x00000040
    ETC2_RGBA8Crunched = 65, // 0x00000041
  }
}
