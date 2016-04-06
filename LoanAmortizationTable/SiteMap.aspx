<%@ Page Language="C#"
     MasterPageFile="Site.master"
     AutoEventWireup="true"
     CodeFile="SiteMap.aspx.cs"
     Inherits="SiteMap" %>

<asp:Content ID="SiteMapContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="well well-sm">
    <asp:SiteMapDataSource ID="SiteMapDataSource" runat="server" />
        <asp:TreeView ID="SiteMapTreeView" 
            DataSourceID="SiteMapDataSource" 
            runat="server"></asp:TreeView>
    </div>
</asp:Content>
