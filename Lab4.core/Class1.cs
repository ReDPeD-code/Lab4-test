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
        var password = "admin123";     // захардкоженный пароль
        int unused = 5;                // неиспользуемая переменная
        try
        {
            return (a / b).ToString();
        }
        catch (Exception)
        {
        }                              // пустой catch
        return "";
    }

    public string FormatA(string name, int value)
    {
        if (name == null) return "";
        var result = name.Trim() + ": " + value;
        result = result.ToUpper();
        result = result.Replace(" ", "_");
        return result;
    }

    public string FormatB(string title, int count)
    {
        if (title == null) return "";
        var result = title.Trim() + ": " + count;
        result = result.ToUpper();
        result = result.Replace(" ", "_");
        return result;
    }
}

