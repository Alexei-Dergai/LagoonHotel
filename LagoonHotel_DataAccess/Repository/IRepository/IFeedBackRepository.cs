using LagoonHotel_Models;

namespace LagoonHotel_DataAccess.Repository.IRepository
{
    public interface IFeedBackRepository : IRepository<Feedback>
    {
        void Update(Feedback obj);
    }
}
