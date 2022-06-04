<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateEmployee.aspx.cs" Inherits="EmployeeManagement.Models.Pages.Employees.CreateEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
    <link rel="stylesheet" href="/www-resources/css/form.css" />
    <style type="text/css">
        .auto-style1{
            height:26px;
        }

    </style>
</head>
<body >
    <h1>Create new Employee</h1>
    <form  id="form1" runat="server" class="border border-secondary w-50 p-3 bg-secondary" style="align-items:center; margin-left:200px; ">
        <div class="status-message">
            <asp:Label runat="server" id="LabelStatus" Visible="false" />
        </div>
        <div>
            <table class="form-block"> 
                
                <tr>
                    <td>
                        <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxName" runat="server" placeholder="Enter  Name"></asp:TextBox>
                    </td>
                </tr>
               
                <tr>
                    <td>
                        <asp:Label ID="GenderLabel" runat="server" Text="Gender"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList runat="server" ID="RadioButtonListGender" RepeatDirection="Horizontal">
                            <asp:ListItem Value="M">Male</asp:ListItem>
                            <asp:ListItem Value="F">Female</asp:ListItem>
                            <asp:ListItem Value="O">Other</asp:ListItem>
                        </asp:RadioButtonList>                    
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="LabelAge" runat="server" Text="Age"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxAge" runat="server" placeholder="Enter  Age"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="LabelAddress" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxAddress"  runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="LabelDepartment" runat="server" Text="Department"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxDepartment"  runat="server" placeholder="Enter Department"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="LabelPosition" runat="server" Text="Position"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxPosition"  runat="server" placeholder="Enter Position"></asp:TextBox>
                    </td>
                </tr>


                <tr>
                    <td>
                        <asp:Label ID="LabelDateOfJoining" runat="server" Text="DateOfJoining"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxDateOfJoining" TextMode="Date" runat="server"></asp:TextBox>                 
                    </td>
                </tr>

                 <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxEmail" TextMode="Email" runat="server" placeholder="Enter Email"></asp:TextBox>
                    </td>
                </tr>

                                                        

                 <tr>
                    <td></td>
                    <td>
                        <asp:Button runat="server" ID="ButtonCreate" Text="Create" OnClick="ButtonCreate_OnClick" />
                        <a style="float: right" href="DefaultEmployee.aspx"><input type="button" value="Back to Listing" /></a>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
