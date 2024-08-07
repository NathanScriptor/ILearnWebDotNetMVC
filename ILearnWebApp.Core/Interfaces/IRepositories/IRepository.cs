namespace ILearnWebApp.Domain.Interfaces.IRepositories
{
    public interface IRepository <T> where T : class
    {
        IQueryable<T> Entities { get; }
        T GetById(string id);
        Task<T> GetByIdAsync(string id);
        List<T> GetAll();
        Task<List<T>> GetAllAsync();
        void Add (T entity);
        Task AddAsync (T entity);
        void AddRange(List<T> obj);
        Task AddRangeAsync(List<T> obj);
        void Update (T entity);
        Task UpdateAsync (T entity);
        void Delete (string id);
        Task DeleteAsync (string id);
        void Save();
        Task SaveAsync();

    }
}
