using Microsoft.AspNetCore.Http;
using System;

namespace dotnet_ocr_tesseract
{
    public class OcrModel
    {
        public String DestinationLanguage { get; set; }
        public IFormFile Image { get; set; }
    }

}
