using BizApp.Components.Model;

namespace BizApp.Components.Repository.Interface
{
    public interface IStudentJson
    {
        public Task<List<Student>> Get();
        public Task<Student?> Get(int id);
        public bool Delete(Student S);
        public bool Update(Student S);
        public bool Add(Student S);
    }
}
