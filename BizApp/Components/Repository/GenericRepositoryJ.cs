//using BizApp.Components.Model;
//using Microsoft.EntityFrameworkCore;
//using BizApp.Components.Repository.Interface;
//using JsonFlatFileDataStore;

//namespace BizApp.Components.Repository
//{
//    public class GenericRepositoryJ<TEntity> : IGenericRepositoryJson<TEntity> where TEntity : class
//    {
//        public virtual async Task<List<TEntity>> Get()
//        {
//            var store = new DataStore("data.json");
//            var collection = store.GetCollection<TEntity>();
//            return await Task.Run(() => collection.AsQueryable().ToList());

//        }

//        public async Task<TEntity?> Get(int id)
//        {
//            var store = new DataStore("data.json");
//            var collection = store.GetCollection<TEntity>();
//            var results = collection.AsQueryable().FirstOrDefault(e => e.ID == id);
//            return (TEntity?)results;

//        }

//        public bool Add(in TEntity sender)
//        {
//            try
//            {
//                var store = new DataStore("data.json");
//                var collection = store.GetCollection<TEntity>();
//                return collection.InsertOne(sender);
//            }
//            catch (Exception ex)
//            {
//                return false;
//            }
//        }

//        public bool Update(in TEntity sender)
//        {
//            try
//            {
//                var store = new DataStore("data.json");
//                var collection = store.GetCollection<TEntity>();
//                return collection.ReplaceOne(sender.ID, sender);
//            }
//            catch (Exception ex)
//            {
//                return false;
//            }
//        }

//        public bool Delete(in TEntity sender)
//        {
//            try
//            {
//                var store = new DataStore("data.json");
//                var collection = store.GetCollection<TEntity>();
//                collection.DeleteOneAsync(sender.ID);
//                return true;
//            }
//            catch
//            {
//                return false;
//            }
//        }

//    }
//}
