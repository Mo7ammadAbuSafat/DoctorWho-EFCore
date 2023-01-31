using DoctorWho.Db.Models;
using DoctorWho.Db.Services;

namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository
    {
        private DoctorWhoCoreDbContext context;
        public CRUDoperaations<Companion> CRUD { get; set; }

        public CompanionRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;
            CRUD = new CRUDoperaations<Companion>(context);
        }

        public List<Companion> GetAllCompanions()
        {
            return context.companions.ToList();
        }

        public Companion? GetCompanionById(int id)
        {
            return context.companions.Find(id);
        }
    }
}
