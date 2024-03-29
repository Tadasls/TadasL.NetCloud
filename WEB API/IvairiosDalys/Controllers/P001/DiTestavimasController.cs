﻿using ApiMokymai.Interfaces.Kiti;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMokymai.Controllers.P001
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiTestavimasController : ControllerBase
    {
        private readonly IMyOperationTransient _operationTransient;
        private readonly IMyOperationScoped _operationScoped;
        private readonly IMyOperationSingleton _operationSingleton;

        public DiTestavimasController(IMyOperationTransient operationTransient,
            IMyOperationScoped operationScoped,
            IMyOperationSingleton operationSingleton)
        {
            _operationTransient = operationTransient;
            _operationScoped = operationScoped;
            _operationSingleton = operationSingleton;
        }

        [HttpGet]
        public ActionResult Get()
        {

            return Ok(new
            {
                Transient = _operationTransient.GetOperationId(),
                Scoped = _operationScoped.GetOperationId(),
                Singleton = _operationSingleton.GetOperationId()
            });
        }

    }
}