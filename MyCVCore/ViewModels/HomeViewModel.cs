using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCVCore.ViewModels
{
    public class HomeViewModel
    {
        public Owner Owner { get; set; }
        public List<Projects> Projects { get; set; }
    }
}
