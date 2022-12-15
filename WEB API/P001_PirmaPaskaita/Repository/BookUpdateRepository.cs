using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebAppMSSQL.Data;
using WebAppMSSQL.Models;
using WebAppMSSQL.Repository.IRepository;

namespace WebAppMSSQL.Repository
{
    public class BookUpdateRepository : Repository<Book>, IUpdateBookRepository
    {
        private readonly KnygynasContext _db;

        public BookUpdateRepository(KnygynasContext db) : base(db)
        {
            _db = db;
        }





    }
}