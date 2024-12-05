using EstateSales.Backend.Context;
using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo.Base;
using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.Repo
{
    public class MessageRepo<TbContext> : BaseRepo<TbContext, Message>, IMessageRepo where TbContext : EstateContext
    {
        public MessageRepo(TbContext? dbContext) : base(dbContext)
        {
          
        }

        public async Task<List<Message>> MessagesByUser()
        {
            return await _dbSet!.SelectAll().Include(x=>x.User).ToListAsync();
        }

        public async Task<List<Message>> GetMessagesByUserIdAsync(Guid userId)
        {
            //List<Message> result = await _dbSet!.ToListAsync();
            return await _dbSet!
                .Where(m => m.UserId == userId)
                .Include(m => m.User)
                .ToListAsync();
        }
    }



}
