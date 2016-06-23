using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.Events.Models
{
  public class EventItems
  {
    //Events List
    public IEnumerable<Item> Items { get; set; }

    //Events List Year Filter
    public int Year { get; set; }

    //Events List Month Filter
    public int Month { get; set; }
  }
}