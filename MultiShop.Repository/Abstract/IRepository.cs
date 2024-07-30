
namespace MultiShop.Repository
{
    public interface IRepository<TEntity> where TEntity : class // genelleştireceğimiz entitylerimiz birer class tır. (product, category...)
    {
        // bu interface te ve class ında tüm entity ler için ortak olan metodları tanımlıyoruz ve implemente ediyoruz.
        // ortak olmayan özel metodları ise abstract ve concrete klasörlerinde ayrı entity class lara tanımlı olacak.
        // genel olarak gerekli metodlar;
        List<TEntity> GetAll(); // tümünü getirme
        List<TEntity> GetAllAsNoTracking(); // listeleme yaptığımız için bir gözcünün entity yi izleyip değişikliği db ye haber vermesi gerekmiyor (fazla işi önlüyor).
        TEntity GetById(int id); // birini getirme (GetBtId<T>(T id) diyerek parametreyi de id veya guid tipinde geçerli olacak şekilde generic yapabiliriz.)
        bool Add(TEntity entity); // bir veri ekleme
        bool AddRange(List<TEntity> entities); // birden çok veri ekleme
        bool Update(TEntity entity);
        bool Delete(int id);
        bool DeleteRange(IEnumerable<TEntity> entities); // Ienumerable daha geniş kapsamlı, list Ienumerable içinde
        bool DeleteAll();
        bool Save();
    }
}
