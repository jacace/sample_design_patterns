using System.Collections.Generic;

namespace sample_design_patterns
{

    public class ControlTable
    {
        public Dictionary<string, Dictionary<int, string>> LoadConfig(){
            Dictionary<string, Dictionary<int, string>> translations=new Dictionary<string, Dictionary<int, string>>();
            Dictionary<int, string> enTranslations=new Dictionary<int, string>();
            enTranslations.Add(1, "January");
            enTranslations.Add(2, "February");
            translations.Add("EN", enTranslations);

            Dictionary<int, string> esTranslations=new Dictionary<int, string>();
            enTranslations.Add(1, "Enero");
            enTranslations.Add(2, "Febrero");
            translations.Add("ES", esTranslations);

            return translations;
        }
    }

}