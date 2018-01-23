﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.ParticlePhysicsExtensions
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;
using System.Collections.Generic;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Method extension for Physics in Particle System.</para>
  /// </summary>
  public static class ParticlePhysicsExtensions
  {
    /// <summary>
    ///   <para>Safe array size for use with ParticleSystem.GetCollisionEvents.</para>
    /// </summary>
    /// <param name="ps"></param>
    public static int GetSafeCollisionEventSize(this ParticleSystem ps)
    {
      return ParticleSystemExtensionsImpl.GetSafeCollisionEventSize(ps);
    }

    public static int GetCollisionEvents(this ParticleSystem ps, GameObject go, List<ParticleCollisionEvent> collisionEvents)
    {
      if ((Object) go == (Object) null)
        throw new ArgumentNullException(nameof (go));
      if (collisionEvents == null)
        throw new ArgumentNullException(nameof (collisionEvents));
      return ParticleSystemExtensionsImpl.GetCollisionEvents(ps, go, (object) collisionEvents);
    }

    /// <summary>
    ///   <para>Get the particle collision events for a GameObject. Returns the number of events written to the array.</para>
    /// </summary>
    /// <param name="go">The GameObject for which to retrieve collision events.</param>
    /// <param name="collisionEvents">Array to write collision events to.</param>
    /// <param name="ps"></param>
    [Obsolete("GetCollisionEvents function using ParticleCollisionEvent[] is deprecated. Use List<ParticleCollisionEvent> instead.", false)]
    public static int GetCollisionEvents(this ParticleSystem ps, GameObject go, ParticleCollisionEvent[] collisionEvents)
    {
      if ((Object) go == (Object) null)
        throw new ArgumentNullException(nameof (go));
      if (collisionEvents == null)
        throw new ArgumentNullException(nameof (collisionEvents));
      return ParticleSystemExtensionsImpl.GetCollisionEventsDeprecated(ps, go, collisionEvents);
    }

    /// <summary>
    ///   <para>Safe array size for use with ParticleSystem.GetTriggerParticles.</para>
    /// </summary>
    /// <param name="ps">Particle system.</param>
    /// <param name="type">Type of trigger to return size for.</param>
    /// <returns>
    ///   <para>Number of particles with this trigger event type.</para>
    /// </returns>
    public static int GetSafeTriggerParticlesSize(this ParticleSystem ps, ParticleSystemTriggerEventType type)
    {
      return ParticleSystemExtensionsImpl.GetSafeTriggerParticlesSize(ps, (int) type);
    }

    public static int GetTriggerParticles(this ParticleSystem ps, ParticleSystemTriggerEventType type, List<ParticleSystem.Particle> particles)
    {
      if (particles == null)
        throw new ArgumentNullException(nameof (particles));
      return ParticleSystemExtensionsImpl.GetTriggerParticles(ps, (int) type, (object) particles);
    }

    public static void SetTriggerParticles(this ParticleSystem ps, ParticleSystemTriggerEventType type, List<ParticleSystem.Particle> particles, int offset, int count)
    {
      if (particles == null)
        throw new ArgumentNullException(nameof (particles));
      if (offset >= particles.Count)
        throw new ArgumentOutOfRangeException(nameof (offset), "offset should be smaller than the size of the particles list.");
      if (offset + count >= particles.Count)
        throw new ArgumentOutOfRangeException(nameof (count), "offset+count should be smaller than the size of the particles list.");
      ParticleSystemExtensionsImpl.SetTriggerParticles(ps, (int) type, (object) particles, offset, count);
    }

    public static void SetTriggerParticles(this ParticleSystem ps, ParticleSystemTriggerEventType type, List<ParticleSystem.Particle> particles)
    {
      if (particles == null)
        throw new ArgumentNullException(nameof (particles));
      ParticleSystemExtensionsImpl.SetTriggerParticles(ps, (int) type, (object) particles, 0, particles.Count);
    }
  }
}
