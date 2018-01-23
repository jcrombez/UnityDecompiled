﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.MathUtils
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

using System;
using UnityEngine;

namespace UnityEditor
{
  public class MathUtils
  {
    private const int kMaxDecimals = 15;

    internal static float ClampToFloat(double value)
    {
      if (double.IsPositiveInfinity(value))
        return float.PositiveInfinity;
      if (double.IsNegativeInfinity(value))
        return float.NegativeInfinity;
      if (value < -3.40282346638529E+38)
        return float.MinValue;
      if (value > 3.40282346638529E+38)
        return float.MaxValue;
      return (float) value;
    }

    internal static int ClampToInt(long value)
    {
      if (value < (long) int.MinValue)
        return int.MinValue;
      if (value > (long) int.MaxValue)
        return int.MaxValue;
      return (int) value;
    }

    internal static float RoundToMultipleOf(float value, float roundingValue)
    {
      if ((double) roundingValue == 0.0)
        return value;
      return Mathf.Round(value / roundingValue) * roundingValue;
    }

    internal static float GetClosestPowerOfTen(float positiveNumber)
    {
      if ((double) positiveNumber <= 0.0)
        return 1f;
      return Mathf.Pow(10f, (float) Mathf.RoundToInt(Mathf.Log10(positiveNumber)));
    }

    internal static int GetNumberOfDecimalsForMinimumDifference(float minDifference)
    {
      return Mathf.Clamp(-Mathf.FloorToInt(Mathf.Log10(Mathf.Abs(minDifference))), 0, 15);
    }

    internal static int GetNumberOfDecimalsForMinimumDifference(double minDifference)
    {
      return (int) Math.Max(0.0, -Math.Floor(Math.Log10(Math.Abs(minDifference))));
    }

    internal static float RoundBasedOnMinimumDifference(float valueToRound, float minDifference)
    {
      if ((double) minDifference == 0.0)
        return MathUtils.DiscardLeastSignificantDecimal(valueToRound);
      return (float) Math.Round((double) valueToRound, MathUtils.GetNumberOfDecimalsForMinimumDifference(minDifference), MidpointRounding.AwayFromZero);
    }

    internal static double RoundBasedOnMinimumDifference(double valueToRound, double minDifference)
    {
      if (minDifference == 0.0)
        return MathUtils.DiscardLeastSignificantDecimal(valueToRound);
      return Math.Round(valueToRound, MathUtils.GetNumberOfDecimalsForMinimumDifference(minDifference), MidpointRounding.AwayFromZero);
    }

    internal static float DiscardLeastSignificantDecimal(float v)
    {
      int digits = Mathf.Clamp((int) (5.0 - (double) Mathf.Log10(Mathf.Abs(v))), 0, 15);
      return (float) Math.Round((double) v, digits, MidpointRounding.AwayFromZero);
    }

    internal static double DiscardLeastSignificantDecimal(double v)
    {
      int digits = Math.Max(0, (int) (5.0 - Math.Log10(Math.Abs(v))));
      try
      {
        return Math.Round(v, digits);
      }
      catch (ArgumentOutOfRangeException ex)
      {
        return 0.0;
      }
    }

    public static float GetQuatLength(Quaternion q)
    {
      return Mathf.Sqrt((float) ((double) q.x * (double) q.x + (double) q.y * (double) q.y + (double) q.z * (double) q.z + (double) q.w * (double) q.w));
    }

    public static Quaternion GetQuatConjugate(Quaternion q)
    {
      return new Quaternion(-q.x, -q.y, -q.z, q.w);
    }

    public static Matrix4x4 OrthogonalizeMatrix(Matrix4x4 m)
    {
      Matrix4x4 identity = Matrix4x4.identity;
      Vector3 column1 = (Vector3) m.GetColumn(0);
      Vector3 column2 = (Vector3) m.GetColumn(1);
      Vector3 vector3 = (Vector3) m.GetColumn(2);
      vector3 = vector3.normalized;
      Vector3 normalized1 = Vector3.Cross(column2, vector3).normalized;
      Vector3 normalized2 = Vector3.Cross(vector3, normalized1).normalized;
      identity.SetColumn(0, (Vector4) normalized1);
      identity.SetColumn(1, (Vector4) normalized2);
      identity.SetColumn(2, (Vector4) vector3);
      return identity;
    }

