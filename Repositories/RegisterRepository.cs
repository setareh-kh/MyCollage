using MyCollage_EF_Rep_AsyncAwait.Models;

namespace MyCollage_EF_Rep_AsyncAwait.Repositories
{
    public class RegisterRepository
    {
        private readonly MyDbContext _mycontext;
        public RegisterRepository(MyDbContext myDbContext)
        {
            _mycontext=myDbContext;
        }
        
    }
}