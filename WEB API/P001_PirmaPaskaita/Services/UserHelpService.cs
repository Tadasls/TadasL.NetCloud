using L05_Tasks_MSSQL.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppMSSQL.Data;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO.BookDTO;
using WebAppMSSQL.Models.ReservationsDTO;
using WebAppMSSQL.Repository;
using WebAppMSSQL.Repository.IRepository;
using WebAppMSSQL.Services.IServices;

namespace WebAppMSSQL.Services
{
    public class UserHelpService : IUserHelpService
    {
     
        private readonly IUpdateBookRepository _bookRepo;
        private readonly IBookWrapper _bookWrapper;
        private readonly ILogger<KnygynasController> _logger;
      

        public UserHelpService(IUpdateBookRepository bookRepo, IBookWrapper bookWrapper, ILogger<KnygynasController> logger)
        {
            
            _bookRepo = bookRepo;
            _bookWrapper = bookWrapper;
            _logger = logger;

        }


        public async Task<GetBookDto> GetFavoriteAutorsForUser(int id, List<Reservation>visosUserioRezervacijos)
        {
            List<GetBookDto>? favoriteBooks = new List<GetBookDto>();
            foreach (var item in visosUserioRezervacijos)
            {
                GetBookDto useriopMegstamaKnyga = _bookWrapper.Bind(await _bookRepo.GetAsync(a => a.Id == id));
                favoriteBooks.Add(useriopMegstamaKnyga);
            }
            var mostFavoriteBook = favoriteBooks.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();

            return mostFavoriteBook;
        }













    }
}
