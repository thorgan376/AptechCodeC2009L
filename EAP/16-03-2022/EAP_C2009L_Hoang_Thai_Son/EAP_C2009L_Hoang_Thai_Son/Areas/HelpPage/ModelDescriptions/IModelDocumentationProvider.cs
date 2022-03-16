using System;
using System.Reflection;

namespace EAP_C2009L_Hoang_Thai_Son.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}