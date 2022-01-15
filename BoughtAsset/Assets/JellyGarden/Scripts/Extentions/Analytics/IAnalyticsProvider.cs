using System.Collections.Generic;

namespace JellyGarden.Scripts.Extentions.Analytics
{
    public interface IAnalyticsProvider
    {
        void SendEvent(string eventName);
        void SendEvent(string eventName, Dictionary<string, object> param);
        void SendEvent(string message, string json);
        void ReportProfile(string key, int value);
        void ReportProfile(string key, float value);
        void ReportProfile(string key, bool value);
        void ReportProfile(string key, string value);
        void IncrementProfile(string key, int value);
    }
}