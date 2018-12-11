using System;
using System.Collections.Generic;
using System.Text;

namespace Orchard.Domain
{
    public class TreatmentId: AggregateId
    {
        public TreatmentId(int id) : base(id)
        {
        }
    }
}
