using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     Time Conversion
     Конвертировать AM/PM формат в 24-часовой
     
     Input: 07:05:45PM
     Output: 19:05:45
     */

    public static string timeConversion(string s)
    {
        DateTime time = Convert.ToDateTime(s);
        return time.ToString("HH:mm:ss");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);
    }
}