using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCVCore.ViewModels
{
    public class PortforlioViewModel
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile File { get; set; }
    }
}
