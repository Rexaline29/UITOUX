using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class MVCImageModel
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public byte[] Files { get; set; }
    }
}