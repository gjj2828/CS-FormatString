/****************************************************************
 * Project: FormatString
 * File: Main.cs
 * Create Date: 2020/04/10
 * Author: Gao Jiongjiong
 * Descript: Format string samples.
****************************************************************/

using System;
using System.Globalization;
using System.Numerics;

class MainClass
{
    public static void Main(string[] args) {
        NumberFormatInfo nfi = CultureInfo.CurrentCulture.NumberFormat;

        // Currency
        Console.WriteLine("Currency: CurrencyDecimalDigits = {0}", nfi.CurrencyDecimalDigits);
        Console.WriteLine("{{0:C}}: {0:C}", -123.456);
        Console.WriteLine("{{0:C4}}: {0:C4}", -123.456);

        // Decimal
        Console.WriteLine();
        Console.WriteLine("Decimal:");
        Console.WriteLine("{{0:D}}: {0:D}", -1234);
        Console.WriteLine("{{0:D6}}: {0:D6}", -1234);

        // Exponential
        Console.WriteLine();
        Console.WriteLine("Exponential:");
        Console.WriteLine("{{0:E}}: {0:E}", 1052.0329112756);
        Console.WriteLine("{{0:E2}}: {0:E2}", 1052.0329112756);

        // Fixed-point
        Console.WriteLine();
        Console.WriteLine("Fixed-point: NumberDecimalDigits = {0}", nfi.NumberDecimalDigits);
        Console.WriteLine("{{0:F}}: {0:F}", -1234.56);
        Console.WriteLine("{{0:F}}: {0:F}", 1234);
        Console.WriteLine("{{0:F1}}: {0:F1}", -1234.56);
        Console.WriteLine("{{0:F1}}: {0:F1}", 1234);
        Console.WriteLine("{{0:F4}}: {0:F4}", -1234.56);

        // General
        Console.WriteLine();
        Console.WriteLine("General:");
        Console.WriteLine("{{0:G}}: {0:G}", 123.4546);
        Console.WriteLine("{{0:G4}}: {0:G4}", 123.4546);
        Console.WriteLine("{{0:G}}: {0:G}", 1234567890);
        Console.WriteLine("{{0:G4}}: {0:G4}", 1234567890);

        // Number
        Console.WriteLine();
        Console.WriteLine("Number: NumberDecimalDigits = {0}", nfi.NumberDecimalDigits);
        Console.WriteLine("{{0:N}}: {0:N}", -1234.567);
        Console.WriteLine("{{0:N1}}: {0:N1}", -1234.567);
        Console.WriteLine("{{0:N4}}: {0:N4}", -1234.567);

        // Percent
        Console.WriteLine();
        Console.WriteLine("Percent: PercentDecimalDigits = {0}", nfi.PercentDecimalDigits);
        Console.WriteLine("{{0:P}}: {0:P}", 0.56789);
        Console.WriteLine("{{0:P1}}: {0:P1}", 0.56789);
        Console.WriteLine("{{0:P3}}: {0:P4}", 0.56789);

        //// Round-trip
        //Console.WriteLine();
        //Console.WriteLine("Round-trip:");
        //Console.WriteLine("{{0:R}}: {0:R}", 123456789.12345678);
        //Console.WriteLine("{{0:R}}: {0:R}", -1234567890.12345678);
        //Console.WriteLine("{{0:R}}: {0:R}", BigInteger.Pow(Int64.MaxValue, 2));

        // Hexadecimal
        Console.WriteLine();
        Console.WriteLine("Hexadecimal:");
        Console.WriteLine("{{0:X}}: {0:X}", 255);
        Console.WriteLine("{{0:X}}: {0:X}", -1);
        Console.WriteLine("{{0:X4}}: {0:X4}", 255);

        // Zero placeholder
        Console.WriteLine();
        Console.WriteLine("Zero placeholder:");
        Console.WriteLine("{{0:00000}}: {0:00000}", 1234.5678);
        Console.WriteLine("{{0:0.00}}: {0:0.00}", 0.45678);

        // Digit placeholder
        Console.WriteLine();
        Console.WriteLine("Digit placeholder:");
        Console.WriteLine("{{0:#####}}: {0:#####}", 1234.5678);
        Console.WriteLine("{{0:#.##}}: {0:#.##}", 0.45678);

        // Decimal point
        Console.WriteLine();
        Console.WriteLine("Digit placeholder:");
        Console.WriteLine("{{0:0.00}}: {0:0.00}", 0.45678);

        // Group separator and number scaling
        Console.WriteLine();
        Console.WriteLine("Group separator and number scaling: NumberGroupSeparator = '{0}'" +
            ", NumberGroupSizes = {1}", nfi.NumberGroupSeparator, nfi.NumberGroupSizes[0]);
        Console.WriteLine("{{0:##,#}}: {0:##,#}", 2147483647);
        Console.WriteLine("{{0:#,#}}: {0:#,#}", 2147483647);
        Console.WriteLine("{{0:#,#,,}}: {0:#,#,,}", 2147483647);
        Console.WriteLine("{{0:#,##0,,}}: {0:#,##0,,}", 1234567890);
        Console.WriteLine("{{0:#,0,,}}: {0:#,0,,}", 1234567890);
        Console.WriteLine("{{0:#,,}}: {0:#,,}", 1234567890);
        Console.WriteLine("{{0:#,,,}}: {0:#,,,}", 1234567890);

        // Percentage placeholder
        Console.WriteLine();
        Console.WriteLine("Percentage placeholder:");
        Console.WriteLine("{{0:#0.00%}}: {0:#0.00%}", 0.3697);
        Console.WriteLine("{{0:0.00%}}: {0:0.00%}", 0.3697);
        Console.WriteLine("{{0:##.0%}}: {0:##.0%}", 0.3697);
        Console.WriteLine("{{0:.0%}}: {0:.0%}", 0.3697);

        // Per mille placeholder
        Console.WriteLine();
        Console.WriteLine("Per mille placeholder:");
        Console.WriteLine("{{0:#0.00‰}}: {0:#0.00‰}", 0.03697);
        Console.WriteLine("{{0:0.00‰}}: {0:0.00‰}", 0.03697);

        // Exponential notation
        Console.WriteLine();
        Console.WriteLine("Exponential notation:");
        Console.WriteLine("{{0:#0.0e0}}: {0:#0.0e0}", 987654);
        Console.WriteLine("{{0:0.0e0}}: {0:0.0e0}", 987654);
        Console.WriteLine("{{0:0.0##e+00}}: {0:0.0##e+00}", 1503.92311);
        Console.WriteLine("{{0:0.0##e+00}}: {0:0.0##e+00}", 1500.02311);
        Console.WriteLine("{{0:0.0e+00}}: {0:0.0e+00}", 1.8901385E-16);

        // Escape character
        Console.WriteLine();
        Console.WriteLine("Escape character:");
        Console.WriteLine(@"{{0:\###00\#}}: {0:\###00\#}", 987654);
        Console.WriteLine("{{0:\\\\###00\\\\#}}: {0:\\###00\\#}", 987654);

        // Section separator
        Console.WriteLine();
        Console.WriteLine("Section separator:");
        Console.WriteLine(@"{{0:#0.0#;(#0.0#);-\0-}}: {0:#0.0#;(#0.0#);-\0-}", 12.345);
        Console.WriteLine(@"{{0:#0.0#;(#0.0#);-\0-}}: {0:#0.0#;(#0.0#);-\0-}", 0);
        Console.WriteLine(@"{{0:#0.0#;(#0.0#);-\0-}}: {0:#0.0#;(#0.0#);-\0-}", -12.345);
        Console.WriteLine(@"{{0:#0.0#;(#0.0#)}}: {0:#0.0#;(#0.0#)}", 12.345);
        Console.WriteLine(@"{{0:#0.0#;(#0.0#)}}: {0:#0.0#;(#0.0#)}", 0);
        Console.WriteLine(@"{{0:#0.0#;(#0.0#)}}: {0:#0.0#;(#0.0#)}", -12.345);
    }
}
