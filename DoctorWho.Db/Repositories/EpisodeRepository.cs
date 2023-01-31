using DoctorWho.Db.Models;
using DoctorWho.Db.Services;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository
    {
        private DoctorWhoCoreDbContext context;
        public CRUDoperaations<Episode> CRUD { get; set; }

        public EpisodeRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;
            CRUD = new CRUDoperaations<Episode>(context);
        }

        public List<Episode> GetAllEpisodes()
        {
            return context.episodes.ToList();
        }

        public Episode? GetEpisodeById(int id)
        {
            return context.episodes.Find(id);
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
