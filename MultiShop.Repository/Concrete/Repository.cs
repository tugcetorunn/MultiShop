
namespace MultiShop.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //repository deki tüm yapıların async yapılması gerek.
        protected readonly MultiShopContext context;
        // context.Set<TEntity>() her metotta tekrar ettiği için bunu bir değişken haline getirelim; 
        // context.Set<TEntity>() mouse la üstüne geldiğmizde DbSet<TEntity> ye karşılık geldiğini görüyoruz.
        private readonly DbSet<TEntity> dbSet;
        public Repository(MultiShopContext _context)
        {
            context = _context;
            dbSet = context.Set<TEntity>();
        }
        
        public List<TEntity> GetAll()
        {
            // context.Set<TEntity>() equals DbSet<Category, Product...>
            return dbSet.ToList();
        }
        public List<TEntity> GetAllAsNoTracking()
        {
            return dbSet.AsNoTracking().ToList(); // asNoTracking metodu entity lerin state lerini takip etmeyi devre dışı bırakır.
        }
        public TEntity GetById(int id)
        {
            return dbSet.Find(id); // find metodu "primary key" e göre arama bulma yapar.
        }
        public bool Add(TEntity entity)
        {
            dbSet.Add(entity);
            return Save();
        }
        public bool AddRange(List<TEntity> entities)
        {
            dbSet.AddRange(entities);
            return Save();
        }
        public bool Delete(int id)
        {
            TEntity entity = GetById(id);

            if (entity != null)
            {
                dbSet.Remove(entity);
                return Save();
            }
            return false;

        }
        public bool DeleteAll()
        {
            dbSet.RemoveRange(GetAll());
            return Save();
        }
        public bool DeleteRange(IEnumerable<TEntity> entities)
        {
            dbSet.RemoveRange(entities);
            return Save();
        }
        public bool Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified; // entity durumunu düzenlenmiş yaptık. uyarlama kısmına tekra dönülecek.
            return Save();
        }
        public bool Save()
        {
            return context.SaveChanges() > 0 ? true : false;
        }        
    }
}
