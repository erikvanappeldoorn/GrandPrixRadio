namespace GrandPrixRadio.Services;

interface IStorageService
{
    void Clear();
    T LoadSetting<T>(string key, T defaultValue);
    void RemoveSetting(string key);
    void SaveSetting<T>(string key, T value);
}