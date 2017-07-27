using System;
using System.Collections.Generic;
using System.Linq;

namespace Digirati.IIIF3.Model.JSONLD
{
    public class JSONLDString
    {
        private string singleValue;
        private Dictionary<string, string> languageMap; 

        public JSONLDString(string value)
        {
            singleValue = value;
        }

        public JSONLDString(string language, string value)
        {
            languageMap = new Dictionary<string, string>
            {
                { language, value }
            };
            singleValue = value;
        }


        public JSONLDString(Dictionary<string, string> languageMap)
        {
            this.languageMap = languageMap;
        }

        public static implicit operator string(JSONLDString js)
        {
            // string s = myJsonLDStringObject;
            return js.ToString();
        }

        public static implicit operator JSONLDString(string s)
        {
            // JSONLDstring js = "hello";
            return new JSONLDString(s);
        }

        public string this[string language]
        {
            get
            {
                if (languageMap != null && languageMap.ContainsKey(language))
                {
                    return languageMap[language];
                }
                if (language == string.Empty)
                {
                    return singleValue;
                }
                return null;
            }
            set
            {
                if (languageMap == null)
                {
                    languageMap = new Dictionary<string, string>
                    {
                        { string.Empty, singleValue }
                    };
                }
                languageMap[language] = value;
            }
        }

        public override string ToString()
        {
            if (languageMap == null)
            {
                return singleValue;
            }
            if (languageMap.ContainsKey(string.Empty))
            {
                return languageMap[string.Empty];
            }
            return string.Join(";", languageMap.Select(x => x.Key + "=" + x.Value));
        }

        public override bool Equals(object obj)
        {
            if (obj is string || obj is JSONLDString)
            {
                return ToString().Equals(obj.ToString());
            }
            return false;
        }
    }
}


