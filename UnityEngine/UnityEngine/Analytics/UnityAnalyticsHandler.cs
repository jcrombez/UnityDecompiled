﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Analytics.UnityAnalyticsHandler
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Analytics
{
  [StructLayout(LayoutKind.Sequential)]
  internal sealed class UnityAnalyticsHandler : IDisposable
  {
    [NonSerialized]
    internal IntPtr m_Ptr;

    public UnityAnalyticsHandler()
    {
      this.InternalCreate();
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern void InternalCreate();

    [ThreadAndSerializationSafe]
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern void InternalDestroy();

    ~UnityAnalyticsHandler()
    {
      this.InternalDestroy();
    }

    public void Dispose()
    {
      this.InternalDestroy();
      GC.SuppressFinalize((object) this);
    }

    public static extern bool limitUserTracking { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    public static extern bool deviceStatsEnabled { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    public extern bool enabled { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern AnalyticsResult FlushEvents();

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern AnalyticsResult SetUserId(string userId);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern AnalyticsResult SetUserGender(Gender gender);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern AnalyticsResult SetUserBirthYear(int birthYear);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern AnalyticsResult Transaction(string productId, double amount, string currency);

    public AnalyticsResult Transaction(string productId, double amount, string currency, string receiptPurchaseData, string signature)
    {
      return this.Transaction(productId, amount, currency, receiptPurchaseData, signature, false);
    }

    internal AnalyticsResult Transaction(string productId, double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService)
    {
      if (receiptPurchaseData == null)
        receiptPurchaseData = string.Empty;
      if (signature == null)
        signature = string.Empty;
      return this.InternalTransaction(productId, amount, currency, receiptPurchaseData, signature, usingIAPService);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern AnalyticsResult InternalTransaction(string productId, double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService);

    public AnalyticsResult CustomEvent(string customEventName)
    {
      return this.SendCustomEventName(customEventName);
    }

    public AnalyticsResult CustomEvent(CustomEventData eventData)
    {
      return this.SendCustomEvent(eventData);
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern AnalyticsResult SendCustomEventName(string customEventName);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern AnalyticsResult SendCustomEvent(CustomEventData eventData);
  }
}
