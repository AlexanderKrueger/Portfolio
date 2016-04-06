using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CustomValidatorMiddleInitials_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if(TextMiddleInitials.Value.Length != 2)
        {
            args.IsValid = false;
        }
    }
}