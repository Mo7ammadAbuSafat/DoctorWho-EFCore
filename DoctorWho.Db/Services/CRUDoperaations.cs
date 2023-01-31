namespace DoctorWho.Db.Services
{
    public class CRUDoperaations<T> where T : class
    {
        private DoctorWhoCoreDbContext context { get; set; }
        public CRUDoperaations(DoctorWhoCoreDbContext context)
        {
            this.context = context;
        }

        public void Add(T Item)
        {
            context.Add(Item);
            context.SaveChanges();
        }

        public void Update(T Item)
        {
            context.Update(Item);
            context.SaveChanges();
        }

        public void Delete(T Item)
        {
            context.Remove(Item);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var enemy = context.Set<T>().Find(Id);
            if (enemy != null)
            {
                Delete(enemy);
            }
        }
    }
}
