using EstateSales.Backend.Context;
using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo.Base;

namespace EstateSales.Backend.Repo
{
    public class MessageRepo<TbContext> : BaseRepo<TbContext, Message>, IMessageRepo where TbContext : EstateContext
    {
        public MessageRepo(TbContext? dbContext) : base(dbContext)
        {
        }
    }
}
