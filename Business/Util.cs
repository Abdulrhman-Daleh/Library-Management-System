using System;

namespace BusinessLogic
{
    public static class Util
    {
        public static bool IsEmptyObject<T>(T obj) where T : class
        {
            return obj == null;
        }

        public static bool IsInRange<T>(T value, T min, T max) where T : IComparable<T>
        {
            return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
        }
    }
}