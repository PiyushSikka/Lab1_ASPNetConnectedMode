<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormEmployee.aspx.cs" Inherits="Lab1_ASPNetConnectedMode.GUI.WebFormEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 304px;
        }
        .auto-style2 {
            height: 96px;
            width: 280px;
        }
        .auto-style3 {
            position: absolute;
            top: 54px;
            left: 366px;
            z-index: 1;
            height: 53px;
            width: 321px;
        }
        .auto-style4 {
            height: 96px;
            width: 246px;
        }
        .auto-style5 {
            width: 246px;
        }
        .auto-style6 {
            width: 246px;
            height: 33px;
        }
        .auto-style7 {
            height: 33px;
            width: 280px;
        }
        .auto-style8 {
            height: 96px;
            width: 267px;
        }
        .auto-style9 {
            height: 33px;
            width: 267px;
        }
        .auto-style10 {
            width: 267px;
        }
        .auto-style11 {
            width: 280px;
        }
        .auto-style12 {
            width: 998px;
            height: 180px;
            position: absolute;
            top: 432px;
            left: 2px;
            z-index: 1;
        }
        .auto-style13 {
            width: 267px;
            margin-left: 40px;
        }
    </style>
</head>
<body style="z-index: 1; width: 1014px; height: 228px; position: absolute; top: 0px; left: 0px">
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Font-Bold="True" Font-Size="Large" Text="Employee Maintainance"></asp:Label>
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style2">
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label2" runat="server" Text="Employee ID"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="tbEmployeeId" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" Width="107px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label3" runat="server" Text="First Name"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style11">
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" Width="108px" OnClick="btnUpdate_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label4" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="tbLastName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style11">
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="107px" OnClick="btnDelete_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label5" runat="server" Text="Job Type"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="tbJobType" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style11">
                    <asp:Button ID="btnListAll" runat="server" Text="List All" Width="107px" OnClick="btnListAll_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label6" runat="server" Text="Search By"></asp:Label>
                </td>
                <td class="auto-style13">
                    <asp:DropDownList ID="ddlSearchList" runat="server" Width="239px">
                        <asp:ListItem>EmployeeId</asp:ListItem>
                        <asp:ListItem>FirstName</asp:ListItem>
                        <asp:ListItem>LastName</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style11">
                    <asp:TextBox ID="tbSearchInput" runat="server" Width="210px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnSearch" runat="server" Text="Search" Width="104px" OnClick="btnSearch_Click" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="gvEmployee" runat="server" CssClass="auto-style12">
        </asp:GridView>
    </form>
</body>
</html>
