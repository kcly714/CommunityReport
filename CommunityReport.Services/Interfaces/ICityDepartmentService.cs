using System.Collections.Generic;
using CommunityReport.Models.Domain;

namespace CommunityReport.Services.Interfaces
{
    public interface ICityDepartmentService
    {
        List<CityDepartmentDomain> SelectAll();
    }
}
