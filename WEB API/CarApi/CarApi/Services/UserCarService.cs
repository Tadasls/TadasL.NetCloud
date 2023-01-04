using CarApi.Controllers;
using CarApi.Models;
using CarApi.Models.Dto;
using CarApi.Repositories.Interfaces;
using System.Collections.Generic;

namespace CarApi.Services
{
    public class UserCarService : IUserCarService 
    {
        private readonly IUserRepository _userRepository;


        public UserCarService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public GetUserCarResponse BuildCarResponse(int userId, IEnumerable<Car>? cars)
        {

            //var user = _userRepository.Get(userId);

            //var vardas = user.UserIdentity.Vardas;
            //var pavarde = user.UserIdentity.Pavarde;
            //var asmensKodas = user.UserIdentity.AsmensKodas;


            //return new GetUserCarResponse()
            //{
            //    Vardas = vardas,
            //    Pavarde = pavarde,
            //    AsmensKodas = asmensKodas,
            //    Automobiliai = cars.Select(c => new GetUserCarResponseCar(c)).ToList(),
            //};
            throw new NotImplementedException();
        }


    }
}
