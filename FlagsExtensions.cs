using System.Collections;
using System.Linq;
namespace FlagsTesting
{
    public static class FlagsExtensions
    {
        public static void Add(ref this ExampleFlags @this, ExampleFlags other) => @this |= other;
        public static void Remove(ref this ExampleFlags @this, ExampleFlags other) => @this &= ~other;

        public static bool IsEqual(ref this ExampleFlags @this, ExampleFlags other) => @this == other;
        public static bool Contains_EitherOr(ref this ExampleFlags @this, ExampleFlags other) => (@this & other) != 0;
        public static bool Contains_AllOf(ref this ExampleFlags @this, ExampleFlags other) => (@this & other) == other;

        public static ExampleFlags GetCommon(ref this ExampleFlags @this, ExampleFlags other) => @this & other;


        /// <summary>
        /// Only use this for debuging. Returns the flag as an array of bytes.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static byte[] ToBitArray(int @this)
        {
            var bitArray = new BitArray(new int[1] { @this });
            bool[] bits = new bool[bitArray.Count];
            bitArray.CopyTo(bits, 0);
            byte[] bitValues = bits.Reverse().Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            return bitValues;
        }
        /// <summary>
        /// Only use this for debuging. Returns the flag as a string containing the bytes.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string MaskToBitArrayString(int @this)
        {
            var bitValues = ToBitArray(@this);
            string result = "[";
            for (int i = 0; i < bitValues.Length; i++)
            {
                result += $"{bitValues[i]}";
                if (i != bitValues.Length - 1)
                    result += ",";
            }
            result += "]";
            return result;
        }
    }
}
