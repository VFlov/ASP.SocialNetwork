using ASP.SocialNetwork.Models;
namespace ASP.SocialNetwork.Controllers.Repository
{
    public class MessageRepository : Repository<Message>
    {
        public MessageRepository(ApplicationDbContext db)
        : base(db)
        {

        }
    }
}
