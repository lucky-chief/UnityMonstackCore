﻿using Unity.Mathematics;
using UnityEngine;

namespace Plugins.UnityMonstackCore.Extensions
{
    public static class VectorExtensions
    {
        public static int2 ToInt2(this Vector3 v)
        {
            return new int2((int) math.floor(v.x), (int) math.floor(v.z));
        }

        public static int3 ToInt3(this Vector3 v)
        {
            return new int3((int) math.floor(v.x), (int) math.floor(v.y), (int) math.floor(v.z));
        }

        public static float3 ToFloat3(this int3 v)
        {
            return new float3(v.x, v.y, v.z);
        }

        public static float3 ToFloat3(this int2 v)
        {
            return new float3(v.x, 0, v.y);
        }
    }
}