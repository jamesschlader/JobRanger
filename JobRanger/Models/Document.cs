using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JobRanger.Models
{
    public class Document
    {
        public int Id { get; set; }

        [Display(Name="File Name")]
        public string Name { get; set; }

        public byte[] RawContent { get; set; }
        
        public string Content { get; set; }

        [Display(Name = "Document Size (bytes)")]
        [DisplayFormat(DataFormatString = "{0:N1}")]
        public long ContentSize { get; set; }

        [Display(Name = "Uploaded (UTC)")]
        [DisplayFormat(DataFormatString = "{0:F}")]
        public DateTime UploadDT { get; set; }
    }
}
