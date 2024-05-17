namespace OCR_TESSERACT.WEBAPI.Models
{
    public class OcrModel
    {
        public string? DestinationLanguage { get; set; }
        public IFormFile? Image { get; set; }
    }
}
