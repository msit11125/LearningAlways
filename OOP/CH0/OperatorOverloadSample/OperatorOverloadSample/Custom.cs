using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadSample
{
    public struct Custom<T> where T : struct
    {
        private T _value;

        public Custom(T value)
        {
            _value = value;
        }

        /// <summary>
        /// 隱含轉換, 把 T 轉換為 Custom
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator Custom<T>(T value)
        {
            return new Custom<T>(value);
        }

        /// <summary>
        /// 明確轉換, 把 Custom 轉換為 T
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static explicit operator T(Custom<T> value)
        {
            return value._value;
        }


        public T GetValue()
        {
            return _value;
        }

    }
}
