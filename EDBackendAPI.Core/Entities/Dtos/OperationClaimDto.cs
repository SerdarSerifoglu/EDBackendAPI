using EDBackendAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDBackendAPI.Core.Entities.Dtos
{
    public class OperationClaimDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
