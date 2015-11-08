<%@ Page Title="AddressValidator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Address.aspx.cs" Inherits="Address" %>

<asp:Content ID="cHeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <script charset="UTF-8" type="text/javascript" src="http://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=6.3&mkt=en-us"></script>
    <style>
        .address {
            float:left; width:400px; margin:15px 5px;
        }
        .address label {
            width:100px;
            text-align:right;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel runat="server" ID="pnlMsg" UpdateMode="Always"><ContentTemplate><asp:Label ID="lblMsg" runat="server" Text="" /></ContentTemplate></asp:UpdatePanel>
    <asp:MultiView runat="server" ID="mvwPage" ActiveViewIndex="0">
    <asp:View ID="vwAddress" runat="server">
    <div style="width:900px; margin:0px auto">
        <h2>Address</h2>
        <asp:ValidationSummary ID="vsAddress" runat="server" Font-Bold="True" ForeColor="#ee2a24" DisplayMode="BulletList" ShowSummary="false" ShowMessageBox="true" ValidationGroup="vgAddress" />
        <div class="address">
            <label for="txtName">Name&nbsp;</label><asp:TextBox ID="txtName" runat="server" Width="250px" MaxLength="40" /><br />
            <label for="txtAddressLine1">Address&nbsp;</label><asp:TextBox ID="txtAddressLine1" runat="server" Width="250px" MaxLength="40" /><br />
            <label for="txtAddressLine2">&nbsp;</label><asp:TextBox ID="txtAddressLine2" runat="server" Width="250px" MaxLength="40" /><br />
            <label for="txtCity">City&nbsp;</label><asp:TextBox ID="txtCity" runat="server" Width="225px" MaxLength="40" /><br />
            <label for="txtState">State&nbsp;</label><asp:TextBox ID="txtState" runat="server" Width="40px" MaxLength="2" />
            <label for="txtZip5">Zip&nbsp;</label><asp:TextBox ID="txtZip5" runat="server" Width="50px" MaxLength="5" AutoPostBack="true" OnTextChanged="OnZipChanged" />
            &nbsp;-&nbsp;<asp:TextBox ID="txtZip4" runat="server" Width="40px" MaxLength="4" />
            <br /><br />
            <div>
                <asp:Button ID="btnValidate" runat="server" Text="Validate" ValidationGroup="vgAddress" style="margin-left:165px" CommandName="Validate" OnCommand="OnCommand" />
                <asp:Button ID="btnClose" runat="server" Text="Close" style="margin-left:10px" CommandName="Close" OnCommand="OnCommand" />
            </div>
            <br />
            <asp:RequiredFieldValidator ID="rfvStreet" runat="server" ControlToValidate="txtAddressLine1" ErrorMessage="Street address is required." Display="None" ValidationGroup="vgAddress" />
            <asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="txtCity" ErrorMessage="City is required." Display="None" ValidationGroup="vgAddress" />
            <asp:RequiredFieldValidator ID="rfvState" runat="server" ControlToValidate="txtState" ErrorMessage="State is required." Display="None" ValidationGroup="vgAddress" />
            <asp:RequiredFieldValidator ID="rfvZip" runat="server" ControlToValidate="txtZip5" ErrorMessage="Zip is required." Display="None" ValidationGroup="vgAddress" />
        </div>
        <div style="float:left; margin-left:25px; margin-top:10px; padding:0 0 0 0; border-style:solid; border-color:#ee2a24">
            <div id='myMap' style="position:relative; width:350px; height:375px"></div>
        </div>
        <div style="clear:both"></div>
    </div>
    <script type="text/javascript">
        var map = new VEMap('myMap');
        map.LoadMap();
        updateMap();

        function updateMap() {
            var street = document.getElementById('<%=txtAddressLine1.ClientID %>').value;
            var city = document.getElementById('<%=txtCity.ClientID %>').value;
            var state = document.getElementById('<%=txtState.ClientID %>').value;
            var zip = document.getElementById('<%=txtZip5.ClientID %>').value;

            var address = street + ' ' + city + ', ' + state + ' ' + zip;
            MapLocation(address);
        }
        function MyHandleCredentialsError() { alert("The Bing Map credentials are invalid."); }
        function UnloadMap() { if (myMap != null) myMap.Dispose(); }
        function MapLocation(address) {
            var points = new Array(address);
            for (var i = 0; i < points.length; i++)
                map.Find(null, points[i], null, null, 0, 10, false, false, false, true, ProcessStore);
        }
        function ProcessStore(layer, results, places, hasmore) {
            //Create a custom pin
            if (places != null && places[0].LatLong != 'Unavailable') {
                var spec = new VECustomIconSpecification();
                spec.CustomHTML = "<div style='font-size:8px; border:solid 1px Black; background-color:red; width:8px;'>&nbsp;<div>";
                var pin = new VEShape(VEShapeType.Pushpin, places[0].LatLong);
                pin.SetCustomIcon(spec);
                map.AddShape(pin);
            }
        }
        function callWebService(url) {
            //Calls web service with url and callback function; callback will be executed when XMLHttpRequest object returns from web service call
            var xmlDoc = new XMLHttpRequest();
            if (xmlDoc) {
                //Execute synchronous call to web service; asynchronous never returns a readystate > 1 with POST
                xmlDoc.onreadystatechange = function () { stateChange(xmlDoc); };
                xmlDoc.open("GET", url, true);
                //params = "name=" + document.infoForm.name.value + "&email=" + document.infoForm.email.value + "&phone=" + document.infoForm.phone.value + "&company=" + document.infoForm.company.value + "&address=" + document.infoForm.address.value + "&state=" + document.infoForm.state.value + "&options=" + document.infoForm.options.value;
                //xmlDoc.setRequestHeader("Content-length", params.length);
                xmlDoc.send(null);
            }
            else
                alert("Unable to create XMLHttpRequest object.");
        }

        function stateChange(xmlDoc) {
            //Updates readystate by callback
            if (xmlDoc.readyState == 4) {
                var text = "";
                if (xmlDoc.status == 200) {
                    //sSelect node containing data
                    var nd = xmlDoc.responseXML.getElementsByTagName("mail");
                    if (nd && nd.length == 1) {
                        //IE use .text, others .textContent
                        text = !nd[0].text ? nd[0].textContent : nd[0].text;
                        if (text != "") alert(text); else alert("Web service call failed: " + text);
                    }
                }
                else
                    alert("Bad response: status code=" + xmlDoc.status);
            }
        }
    </script>
    </asp:View>
    <asp:View ID="vwVerifyAddress" runat="server">
    <div style="width:900px; margin:0px auto">
        <h2>Verify Address</h2>
        <div class="address">
            <fieldset>
                <legend>Address</legend>
                <label for="txtSrcName">Name&nbsp;</label><asp:TextBox ID="txtSrcName" runat="server" Width="250px" MaxLength="40" ReadOnly="true" /><br />
                <label for="txtSrcAddressLine1">Address&nbsp;</label><asp:TextBox ID="txtSrcAddressLine1" runat="server" Width="250px" MaxLength="40" ReadOnly="true" /><br />
                <label for="txtSrcAddressLine2">&nbsp;</label><asp:TextBox ID="txtSrcAddressLine2" runat="server" Width="250px" MaxLength="40" ReadOnly="true" /><br />
                <label for="txtSrcCity">City&nbsp;</label><asp:TextBox ID="txtSrcCity" runat="server" Width="225px" MaxLength="40" ReadOnly="true" /><br />
                <label for="txtSrcState">State&nbsp;</label><asp:TextBox ID="txtSrcState" runat="server" Width="40px" MaxLength="2" ReadOnly="true" />
                <label for="txtSrcZip5">Zip&nbsp;</label><asp:TextBox ID="txtSrcZip5" runat="server" Width="50px" MaxLength="5" ReadOnly="true" />
                &nbsp;-&nbsp;<asp:TextBox ID="txtSrcZip4" runat="server" Width="40px" MaxLength="4" ReadOnly="true" />
                <br /><br />
                <asp:Button ID="btnChooseAddress" runat="server" Text="Choose" style="margin-left:165px" CommandName="ChooseAddress" OnCommand="OnCommand" />
            </fieldset>
        </div>
        <div class="address">
            <fieldset>
                <legend>USPS Address</legend>
                <label title="Name" for="txtUSPSName">Name&nbsp;</label><asp:TextBox ID="txtUSPSName" runat="server" Width="275px" MaxLength="40" ReadOnly="true" />
                <label for="txtUSPSAddressLine1">Address&nbsp;</label><asp:TextBox ID="txtUSPSAddressLine1" runat="server" Width="250px" MaxLength="40" ReadOnly="true" /><br />
                <label for="txtUSPSAddressLine2">&nbsp;</label><asp:TextBox ID="txtUSPSAddressLine2" runat="server" Width="250px" MaxLength="40" ReadOnly="true" /><br />
                <label for="txtUSPSCity">City&nbsp;</label><asp:TextBox ID="txtUSPSCity" runat="server" Width="225px" MaxLength="40" ReadOnly="true" /><br />
                <label for="txtUSPSState">State&nbsp;</label><asp:TextBox ID="txtUSPSState" runat="server" Width="40px" MaxLength="2" ReadOnly="true" />
                <label for="txtUSPSZip5">Zip&nbsp;</label><asp:TextBox ID="txtUSPSZip5" runat="server" Width="50px" MaxLength="5" ReadOnly="true" />
                &nbsp;-&nbsp;<asp:TextBox ID="txtUSPSZip4" runat="server" Width="40px" MaxLength="4" ReadOnly="true" />
                <br /><br />
                <asp:Button ID="btnChooseUSPSAddress" runat="server" Text="Choose" style="margin-left:165px" CommandName="ChooseUSPSAddress" OnCommand="OnCommand" />
            </fieldset>
        </div>
        <div style="clear:left"></div>
        <div><asp:Label ID="lblMessage" runat="server" Text="" /></div>
    </div>
    </asp:View>
    </asp:MultiView>
</asp:Content>
