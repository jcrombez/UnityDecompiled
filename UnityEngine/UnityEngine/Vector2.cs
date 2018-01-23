﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Vector2
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
  [UsedByNativeCode]
  public struct Vector2
  {
    private static readonly Vector2 zeroVector = new Vector2(0.0f, 0.0f);
    private static readonly Vector2 oneVector = new Vector2(1f, 1f);
    private static readonly Vector2 upVector = new Vector2(0.0f, 1f);
    private static readonly Vector2 downVector = new Vector2(0.0f, -1f);
    private static readonly Vector2 leftVector = new Vector2(-1f, 0.0f);
    private static readonly Vector2 rightVector = new Vector2(1f, 0.0f);
    private static readonly Vector2 positiveInfinityVector = new Vector2(float.PositiveInfinity, float.PositiveInfinity);
    private static readonly Vector2 negativeInfinityVector = new Vector2(float.NegativeInfinity, float.NegativeInfinity);
    public float x;
    public float y;
    public const float kEpsilon = 1E-05f;

    public Vector2(float x, float y)
    {
      this.x = x;
      this.y = y;
    }

    public float this[int index]
    {
      get
      {
        if (index == 0)
          return this.x;
        if (index == 1)
          return this.y;
        throw new IndexOutOfRangeException("Invalid Vector2 index!");
      }
      set
      {
        if (index != 0)
        {
          if (index != 1)
            throw new IndexOutOfRangeException("Invalid Vector2 index!");
          this.y = value;
        }
        else
          this.x = value;
      }
    }

    public void Set(float newX, float newY)
    {
      this.x = newX;
      this.y = newY;
    }

    public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
    {
      t = Mathf.Clamp01(t);
      return new Vector2(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t);
    }

    public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t)
    {
      return new Vector2(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t);
    }

    public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta)
    {
      Vector2 vector2 = target - current;
      float magnitude = vector2.magnitude;
      if ((double) magnitude <= (double) maxDistanceDelta || (double) magnitude == 0.0)
        return target;
      return current + vector2 / magnitude * maxDistanceDelta;
    }

    public static Vector2 Scale(Vector2 a, Vector2 b)
    {
      return new Vector2(a.x * b.x, a.y * b.y);
    }

    public void Scale(Vector2 scale)
    {
      this.x *= scale.x;
      this.y *= scale.y;
    }

    public void Normalize()
    {
      float magnitude = this.magnitude;
      if ((double) magnitude > 9.99999974737875E-06)
        this = this / magnitude;
      else
        this = Vector2.zero;
    }

    public Vector2 normalized
    {
      get
      {
        Vector2 vector2 = new Vector2(this.x, this.y);
        vector2.Normalize();
        return vector2;
      }
    }

    public override string ToString()
    {
      return UnityString.Format("({0:F1}, {1:F1})", (object) this.x, (object) this.y);
    }

    public string ToString(string format)
    {
      return UnityString.Format("({0}, {1})", (object) this.x.ToString(format), (object) this.y.ToString(format));
    }

    public override int GetHashCode()
    {
      return this.x.GetHashCode() ^ this.y.GetHashCode() << 2;
    }

    public override bool Equals(object other)
    {
      if (!(other is Vector2))
        return false;
      Vector2 vector2 = (Vector2) other;
      return this.x.Equals(vector2.x) && this.y.Equals(vector2.y);
    }

    public static Vector2 Reflect(Vector2 inDirection, Vector2 inNormal)
    {
      return -2f * Vector2.Dot(inNormal, inDirection) * inNormal + inDirection;
    }

    public static float Dot(Vector2 lhs, Vector2 rhs)
    {
      return (float) ((double) lhs.x * (double) rhs.x + (double) lhs.y * (double) rhs.y);
    }

    public float magnitude
    {
      get
      {
        return Mathf.Sqrt((float) ((double) this.x * (double) this.x + (double) this.y * (double) this.y));
      }
    }

    public float sqrMagnitude
    {
      get
      {
        return (float) ((double) this.x * (double) this.x + (double) this.y * (double) this.y);
      }
    }

    public static float Angle(Vector2 from, Vector2 to)
    {
      return Mathf.Acos(Mathf.Clamp(Vector2.Dot(from.normalized, to.normalized), -1f, 1f)) * 57.29578f;
    }

    public static float SignedAngle(Vector2 from, Vector2 to)
    {
      Vector2 normalized1 = from.normalized;
      Vector2 normalized2 = to.normalized;
      return Mathf.Acos(Mathf.Clamp(Vector2.Dot(normalized1, normalized2), -1f, 1f)) * 57.29578f * Mathf.Sign((float) ((double) normalized1.x * (double) normalized2.y - (double) normalized1.y * (double) normalized2.x));
    }

    public static float Distance(Vector2 a, Vector2 b)
    {
      return (a - b).magnitude;
    }

    public static Vector2 ClampMagnitude(Vector2 vector, float maxLength)
    {
      if ((double) vector.sqrMagnitude > (double) maxLength * (double) maxLength)
        return vector.normalized * maxLength;
      return vector;
    }

    public static float SqrMagnitude(Vector2 a)
    {
      return (float) ((double) a.x * (double) a.x + (double) a.y * (double) a.y);
    }

    public float SqrMagnitude()
    {
      return (float) ((double) this.x * (double) this.x + (double) this.y * (double) this.y);
    }

    public static Vector2 Min(Vector2 lhs, Vector2 rhs)
    {
      return new Vector2(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y));
    }

    public static Vector2 Max(Vector2 lhs, Vector2 rhs)
    {
      return new Vector2(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y));
    }

    public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
    {
      smoothTime = Mathf.Max(0.0001f, smoothTime);
      float num1 = 2f / smoothTime;
      float num2 = num1 * deltaTime;
      float num3 = (float) (1.0 / (1.0 + (double) num2 + 0.479999989271164 * (double) num2 * (double) num2 + 0.234999999403954 * (double) num2 * (double) num2 * (double) num2));
      Vector2 vector = current - target;
      Vector2 vector2_1 = target;
      float maxLength = maxSpeed * smoothTime;
      Vector2 vector2_2 = Vector2.ClampMagnitude(vector, maxLength);
      target = current - vector2_2;
      Vector2 vector2_3 = (currentVelocity + num1 * vector2_2) * deltaTime;
      currentVelocity = (currentVelocity - num1 * vector2_3) * num3;
      Vector2 vector2_4 = target + (vector2_2 + vector2_3) * num3;
      if ((double) Vector2.Dot(vector2_1 - current, vector2_4 - vector2_1) > 0.0)
      {
        vector2_4 = vector2_1;
        currentVelocity = (vector2_4 - vector2_1) / deltaTime;
      }
      return vector2_4;
    }

    public static Vector2 operator +(Vector2 a, Vector2 b)
    {
      return new Vector2(a.x + b.x, a.y + b.y);
    }

    public static Vector2 operator -(Vector2 a, Vector2 b)
    {
      return new Vector2(a.x - b.x, a.y - b.y);
    }

    public static Vector2 operator -(Vector2 a)
    {
      return new Vector2(-a.x, -a.y);
    }

    public static Vector2 operator *(Vector2 a, float d)
    {
      return new Vector2(a.x * d, a.y * d);
    }

    public static Vector2 operator *(float d, Vector2 a)
    {
      return new Vector2(a.x * d, a.y * d);
    }

    public static Vector2 operator /(Vector2 a, float d)
    {
      return new Vector2(a.x / d, a.y / d);
    }

    public static bool operator ==(Vector2 lhs, Vector2 rhs)
    {
      return (double) (lhs - rhs).sqrMagnitude < 9.99999943962493E-11;
    }

    public static bool operator !=(Vector2 lhs, Vector2 rhs)
    {
      return !(lhs == rhs);
    }

    public static implicit operator Vector2(Vector3 v)
    {
      return new Vector2(v.x, v.y);
    }

    public static implicit operator Vector3(Vector2 v)
    {
      return new Vector3(v.x, v.y, 0.0f);
    }

    public static Vector2 zero
    {
      get
      {
        return Vector2.zeroVector;
      }
    }

    public static Vector2 one
    {
      get
      {
        return Vector2.oneVector;
      }
    }

    public static Vector2 up
    {
      get
      {
        return Vector2.upVector;
      }
    }

    public static Vector2 down
    {
      get
      {
        return Vector2.downVector;
      }
    }

    public static Vector2 left
    {
      get
      {
        return Vector2.leftVector;
      }
    }

    public static Vector2 right
    {
      get
      {
        return Vector2.rightVector;
      }
    }

    public static Vector2 positiveInfinity
    {
      get
      {
        return Vector2.positiveInfinityVector;
      }
    }

    public static Vector2 negativeInfinity
    {
      get
      {
        return Vector2.negativeInfinityVector;
      }
    }
  }
}
