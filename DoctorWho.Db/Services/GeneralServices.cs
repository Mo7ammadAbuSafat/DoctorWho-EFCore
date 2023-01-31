using DoctorWho.Db.Models;

namespace DoctorWho.Db.Services
{
    public class GeneralServices
    {
        private DoctorWhoCoreDbContext context;

        public GeneralServices(DoctorWhoCoreDbContext context)
        {
            this.context = context;
        }

        public List<Doctor> GetAllDoctors()
        {
            return context.doctors.ToList();
        }

        public Enemy? GetEnemyById(int id)
        {
            return context.enemys.Find(id);
        }

        public Companion? GetCompanionById(int id)
        {
            return context.companions.Find(id);
        }

        public void AddEnemyToEpisode(Enemy enemy, Episode episode)
        {
            AddEnemyToEpisode(enemy.Id, episode.Id);
        }

        public void AddEnemyToEpisode(int enemyId, int episodeId)
        {
            if (context.enemys.Find(enemyId) != null && context.episodes.Find(episodeId) != null)
            {
                context.Set<EnemyEpisode>().Add(new EnemyEpisode()
                {
                    EnemyId = enemyId,
                    EpisodeId = episodeId
                });
                context.SaveChanges();
            }

        }

        public void AddCompanionToEpisode(Companion companion, Episode episode)
        {
            AddCompanionToEpisode(companion.Id, episode.Id);
        }

        public void AddCompanionToEpisode(int companionId, int episodeId)
        {
            if (context.companions.Find(companionId) != null && context.episodes.Find(episodeId) != null)
            {
                context.Set<CompanionEpisode>().Add(new CompanionEpisode()
                {
                    CompanionId = companionId,
                    EpisodeId = episodeId
                });
                context.SaveChanges();
            }
        }


    }
}
