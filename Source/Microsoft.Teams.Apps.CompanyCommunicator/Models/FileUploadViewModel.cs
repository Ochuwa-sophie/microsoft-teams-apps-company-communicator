﻿using Microsoft.AspNetCore.Http;
using Microsoft.Teams.Apps.CompanyCommunicator.Models;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.Teams.Apps.CompanyCommunicator.ViewModels
{
    public class FileUploadViewModel: NewResourceInformation
    {
        [Required]
        public IFormFile File { get; set; }
    }
}
