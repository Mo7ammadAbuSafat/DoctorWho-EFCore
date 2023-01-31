using DoctorWho.Db;
using DoctorWho.Db.Services;

using (var context = new DoctorWhoCoreDbContext())
{
    var service = new GeneralServices(context);

    service.AddEnemyToEpisode(4, 1);

}