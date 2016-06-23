using System.Collections.Generic;

namespace Sitecore.Feature.Events.Repositories
{
  using Sitecore.Data;
  using Sitecore.Foundation.Indexing.Models;
  using Sitecore.Foundation.Indexing.Repositories;

  public class SearchSettingsRepository : SearchSettingsRepositoryBase
  {
    public override ISearchSettings Get()
    {
      var settings = new SearchSettingsBase();
      settings.Templates = new List<ID>
      {
        Templates.EventDetails.ID
      };

      return settings;
    }
  }
}