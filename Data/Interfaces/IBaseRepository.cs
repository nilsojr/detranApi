using System.Threading.Tasks;

namespace DetranApp.Data.Interfaces
{
    public interface IBaseRepository
    {
         T Create<T>(T obj);
         bool Delete<T>(T obj);
         T Update<T>(T obj);
         Task<bool> SaveAllAsynsc();         
    }
}