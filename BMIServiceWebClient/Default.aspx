<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BMIServiceWebClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 30px;
            width: 137px;
        }
    </style>
</head>
<body style="width: 110px; height: 24px">
    <form id="form1" runat="server">
        <p style="width: 704px">
            Enter Height (in):&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Enter Weight (lb):"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p style="width: 704px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="MyBMI (SOAP Service)" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p style="width: 704px">
            <asp:Literal ID="Literal5" runat="server"></asp:Literal>
        </p>
        <p style="width: 704px">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="MyHealth (SOAP Service)" />
        </p>
        <p style="width: 704px">
            <asp:Literal ID="Literal6" runat="server"></asp:Literal>
        </p>
        <p style="width: 704px">
            <asp:Literal ID="Literal7" runat="server"></asp:Literal>
        </p>
        <p style="width: 704px">
            &nbsp;</p>
        <p style="width: 704px">
            &nbsp;</p>
        <p style="width: 704px">
            &nbsp;</p>
        <p style="width: 704px">
            &nbsp;</p>
        <p style="width: 704px">
            &nbsp;</p>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
