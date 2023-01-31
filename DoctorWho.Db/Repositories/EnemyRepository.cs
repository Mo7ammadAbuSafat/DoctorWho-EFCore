using DoctorWho.Db.Models;
using DoctorWho.Db.Services;

namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository
    {
        private DoctorWhoCoreDbContext context;
        public CRUDoperaations<Enemy> CRUD { get; set; }

        public EnemyRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;
            CRUD = new CRUDoperaations<Enemy>(context);
        }

        public List<Enemy> GetAllEnemies()
        {
            return context.enemys.ToList();
        }

        public Enemy? GetEnemyById(int id)
        {
            return context.enemys.Find(id);
        }



    }
}
