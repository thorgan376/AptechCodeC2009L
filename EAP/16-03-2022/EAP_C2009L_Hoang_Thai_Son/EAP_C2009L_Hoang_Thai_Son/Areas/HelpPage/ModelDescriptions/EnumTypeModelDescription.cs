using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EAP_C2009L_Hoang_Thai_Son.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}