<%@ Page Title="Home Page" 
    Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeFile="Default.aspx.cs"
    StylesheetTheme="Button"
    Inherits="_Default"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="Scripts/jqueryTextBoxFeedBack.js"></script>
    <script type="text/javascript">
        $(document)
        .ready
        (
        function ()
        {
            setTextBoxFeedBack(
       "#Parent_MainContent_TextBoxPrincipalBalance",
       "#MainContent_TextBoxPrincipalBalance",
       "#GlyphIconTextBoxPrincipalBalance",
       "#MainContent_RangeValidatorPrincipalBalance");

            setTextBoxFeedBack(
       "#Parent_MainContent_TextBoxTerm",
       "#MainContent_TextBoxTerm",
       "#GlyphIconTextBoxTerm",
       "#MainContent_RangeValidatorTerm");

            setTextBoxFeedBack(
       "#Parent_MainContent_TextBoxAnnualInterest",
       "#MainContent_TextBoxAnnualPayRate",
       "#GlyphIconTextBoxAnnualInterest",
       "#MainContent_RangeValidatorAnnualInterest");
        }
        );
    </script>

    <div class="jumbotron">
        <asp:Image ID="ImageCompanyLogo"
            runat="server"
            height="75"
            width="75"
            ImageUrl="Images/JumbotronLogo.png"
            AlternateText="Company Logo"/>
    </div>  

    <div class="well well-sm">
        <div>
            <div id="Parent_MainContent_TextBoxPrincipalBalance" class="form-inline has-feedback">
                <label for="TextBoxPrincipalBalance"
                    class="control-label col-md-4 text-right">Principal Balance (Innitial Loan Balance)</label>
                    <asp:TextBox ID ="TextBoxPrincipalBalance"
                        runat="server"
                        CssClass="form-control">
                    </asp:TextBox>  
                    <span id="GlyphIconTextBoxPrincipalBalance" class="glyphicon"></span>
            </div>

            <asp:RangeValidator ID="RangeValidatorPrincipalBalance"
                 runat="server" 
                 ErrorMessage="Principal Balance must be between 100 - 1000000."
                 ControlToValidate="TextBoxPrincipalBalance"
                 MaximumValue="1000000" 
                 MinimumValue="100"
                 Display="Dynamic"
                 CssClass="text-danger col-md-offset-4"
                 Type="Double">
            </asp:RangeValidator>
            <br />

            <div id="Parent_MainContent_TextBoxTerm" class="form-inline has-feedback">
                    <label for ="TextBoxTerm"
                        class="control-label col-md-4 text-right">Term</label>
                    <asp:TextBox ID="TextBoxTerm"
                        runat="server"
                        CssClass="form-control">
                        </asp:TextBox>
                    <span id="GlyphIconTextBoxTerm" class="glyphicon"></span>
            </div>

            <!-- Term is in months -->
            <asp:RangeValidator ID="RangeValidatorTerm"
                 runat="server"                
                 ErrorMessage="Total amount of payments must be between 12 - 360"
                 ControlToValidate="TextBoxTerm"
                 MinimumValue="12"
                 MaximumValue="360"
                 Display="Dynamic"
                 CssClass="text-danger col-md-offset-4"
                 Type="Integer">
            </asp:RangeValidator>
            <br />

            <div id="Parent_MainContent_TextBoxAnnualInterest" class="form-inline has-feedback">
                <label for="TextBoxAnnualPayRate"<%-- change back to annual interest rate --%>
                     class="control-label col-md-4 text-right">Annual Interest</label>
                    <asp:TextBox ID ="TextBoxAnnualPayRate"
                        runat="server"
                        CssClass="form-control">
                        </asp:TextBox>
                    <span id="GlyphIconTextBoxAnnualInterest" class="glyphicon"></span>
            </div>

            <asp:RangeValidator ID="RangeValidatorAnnualInterest"
                 runat="server" 
                 ErrorMessage="Annual interest must be between 1 - 25"
                 ControlToValidate="TextBoxAnnualPayRate"
                 MinimumValue="1"
                 MaximumValue="25"
                 Display="Dynamic"
                 CssClass="text-danger col-md-offset-4"
                 Type="Integer">
            </asp:RangeValidator>
        </div>
        <br />

        <%-- Custom attribute does not work. --%>
        <fb:TextboxFeedBack ID="TestCustomControl" LabelText="TestCustomAttribute" runat="server"></fb:TextboxFeedBack>
        <br />

        <div id="Parent_MainContent_TextBoxMonthlyPayment" class="form-inline has-feedback">
                <label for="TextBoxMonthlyPayment"
                    class="control-label col-md-4 text-right">Monthly Payment</label>
                    <asp:TextBox ID="TextBoxMonthlyPayment"
                        runat="server"
                        CssClass="form-control"
                        ReadOnly="true">
                    </asp:TextBox>
            </div>
            <br />

        <asp:Button ID="ButtonCalculate"
            runat="server"
            text="Calculate"
            SkinID="button=primary"
            OnClick="ButtonCalculate_Click"/>

        <asp:Button ID="ButtonClear"
            runat="server"
            text="Clear"
            OnClick="ButtonClear_Click" 
            CausesValidation="False"/>
        <br /><br />

        <label for="AmortizationTable"
            class="control-label">Armortization Table</label>
        <asp:Table style="width: 100%;"
             ID="AmortizationTable" 
             runat="server" 
             CssClass="table table-bordered"
             GridLines="Both">
            <asp:TableHeaderRow id="headers">
                <asp:TableHeaderCell>Payment Number</asp:TableHeaderCell>
                <asp:TableHeaderCell>Monthly Interest (Paid Down)</asp:TableHeaderCell>
                <asp:TableHeaderCell>Principle (Paid Down)</asp:TableHeaderCell>
                <asp:TableHeaderCell>Principle Balance</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableFooterRow ID ="myTableFooter" runat="server">
                <asp:TableCell>Final Payment:</asp:TableCell>
                <asp:TableCell>&nbsp;</asp:TableCell>
                <asp:TableCell ID="FooterFinalPaymentValue" runat="server">&nbsp;</asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableFooterRow>
        </asp:Table>
    </div>
</asp:Content>
