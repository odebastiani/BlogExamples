using System;
using System.Linq;

namespace BitFiddlingTest
{
    public static class Program
    {
        #region Main

        public static void Main()
        {
            Int32AndUInt32();
            DifferentTypes();
            Operators();

            Console.ReadKey();
        }

        #endregion

        #region Tests

        private static void Int32AndUInt32()
        {
            PrintTitle("Int32 and UInt32");

            // Int32 because the MSb is not set
            int value1 = 0b0111_1111_1111_1111_1111_1111_1111_1111;
            PrintToConsole("Int32 because the MSb is not set", "int value = 0b0111_1111_1111_1111_1111_1111_1111_1111", value1);

            // also Int32 because the MSb is not set
            int value2 = 0b1111;
            PrintToConsole("also Int32 because the MSb is not set", "int value = 0b1111;", value2);

            // UInt32 because the MSb is set
            uint value3 = 0b1111_1111_1111_1111_1111_1111_1111_1111;
            PrintToConsole("UInt32 because the MSb is set", "uint value = 0b1111_1111_1111_1111_1111_1111_1111_1111;", value3);

            // UInt32 because the MSb is set
            int value4 = unchecked((int)0b1111_1111_1111_1111_1111_1111_1111_1111);
            PrintToConsole("Int32 with unchecked cast to set the MSb", "int value = unchecked((int)0b1111_1111_1111_1111_1111_1111_1111_1111);", value4);
        }

        private static void DifferentTypes()
        {
            PrintTitle("Different Types");

            byte byteValue = 0b0000_0001;
            PrintToConsole("byte", "byte value = 0b0000_0001", byteValue);

            sbyte sByteValue = 0b0000_0001;
            PrintToConsole("sbyte", "sbyte value = 0b0000_0001;", sByteValue);

            short shortValue = 0b0000_0000_0000_0010;
            PrintToConsole("short", "short value = 0b0000_0000_0000_0010;", shortValue);

            ushort uShortValue = 0b0000_0000_0000_0010;
            PrintToConsole("ushort", "ushort value = 0b0000_0000_0000_0010;", uShortValue);

            int intValue = 0b0000_0000_0000_0000_0000_0000_0000_0011;
            PrintToConsole("int", "int value = 0b0000_0000_0000_0000_0000_0000_0000_0011;", intValue);

            uint uIntValue = 0b0000_0000_0000_0000_0000_0000_0000_0011;
            PrintToConsole("uint", "uint value = 0b0000_0000_0000_0000_0000_0000_0000_0011;", uIntValue);

            long longValue = 0b0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0100;
            PrintToConsole("long", "long value = 0b0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0100;", longValue);

            ulong uLongValue = 0b0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0100;
            PrintToConsole("ulong", "ulong value = 0b0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0100;", uLongValue);
        }

