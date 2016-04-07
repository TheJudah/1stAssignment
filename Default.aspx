<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Birthday Calculator</title>
    <link href="FirstStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <h1>Birthday Calculator</h1>
</hr>
<p>Choose your birthday</p>
    <form id="form1" runat="server">
    
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <!-- this is a comment. the above adds a calendar. properties. -->
        <p>Enter your name <asp:TextBox ID="NameTextBox" runat="server">
        </asp:TextBox>
        </p>

        <p> <asp:Button ID="Button1" runat="server" Text="Button" Width="72px" OnClick="Button1_Click" /> </p>
        <asp:Label ID="ResultLabel" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
        
