namespace Sitecore.Feature.Events.Indexing
{
  using Sitecore.ContentSearch.SearchTypes;
  using Sitecore.Data;
  using Sitecore.Foundation.Indexing.Infrastructure;
  using Sitecore.Foundation.Indexing.Models;
  using Sitecore.Foundation.SitecoreExtensions.Repositories;
  using Sitecore.Web.UI.WebControls;
  using System;
  using System.Collections.Generic;
  using System.Linq.Expressions;

  public class EventsIndexContentProvider : IndexContentProviderBase
  {
    public override string ContentType => DictionaryRepository.Get("/events/search/contenttype", "Events");

    public override IEnumerable<ID> SupportedTemplates => new[]
    {
      Templates.EventDetails.ID
    };

    public override Expression<Func<SearchResultItem, bool>> GetQueryPredicate(IQuery query)
    {
      var fieldNames = new[]
      {
        Templates.EventDetails.Fields.Date_FieldName
      };
      return this.GetFreeTextPredicate(fieldNames, query);
    }

    public override void FormatResult(SearchResultItem item, ISearchResult formattedResult)
    {
      var contentItem = item.GetItem();
      formattedResult.Title = FieldRenderer.Render(contentItem, Templates.EventDetails.Fields.Title.ToString());
      formattedResult.Description = FieldRenderer.Render(contentItem, Templates.EventDetails.Fields.Summary.ToString());
    }
  }
}