using Newtonsoft.Json;
using Windows.Storage;

namespace GrandPrixRadio.Services;

internal class StorageService : IStorageService
{
        public void SaveSetting<T>(string key, T value)
        {
            var localSettings = ApplicationData.Current.LocalSettings;
            localSettings.Values[key] = JsonConvert.SerializeObject(value);
        }

        public T LoadSetting<T>(string key, T defaultValue)
        {
            var localSettings = ApplicationData.Current.LocalSettings;
            if (localSettings.Values.ContainsKey(key))
                return JsonConvert.DeserializeObject<T>(((string)localSettings.Values[key]));
            return defaultValue;
        }

        public void RemoveSetting(string key)
        {
            var localSettings = ApplicationData.Current.LocalSettings;
            if (localSettings.Values.ContainsKey(key))
                localSettings.Values.Remove((key));
        }

        public void Clear()
        {
            ApplicationData.Current.LocalSettings.Values.Clear();
        }
    }
