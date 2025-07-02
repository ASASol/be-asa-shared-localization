using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System.Text.Json;

namespace be_asa_shared_localization.Localization
{
    public class JsonLocalizationService : IJsonLocalizationService
    {
        private readonly IHostEnvironment _env;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly Dictionary<string, Dictionary<string, string>> _localizationCache = new();

        public JsonLocalizationService(IHostEnvironment env, IHttpContextAccessor httpContextAccessor)
        {
            _env = env;
            _httpContextAccessor = httpContextAccessor;
            LoadAllLanguages();
        }

        public string this[Enum key] => Get(key);

        public string Get<TEnum>(TEnum key, params object[] args) where TEnum : Enum
            => Get((Enum)(object)key, args);

        private string Get(Enum key, params object[] args)
        {
            var culture = GetRequestCulture();
            var stringKey = key.ToString();

            if (_localizationCache.TryGetValue(culture, out var dict) &&
                dict.TryGetValue(stringKey, out var value))
            {
                return string.Format(value, args);
            }

            return stringKey; // fallback
        }

        private string GetRequestCulture()
        {
            var culture = _httpContextAccessor.HttpContext?.Request.Headers["Accept-Language"].ToString();
            return string.IsNullOrWhiteSpace(culture) ? "vi" : culture.Split(',')[0].Trim().ToLower();
        }

        private void LoadAllLanguages()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "Resources", "i18n");
            if (!Directory.Exists(path)) return;

            foreach (var file in Directory.GetFiles(path, "*.json"))
            {
                var culture = Path.GetFileNameWithoutExtension(file).ToLower();
                var json = File.ReadAllText(file);
                var dict = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
                if (dict != null)
                {
                    _localizationCache[culture] = dict;
                }
            }
        }
    }
}
