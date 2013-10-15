using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ImageHoster.Models
{
    
    public class ImageInformation
    {
        [Key]
        public int ImageInformationId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public int ImageDataId { get; set; }
    }
    
    public class ImageData
    {
        public int ImageDataId { get; set; }
        public byte Image { get; set; }
    }
}