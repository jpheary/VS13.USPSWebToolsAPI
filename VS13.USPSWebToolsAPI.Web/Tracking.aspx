<%@ Page Title="Tracking" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Tracking.aspx.cs" Inherits="Tracking" %>

<asp:Content ID="cHeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <style>
        .request {
            float:left; width:400px; margin:15px 5px;
        }
        .request label {
            width:100px;
            text-align:right;
        }
        .response {
            float:left; width:400px; margin:15px 5px;
        }
        .response label {
            width:100px;
            text-align:right;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel runat="server" ID="pnlMsg" UpdateMode="Always"><ContentTemplate><asp:Label ID="lblMsg" runat="server" Text="" /></ContentTemplate></asp:UpdatePanel>
    <asp:MultiView runat="server" ID="mvwPage" ActiveViewIndex="0">
    <asp:View ID="vwRequest" runat="server">
    <div style="width:900px; margin:0px auto">
        <h2>Tracking Request</h2>
        <asp:ValidationSummary ID="vsTracking" runat="server" Font-Bold="True" ForeColor="#ee2a24" DisplayMode="BulletList" ShowSummary="false" ShowMessageBox="true" ValidationGroup="vgTracking" />
        <div class="request">
            <label for="txtItemNumber">Item Number&nbsp;</label><asp:TextBox ID="txtItemNumber" runat="server" Width="250px" MaxLength="40" /><br />
            <br /><br />
            <div>
                <asp:Button ID="btnTrack" runat="server" Text="Track" ValidationGroup="vgTracking" CommandName="Track" OnCommand="OnCommand" />
                <asp:Button ID="btnClose1" runat="server" Text="Close" style="margin-left:10px" CommandName="Close1" OnCommand="OnCommand" />
            </div>
            <br />
            <asp:RequiredFieldValidator ID="rfvItemNumber" runat="server" ControlToValidate="txtItemNumber" ErrorMessage="Item number is required." Display="None" ValidationGroup="vgTracking" />
        </div>
        <div style="clear:both"></div>
    </div>
    </asp:View>
    <asp:View ID="vwResponse" runat="server">
    <div style="width:900px; margin:0px auto">
        <h2>Tracking Response</h2>
        <div class="response">
            <fieldset>
                <legend>Response</legend>
                <label for="txtSummary">Summary&nbsp;</label><asp:TextBox ID="txtSummary" runat="server" Width="800px" TextMode="MultiLine" Rows="10" ReadOnly="true" /><br />
                <br /><br />
                <asp:Button ID="btnClose2" runat="server" Text="Close" style="margin-left:165px" CommandName="Close2" OnCommand="OnCommand" />
            </fieldset>
        </div>
        <div style="clear:both"></div>
    </div>
    </asp:View>
    </asp:MultiView>
</asp:Content>
