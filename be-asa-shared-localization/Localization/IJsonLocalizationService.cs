namespace be_asa_shared_localization.Localization
{
    public interface IJsonLocalizationService
    {
        string this[string key] { get; }
        string Get(string key, params object[] args);
    }
}
