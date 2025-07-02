﻿namespace be_asa_shared_localization.Localization
{
    public interface IJsonLocalizationService
    {
        string Get<TEnum>(TEnum key, params object[] args) where TEnum : Enum;
        string this[Enum key] { get; }
        string Get<TEnum>(string prefix, TEnum key, params object[] args) where TEnum : Enum;

    }
}
