using Sitecore.Feature.Events.Models;
using Sitecore.Feature.Events.Repositories;
using Sitecore.Foundation.SitecoreExtensions.Attributes;
using Sitecore.Foundation.SitecoreExtensions.Extensions;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Sitecore.Feature.Events.Controllers
{
  public class EventsController : SitecoreController
  {
    private IEventsRepository repository;

    public EventsController() : this(new EventsRepository(RenderingContext.Current.ContextItem)) { }

    public EventsController(IEventsRepository repository)
    {
      this.repository = repository;
    }

    // GET: Events List
    public ActionResult EventsList()
    {
      return View("EventsList", repository.GetAllEvents());
    }

    // GET: Events List with filter option
    public ActionResult EventsListWithFilter()
    {
      return View("EventsListWithFilter", repository.GetAllEvents());
    }

    // Post: Events List after applying filter
    [HttpPost]
    [ValidateRenderingId]
    public ActionResult EventsListWithFilter(EventItems eventItems)
    {
      return View("EventsListWithFilter", repository.GetFilteredEvents(eventItems));
    }

    // GET: Latest Events
    public ActionResult LatestEvents()
    {
      var count = RenderingContext.Current.Rendering.GetIntegerParameter("count", 5);
      return View("LatestEvents", repository.GetLatestEvents(count));
    }
  }
}