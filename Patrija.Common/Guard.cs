using System;

namespace Patrija.Common
{
    public static class Guard
    {
        public static void AgainstDefaultValue<T>(T value)
            => AgainstDefaultValue(value, typeof(T).FullName);
        
        public static void AgainstDefaultValue<T>(T value, string reportingName)
        {
            if (Equals(value, default(T)))
            {
                throw new ArgumentException($"Value of {reportingName} was equal to {default(T)}!");
            }
        }
    }
}