    public static void QuaternionNormalize(ref Quaternion q)
    {
      float num = 1f / Mathf.Sqrt((float) ((double) q.x * (double) q.x + (double) q.y * (double) q.y + (double) q.z * (double) q.z + (double) q.w * (double) q.w));
      q.x *= num;
      q.y *= num;
      q.z *= num;
      q.w *= num;
    }

    public static Quaternion QuaternionFromMatrix(Matrix4x4 m)
    {
      Quaternion q = new Quaternion();
      q.w = Mathf.Sqrt(Mathf.Max(0.0f, 1f + m[0, 0] + m[1, 1] + m[2, 2])) / 2f;
      q.x = Mathf.Sqrt(Mathf.Max(0.0f, 1f + m[0, 0] - m[1, 1] - m[2, 2])) / 2f;
      q.y = Mathf.Sqrt(Mathf.Max(0.0f, 1f - m[0, 0] + m[1, 1] - m[2, 2])) / 2f;
      q.z = Mathf.Sqrt(Mathf.Max(0.0f, 1f - m[0, 0] - m[1, 1] + m[2, 2])) / 2f;
      q.x *= Mathf.Sign(q.x * (m[2, 1] - m[1, 2]));
      q.y *= Mathf.Sign(q.y * (m[0, 2] - m[2, 0]));
      q.z *= Mathf.Sign(q.z * (m[1, 0] - m[0, 1]));
      MathUtils.QuaternionNormalize(ref q);
      return q;
    }

    public static Quaternion GetQuatLog(Quaternion q)
    {
      Quaternion quaternion = q;
      quaternion.w = 0.0f;
      if ((double) Mathf.Abs(q.w) < 1.0)
      {
        float f1 = Mathf.Acos(q.w);
        float f2 = Mathf.Sin(f1);
        if ((double) Mathf.Abs(f2) > 0.0001)
        {
          float num = f1 / f2;
          quaternion.x = q.x * num;
          quaternion.y = q.y * num;
          quaternion.z = q.z * num;
        }
      }
      return quaternion;
    }

    public static Quaternion GetQuatExp(Quaternion q)
    {
      Quaternion quaternion = q;
      float f1 = Mathf.Sqrt((float) ((double) q.x * (double) q.x + (double) q.y * (double) q.y + (double) q.z * (double) q.z));
      float f2 = Mathf.Sin(f1);
      quaternion.w = Mathf.Cos(f1);
      if ((double) Mathf.Abs(f2) > 0.0001)
      {
        float num = f2 / f1;
        quaternion.x = num * q.x;
        quaternion.y = num * q.y;
        quaternion.z = num * q.z;
      }
      return quaternion;
    }

    public static Quaternion GetQuatSquad(float t, Quaternion q0, Quaternion q1, Quaternion a0, Quaternion a1)
    {
      float t1 = (float) (2.0 * (double) t * (1.0 - (double) t));
      Quaternion quaternion = MathUtils.Slerp(MathUtils.Slerp(q0, q1, t), MathUtils.Slerp(a0, a1, t), t1);
      float num = Mathf.Sqrt((float) ((double) quaternion.x * (double) quaternion.x + (double) quaternion.y * (double) quaternion.y + (double) quaternion.z * (double) quaternion.z + (double) quaternion.w * (double) quaternion.w));
      quaternion.x /= num;
      quaternion.y /= num;
      quaternion.z /= num;
      quaternion.w /= num;
      return quaternion;
    }

    public static Quaternion GetSquadIntermediate(Quaternion q0, Quaternion q1, Quaternion q2)
    {
      Quaternion quatConjugate = MathUtils.GetQuatConjugate(q1);
      Quaternion quatLog1 = MathUtils.GetQuatLog(quatConjugate * q0);
      Quaternion quatLog2 = MathUtils.GetQuatLog(quatConjugate * q2);
      Quaternion q = new Quaternion((float) (-0.25 * ((double) quatLog1.x + (double) quatLog2.x)), (float) (-0.25 * ((double) quatLog1.y + (double) quatLog2.y)), (float) (-0.25 * ((double) quatLog1.z + (double) quatLog2.z)), (float) (-0.25 * ((double) quatLog1.w + (double) quatLog2.w)));
      return q1 * MathUtils.GetQuatExp(q);
    }

