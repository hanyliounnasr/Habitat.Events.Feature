namespace Sitecore.Feature.Events.Repositories
{
  using Foundation.Indexing.Repositories;
  using Models;
  using Sitecore.Data.Fields;
  using Sitecore.Data.Items;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  public class EventsRepository : IEventsRepository
  {
    //Search Service
    private readonly ISearchServiceRepository searchServiceRepository;

    //Sitecore Current Item
    public Item ContextItem { get; set; }

    public EventsRepository(Item contextItem) : this(contextItem, new SearchServiceRepository(new SearchSettingsRepository())) { }

    public EventsRepository(Item contextItem, ISearchServiceRepository searchServiceRepository)
    {
      if (contextItem == null)
      {
        throw new ArgumentNullException(nameof(contextItem));
      }
      
      this.ContextItem = contextItem;
      this.searchServiceRepository = searchServiceRepository;
    }

    public EventItems GetAllEvents()
    {
      var searchService = this.searchServiceRepository.Get();
      searchService.Settings.Root = this.ContextItem;
      var results = searchService.FindAll();
      var items = results.Results.Select(x => x.Item).OrderByDescending(i => i[Templates.EventDetails.Fields.Date]);
      return new EventItems() { Items = items };
    }

    public EventItems GetFilteredEvents(EventItems eventItems)
    {
      var newEventItems = this.GetAllEvents().Items;

      newEventItems = this.FilterByYear(newEventItems, eventItems.Year);

      newEventItems = this.FilterByMonth(newEventItems, eventItems.Month);

      return new EventItems() { Items = newEventItems };
    }

    public EventItems GetLatestEvents(int count)
    {
      return new EventItems() { Items = this.GetAllEvents().Items.Take(count) };
    }

    private IEnumerable<Item> FilterByYear(IEnumerable<Item> items, int year)
    {
      if(year > 0)
      {
        items = items.Where(i => ((DateField)i.Fields[Templates.EventDetails.Fields.Date]).DateTime.Year == year);
      }

      return items;
    }
  
    private IEnumerable<Item> FilterByMonth(IEnumerable<Item> items, int month)
    {
      if (month > 0)
      {
        items = items.Where(i => ((DateField)i.Fields[Templates.EventDetails.Fields.Date]).DateTime.Month == month);
      }

      return items;
    }
  }
}