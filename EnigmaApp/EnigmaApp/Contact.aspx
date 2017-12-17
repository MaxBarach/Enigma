<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="EnigmaApp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Button ID="ResetButton" runat="server" OnClick="ResetButton_Click" Text="Reset" Width="86px" />
        <asp:DropDownList ID="RotorNumList" runat="server" OnSelectedIndexChanged="RotorNumList_SelectedIndexChanged">
            <asp:ListItem>3</asp:ListItem>
        </asp:DropDownList>
    </div>
    <asp:Button ID="QButton" runat="server" OnClick="QButton_Click" Text="Q" />
    <asp:Button ID="WButton" runat="server" OnClick="WButton_Click" Text="W" />
    <asp:Button ID="EButton" runat="server" OnClick="EButton_Click" Text="E" />
    <asp:Button ID="RButton" runat="server" OnClick="RButton_Click" Text="R" />
    <asp:Button ID="TButton" runat="server" OnClick="TButton_Click" Text="T" />
    <asp:Button ID="YButton" runat="server" OnClick="YButton_Click" Text="Y" />
    <asp:Button ID="UButton" runat="server" OnClick="UButton_Click" Text="U" />
    <asp:Button ID="IButton" runat="server" OnClick="IButton_Click" Text="I" Width="21px" />
    <asp:Button ID="OButton" runat="server" OnClick="OButton_Click" Text="O" />
    <asp:Button ID="PButton" runat="server" OnClick="PButton_Click" Text="P" />
    <div>
    </div>
    <asp:Button ID="AButton" runat="server" OnClick="AButton_Click" Text="A" />
    <asp:Button ID="SButton" runat="server" OnClick="SButton_Click" Text="S" />
    <asp:Button ID="DButton" runat="server" OnClick="DButton_Click" Text="D" />
    <asp:Button ID="FButton" runat="server" OnClick="FButton_Click" Text="F" />
    <asp:Button ID="GButton" runat="server" OnClick="GButton_Click" Text="G" />
    <asp:Button ID="HButton" runat="server" OnClick="HButton_Click" Text="H" />
    <asp:Button ID="JButton" runat="server" OnClick="JButton_Click" Text="J" />
    <asp:Button ID="KButton" runat="server" OnClick="KButton_Click" Text="K" />
    <asp:Button ID="LButton" runat="server" OnClick="LButton_Click" Text="L" />
    <div>
    </div>
    <asp:Button ID="ZButton" runat="server" OnClick="ZButton_Click" Text="Z" />
    <asp:Button ID="XButton" runat="server" OnClick="XButton_Click" Text="X" />
    <asp:Button ID="CButton" runat="server" OnClick="CButton_Click" Text="C" />
    <asp:Button ID="VButton" runat="server" OnClick="VButton_Click" Text="V" />
    <asp:Button ID="BButton" runat="server" OnClick="BButton_Click" Text="B" />
    <asp:Button ID="NButton" runat="server" OnClick="NButton_Click" Text="N" />
    <asp:Button ID="MButton" runat="server" OnClick="MButton_Click" Text="M" />
    <asp:Button ID="SpaceButton" runat="server" OnClick="SpaceButton_Click" Text=" _ " />
    <div>
        <asp:Label ID="OutputLabel" runat="server" Text="Output: "></asp:Label>
        <div>
            <asp:Label ID="OutputText" runat="server" Text=" "></asp:Label>
            <asp:Label ID="OutputTxt" runat="server" Text=" "></asp:Label>
        </div>
    </div>
</asp:Content>
