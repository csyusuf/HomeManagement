using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;

namespace HMHelper
{
    public class ResponseMessage
    {
        public ResponseMessage()
        { }
        public void PrintSuccessMessage(HtmlControl control, string message)
        {
            HtmlGenericControl hgc = (HtmlGenericControl)control; //html tags can be created in c# as HtmlGenericControl
            hgc.TagName = "span";
            hgc.InnerText = message;
            hgc.Attributes.Add("class", "label label-success"); //label and label-success are bootstrap css classes
        }

        public void PrintFailureMessage(HtmlControl control, string message)
        {
            HtmlGenericControl hgc = (HtmlGenericControl)control;
            hgc.TagName = "span";
            hgc.InnerText = message;
            hgc.Attributes.Add("class", "label label-danger"); //label and label-danger are bootstrap css classes
        }
    }
}
