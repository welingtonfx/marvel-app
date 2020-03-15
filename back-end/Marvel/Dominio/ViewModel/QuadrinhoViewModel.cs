using Dominio.Model.Quadrinhos;

namespace Dominio.ViewModel
{
    public class QuadrinhoViewModel
    {
        public int id { get; set; }
        public int digitalId { get; set; }
        public string title { get; set; }
        public int issueNumber { get; set; }
        public string variantDescription { get; set; }
        public string description { get; set; }
        public object modified { get; set; }
        public string isbn { get; set; }
        public string upc { get; set; }
        public string diamondCode { get; set; }
        public string ean { get; set; }
        public string issn { get; set; }
        public string format { get; set; }
        public int pageCount { get; set; }
        public string resourceURI { get; set; }

        public static explicit operator QuadrinhoViewModel(ResultQuadrinhos quadrinhos)
        {
            return new QuadrinhoViewModel
            {
                id = quadrinhos.id,
                digitalId = quadrinhos.digitalId,
                title = quadrinhos.title,
                issueNumber = quadrinhos.issueNumber,
                variantDescription = quadrinhos.variantDescription,
                description = quadrinhos.description,
                modified = quadrinhos.modified,
                isbn = quadrinhos.isbn,
                upc = quadrinhos.upc,
                diamondCode = quadrinhos.diamondCode,
                ean = quadrinhos.ean,
                issn = quadrinhos.issn,
                format = quadrinhos.format,
                pageCount = quadrinhos.pageCount,
                resourceURI = quadrinhos.resourceURI
            };
        }
    }
}
