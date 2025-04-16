using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RomRepo.api.Auth;
using RomRepo.api.DataAccess;

namespace RomRepo.api.Controllers
{
    /// <summary>
    /// Handles operations for API information
    /// </summary>
    public class RepoController : Controller
    {
        /// <summary>
        /// Get the current version of the API
        /// </summary>
        [HttpGet("/version")]
        public string GetVersion()
        {
            try
            {
                return GetType().Assembly.GetName().Version.ToString();
            }
            catch
            {
                return "unknown";
            }
        }

        /// <summary>
        /// Debug info for sysadmin
        /// </summary>
        [Admin]
        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpGet("/dbpath")]
        public ActionResult<string> GetDbPath()
        {
            return StatusCode(501);
            //return _context.DbPath;
        }
    }
}
