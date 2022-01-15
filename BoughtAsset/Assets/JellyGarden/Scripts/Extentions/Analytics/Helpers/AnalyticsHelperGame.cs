using System.Collections.Generic;

namespace JellyGarden.Scripts.Extentions.Analytics.Helpers
{
    public static partial class AnalyticsHelper
    {
        public static class Game
        {
            public static void level_start(int level)
            {
                AnalyticsManager.Instance.SendEvent("level_start", new Dictionary<string, object>
                {
                    {"number", level}
                });
            }
            
            public static void level_complete(int level)
            {
                AnalyticsManager.Instance.SendEvent("level_complete", new Dictionary<string, object>
                {
                    {"number", level}
                });
            }
        }
    }
}