<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Contacts R Us</h3>
    

    <label>First Name</label>
    <input id="TextboxFirstName" type="text" class="form-control" runat="server" required/>
    <asp:RequiredFieldValidator 
        ID="RequiredFieldValidatorTextboxFirstName" 
        runat="server" 
        ErrorMessage="Must enter first name."
        ControlToValidate="TextboxFirstName"
        Display="Dynamic"
        >
    </asp:RequiredFieldValidator>
    <br />

    <label>Middle Initials</label>
    <input id="TextMiddleInitials" type="text" class="form-control" runat="server" required/>
    <asp:CustomValidator 
        ID="CustomValidatorMiddleInitials" 
        runat="server" 
        ErrorMessage="Must enter a valid middle name initials."       
        ControlToValidate="TextMiddleInitials"
        OnServerValidate="CustomValidatorMiddleInitials_ServerValidate"            
        Display="Dynamic"
        >
    </asp:CustomValidator>
    <br />
    
    
    
    <label>Last Name</label>
    <input id="TextboxLastName" type="text" class="form-control" runat="server" required />
    <asp:RequiredFieldValidator
        ID="RequiredFieldValidatorTextboxLastName" 
        runat="server" 
        ErrorMessage="Must enter first name"
        ControlToValidate="TextboxLastName"
        Display="Dynamic"></asp:RequiredFieldValidator>
    <br />
    
    
    
    <label>Email Address</label>
    <input id="TextboxEmail" type="text" class="form-control" runat="server" required />
    <asp:RegularExpressionValidator 
        ID="RegularExpressionValidatorEmail" 
        runat="server" 
        ErrorMessage="RegularExpressionValidator"
        ControlToValidate="TextboxEmail"
        ValidationExpression="\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b."> 
    </asp:RegularExpressionValidator>
    <br />


    <label>While Your At It-- Register</label>
    <br />
    
    <label>Enter your age</label> 
    <input id="TextboxAge" type="text" class="form-control" runat="server" required />
    <asp:RangeValidator 
        ID="RangeValidatorTextboxAge" 
        ControlToValidate="TextboxAge"
        runat="server" 
        ErrorMessage="Must be 18 or older and alive(younger than 120) to email."
        type="Integer"
        MaximumValue="120"
        MinimumValue="18"
        Display="Dynamic"></asp:RangeValidator>

    <label>PassWord</label><br />
    <input id="PasswordFirst" type="password" class="form-control" runat="server" required /><br />
    <input id="PasswordSecond" type="password" class="form-control" runat="server" required /><br />
    <asp:CompareValidator 
        ID="CompareValidatorPassword" 
        runat="server" 
        ErrorMessage="Passwords are not the same"
        ControlToValidate="PasswordFirst"
        ControlToCompare="PasswordSecond"
        Operator="Equal"
        Display="Dynamic" 
        Type="String">
    </asp:CompareValidator>
    <br />

    <input id="SubmitEmail" type="submit" value="Submit Email" class="btn btn-primary" runat="server"/>&nbsp;<input id="SubmitRegistration" type="submit" value="Register" class="btn btn-default" runat="server"/>
    <br /><br />
        <%--AJAX control --%>
    <asp:UpdatePanel 
        ID="UpdatePanelValidators"
        runat="server"
        ChildrenAsTriggers="true">
    <ContentTemplate>
        <asp:Timer ID="TimerWorkingAjaxProff" runat="server" Interval="5"></asp:Timer>
        <label>Time(seconds) displayed inside AJAX control: <%:DateTime.Now.Second %></label>
    <br />
    </ContentTemplate>
    </asp:UpdatePanel>   
       <label>Time(seconds) displayed outside AJAX control: <%:DateTime.Now.Second %></label> 
    
     <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
