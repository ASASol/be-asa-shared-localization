using System.Text.Json.Serialization;

namespace be_asa_shared_localization.Localization
{
    public class LocalizationConfig
    {
        [JsonPropertyName("defaultLanguage")]
        public string DefaultLanguage { get; set; } = "vi";

        [JsonPropertyName("supportedLanguages")]
        public List<string> SupportedLanguages { get; set; } = ["vi"];
    }
}
