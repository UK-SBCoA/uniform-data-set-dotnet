using System;
using UDS.Net.API.Entities;
using UDS.Net.Dto;

namespace UDS.Net.API.Extensions
{
    public static class DtoToEntityMapper
    {
        private static void SetBaseProperties(Form entity, FormDto dto)
        {
            entity.CreatedAt = dto.CreatedAt;
            entity.CreatedBy = dto.CreatedBy;
            entity.ModifiedBy = dto.ModifiedBy;
            entity.DeletedBy = dto.DeletedBy;
            entity.IsDeleted = dto.IsDeleted;
            entity.Status = dto.Status;

            if (String.IsNullOrWhiteSpace(dto.Language))
                entity.Language = null;
            else
            {
                if (Enum.TryParse(dto.Language, true, out Language language))
                    entity.Language = language;
            }

            entity.IsIncluded = dto.IsIncluded;

            if (String.IsNullOrWhiteSpace(dto.ReasonCode))
                entity.ReasonCode = null;
            else
            {
                if (Enum.TryParse(dto.ReasonCode, true, out ReasonCode reasonCode))
                    entity.ReasonCode = reasonCode;
            }
        }

        public static bool Update(this A1 entity, A1Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                SetBaseProperties(entity, dto);

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

        public static bool Update(this A2 entity, A2Dto dto)
        {
            if (entity.Id == dto.Id)
            {
                SetBaseProperties(entity, dto);

                entity.INBIRMO = dto.INBIRMO;
                entity.INBIRYR = dto.INBIRYR;
                entity.INSEX = dto.INSEX;
                entity.INHISP = dto.INHISP;
                entity.INHISPOR = dto.INHISPOR;
                entity.INHISPOX = dto.INHISPOX;
                entity.INRACE = dto.INRACE;
                entity.INRACEX = dto.INRACEX;
                entity.INRASEC = dto.INRASEC;
                entity.INRASECX = dto.INRASECX;
                entity.INRATER = dto.INRATER;
                entity.INRATERX = dto.INRATERX;
                entity.INEDUC = dto.INEDUC;
                entity.INRELTO = dto.INRELTO;
                entity.INKNOWN = dto.INKNOWN;
                entity.INLIVWTH = dto.INLIVWTH;
                entity.INVISITS = dto.INVISITS;
                entity.INCALLS = dto.INCALLS;
                entity.INRELY = dto.INRELY;

                return true;
            }
            return false;
        }

        public static bool Update(this A3 entity, A3Dto dto)
        {
            SetBaseProperties(entity, dto);
            // TODO map a3
            return false;
        }

        public static bool Update(this A4G entity, A4GDto dto)
        {
            SetBaseProperties(entity, dto);
            // TODO map a4
            return false;
        }

        public static bool Update(this A5 entity, A5Dto dto)
        {
            SetBaseProperties(entity, dto);
            // TODO map a5
            return false;
        }
    }
}

