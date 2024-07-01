using LagoonHotel_DataAccess.Data;
using LagoonHotel_DataAccess.Repository.IRepository;
using LagoonHotel_Models;
using System.Linq;

namespace LagoonHotel_DataAccess.Repository
{
    public class FeedbackRepository : Repository<Feedback>, IFeedBackRepository
    {
        private readonly ApplicationDbContext _db;

        public FeedbackRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Feedback obj)
        {
            var objFromDb = _db.Feedback.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
            }
        }
    }
}
