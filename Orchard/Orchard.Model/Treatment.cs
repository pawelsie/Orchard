using System;
using System.Collections.Generic;
using System.Text;
using Orchard.Domain.Helpers;

namespace Orchard.Domain
{
    public class Treatment
    {
        public TreatmentId Id { get; }
        public PlantInOrchardId PlantInOrchardId { get; }
        public DateTime TreatmentDate { get; }

        private Treatment(TreatmentId treatmentId, PlantInOrchardId plantInOrchardId, DateTime treatmentDate)
        {
            Id = treatmentId;
            PlantInOrchardId = plantInOrchardId;
            TreatmentDate = treatmentDate;
        }

        public static Treatment AddTreatment(TreatmentId treatmentId, PlantId plantId, DateTime treatmentDate ,
            PlantInOrchardId plantInOrchardId, ITreatmentVerificationService verificationService)
        {
            Result verification = verificationService.CanApplyTreatmentToPlant(treatmentId, plantId);
            if (verification.Failure)
                throw new ArgumentException(verification.Error);


            return new Treatment(treatmentId, plantInOrchardId, treatmentDate);
        }
    }

    public interface ITreatmentVerificationService
    {
        Result CanApplyTreatmentToPlant(TreatmentId treatmentId, PlantId plantId);
    }
}