using System;
using System.Collections.Generic;
using System.Text;

namespace P2Les4.Classes
{
    class DataValue
    {
        public int Value { set; get; }

        /// <summary>
        /// Set the Value
        /// </summary>
        /// <param name="value"></param>
        public DataValue(int value)
        {
            Value = value;
        }
    }
}
