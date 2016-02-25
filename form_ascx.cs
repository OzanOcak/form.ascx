<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContactForm.ascx.cs" Inherits="ContactFormNew.ControlTemplates.ContactFormNew.ContactForm" %>


<%--<form id="ContactForm1" runat="server">
--%>
<style media="screen" type="text/css">


    
    
    #windows_21{visibility:hidden;}
    
    
    select {
    font-size: 12pt;
    font-family: Verdana,sans-serif;
    width:90%;
}
    .section.sect label b{ font-size:15px;}
    
    .ContactFormTable {
    border: 1px solid #007168;
    background-color: #FFFFF0;
    padding: 5px 8px;
}
    .ContactFormTable legend b{color:#007168;}
</style>



<fieldset class="ContactFormTable">
    <legend>Contact Form</legend>
    <div class="CFstyle1Table">
        <div class="CFstyle1Row">
            <label for="nameTextBox" class="CFstyle1Cell">
                <strong>Name:</strong><span class="ReqValStyle">*</span>
            </label>
            <div class="CFstyle2Cell">
                <asp:TextBox ID="nameTextBox" ClientIDMode="Static" runat="server" title="e.g. Bruce "></asp:TextBox>
                <asp:RequiredFieldValidator ID="nameReq" runat="server"
                    Display="Dynamic" ControlToValidate="nameTextBox" SetFocusOnError="true" ErrorMessage="<br/>Please enter your name!" />
            </div>
        </div>
        <div class="CFstyle1Row">
            <label for="emailTextBox" class="CFstyle1Cell">
                <strong>Email Address:</strong><span class="ReqValStyle">*</span>
            </label>
            <div class="CFstyle2Cell">
                <asp:TextBox ID="emailTextBox"  ClientIDMode="Static" runat="server" Rows="6" Columns="20" title="e.g. bruce@example.com "></asp:TextBox>
                <asp:RequiredFieldValidator ID="emailReq" runat="server"
                    Display="Dynamic" ControlToValidate="emailTextBox" SetFocusOnError="true" ErrorMessage="<br/>Please enter your email address!" />
                <asp:RegularExpressionValidator ID="emailExpressionValidator" runat="server" Display="Dynamic"
                    ControlToValidate="emailTextBox" ValidationExpression="^\S+@\S+\.\S+$" ErrorMessage="<br/>You must enter a valid email address!"
                    SetFocusOnError="true"> </asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="CFstyle1Row">
            <label for="ctl00_PlaceHolderMain_ContactForm1_subjectDBox" class="CFstyle1Cell">
                <strong>Reason for sending :</strong><span class="ReqValStyle">*</span>
            </label>
            <div class="CFstyle2Cell">
                <asp:DropDownList ID="subjectDBox" runat="server">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Address Change</asp:ListItem>
                    <asp:ListItem>Mailing List Inquiry</asp:ListItem>
                    <asp:ListItem>Working at March of Dimes</asp:ListItem>
                    <asp:ListItem>Funding for Assistive Devices</asp:ListItem>
                    <asp:ListItem>Funding for Home and/or Vehicle Modification</asp:ListItem>
                    <asp:ListItem>Events</asp:ListItem>
                    <asp:ListItem>Advocacy</asp:ListItem>
                    <asp:ListItem>Government Relations</asp:ListItem>
                    <asp:ListItem>An Other Reason</asp:ListItem>
                    <asp:ListItem>Website Related</asp:ListItem>
                    <asp:ListItem>Volunteering</asp:ListItem>
                    <asp:ListItem>Media inquiries</asp:ListItem>  
                    <asp:ListItem>Polio Canada</asp:ListItem>
                    <asp:ListItem>Stroke Recovery Canada</asp:ListItem>                  
                    <%--<asp:ListItem>Programs</asp:ListItem>--%>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="subjectReq" runat="server"
                    Display="Dynamic" ControlToValidate="subjectDBox" SetFocusOnError="true" ErrorMessage="<br/>Please enter a Reason!" />
            </div>
        </div>
        <div class="CFstyle1Row">
            <label for="bodyTextBox" class="CFstyle1Cell">
                <strong>Message:</strong><span class="ReqValStyle">*</span>
            </label>
            <div class="CFstyle2Cell">
                <asp:TextBox ID="bodyTextBox" ClientIDMode="Static" runat="server" TextMode="MultiLine" Rows="6" Columns="25" title="e.g. please, you can tell us what you would like to learn...."></asp:TextBox>
                <asp:RequiredFieldValidator ID="bodyReq" runat="server"
                    Display="Dynamic" ControlToValidate="bodyTextBox" SetFocusOnError="true" ErrorMessage="<br/>Please enter a Message!" />
            </div>
        </div>

        <div class="CFstyle1Table" id="CFstyle9Table">
          <label for="ctl00_PlaceHolderMain_ContactForm1_mrmari" class="CFstyle1Cell">
                <strong>Message1:</strong><span class="ReqValStyle">*</span>
          </label>
          <div class="CFstyle1Row">
            <div class="CFstyle2Cell">
                <asp:TextBox ID="mrmari" runat="server"></asp:TextBox>
            </div>
          </div>
        </div>
     

        <div class="CFstyle1Row">
            <div class="CFstyle1Cell">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send" />
            </div>
        </div>
    </div>
    <br />

</fieldset>


<script type="text/javascript">

    $(document).ready(function () {
        $(".defaultText").focus(function (srcc) {
            if ($(this).val() == $(this)[0].title) {
                $(this).removeClass("defaultTextActive");
                $(this).val("");
            }
        });
        $(".defaultText").blur(function () {
            if ($(this).val() == "") {
                $(this).addClass("defaultTextActive");
                $(this).val($(this)[0].title);
            }
        });

        $(".defaultText").blur();

    });

</script>


<%--</form>--%>
