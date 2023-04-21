using System;
using UDS.Net.Dto;
using UDS.Net.Forms.Models;
using UDS.Net.Forms.Models.UDS3;
using UDS.Net.Services.DomainModels;
using UDS.Net.Services.DomainModels.Forms;

namespace UDS.Net.Forms.Extensions
{
    public static class ViewModelToDomainMapper
    {
        public static Participation ToEntity(this ParticipationModel vm)
        {
            return new Participation
            {
                Id = vm.Id,
                LegacyId = vm.LegacyId
            };
        }

        public static Visit ToEntity(this VisitModel vm)
        {
            return new Visit(vm.Id, vm.Number, vm.ParticipationId, vm.Version, vm.Kind, vm.StartDateTime, vm.CreatedAt, vm.CreatedBy, vm.ModifiedBy, vm.DeletedBy, vm.IsDeleted, vm.Forms.ToEntity());
        }

        public static List<Form> ToEntity(this IList<FormModel> vm)
        {
            return vm.Select(v => v.ToEntity()).ToList();
        }

        public static Form ToEntity(this FormModel vm)
        {
            return new Form(vm.VisitId, vm.Id, vm.Title, vm.Kind, vm.Status, vm.Language, vm.IncludeInPacketSubmission, vm.ReasonCodeNotIncluded.ToString(), null);
        }

        public static Form ToEntity(this A1 vm)
        {
            // TODO How to determine whether an IVP or RVP (is it important?)
            var fields = new A1FormFields
            {
                REASON = vm.IVP.REASON,
                REFERSC = vm.IVP.REFERSC,
                LEARNED = vm.IVP.LEARNED,
                PRESTAT = vm.IVP.PRESTAT,
                PRESPART = vm.IVP.PRESPART,
                SOURCENW = vm.IVP.SOURCENW
            };

            return new Form(vm.VisitId, vm.Id, vm.Title, vm.Kind, vm.Status, vm.Language, vm.IncludeInPacketSubmission, vm.ReasonCodeNotIncluded.ToString(), fields);
        }

        public static Form ToEntity(this A2 vm)
        {
            var fields = new A2FormFields
            {
                INBIRMO = vm.INBIRMO,
                INBIRYR = vm.INBIRYR,
                INSEX = vm.INSEX
            };

            return new Form(vm.VisitId, vm.Id, vm.Title, vm.Kind, vm.Status, vm.Language, vm.IncludeInPacketSubmission, vm.ReasonCodeNotIncluded.ToString(), fields);
        }
    }
}

