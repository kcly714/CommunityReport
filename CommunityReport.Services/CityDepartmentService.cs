using CommunityReport.Data;
using CommunityReport.Data.Providers;
using CommunityReport.Models.Domain;
using CommunityReport.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityReport.Services
{
    public class CityDepartmentService : ICityDepartmentService
    {
        IDataProvider _dataProvider;

        public CityDepartmentService(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }
        public List<CityDepartmentDomain> SelectAll()
        {
            var result = new List<CityDepartmentDomain>();
            _dataProvider.ExecuteCmd(
                "city_department_select_all",
                inputParamMapper: null,
                singleRecordMapper: delegate (IDataReader reader, short set)
                {
                    CityDepartmentDomain model = new CityDepartmentDomain();
                    int index = 0;
                    model.DepartmentId = reader.GetSafeInt32(index++);
                    model.DepartmentName = reader.GetSafeString(index++);
                    result.Add(model);
                }
            );
            return result;
        }

    }

}

