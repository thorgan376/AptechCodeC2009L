using System;
using System.Reflection;

namespace EAP_C2009L_HoangThaiSon.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}