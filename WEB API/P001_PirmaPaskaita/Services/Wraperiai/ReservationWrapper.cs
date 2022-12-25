using System.Net;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO.BookDTO;
using WebAppMSSQL.Models.DTO.ReservationsDTO;
using WebAppMSSQL.Models.Enums;
using WebAppMSSQL.Models.ReservationsDTO;
using WebAppMSSQL.Services.IServices;

namespace WebAppMSSQL.Services.Wraperiai
{
    public class ReservationWrapper : IReservationWrapper
    {
        public ReservationWrapper() { }


        //public Reservation Bind(ReturnReservationDTO returnReservationDto)
        //{
        //    return new Reservation
        //    {
        //        ActualReturnDate = returnReservationDto.ActualReturnDate, //useriui grazinant reiktu kad isivestu data auto data now
        //        LocalUserId = returnReservationDto.LocalUserId,
        //        BookId = returnReservationDto.BookId,
        //        Active = false,
        //    };
        //}


        public GetReservationResponse Bind(Reservation reservation)
        {
            return new GetReservationResponse
            {
                LocalUser = reservation.LocalUser,
                Book = reservation.Book,
            };
        }


        public Reservation Bind(CreateReservationDTO request)
        {
            return new Reservation
            {
                BorrowDate = request.BorrowDate,
                ReturnDate = request.BorrowDate.AddDays(28), //magic number
                LocalUserId = request.LocalUserId,
                BookId = request.BookId,
                Active = true,
            };
        }


        public CreateReservationResponse Bind(Book book)
        {
            return new CreateReservationResponse
            {
                BookName = book.Title,
                HandlingFinnishDateTime = DateTime.Now.AddMinutes(5), //magic numbers
                State = "Vykdoma rezervacija..",

            };
        }




    }
}