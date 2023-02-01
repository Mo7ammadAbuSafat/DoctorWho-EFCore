using DoctorWho.Db;
using DoctorWho.Db.Services;

var context = new DoctorWhoCoreDbContext();

GeneralServices m = new GeneralServices(context);

m.CallSPSammarizeEpisodes();








