using System.Collections.Generic;

namespace JellyGarden.Scripts.Extentions.Analytics.Helpers
{
    public static partial class AnalyticsHelper
    {
        public static class Shop
        {
            public static void buy_complete(string id, double cost)
            {
                AnalyticsManager.Instance.SendEvent("buy_complete", new Dictionary<string, object>
                {
                    {"item", id},
                    {"cost", cost},
                });
            }
        }
    }
}