using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static class encoder
{
    public static long dec2bin(long dec)
        {
            long value = 1;
            long result = 0;

            while (dec > 0)
            {
                long mod = dec % 2;
                dec /= 2;
                result += mod * value;
                value *= 10;
            }

            return result;
        }

    public static long bin2dec(long bin)
    {
        long result = 0;
        string str = bin.ToString();
        for (int i = str.Length; i > 0; i--)
        {
            int a = i - 1;
            int b = str.Length - i;
            result += Convert.ToInt64(str[a].ToString()) * (long)Math.Pow(2, b);
        }
        return result;
    }

    public enum SeedParams
        {
            PARAM_1 = 1,
            PARAM_2 = 2,
            PARAM_3 = 3,
            PARAM_4 = 4,
            PARAM_5 = 5,
            PARAM_6 = 6,
            PARAM_7 = 7,
            PARAM_8 = 8,
            PARAM_9 = 9,
            PARAM_10 = 10,
            PARAM_11 = 11,
            PARAM_12 = 12,
            PARAM_13 = 13,
            PARAM_14 = 14,
            PARAM_15 = 15,
        }

    public static SeedParams seedParam(int num)
    {
        return (SeedParams)num;
    }

    public static string encode(string text, SeedParams seed)
    {
        int intSeed = (int)seed;
        StringBuilder result = new StringBuilder();
        StringBuilder binary = new StringBuilder();

        foreach (char i in text)
        {
            long num = Convert.ToInt64(i);
            long bin = dec2bin(num);
            binary.Append((bin + 10000000000000000).ToString().Substring(1));
        }

        string binaryStr = binary.ToString();
        while (binaryStr.Length >= intSeed)
        {
            long charNum;
            if (intSeed > 1)
            {
                charNum = bin2dec(Convert.ToInt64(binaryStr.Substring(0, intSeed))) + intSeed + 34;
            } else
            {
                charNum = bin2dec(Convert.ToInt64(binaryStr[0].ToString())) + intSeed + 34;
            }
            result.Append((char)charNum);
            binaryStr = binaryStr.Substring(intSeed);
        }
        if (binaryStr.Length > 0)
        {
            long charNum_;
            if (binaryStr.Length > 1)
            {
                charNum_ = bin2dec(Convert.ToInt64(binaryStr.Substring(0, binaryStr.Length))) + intSeed + 34;
            } else
            {
                charNum_ = bin2dec(Convert.ToInt64(binaryStr)) + intSeed + 34;
            }
            result.Append((char)charNum_);
        }

        return result.ToString();
    }

    public static string decode(string text, SeedParams seed)
    {
        int intSeed = (int)seed;
        StringBuilder result = new StringBuilder();
        StringBuilder binary = new StringBuilder();

        for (int i = 0; i < text.Length - 1; i++)
        {
            char c = text[i];
            long num = Convert.ToInt64(c) - intSeed - 34;
            long bin = dec2bin(num);
            binary.Append((bin + (long)Math.Pow(10, intSeed)).ToString().Substring(1));
        }
        long digit = 15 - ((binary.Length - 1) % 16);
        char c_ = text[text.Length - 1];
        long num_ = Convert.ToInt64(c_) - intSeed - 34;
        long bin_ = dec2bin(num_);
        binary.Append((bin_ + (long)Math.Pow(10, digit)).ToString().Substring(1));

        string binaryStr = binary.ToString();
        while (binaryStr.Length > 16)
        {
            char chr = (char)bin2dec(Convert.ToInt64(binaryStr.Substring(0, 16)));
            result.Append(chr);
            binaryStr = binaryStr.Substring(16);
        }
        char chr_;
        if (binaryStr.Length > 1)
        {
            long test = Convert.ToInt64(binaryStr.Substring(0, binaryStr.Length));
            chr_ = (char)bin2dec(Convert.ToInt64(binaryStr.Substring(0, binaryStr.Length)));
        } else
        {
            chr_ = (char)bin2dec(Convert.ToInt64(binaryStr));
        }
        result.Append(chr_);

        return result.ToString();
    }
}
