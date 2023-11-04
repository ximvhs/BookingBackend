﻿using BookingBackend.Models;
using BookingBackend.Models.InputModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace BookingBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ChuyenBayController : ControllerBase
    {
        private readonly DvmayBayContext _context;

        public ChuyenBayController(DvmayBayContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Chuyenbay>>> GetAllAsync()
        {
            return await _context.Chuyenbays.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<List<Chuyenbay>>> FilterChuyenBayAsync(InputFilterChuyenBay input)
        {
            var result = await _context.Chuyenbays.Where(x => x.NoiXuatPhat == input.fromPlace && x.NoiDen == input.toPlace && x.NgayXuatPhat >= DateTime.Parse(input.startDate)).ToListAsync();
            return Ok(result);
        }

        
    }
}