    public static float Ease(float t, float k1, float k2)
    {
      float num = (float) ((double) k1 * 2.0 / 3.14159274101257 + (double) k2 - (double) k1 + (1.0 - (double) k2) * 2.0 / 3.14159274101257);
      return ((double) t >= (double) k1 ? ((double) t >= (double) k2 ? (float) (2.0 * (double) k1 / 3.14159274101257 + (double) k2 - (double) k1 + (1.0 - (double) k2) * 0.636619746685028 * (double) Mathf.Sin((float) (((double) t - (double) k2) / (1.0 - (double) k2) * 3.14159274101257 / 2.0))) : (float) (2.0 * (double) k1 / 3.14159274101257) + t - k1) : (float) ((double) k1 * 0.636619746685028 * ((double) Mathf.Sin((float) ((double) t / (double) k1 * 3.14159274101257 / 2.0 - 1.57079637050629)) + 1.0))) / num;
    }

    public static Quaternion Slerp(Quaternion p, Quaternion q, float t)
    {
      float f1 = Quaternion.Dot(p, q);
      Quaternion quaternion;
      if (1.0 + (double) f1 > 1E-05)
      {
        float num1;
        float num2;
        if (1.0 - (double) f1 > 1E-05)
        {
          float f2 = Mathf.Acos(f1);
          float num3 = 1f / Mathf.Sin(f2);
          num1 = Mathf.Sin((1f - t) * f2) * num3;
          num2 = Mathf.Sin(t * f2) * num3;
        }
        else
        {
          num1 = 1f - t;
          num2 = t;
        }
        quaternion.x = (float) ((double) num1 * (double) p.x + (double) num2 * (double) q.x);
        quaternion.y = (float) ((double) num1 * (double) p.y + (double) num2 * (double) q.y);
        quaternion.z = (float) ((double) num1 * (double) p.z + (double) num2 * (double) q.z);
        quaternion.w = (float) ((double) num1 * (double) p.w + (double) num2 * (double) q.w);
      }
      else
      {
        float num1 = Mathf.Sin((float) ((1.0 - (double) t) * 3.14159274101257 * 0.5));
        float num2 = Mathf.Sin((float) ((double) t * 3.14159274101257 * 0.5));
        quaternion.x = (float) ((double) num1 * (double) p.x - (double) num2 * (double) p.y);
        quaternion.y = (float) ((double) num1 * (double) p.y + (double) num2 * (double) p.x);
        quaternion.z = (float) ((double) num1 * (double) p.z - (double) num2 * (double) p.w);
        quaternion.w = p.z;
      }
      return quaternion;
    }

    public static object IntersectRayTriangle(Ray ray, Vector3 v0, Vector3 v1, Vector3 v2, bool bidirectional)
    {
      Vector3 lhs = v1 - v0;
      Vector3 vector3_1 = v2 - v0;
      Vector3 rhs1 = Vector3.Cross(lhs, vector3_1);
      float num1 = Vector3.Dot(-ray.direction, rhs1);
      if ((double) num1 <= 0.0)
        return (object) null;
      Vector3 vector3_2 = ray.origin - v0;
      float num2 = Vector3.Dot(vector3_2, rhs1);
      if ((double) num2 < 0.0 && !bidirectional)
        return (object) null;
      Vector3 rhs2 = Vector3.Cross(-ray.direction, vector3_2);
      float num3 = Vector3.Dot(vector3_1, rhs2);
      if ((double) num3 < 0.0 || (double) num3 > (double) num1)
        return (object) null;
      float num4 = -Vector3.Dot(lhs, rhs2);
      if ((double) num4 < 0.0 || (double) num3 + (double) num4 > (double) num1)
        return (object) null;
      float num5 = 1f / num1;
      float num6 = num2 * num5;
      float y = num3 * num5;
      float z = num4 * num5;
      float x = 1f - y - z;
      return (object) new RaycastHit() { point = (ray.origin + num6 * ray.direction), distance = num6, barycentricCoordinate = new Vector3(x, y, z), normal = Vector3.Normalize(rhs1) };
    }

