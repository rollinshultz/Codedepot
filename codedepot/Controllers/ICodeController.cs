using System;
namespace codedepot.Controllers
{
    interface ICodeController
    {
        System.Web.Mvc.ActionResult GeneralContent(codedepot.Models.Code snippets);
    }
}
