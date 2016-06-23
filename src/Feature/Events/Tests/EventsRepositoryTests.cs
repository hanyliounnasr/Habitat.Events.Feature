namespace Sitecore.Feature.Evernts.Tests
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using FluentAssertions;
  using NSubstitute;
  using Ploeh.AutoFixture.Xunit2;
  using Sitecore.Data;
  using Sitecore.FakeDb;
  using Sitecore.Feature.Events;
  using Sitecore.Feature.Events.Repositories;
  using Sitecore.Feature.Events.Tests.Extensions;
  using Sitecore.Foundation.Indexing;
  using Sitecore.Rules.Conditions.ItemConditions;
  using Xunit;
  using Ploeh.AutoFixture.AutoNSubstitute;
  using Sitecore.ContentSearch.SearchTypes;
  using Sitecore.Data.Items;
  using Sitecore.Foundation.Indexing.Models;
  using Sitecore.Foundation.Indexing.Repositories;
  using Sitecore.Search;
  using Events.Models;
  public class EventsRepositoryTests
  {
    [Theory]
    [AutoDbData]
    public void GetAllEvents_ReturnsListOfEvents([Frozen] ISearchServiceRepository searchServiceRepository, [Frozen] ISearchSettingsRepository searchSettingsRepository, string itemName, [Substitute] SearchService searchService, ISearchSettings searchSettings)
    {
      var id = ID.NewID;
      searchService.Settings.Returns(searchSettings);
      searchServiceRepository.Get().Returns(searchService);
      var db = new Db
      {
        new DbItem(itemName, id, Templates.EventDetails.ID)
      };
      var contextItem = db.GetItem(id).Parent;
      var repository = new EventsRepository(contextItem, searchServiceRepository);
      var events = repository.GetAllEvents();
      events.Should().As<EventItems>();
    }

    [Theory]
    [AutoDbData]
    public void GetFilteredEvents_ReturnsListOfEvents([Frozen] ISearchServiceRepository searchServiceRepository, [Frozen] ISearchSettingsRepository searchSettingsRepository, string itemName, [Substitute] SearchService searchService, ISearchSettings searchSettings)
    {
      var id = ID.NewID;
      searchService.Settings.Returns(searchSettings);
      searchServiceRepository.Get().Returns(searchService);
      var db = new Db
      {
        new DbItem(itemName, id, Templates.EventDetails.ID)
      };
      var contextItem = db.GetItem(id).Parent;
      var eventsModel = new EventItems();
      var repository = new EventsRepository(contextItem, searchServiceRepository);
      var events = repository.GetFilteredEvents(eventsModel);
      events.Should().As<EventItems>();
    }

    [Theory]
    [AutoDbData]
    public void Constructor_NullAs1Parameter_ThrowArgumentNullException([Frozen] ISearchServiceRepository searchServiceRepository, [Frozen] ISearchSettingsRepository searchSettingsRepository)
    {
      Action act = () => new EventsRepository(null);
      act.ShouldThrow<ArgumentNullException>();
    }

    [Theory]
    [AutoDbData]
    public void GetLatestEvents_IntegerAs1Parameter_ReturnsNumberOfEventsEquelToParameterValue([Frozen] ISearchServiceRepository searchServiceRepository, [Frozen] ISearchSettingsRepository searchSettingsRepository, string itemName, [Substitute] SearchService searchService, ISearchSettings searchSettings, ISearchResults searchResults, List<Item> collection)
    {
      var id = ID.NewID;
      searchService.Settings.Returns(searchSettings);
      searchResults.Results.Returns(collection.Select(x=>new Foundation.Indexing.Models.SearchResult(x)));
      searchService.FindAll().Returns(searchResults);
      searchServiceRepository.Get().Returns(searchService);
      var db = new Db
      {
        new DbItem(itemName, id, Templates.EventDetails.ID)
      };
      var contextItem = db.GetItem(id).Parent;
      var repository = new EventsRepository(contextItem, searchServiceRepository);
      var events = repository.GetLatestEvents(1);
      events.Items.Count().ShouldBeEquivalentTo(1);
    }
  }
}
