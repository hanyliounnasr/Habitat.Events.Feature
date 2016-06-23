namespace Sitecore.Feature.Events.Tests
{
  using FluentAssertions;
  using Sitecore.Feature.Events.Repositories;
  using Sitecore.Feature.Events.Tests.Extensions;
  using Xunit;

  public class SearchSettingsRepositoryTests
  {
    [Theory]
    [AutoDbData]
    public void Get_ReturnsSearchSettings(SearchSettingsRepository settingsRepository)
    {
      var searchSettings = settingsRepository.Get();
      searchSettings.Templates.Should().Contain(Templates.EventDetails.ID);
    }
  }
}
