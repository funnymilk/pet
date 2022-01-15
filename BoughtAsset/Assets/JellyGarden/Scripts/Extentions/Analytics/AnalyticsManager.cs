using System.Collections.Generic;
using JellyGarden.Scripts.Extentions.Analytics.Providers;

namespace JellyGarden.Scripts.Extentions.Analytics
{
    public class AnalyticsManager : Singleton<AnalyticsManager>, IAnalyticsProvider
    {
        private List<IAnalyticsProvider> _providers;
        protected override void Initialization()
        {
            base.Initialization();
            _providers = new List<IAnalyticsProvider>
            {
                new AppmetricaProvider()
            };
        }

        public void SendEvent(string eventName)
        {
            foreach (var p in _providers)
                p.SendEvent(eventName);
        }

        public void SendEvent(string eventName, Dictionary<string, object> param)
        {
            foreach (var p in _providers)
                p.SendEvent(eventName, param);
        }

        public void SendEvent(string message, string json)
        {
            foreach (var p in _providers)
                p.SendEvent(message, json);
        }

        public void ReportProfile(string key, int value)
        {
            foreach (var p in _providers)
                p.ReportProfile(key, value);
        }

        public void ReportProfile(string key, float value)
        {
            foreach (var p in _providers)
                p.ReportProfile(key, value);
        }

        public void ReportProfile(string key, bool value)
        {
            foreach (var p in _providers)
                p.ReportProfile(key, value);
        }

        public void ReportProfile(string key, string value)
        {
            foreach (var p in _providers)
                p.ReportProfile(key, value);
        }

        public void IncrementProfile(string key, int value)
        {
            foreach (var p in _providers)
                p.IncrementProfile(key, value);
        }
    }
}