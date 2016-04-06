using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TextboxFeedBack : System.Web.UI.UserControl
{
    //---CUSTOM CONTROL: TAG PREVIWE WITH REQUIRED ATTRIBUTES SHOWN---
    /*
     * IMPORTANT: Shown tag prefix is a placeholder, and it should not be used in
     * the actual(usable) custom control.
     * 
     * /===< Legend >==========================================\
     * | "..." -----------------: Desired string               |
     * | *(Attribute Name) -----: Custom attribute             |
     * | [R](Tag/ Attribute) ---: Required for proper behavior |
     * | ( (Text) ) ------------: Place holder label           |
     * \=======================================================/
     * 
     * /===<Legend: Examples >=============================\
     * | "..." --- : <TagName ID="..." />                  |
     * | * ------- : <TagName ID="Example" *ATRIB="..." /> |
     * | [R] ----- : [R]<TagName ID="Example" />           |
     * | ( ) ----- : <(Type of Validator) ID="Example" />  |
     * \===================================================/
     * 
     * <custom:TextboxFeedBack
     *    [R] ID="..." 
     *    *LabelValue="..." 
     *    *TextBoxValue="..." 
     *    [R] runat="server"
     * >
     *    [R]<asp:(Type of Validator)
     *          ErrorMessage="..."
     *          [R](Validation Condition #1)="..."
     *          [R](Validation Condition #...)="..."
     *          [R]Display="Dynamic"
     *          [R]Type=(Data Type: i.e. Type="Double")
     *          [R]runat="server"
     *       >
     *       </asp:(Type of Validator)>
     * </custom:TextboxFeedBack>
     */

    //---CUSTOM TAG ATTRIBUTES---
    //***Variables to Store Attribute Values In***
    protected string LabelText = null;

    //***Attribute Adder***
    //IMPORTANT: Remember to invoke the method inside the 'Site.master'.
    private void addCustomAttributes()
    {
        //***Define Attributes Here***
        //-----------------/* Attribute Name   |   Defualt Value */
        this.Attributes.Add("LabelText"        ,         ""       );
    }


    //---FIELDS---
    protected string GlyphIconID = null;
    protected string ValidatorID = null;


    //---METHODS---
    protected void Page_Load(object sender, EventArgs e)
    {
        //***Variable Asignments***
        //Adds all custom attributes defined in the above method.
        addCustomAttributes();

        //Attribute variables are defined.
        LabelText = this.Attributes["LabelText"];

        //IDs are defined for tag associated variables.
        ControlTextBox.ID = this.ID;
        ControlContainer.ID = "Parent_" + ControlTextBox.ID;
        GlyphIconID = "GlyphIcon_" + ControlTextBox.ID;

        //Here on after, all variables suffixed with "ID" are defined.

        //***Remaining Code***
        /*Automaticaly generates each nested validator's 'ID' and 'ControlToValidate' attributes.
         * 
         * i.e.
         * (Below is an illustration using pseudo ASP mark up)
         * 
         * <asp:Validator ID="Gets_No_Auto_Generated_ID...></asp:Validator>
         * 
         * <CustomControl:TextboxFeedBack ID="Has_Nested_Validators" ...>
         *      <asp:Validator ID="Auto_Generated_ID_1" ...></asp:Validator>
         *      <asp:Validator ID="Auto_Generated_ID_2" ...></asp:Validator>
         *      <asp:Validator ID="Auto_Generated_ID_3" ...></asp:Validator>
         * </CustomControl:TextboxFeedBack>
         *
         */
        foreach(Control control in this.Controls)
        {
            if(control is BaseValidator)
            {
                //IMPORTANT: The validator ID is automaticly generated.
                //Custom ID's coded within the encompassing (parent) control will be overwritten.
                //
                //However, after ASP code is converted into HTML, the HTML derived from the 
                //ASP 'Validator' control can be given a custom ID name.
                //Of Course, there is probably multiple -if not better- working solutions.

                //***Last of 4 Fields is Assigned a Value***
                //Each validator nested in the custom control is given a unique ID.
                ValidatorID = "Validator" + (control as BaseValidator).UniqueID.ToString() + ControlTextBox.ID;
                (control as BaseValidator).ID = ValidatorID;
                (control as BaseValidator).ControlToValidate = ControlTextBox.ID;
            }
            /*NOTE: Below is alternate code layout of above should the above not work.
            if(control is CompareValidator)
            {

            }
            else if(control is CustomValidator)
            {

            }
            else if(control is RangeValidator)
            {

            }
            else if(control is RegularExpressionValidator)
            {

            }
            else if(control is RequiredFieldValidator)
            {

            }
             */
        }        
    }
}