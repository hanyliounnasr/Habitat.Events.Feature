namespace Sitecore.Feature.Events
{
  using Sitecore.Data;

  public struct Templates
  {
    public struct EventDetails
    {
      public static ID ID = new ID("{8B664D8C-3538-457E-A786-9F8BB87E49AD}");

      public struct Fields
      {
        public static readonly ID Title = new ID("{5B99D867-4EF0-44BB-927C-E15024889C23}");
        public const string Title_FieldName = "EventsTitle";

        public static readonly ID Date = new ID("{FB768B1D-C730-4DEE-8DA3-BA40366CE745}");
        public const string Date_FieldName = "EventsDate";

        public static readonly ID Image = new ID("{DDC68006-90AC-454B-9D9B-5FC5640D1E19}");

        public static readonly ID Summary = new ID("{8C2092F0-9FBE-4606-B54A-5970298DC315}");
        public const string Summary_FieldName = "EventsSummary";

        public static readonly ID Details = new ID("{627B845E-B671-4CC7-93BB-475D302A374E}");
      }
    }
  }
}