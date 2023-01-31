using DoctorWho.Db.Models;
using DoctorWho.Db.Services;

namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository
    {
        private DoctorWhoCoreDbContext context;
        public CRUDoperaations<Author> CRUD { get; set; }

        public AuthorRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;
            CRUD = new CRUDoperaations<Author>(context);
        }

        public List<Author> GetAllAuthors()
        {
            return context.authors.ToList();
        }

        public Author? GetAuthorById(int id)
        {
            return context.authors.Find(id);
        }
    }
}
