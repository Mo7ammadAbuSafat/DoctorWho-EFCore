using DoctorWho.Db.Models;
using DoctorWho.Db.Services;

namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository
    {
        private DoctorWhoCoreDbContext context;
        public CRUDoperaations<Doctor> CRUD { get; set; }

        public DoctorRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;
            CRUD = new CRUDoperaations<Doctor>(context);
        }

        public List<Doctor> GetAllDoctors()
        {
            return context.doctors.ToList();
        }

        public Doctor? GetDoctorById(int id)
        {
            return context.doctors.Find(id);
        }
    }
}
