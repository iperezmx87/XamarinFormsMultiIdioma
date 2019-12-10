using System.Globalization;

namespace MultiIdiomaStarter.DependencyService
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();
        void SetLocale(CultureInfo ci);
    }
}
