<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultEmployee.aspx.cs" Inherits="EmployeeManagement.Models.Pages.Employees.DefaultEmployee" %>
<%@ Import Namespace="EmploayeeManagementServices" %>
<%@Import Namespace="EmploayeeManagementServices.Utilities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="/www-resources/css/form.css" />
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
    </style>

</head>
<body>
    <h1>View All Employees</h1>

    <a href="CreateEmployee.aspx">Add new Employee</a>
    <br />
    <form id="form1" runat="server">
       
        <div>
            <table class="data-view">
                <tr>
                    <th>Emp_no</th>
                    <th>Name</th>
                    <th>Gender</th>
                    <th>Age</th>
                    <th>Address</th>
                    <th>Department</th>
                    <th>Position</th>
                    <th>DateOfJoining</th>
                    <th>Email</th>
                    <th colspan="2"></th>
                </tr>
                <%
                    
                    var employeeService = new EmployeeService();
                    var employees = employeeService.GetAll();

                    foreach (var employee in employees)
                    {
                %>
                <tr>
                    <td><%= employee.Emp_no %></td>
                    <td><%= employee.Name %></td>
                    <td><%= employee.Gender %></td>
                    <td><%= employee.Age %></td>
                    <td><%= employee.Address %></td>
                    <td><%= employee.Department %></td>
                    <td><%= employee.Position %></td>
                    <td><%= employee.DateOfJoining %></td>
                    <td><%= employee.Email %></td>

                    <%--<td><%= employee.Description.GetFormattedValue() %></td>--%>
                    <td><a href="UpdateEmployee.aspx?id=<%= employee.Emp_no %>">Edit</a></td>
                    <td><a href="DeleteEmployee.aspx?id=<%= employee.Emp_no %>">Delete</a></td>
                </tr>
                <%
                    }
                %>
            </table>
        </div>
    </form>
</body>
</html>
