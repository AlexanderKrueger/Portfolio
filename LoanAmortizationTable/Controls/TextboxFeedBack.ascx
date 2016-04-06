<%@ Control Language="C#"
     AutoEventWireup="true"
     CodeFile="TextboxFeedBack.ascx.cs" 
     Inherits="TextboxFeedBack" %>

<%---CUSTOM CONTROL: TAG PREVIWE WITH REQUIRED ATTRIBUTES SHOWN---%>
<%--
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
 *    [R] ID="TextboxFeedBack1" 
 *    *LabelValue="..." 
 *    TextBoxValue="..." 
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
--%>

<asp:Panel ID=ControlContainer runat="server" CssClass="form-inline has-feedback">
    <label 
        for=TextBoxID
        class="control-label"
        >
        <%: LabelText + "Broken Custom Control" %>
    </label>
        <asp:TextBox 
            ID=ControlTextBox
            runat="server"
            CssClass="form-control"
            >
        </asp:TextBox>
        <%--
         * ABOUT 'Bootstrap 4': Currently 'Bootstrap 3' is utilized.
         * Although version 3 of 'Bootstrap' allows for "glyphicons",
         * the upcoming version ,'Bootstrap 4', will not, but will instead use "cards".
         * As such, the below tag will require modification to work with
         * 'Bootstrap 4' when available, and in such a way
         * that, hopfully, maintains backwards compatibility with 'Bootstrap 3'.
        --%>
        <span id=<%: "\"" + GlyphIconID + "\"" %> class="glyphicon"></span>
        <script type="text/javascript">
            <%--
             * IMPORTANT: Remember to include a javascript reference to 'jqueryTextboxFeedBackV2.js'
             * and a version of 'jquery' inside -for convenience- the 'Site.master' webpage. 
             * Otherwise, this custom control will not work.
            --%>

            <%--WARNING: Do not delete the javascript function as doing so will also break this control.--%>
            addTextBoxFeedBack(
                "#"+<%:ControlContainer.ID%>,
                "#"+<%:ControlTextBox.ID%>,
                "#"+<%: ValidatorID%>,
                "#"+<%:GlyphIconID%>);
        </script>
</asp:Panel>

