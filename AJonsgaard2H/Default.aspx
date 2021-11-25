<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AJonsgaard2H._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    

    <div class="row">
        <div class="col-md-6">
            <h2>DateTime Methods</h2>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="1) Now:"></asp:Label>
                <asp:TextBox ID="TextBox1aResult" runat="server" Enabled="False"></asp:TextBox>
                <asp:TextBox ID="TextBox1bResult" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="2) Today:"></asp:Label>
                <asp:TextBox ID="TextBox2aResult" runat="server" Enabled="False"></asp:TextBox>
                <asp:TextBox ID="TextBox2bResult" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="3) Today YMD:"></asp:Label>
                <asp:TextBox ID="TextBox3aResult" runat="server" Enabled="False" Width="40px"></asp:TextBox>
                <asp:TextBox ID="TextBox3bResult" runat="server" Enabled="False" Width="30px"></asp:TextBox>
                <asp:TextBox ID="TextBox3cResult" runat="server" Enabled="False" Width="30px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="4) AddDays(90):"></asp:Label>
                <asp:TextBox ID="TextBox4Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="5) AddMoths(3):"></asp:Label>
                <asp:TextBox ID="TextBox5Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="6) (Y.M.D):"></asp:Label>
                <asp:TextBox ID="TextBox6aInput" runat="server" Width="40px">1995</asp:TextBox>
                <asp:TextBox ID="TextBox6bInput" runat="server" Width="30px">12</asp:TextBox>
                <asp:TextBox ID="TextBox6cInput" runat="server" Width="30px">13</asp:TextBox>
                <asp:TextBox ID="TextBox6Reault" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="7) Parse():"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server">November 1, 2021</asp:TextBox>
                <asp:TextBox ID="TextBox7Reault" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label8" runat="server" Text="8) TryParse():"></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server">November 1, 2021</asp:TextBox>
                <asp:TextBox ID="TextBox8Reault" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="9) DateA - DateB:"></asp:Label>
                <asp:TextBox ID="TextBox9a" runat="server" Width="90px">1/13/2013</asp:TextBox>
                <asp:TextBox ID="TextBox9b" runat="server" Width="90px">12/12/2012</asp:TextBox>
                <asp:TextBox ID="TextBox9Reault" runat="server" Width="80px" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label10" runat="server" Text="10) DateA &gt; DateB:"></asp:Label>
                <asp:TextBox ID="TextBox10a" runat="server" Width="90px">1/13/2013</asp:TextBox>
                <asp:TextBox ID="TextBox10b" runat="server" Width="90px">12/12/2012</asp:TextBox>
                <asp:TextBox ID="TextBox10Reault" runat="server" Width="130px" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="DateCalculationsButton" runat="server" Text="Date Calculations" OnClick="DateCalculationsButton_Click" />
            </div>
        </div>
        <div class="col-md-6">
            <h2>String Methods</h2>
            <div class="form-group">
                <asp:Label ID="Label11" runat="server" Text="1) Remove/Insert:"></asp:Label>
                <asp:TextBox ID="TextBox11" runat="server">late</asp:TextBox>
                <asp:TextBox ID="TextBox11Reault" runat="server" Width="130px" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label12" runat="server" Text="2) Remove/Insert:"></asp:Label>
                <asp:TextBox ID="TextBox12" runat="server">cater</asp:TextBox>
                <asp:TextBox ID="TextBox12Reault" runat="server" Width="130px" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label13" runat="server" Text="3) Substring/ToUpper:"></asp:Label>
                <asp:TextBox ID="TextBox13" runat="server">ABBlue22</asp:TextBox>
                <asp:TextBox ID="TextBox13Reault" runat="server" Width="130px" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label14" runat="server" Text="4) PadLeft:"></asp:Label>
                <asp:TextBox ID="TextBox14" runat="server">123.45</asp:TextBox>
                <asp:TextBox ID="TextBox14Reault" runat="server" Width="130px" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label15" runat="server" Text="5) Replace:"></asp:Label>
                <asp:TextBox ID="TextBox15" runat="server">(651) 385-6300</asp:TextBox>
                <asp:TextBox ID="TextBox15Reault" runat="server" Width="130px" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label16" runat="server" Text="6) Replace/Length/Insert:"></asp:Label>
                <asp:TextBox ID="TextBox16" runat="server">(651) 385-6300</asp:TextBox>
                <asp:TextBox ID="TextBox16Reault" runat="server" Width="130px" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label17" runat="server" Text="7) ToLower/Contains:"></asp:Label>
                <asp:TextBox ID="TextBox17" runat="server">308 Pioneer Rd</asp:TextBox>
                <asp:TextBox ID="TextBox17Reault" runat="server" Width="130px" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label18" runat="server" Text="8) IndexOf/Substring:"></asp:Label>
                <asp:TextBox ID="TextBox18" runat="server" Width="160px">1250 Homer Rd, Winona</asp:TextBox>
                <asp:TextBox ID="TextBox18Reault" runat="server" Width="130px" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label19" runat="server" Text="9) LastIndexOf/Substring:"></asp:Label>
                <asp:TextBox ID="TextBox19" runat="server" Width="210px">111 1st St, Lake City, MN 55041</asp:TextBox>
                <asp:TextBox ID="TextBox19Reault" runat="server" Width="90px" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label20" runat="server" Text="10) StringBuilder.Append:"></asp:Label>
                <asp:Label ID="Label20Result" runat="server" Text="[Label20Result]"></asp:Label>
            </div>
            <div class="form-group">
                <asp:Button ID="StringCalculationsButton" runat="server" Text="String Calculations" OnClick="StringCalculationsButton_Click" />
            </div>
        </div>
    </div>

</asp:Content>
