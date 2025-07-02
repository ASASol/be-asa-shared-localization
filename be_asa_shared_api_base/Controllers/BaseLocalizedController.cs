using be_asa_shared_localization.Localization;
using CoreApiResponse;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace be_asa_shared_api_base.Controllers
{
    public class BaseLocalizedController : BaseController
    {
        private readonly IJsonLocalizationService _localizer;

        public BaseLocalizedController(IJsonLocalizationService localizer)
        {
            _localizer = localizer;
        }

        protected IActionResult CustomLocalizedResult(string key, object? data = null, HttpStatusCode code = HttpStatusCode.OK)
        {
            var message = _localizer[key];
            return CustomResult(message, data, code);
        }
    }
}