        private static void Operators()
        {
            PrintTitle("Operators");

            // Bitwise complement operator ~
            int sample1Value1 = 0b0000_1111_0000_1111_0000_1111_0000_1111;
            int sample1Value2 = ~sample1Value1;
            PrintToConsole("Bitwise complement operator ~", "int value = ~0b0000_1111_0000_1111_0000_1111_0000_1111;", sample1Value1, sample1Value2);

            // Left-shift operator <<
            int sample2Value1 = unchecked((int)0b1000_0000_0000_0000_0000_0000_0000_0001);
            int sample2Value2 = sample2Value1 << 4;
            PrintToConsole("Left-shift operator <<", "int value = unchecked((int)0b1000_0000_0000_0000_0000_0000_0000_0001) << 4;", sample2Value1, sample2Value2);

            // Right-shift operator >> with 1 as MSb
            int sample3Value1 = unchecked((int)0b1000_0000_0000_0000_0000_0000_0000_0001);
            int sample3Value2 = sample3Value1 >> 4;
            PrintToConsole("Right-shift operator >> with 1 as MSb", "int value = unchecked((int)0b1000_0000_0000_0000_0000_0000_0000_0001) >> 4;", sample3Value1, sample3Value2);

            // Right-shift operator >> with 0 as MSb
            int sample4Value1 = 0b0000_1000_0000_0000_0000_0000_0000_0001;
            int sample4Value2 = sample4Value1 >> 4;
            PrintToConsole("Right-shift operator >> with 0 as MSb", "int value = 0b0000_1000_0000_0000_0000_0000_0000_0001 >> 4;", sample4Value1, sample4Value2);

            // Right-shift operator >> with 1 as MSb and unsigned type
            uint sample5Value1 = 0b1000_0000_0000_0000_0000_0000_0000_0001;
            uint sample5Value2 = sample5Value1 >> 4;
            PrintToConsole("Right-shift operator >> with 1 as MSb and unsigned type", "uint value = 0b1000_0000_0000_0000_0000_0000_0000_0001 >> 4;", sample5Value1, sample5Value2);

            // Right-shift operator >> with 0 as MSb and unsigned type
            uint sample6Value1 = 0b0000_1000_0000_0000_0000_0000_0000_0001;
            uint sample6Value2 = sample6Value1 >> 4;
            PrintToConsole("Right-shift operator >> with 0 as MSb and unsigned type", "uint value = 0b0000_1000_0000_0000_0000_0000_0000_0001 >> 4;", sample6Value1, sample6Value2);

            // Unsigned right-shift operator >>> with 1 as MSb
            int sample7Value1 = unchecked((int)0b1000_0000_0000_0000_0000_0000_0000_0001);
            int sample7Value2 = sample7Value1 >>> 4;
            PrintToConsole("Unsigned right-shift operator >>> with 1 as MSb", "int value = unchecked((int)0b1000_0000_0000_0000_0000_0000_0000_0001) >>> 4;", sample7Value1, sample7Value2);

            // Unsigned right-shift operator >>> with 0 as MSb
            int sample8Value1 = 0b0000_1000_0000_0000_0000_0000_0000_0001;
            int sample8Value2 = sample8Value1 >>> 4;
            PrintToConsole("Unsigned right-shift operator >>> with 0 as MSb", "int value = 0b0000_1000_0000_0000_0000_0000_0000_0001 >>> 4;", sample8Value1, sample8Value2);

            // Logical AND operator &
            int sample9Value1 = 0b0000_1111_0000_1111_0000_1111_0000_1111;
            int sample9Value2 = 0b0101_0101_0101_0101_0101_0101_0101_0101;
            int sample9Value3 = sample9Value1 & sample9Value2;
            PrintToConsole("Logical AND operator &", "int value = 0b0000_1111_0000_1111_0000_1111_0000_1111 & 0b0101_0101_0101_0101_0101_0101_0101_0101;", sample9Value1, sample9Value2, sample9Value3);

            // Logical OR operator |
            int sample10Value1 = 0b0000_1111_0000_1111_0000_1111_0000_1111;
            int sample10Value2 = 0b0101_0101_0101_0101_0101_0101_0101_0101;
            int sample10Value3 = sample10Value1 | sample10Value2;
            PrintToConsole("Logical OR operator |", "int value = 0b0000_1111_0000_1111_0000_1111_0000_1111 | 0b0101_0101_0101_0101_0101_0101_0101_0101;", sample10Value1, sample10Value2, sample10Value3);

            // Logical XOR operator ^
            int sample11Value1 = 0b0000_1111_0000_1111_0000_1111_0000_1111;
            int sample11Value2 = 0b0101_0101_0101_0101_0101_0101_0101_0101;
            int sample11Value3 = sample11Value1 ^ sample11Value2;
            PrintToConsole("Logical XOR operator ^", "int value = 0b0000_1111_0000_1111_0000_1111_0000_1111 ^ 0b0101_0101_0101_0101_0101_0101_0101_0101;", sample11Value1, sample11Value2, sample11Value3);
        }

        #endregion

        #region Print To Console

        private static void PrintTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("--- " + title);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
        }

