using BizApp.Components.Model;
using Microsoft.EntityFrameworkCore;
using BizApp.Components.Repository.Interface;
using Radzen;
using JsonFlatFileDataStore;
using System.Reflection;
namespace BizApp.Components.Repository
{
    public class GenericRepositoryJson : IStudentJson
    {
        public virtual async Task<List<Student>> Get()
        {

            var store = new DataStore("data.json");
            var collection = store.GetCollection<Student>();
            return await Task.Run(() => collection.AsQueryable().ToList());

        }

        public async Task<Student?> Get(int id)
        {
            var store = new DataStore("data.json");
            var collection = store.GetCollection<Student>();
            var results = collection.AsQueryable().FirstOrDefault(e => e.ID == id);
            return (Student?)results;
        }
        public bool Delete(Student del)
        {
            try
            {
                var store = new DataStore("data.json");
                var collection = store.GetCollection<Student>();
                collection.DeleteOneAsync(del.ID);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Student up)
        {
            try
            {
                var store = new DataStore("data.json");
                var collection = store.GetCollection<Student>();
                return collection.ReplaceOne(up.ID, up);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Add(Student ad)
        {
            try
            {
                var store = new DataStore("data.json");
                var collection = store.GetCollection<Student>();
                return collection.InsertOne(ad);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
