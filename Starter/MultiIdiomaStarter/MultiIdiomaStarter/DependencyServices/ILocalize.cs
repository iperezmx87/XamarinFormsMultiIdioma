using System.Globalization;

namespace MultiIdiomaStarter.DependencyServices
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();
        void SetLocale(CultureInfo ci);
    }
}