    public static Vector3 ClosestPtSegmentRay(Vector3 p1, Vector3 q1, Ray ray, out float squaredDist, out float s, out Vector3 closestRay)
    {
      Vector3 origin = ray.origin;
      Vector3 point = ray.GetPoint(10000f);
      Vector3 vector3_1 = q1 - p1;
      Vector3 vector3_2 = point - origin;
      Vector3 rhs = p1 - origin;
      float num1 = Vector3.Dot(vector3_1, vector3_1);
      float num2 = Vector3.Dot(vector3_2, vector3_2);
      float num3 = Vector3.Dot(vector3_2, rhs);
      if ((double) num1 <= (double) Mathf.Epsilon && (double) num2 <= (double) Mathf.Epsilon)
      {
        squaredDist = Vector3.Dot(p1 - origin, p1 - origin);
        s = 0.0f;
        closestRay = origin;
        return p1;
      }
      float num4;
      if ((double) num1 <= (double) Mathf.Epsilon)
      {
        s = 0.0f;
        num4 = Mathf.Clamp(num3 / num2, 0.0f, 1f);
      }
      else
      {
        float num5 = Vector3.Dot(vector3_1, rhs);
        if ((double) num2 <= (double) Mathf.Epsilon)
        {
          num4 = 0.0f;
          s = Mathf.Clamp(-num5 / num1, 0.0f, 1f);
        }
        else
        {
          float num6 = Vector3.Dot(vector3_1, vector3_2);
          float num7 = (float) ((double) num1 * (double) num2 - (double) num6 * (double) num6);
          s = (double) num7 == 0.0 ? 0.0f : Mathf.Clamp((float) ((double) num6 * (double) num3 - (double) num5 * (double) num2) / num7, 0.0f, 1f);
          num4 = (num6 * s + num3) / num2;
          if ((double) num4 < 0.0)
          {
            num4 = 0.0f;
            s = Mathf.Clamp(-num5 / num1, 0.0f, 1f);
          }
          else if ((double) num4 > 1.0)
          {
            num4 = 1f;
            s = Mathf.Clamp((num6 - num5) / num1, 0.0f, 1f);
          }
        }
      }
      Vector3 vector3_3 = p1 + vector3_1 * s;
      Vector3 vector3_4 = origin + vector3_2 * num4;
      squaredDist = Vector3.Dot(vector3_3 - vector3_4, vector3_3 - vector3_4);
      closestRay = vector3_4;
      return vector3_3;
    }

    public static bool IntersectRaySphere(Ray ray, Vector3 sphereOrigin, float sphereRadius, ref float t, ref Vector3 q)
    {
      Vector3 vector3 = ray.origin - sphereOrigin;
      float num1 = Vector3.Dot(vector3, ray.direction);
      float num2 = Vector3.Dot(vector3, vector3) - sphereRadius * sphereRadius;
      if ((double) num2 > 0.0 && (double) num1 > 0.0)
        return false;
      float f = num1 * num1 - num2;
      if ((double) f < 0.0)
        return false;
      t = -num1 - Mathf.Sqrt(f);
      if ((double) t < 0.0)
        t = 0.0f;
      q = ray.origin + t * ray.direction;
      return true;
    }

    public static bool ClosestPtRaySphere(Ray ray, Vector3 sphereOrigin, float sphereRadius, ref float t, ref Vector3 q)
    {
      Vector3 vector3 = ray.origin - sphereOrigin;
      float num1 = Vector3.Dot(vector3, ray.direction);
      float num2 = Vector3.Dot(vector3, vector3) - sphereRadius * sphereRadius;
      if ((double) num2 > 0.0 && (double) num1 > 0.0)
      {
        t = 0.0f;
        q = ray.origin;
        return true;
      }
      float f = num1 * num1 - num2;
      if ((double) f < 0.0)
        f = 0.0f;
      t = -num1 - Mathf.Sqrt(f);
      if ((double) t < 0.0)
        t = 0.0f;
      q = ray.origin + t * ray.direction;
      return true;
    }
  }
}
