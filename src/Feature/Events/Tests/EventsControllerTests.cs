namespace Sitecore.Feature.Events.Tests
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using System.Web.Mvc;
  using FluentAssertions;
  using Sitecore.Data;
  using Sitecore.FakeDb;
  using Sitecore.Feature.Events.Controllers;
  using Sitecore.Feature.Events.Repositories;
  using Sitecore.Feature.Events.Tests.Extensions;
  using Sitecore.Mvc.Common;
  using Sitecore.Mvc.Presentation;
  using Xunit;

  public class EventsControllerTests
  {
    [Theory]
    [AutoDbData]
    public void EventsList_ShouldReturnViewResult(Db db, string itemName, ID itemId, IEventsRepository repository)
    {
      //Arrange
      var eventsController = new EventsController(repository);
      db.Add(new DbItem(itemName, itemId, Templates.EventDetails.ID));
      var contextItem = db.GetItem(itemId);
      var context = new RenderingContext();
      context.Rendering = new Rendering();
      context.Rendering.Item = contextItem;
      ContextService.Get().Push(context);
      //Act
      var list = eventsController.EventsList();
      //Assert      
      list.Should().BeOfType<ViewResult>();
    }

    [Theory]
    [AutoDbData]
    public void LatestEvents_ShouldReturnViewResult(Db db, string itemName, ID itemId, IEventsRepository repository)
    {
      //Arrange
      var eventsController = new EventsController(repository);
      db.Add(new DbItem(itemName, itemId, Templates.EventDetails.ID));
      var contextItem = db.GetItem(itemId);
      var context = new RenderingContext();
      context.Rendering = new Rendering();
      context.Rendering.Item = contextItem;
      ContextService.Get().Push(context);
      //Act
      var list = eventsController.LatestEvents();
      //Assert      
      list.Should().BeOfType<ViewResult>();
    }

    [Theory]
    [AutoDbData]
    public void EventsListWithFilter_ShouldReturnViewResult(Db db, string itemName, ID itemId, IEventsRepository repository)
    {
      //Arrange
      var eventsController = new EventsController(repository);
      db.Add(new DbItem(itemName, itemId, Templates.EventDetails.ID));
      var contextItem = db.GetItem(itemId);
      var context = new RenderingContext();
      context.Rendering = new Rendering();
      context.Rendering.Item = contextItem;
      ContextService.Get().Push(context);
      //Act
      var list = eventsController.EventsListWithFilter();
      //Assert      
      list.Should().BeOfType<ViewResult>();
    }
  }
}
