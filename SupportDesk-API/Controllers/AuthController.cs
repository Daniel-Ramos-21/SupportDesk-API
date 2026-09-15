using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupportDesk_API.Data;
using SupportDesk_API.Models;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.AspNetCore.Http.HttpResults;

namespace SupportDesk_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly SupportContext _db;

    }
}
