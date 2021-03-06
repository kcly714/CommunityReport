using System.Collections.Generic;
using CommunityReport.Models.Domain;
using CommunityReport.Models.Requests;

namespace CommunityReport.Services.Interfaces
{
    public interface IConcernService
    {
        void Delete(int id);
        int Insert(ConcernAddRequest model);
        List<ConcernDomain> SelectAll();
        ConcernDomain SelectById(int id);
        void Update(ConcernDomain model);
        void Upvote(UpvoteDomain model);
    }
}
