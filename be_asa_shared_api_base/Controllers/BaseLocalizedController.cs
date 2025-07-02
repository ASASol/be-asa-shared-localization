﻿using be_asa_shared_localization.Localization;
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

        protected IActionResult CustomLocalizedResult<TEnum>
            (
                TEnum key, 
                object? data = null, 
                HttpStatusCode code = HttpStatusCode.OK
            ) where TEnum : Enum
        {
            var message = _localizer.Get(key);
            return CustomResult(message, data, code);
        }
        protected IActionResult CustomLocalizedResult<TEnum>
            (
                string prefix, 
                TEnum key, 
                object? data = null, 
                HttpStatusCode code = HttpStatusCode.OK
            ) where TEnum : Enum
        {
            var message = _localizer.Get(prefix, key);
            return CustomResult(message, data, code);
        }

    }
}
