using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RomRepo.api.DataAccess;
using System.Net;
using System.Web.Http;

namespace RomRepo.api.Auth
{
    /// <summary>
    /// Authorization filter for admin level API Key access
    /// </summary>
    public class AdminFilter : IAuthorizationFilter
    {
        private readonly IApiRepository _apiRepository;

        /// <summary>Constructor</summary>
        public AdminFilter(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }

        /// <inheritdoc/>
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var key = context.HttpContext.Request.Headers["x-api-key"].FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(key))
            {
                var keyObj = _apiRepository.GetApiKey(key).Result;

                if (keyObj?.Status == (int)ApiKeyStatus.Active && keyObj?.IsAdmin == true)
                {
                    return;
                }
                else
                {
                    context.Result = new UnauthorizedResult();
                }
            }
        }
    }

    /// <summary>
    /// Attribute to enforce admin-level API key authorization on controllers or actions.
    /// </summary>
    public class AdminAttribute : ServiceFilterAttribute
    {
        /// <summary>Constructor</summary>
        public AdminAttribute()
            : base(typeof(AdminFilter))
        {

        }
    }

}
