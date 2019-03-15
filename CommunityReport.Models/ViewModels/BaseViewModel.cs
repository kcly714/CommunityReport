using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityReport.Models.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseViewModel
    {//CommunityReport: make note that this base class does not have to be, or should not be abstract. 
        // it is a perfectly good class to be used as a ViewModel 
        
        public bool IsLoggedIn { get; set; }
    }
}
