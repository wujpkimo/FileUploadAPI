using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileUploadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        [HttpPost("File")]
        public string UploadFile([FromForm]IFormFile file)
        {
            return $"got file: {file.FileName}";
        }

        [HttpPost("Files")]
        public string UploadFiles([FromForm]ICollection<IFormFile> files)
        {
            return $"got {files.Count} files";
        }

        [HttpPost("CreateProfile2")]
        public string CreateProfile([FromForm]ProfileData profile)
        {
            return $"get avatar:{profile.Avatar.FileName}, name:{profile.Name}, phone:{profile.Phone}";
        }
    }

    public class ProfileData
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public IFormFile Avatar { get; set; }
    }
}