        private static void PrintToConsole(string title, string input, params byte[] values)
        {
            int countOfBits = 8;

            PrintToConsole(title,
                           input,
                           x => x.ToString("#,##0"),
                           x => FormatBinaryString(Convert.ToString(x, 2), countOfBits),
                           values);
        }

        private static void PrintToConsole(string title, string input, params sbyte[] values)
        {
            int countOfBits = 8;

            PrintToConsole(title,
                           input,
                           x => x.ToString("#,##0"),
                           x => FormatBinaryString(Convert.ToString((byte)x, 2), countOfBits),
                           values);
        }

        private static void PrintToConsole(string title, string input, params short[] values)
        {
            int countOfBits = 16;

            PrintToConsole(title,
                           input,
                           x => x.ToString("#,##0"),
                           x => FormatBinaryString(Convert.ToString(x, 2), countOfBits),
                           values);
        }

        private static void PrintToConsole(string title, string input, params ushort[] values)
        {
            int countOfBits = 16;

            PrintToConsole(title,
                           input,
                           x => x.ToString("#,##0"),
                           x => FormatBinaryString(Convert.ToString((short)x, 2), countOfBits),
                           values);
        }

        private static void PrintToConsole(string title, string input, params int[] values)
        {
            int countOfBits = 32;

            PrintToConsole(title,
                           input,
                           x => x.ToString("#,##0"),
                           x => FormatBinaryString(Convert.ToString(x, 2), countOfBits),
                           values);
        }

        private static void PrintToConsole(string title, string input, params uint[] values)
        {
            int countOfBits = 32;

            PrintToConsole(title,
                           input,
                           x => x.ToString("#,##0"),
                           x => FormatBinaryString(Convert.ToString((int)x, 2), countOfBits),
                           values);
        }

        private static void PrintToConsole(string title, string input, params long[] values)
        {
            int countOfBits = 64;

            PrintToConsole(title,
                           input,
                           x => x.ToString("#,##0"),
                           x => FormatBinaryString(Convert.ToString(x, 2), countOfBits),
                           values);
        }

        private static void PrintToConsole(string title, string input, params ulong[] values)
        {
            int countOfBits = 64;

            PrintToConsole(title,
                           input,
                           x => x.ToString("#,##0"),
                           x => FormatBinaryString(Convert.ToString((long)x, 2), countOfBits),
                           values);
        }

        private static void PrintToConsole<T>(string title, string input, Func<T, string> toDecimalString, Func<T, string> toFormattedBinaryString, params T[] values)
            where T : struct
        {
            ConsoleWriteLine(ConsoleColor.White, title);

            ConsoleWrite(ConsoleColor.Gray, " -     Input: ");
            ConsoleWriteLine(ConsoleColor.Green, input);

            for (int i = 0; i < values.Length; i++)
            {
                ConsoleWrite(ConsoleColor.Gray, (values.Length == 1 ? " -   Decimal: " : $" - Decimal {i + 1}: "));
                ConsoleWriteLine(ConsoleColor.Green, toDecimalString(values[i]));
            }

            for (int i = 0; i < values.Length; i++)
            {
                ConsoleWrite(ConsoleColor.Gray, (values.Length == 1 ? " -    Binary: " : $" -  Binary {i + 1}: "));
                ConsoleWriteLine(ConsoleColor.Green, toFormattedBinaryString(values[i]));
            }

            Console.WriteLine();

            Console.ResetColor();
        }

        private static string FormatBinaryString(string original, int length)
        {
            int blockSize = 4;
            string padded = original.PadLeft(length, '0');

            return string.Join(" ", Enumerable.Range(0, padded.Length / blockSize)
                                              .Select(x => padded.Substring(x * blockSize, blockSize)));
        }

        private static void ConsoleWrite(ConsoleColor color, string value)
        {
            Console.ForegroundColor = color;
            Console.Write(value);
        }

        private static void ConsoleWriteLine(ConsoleColor color, string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
        }

        #endregion
    }
}
