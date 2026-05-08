using Acervo.Domain.Exceptions;

namespace Acervo.Domain.Entities
{
    public class Book
    {
        public long Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int PagesNumber { get; set; }
        public DateTime Release { get; set; }
        public long CategoryId { get; set; } 
        public Category Category { get; set; }

        protected Book() { }

        public Book(string title, string description, string author, DateTime release, int pagesNumber)
        {
            RulesValidations(title, description, pagesNumber);

            Title = title;
            Description = description;
            Author = author;
            Release = release;
            PagesNumber = pagesNumber;
        }

        public void Update(string title, string description, string author, DateTime release, int pagesNumber)
        {
            RulesValidations(title, description, pagesNumber);

            Title = title;
            Description = description;
            Author = author;
            Release = release;
            PagesNumber = pagesNumber;
        }

        private void RulesValidations(string title, string description, int pagesNumber)
        {
            string Message = string.Empty;

            if (string.IsNullOrEmpty(title))
            {
                Message += "O Título deve ser preenchido. \n";
            }

            if (string.IsNullOrEmpty(description))
            {
                Message += "A Descrição deve ser preenchida. \n";
            }

            if(pagesNumber <= 0)
            {
                Message += "A quantidade de páginas deve ser maior que 0. \n";
            }

            if (string.IsNullOrEmpty(Message))
            {
                throw new DomainException(Message);
            }
        }
    }
}
