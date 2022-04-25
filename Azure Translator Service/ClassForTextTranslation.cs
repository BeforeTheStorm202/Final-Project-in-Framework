using System.Collections.Generic;

namespace Azure_Translator_Service
{
    // Text translation
    public class translatetextresponse
    {
        public List<translatetext> translations { get; set; }
    }
    public class translatetext
    {
        public string text { get; set; }
        public string to { get; set; }
    }
}
