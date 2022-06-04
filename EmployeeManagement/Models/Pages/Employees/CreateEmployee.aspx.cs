using EmploayeeManagementServices;
using EmploayeeManagementServices.Models;
using EmploayeeManagementServices.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement.Models.Pages.Employees
{
    public partial class CreateEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonCreate_OnClick(object sender, EventArgs e)
        {
            CreateData();
        }

        private void CreateData()
        {
            var employeeService = new EmployeeService();

            try
            {
                var employee = new Employee
                {
                    Name = TextBoxName.Text,
                    Gender = RadioButtonListGender.SelectedValue,
                    Age = int.Parse(TextBoxAge.Text),
                    Address = TextBoxAddress.Text,
                    Department = TextBoxDepartment.Text,
                    Position = TextBoxPosition.Text,
                    DateOfJoining = DateTime.Parse(TextBoxDateOfJoining.Text),
                    Email = TextBoxEmail.Text,




                };

                employeeService.Add(employee);

                LabelStatus.ShowStatusMessage("Employee record successfully added!");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                LabelStatus.ShowStatusMessage("Failed to add Employee record!");
            }
        }
    }
}