using EntityFrameworkCore.Repository.Repository;
using marketplace_v4.Data;
using marketplace_v4.Interfaces.Repository;
using marketplace_v4.Models;

namespace marketplace_v4.Repository
{
    public class CategoriaRepository : CommonRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(APIDbContext context) : base(context)
        {
        }
    }
}
