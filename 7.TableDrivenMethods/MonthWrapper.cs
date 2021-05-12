using System;
using System.Collections.Generic;

namespace sample_design_patterns
{

public class MonthWrapper
{
    private readonly Dictionary<string, Dictionary<int, string>> months=ControlTable.LoadConfig();
    public string getMonthName(string lang, int monthNum)
    {
        if(months.ContainsKey(lang))
        {
            return months[lang][monthNum];
        }
        throw new ArgumentException();
    }
}

}
