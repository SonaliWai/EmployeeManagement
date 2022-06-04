using EmploayeeManagementServices;
using EmploayeeManagementServices.Models;
using EmploayeeManagementServices.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement.Models.Pages.Employees
{
    public partial class UpdateEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            ShowDataToUpdate();
        }
        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            var employeeService = new EmployeeService();

            try
            {
                var idText = Request.QueryString["id"];

                var employee = new Employee();

                employee.Name = TextBoxName.Text;
                employee.Gender = RadioButtonListGender.SelectedValue;
                employee.Age = int.Parse(TextBoxAge.Text);
                employee.Address = TextBoxAddress.Text; //Gender = MaleRadioButton.Checked ? MaleRadioButton.Text : MaleRadioButton.Checked ? OtherRadioButton.Text : OtherRadioButton.Text,
                employee.Department = TextBoxDepartment.Text;
                employee.Position = TextBoxPosition.Text;
                employee.DateOfJoining = DateTime.Parse(TextBoxDateOfJoining.Text);
                employee.Email = TextBoxEmail.Text;






                employeeService.Update(employee);

                LabelStatus.ShowStatusMessage("Employee record successfully updated!");
            }
            catch (Exception exception)
            {
                Debug.Print(exception.StackTrace);
                LabelStatus.ShowStatusMessage("Failed to update Employee record!");
            }
        }

        private void ShowDataToUpdate()
        {
            var Emp_noText = Request.QueryString["Emp_no"];
            try
            {
                var emp = int.Parse(Emp_noText);

                var employeeService = new EmployeeService();

                var employee = employeeService.GetById(emp);

                if (employee == null)
                {
                    LabelStatus.ShowStatusMessage("Specified Id not found in database!");
                    return;
                }

                TextBoxName.Text = employee.Name;
                RadioButtonListGender.SelectedValue = employee.Gender;
                TextBoxAge.Text = employee.Age.ToString();
                TextBoxAddress.Text = employee.Address;
                TextBoxDepartment.Text = employee.Department;
                TextBoxPosition.Text = employee.Position;
                TextBoxDateOfJoining.Text = employee.DateOfJoining.ToString();
                TextBoxEmail.Text = employee.Email;
               
                //LoadDepartmentDropDown();
            }
            catch (Exception e)
            {
                LabelStatus.ShowStatusMessage("Emp_id parameter not found!");
            }
        }

        //private void LoadDepartmentDropDown()
        //{
        //    var employeeService = new EmployeeService();
        //    DropDownListDepartmentRefId.DataSource = employeeService.GetAllForDropDown();
        //    DropDownListDepartmentRefId.DataBind();
        //}
    }
}