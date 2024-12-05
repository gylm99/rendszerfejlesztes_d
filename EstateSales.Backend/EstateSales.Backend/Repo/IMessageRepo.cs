using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo.Base;
using EstateSales.Backend.Responses;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EstateSales.Backend.Repo
{
    public interface IMessageRepo : IBaseRepo<Message>
    {

        Task<List<Message>> GetMessagesByUserIdAsync(Guid userId);

    }
}
