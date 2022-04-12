namespace CSharp.Net6.ReportingRestServiceCorsDemo.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Telerik.Reporting.Services;
    using Telerik.WebReportDesigner.Services;
    using Telerik.WebReportDesigner.Services.Controllers;
    using System.Web.Http.Cors;

    [Route("api/reportdesigner")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ReportDesignerController : ReportDesignerControllerBase
    {
        public ReportDesignerController(IReportDesignerServiceConfiguration reportDesignerServiceConfiguration, IReportServiceConfiguration reportServiceConfiguration)
            : base(reportDesignerServiceConfiguration, reportServiceConfiguration)
        {
        }
    }
}
