using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab4.Core;

public class ReportService
{
    public string BuildReport(int a, int b)
    {
        if (b == 0) return string.Empty;
        return (a / b).ToString();
    }

    public string Format(string? text, int value)
    {
        if (text == null) return string.Empty;
        return $"{text.Trim()}: {value}".ToUpper().Replace(" ", "_");
    }
}


