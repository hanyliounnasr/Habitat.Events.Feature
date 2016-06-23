namespace Sitecore.Feature.Events.Repositories
{
  using Models;
  public interface IEventsRepository
  {
    EventItems GetAllEvents();
    EventItems GetFilteredEvents(EventItems eventItems);
    EventItems GetLatestEvents(int count);
  }
}