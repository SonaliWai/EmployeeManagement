using EmploayeeManagementServices.Models;
using EmploayeeManagementServices.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploayeeManagementServices
{
    public class EmployeeService
    {
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["EmployeeManagementApp"].ConnectionString;

        public List<Employee> GetAll()
        {
            var employees = new List<Employee>();

            using (var connection = new SqlConnection(ConnectionString))
            {
                const string cmdText = "Employee_GetAll";

                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var employee = new Employee
                            {
                                Emp_no = (int)reader["Emp_no"],
                                Name = reader["Name"].GetDataFromDb<string>(),
                                Gender = reader["Gender"].GetDataFromDb<string>(),
                                Age = (int)reader["Age"],
                                Address = reader["Address"].GetDataFromDb<string>(),
                                Department = reader["Department"].GetDataFromDb<string>(),
                                Position = reader["Position"].GetDataFromDb<string>(),
                                DateOfJoining = (DateTime)reader["DateOfJoining"],
                                Email = reader["Email"].GetDataFromDb<string>(),
                                //DepatmentObj =reader["DeparmentName"]
                            };

                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }

        //public void Delete(int id)
        //{
        //    using (var connection = new SqlConnection(WebConfigHelper.ConnectionString))
        //    {
        //        const string cmdText = "Employees_Delete";

        //        using (var command = new SqlCommand(cmdText, connection))
        //        {
        //            command.CommandType = CommandType.StoredProcedure;

        //            command.Parameters.AddWithValue("@Id", id);

        //            connection.Open();

        //            var rowsAffected = command.ExecuteNonQuery();

        //            if (rowsAffected != 1)
        //                throw new Exception("Add returned 0 rows affected. Expecting 1 rows affected");
        //        }
        //    }
        //}

        public void Add(Employee employee)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                const string cmdText = "Employee_Add";

                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Name", employee.Name);
                    command.Parameters.AddWithValue("@Gender", employee.Gender);
                    command.Parameters.AddWithValue("@Age", employee.Age);
                    command.Parameters.AddWithValue("@Address", employee.Address);
                    command.Parameters.AddWithValue("@Department", employee.Department);
                    command.Parameters.AddWithValue("@Position", employee.Position);
                    command.Parameters.AddWithValue("@DateOfJoining", employee.DateOfJoining);
                    command.Parameters.AddWithValue("@Email", employee.Email);


                    connection.Open();

                    var rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected != 1)
                        throw new Exception("Add returned 0 rows affected. Expecting 1 rows affected");
                }
            }
        }
        public void Update(Employee employee)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                const string cmdText = "Employee_Update";

                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Emp_no", employee.Emp_no);
                    command.Parameters.AddWithValue("@Name", employee.Name.GetDataFromUi<string>());
                    command.Parameters.AddWithValue("@Gender", employee.Gender.GetDataFromUi<string>());
                    command.Parameters.AddWithValue("@Age", employee.Age.GetDataFromUi<int>());
                    command.Parameters.AddWithValue("@Address", employee.Address.GetDataFromUi<string>());
                    command.Parameters.AddWithValue("@Department", employee.Department.GetDataFromUi<string>());
                    command.Parameters.AddWithValue("@Position", employee.Position.GetDataFromUi<string>());
                    command.Parameters.AddWithValue("@DateOfJoining", employee.DateOfJoining.GetDataFromUi<DateTime>());
                    command.Parameters.AddWithValue("@Email", employee.Email.GetDataFromUi<string>());
                   


                    connection.Open();

                    var rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected != 1)
                        throw new Exception("Add returned 0 rows affected. Expecting 1 rows affected");
                }
            }
        }
        public Employee GetById(int Emp_no)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                const string cmdText = "Employee_GetById";

                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Emp_no", Emp_no);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var employee = new Employee
                            {
                                Emp_no = (int)reader["Emp_no"],
                                Name = (string)reader["Name"],
                                Gender = (string)reader["Gender"],
                                Age = (int)reader["Age"],
                                Address = (string)reader["Address"],
                                Department = (string)reader["Department"],
                                Position = (string)reader["Position"],
                                DateOfJoining = (DateTime)reader["DateOfJoining"],
                                Email = (string)reader["Email"]
                                
                            };
                            return employee;
                        }
                    }
                }
            }

            return null;
        }
    }
}
