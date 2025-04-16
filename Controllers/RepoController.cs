using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RomRepo.api.Auth;
using RomRepo.api.DataAccess;
using System.IO;

namespace RomRepo.api.Controllers
{
    /// <summary>
    /// Handles operations for API information
    /// </summary>
    public class RepoController : Controller
    {
        private readonly ApiContext _context;


        /// <summary>Constructor</summary>
        public RepoController(ApiContext context)
        {
            _context = context;
        }

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
        /// Download the database file
        /// </summary>
        [Admin]
        [HttpGet("/download")]
        public ActionResult DownloadDb()
        {
            var filePath = _context.DbPath;
            if (System.IO.File.Exists(filePath))
            {
                using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                var fileBytes = new byte[fs.Length];
                fs.ReadExactly(fileBytes, 0, (int)fs.Length);
                return File(fileBytes, "application/octet-stream", "romrepo.api.db");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
