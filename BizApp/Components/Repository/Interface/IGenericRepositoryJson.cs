namespace BizApp.Components.Repository.Interface
{
    public interface IGenericRepositoryJson<T> where T : class
    {
        public Task<List<T>> Get();
        public Task<T?> Get(int id);
        public bool Update(in T sender);
        public bool Add(in T sender);
        public bool Delete(in T sender);
    }
}
