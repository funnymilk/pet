using System.Collections.Generic;

namespace JellyGarden.Scripts.Extentions.Analytics.Providers
{
    public class AppmetricaProvider : IAnalyticsProvider
    {
        public void SendEvent(string eventName)
        {
            AppMetrica.Instance.ReportEvent(eventName);
        }

        public void SendEvent(string eventName, Dictionary<string, object> param)
        {
            AppMetrica.Instance.ReportEvent(eventName, param);
        }

        public void SendEvent(string message, string json)
        {
            AppMetrica.Instance.ReportEvent(message, json);
        }

        public void ReportProfile(string key, int value)
        {
            var attribute = new YandexAppMetricaUserProfile().Apply(YandexAppMetricaAttribute.CustomNumber(key).WithValue(value));
            AppMetrica.Instance.ReportUserProfile(attribute);
        }

        public void ReportProfile(string key, float value)
        {
            var attribute = new YandexAppMetricaUserProfile().Apply(YandexAppMetricaAttribute.CustomNumber(key).WithValue(value));
            AppMetrica.Instance.ReportUserProfile(attribute);
        }

        public void ReportProfile(string key, bool value)
        {
            var attribute = new YandexAppMetricaUserProfile().Apply(YandexAppMetricaAttribute.CustomBoolean(key).WithValue(value));
            AppMetrica.Instance.ReportUserProfile(attribute);
        }

        public void ReportProfile(string key, string value)
        {
            var attribute = new YandexAppMetricaUserProfile().Apply(YandexAppMetricaAttribute.CustomString(key).WithValue(value));
            AppMetrica.Instance.ReportUserProfile(attribute);
        }

        public void IncrementProfile(string key, int value)
        {
            var attribute = new YandexAppMetricaUserProfile().Apply(YandexAppMetricaAttribute.CustomCounter(key).WithDelta(value));
            AppMetrica.Instance.ReportUserProfile(attribute);
        }
    }
}