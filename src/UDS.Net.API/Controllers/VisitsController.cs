﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UDS.Net.API.Client;
using UDS.Net.API.Data;
using UDS.Net.API.Entities;
using UDS.Net.API.Extensions;
using UDS.Net.Dto;

namespace UDS.Net.API.Controllers
{
    /// <summary>
    /// Agrees to VisitClient interface to always ensure client and api endpoints are in-sync. 
    /// </summary>
    [Route("api/[controller]")]
    public class VisitsController : Controller, IVisitClient
    {
        private readonly ApiDbContext _context;

        public VisitsController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<VisitDto>> Get()
        {
            return await _context.Visits.Select(v => v.ToDto()).ToListAsync();
        }

        [HttpGet("Count", Name = "VisitsCount")]
        public async Task<int> Count()
        {
            return await _context.Visits.CountAsync();
        }

        [HttpGet("{id}")]
        public async Task<VisitDto> Get(int id)
        {
            var dto = await _context.Visits.Where(v => v.Id == id).Select(v => v.ToDto()).FirstOrDefaultAsync();

            return dto;
        }

        [HttpPost]
        public async Task Post([FromBody] VisitDto dto)
        {
            var visit = new Visit
            {
                CreatedBy = dto.CreatedBy,
                CreatedAt = dto.CreatedAt,
                ModifiedBy = dto.ModifiedBy,
                IsDeleted = dto.IsDeleted,
                DeletedBy = dto.DeletedBy,
                ParticipationId = dto.ParticipationId
            };
            _context.Visits.Add(visit);
            await _context.SaveChangesAsync();
        }

        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] VisitDto dto)
        {
            var visit = await _context.Visits.FindAsync(id);

            if (visit != null)
            {
                visit.CreatedBy = dto.CreatedBy;
                visit.CreatedAt = dto.CreatedAt;
                visit.ModifiedBy = dto.ModifiedBy;
                visit.IsDeleted = dto.IsDeleted;
                visit.DeletedBy = dto.DeletedBy;
                visit.ParticipationId = dto.ParticipationId;

                _context.Visits.Update(visit);
                await _context.SaveChangesAsync();
            }

        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var visit = await _context.Visits.FindAsync(id);

            _context.Visits.Remove(visit);

            await _context.SaveChangesAsync();
        }
    }
}

