using System.Threading.Tasks;
using DetranApp.Data.Interfaces;

namespace DetranApp.Data.Impl
{
    public class CondutorRepository : ICondutorRepository
    {
        public T Create<T>(T obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete<T>(T obj)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveAllAsynsc()
        {
            throw new System.NotImplementedException();
        }

        public T Update<T>(T obj)
        {
            throw new System.NotImplementedException();
        }
    }
}