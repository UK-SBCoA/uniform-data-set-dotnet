using System;
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

        private async Task<Visit> Get(int id, string formKind)
        {
            if (!String.IsNullOrWhiteSpace(formKind))
            {
                var visit = await _context.Visits
                    .Include(v => v.FormStatuses)
                    .Where(v => v.Id == id)
                    .FirstOrDefaultAsync();

                // get details for form requested
                if (formKind == "A1")
                {
                    var a1 = await _context.A1s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (a1 != null)
                        visit.A1 = a1;
                }
                else if (formKind == "A2")
                {
                    var a2 = await _context.A2s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (a2 != null)
                        visit.A2 = a2;
                }
                else if (formKind == "A3")
                {
                    var a3 = await _context.A3s
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (a3 != null)
                        visit.A3 = a3;
                }
                else if (formKind == "A4")
                {
                    var a4 = await _context.A4Gs
                        .Where(a => a.VisitId == id)
                        .FirstOrDefaultAsync();

                    if (a4 != null)
                        visit.A4G = a4;

                    var a4details = await _context.A4Ds
                        .Where(a => a.VisitId == id)
                        .ToListAsync();

                    if (a4details != null)
                        visit.A4Ds = a4details;
                }

                return visit;
            }

            return null;
        }

        private bool Update(A1 entity, A1Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                entity.CreatedAt = dto.CreatedAt;
                entity.CreatedBy = dto.CreatedBy;
                entity.ModifiedBy = dto.ModifiedBy;
                entity.DeletedBy = dto.DeletedBy;
                entity.IsDeleted = dto.IsDeleted;
                entity.REASON = dto.REASON;
                entity.REFERSC = dto.REFERSC;
                entity.LEARNED = dto.LEARNED;
                entity.PRESTAT = dto.PRESTAT;
                entity.PRESPART = dto.PRESPART;
                entity.SOURCENW = dto.SOURCENW;
                entity.BIRTHMO = dto.BIRTHMO;
                entity.BIRTHYR = dto.BIRTHYR;
                entity.SEX = dto.SEX;
                entity.HISPANIC = dto.HISPANIC;
                entity.HISPOR = dto.HISPOR;
                entity.HISPORX = dto.HISPORX;
                entity.RACE = dto.RACE;
                entity.RACEX = dto.RACEX;
                entity.RACESEC = dto.RACESEC;
                entity.RACESECX = dto.RACESECX;
                entity.PRIMLANG = dto.PRIMLANG;
                entity.EDUC = dto.EDUC;
                entity.MARISTAT = dto.MARISTAT;
                entity.LIVSITUA = dto.LIVSITUA;
                entity.INDEPEND = dto.INDEPEND;
                entity.RESIDENC = dto.RESIDENC;
                entity.ZIP = dto.ZIP;
                entity.HANDED = dto.HANDED;
                return true;
            }
            return false;
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
            var dto = await _context.Visits
                .Include(v => v.FormStatuses)
                .Where(v => v.Id == id)
                .Select(v => v.ToDto())
                .FirstOrDefaultAsync();

            return dto;
        }

        [HttpGet("{id}/Forms/{formKind}", Name = "GetWithForm")]
        public async Task<VisitDto> GetWithForm(int id, string formKind)
        {
            if (!String.IsNullOrWhiteSpace(formKind))
            {
                var visit = await Get(id, formKind);

                return visit.ToDto(formKind);
            }
            throw new Exception("Must include a form id.");
        }

        [HttpPost]
        public async Task Post([FromBody] VisitDto dto)
        {
            var visit = new Visit
            {
                Kind = dto.Kind,
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
            // check to see if the dto has a full form
            string formKind = "";
            if (dto.Forms != null && dto.Forms.Count() > 0)
            {
                foreach (var form in dto.Forms)
                {
                    if (form is A1Dto)
                        formKind = "A1";
                    else if (form is A2Dto)
                        formKind = "A2";
                    else if (form is A3Dto)
                        formKind = "A3";
                    else if (form is A4GDto)
                        formKind = "A4";
                    else if (form is A5Dto)
                        formKind = "A5";
                }
            }

            Visit? visit;
            if (String.IsNullOrEmpty(formKind))
            {
                // there could be status updates for form bases
                visit = await _context.Visits
                    .Include(v => v.FormStatuses)
                    .Where(v => v.Id == id)
                    .FirstOrDefaultAsync();
            }
            else
            {
                visit = await Get(id, formKind);
            }

            if (visit != null)
            {
                visit.ParticipationId = dto.ParticipationId;
                visit.Number = dto.Number;
                visit.Kind = dto.Kind;
                visit.Version = dto.Version;
                visit.StartDateTime = dto.StartDateTime;
                visit.CreatedAt = dto.CreatedAt;
                visit.CreatedBy = dto.CreatedBy;
                visit.ModifiedBy = dto.ModifiedBy;
                visit.DeletedBy = dto.DeletedBy;
                visit.IsDeleted = dto.IsDeleted;


                if (!String.IsNullOrEmpty(formKind))
                {
                    if (formKind == "A1")
                    {
                        var formDto = dto.Forms.Where(f => f.Kind == "A1").FirstOrDefault();

                        if (formDto is A1Dto)
                        {
                            A1Dto a1Dto = (A1Dto)formDto;

                            this.Update(visit.A1, a1Dto);
                        }
                    }

                }

                _context.Visits.Update(visit);
                await _context.SaveChangesAsync();
            }

        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var visit = await _context.Visits.FindAsync(id);

            if (visit == null)
                return;

            _context.Visits.Remove(visit);

            await _context.SaveChangesAsync();
        }

    }
}

