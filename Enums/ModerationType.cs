using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ABlogV1.Enums
{
    public enum ModerationType
    {
        [Description("Political Incorrect Fact")]
        Political,
        [Description("Offensive Language")]
        Language,
        [Description("Addictive Drug Use Promotion")]
        Drugs,
        [Description("Threatening Speech")]
        Threatening,
        [Description("Sexual Content")]
        Sexual,
        [Description("Hate Speech")]
        HateSpeech,
        [Description("Targeted Shaming")]
        Shaming
    }
}