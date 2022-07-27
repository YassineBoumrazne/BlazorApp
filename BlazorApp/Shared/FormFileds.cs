using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared
{
    public class FormFields
    {
        [Required]
        public string Field1 { get; set; }

        [Required]
        public string Field2 { get; set; }

        [Required]
        public DateOnly? Field3 { get; set; }

        [Required]
        public int Field4 { get; set; }

        [Required]
        public string Field5 { get; set; }

        [Required]
        public string Field6 { get; set; }

        [Required]
        public int Field7 { get; set; }

        [Required]
        public int Field8 { get; set; }

        [Required]
        public int Field9 { get; set; }

        [Required]
        public int Field10 { get; set; }

        [Required]
        public string Field11 { get; set; }
        
        [Required]
        public byte[] FileContent { get; set; }
        
        [Required]
        public string FileName { get; set; }
    }
}
