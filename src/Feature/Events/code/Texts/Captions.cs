namespace Sitecore.Feature.Events.Texts
{
  using Sitecore.Foundation.SitecoreExtensions.Repositories;

  public static class Captions
  {
    public static string Year => DictionaryRepository.Get("/Events/Captions/Year", "Year");

    public static string Month => DictionaryRepository.Get("/Events/Captions/Year", "Month");

    public static string Filter => DictionaryRepository.Get("/Events/Captions/Filter", "Filter");
  }
}