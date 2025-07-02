using be_asa_shared_localization.Enums;

namespace be_asa_shared_localization.Localization
{
    public interface IJsonLocalizationService
    {
        string this[LocalizationKey key] { get; }
        string Get(LocalizationKey key, params object[] args);
    }
}
