using CarApi.Models.Dto;
using CarApi.Models;
using CarApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using CarApi.Services;
using CarApi.Repositories;

namespace CarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserIdentityController : ControllerBase
    {
        private readonly UserIdentityRepository _userIdentityRepository;
    
        public UserIdentityController(UserIdentityRepository userIdentityRepository)
        {
            _userIdentityRepository = userIdentityRepository;
 
        }



   


    }
}
