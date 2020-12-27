using MarsRover.Business.Common;
using MarsRover.Business.IServices;
using MarsRover.Domain.Dtos;
using MarsRover.Domain.Entities;
using MarsRover.Presentation.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MarsRover.Presentation.Controllers
{
    public class HomeController : Controller
    {

        public IRoversService roversService;

        public IMapService mapService;

        private readonly IMediator mediator;

        public HomeController(IMediator _mediator)
        {
            mediator = _mediator;
    
        }

        public async Task<IActionResult> Index()
        {
          
            return View();
        }
        [HttpPost]
        public async Task<ListRoverOutput> SetInfos(CreateMapCommand request)
        {
           

            var result = await mediator.Send(request);

            return result;

        }

   
    }
}
