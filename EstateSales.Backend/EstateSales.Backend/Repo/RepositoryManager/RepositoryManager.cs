namespace EstateSales.Backend.Repo.RepositoryManager
{
    public class RepositoryManager:IRepositoryManager
    {
        private IUserRepo? _userRepo;
        public RepositoryManager(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public IUserRepo? UserRepo => _userRepo;
    }
}
