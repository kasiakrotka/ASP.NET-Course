using System;
using System.Reflection;

namespace KatarzynaKrawczykLab6Zad1.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}