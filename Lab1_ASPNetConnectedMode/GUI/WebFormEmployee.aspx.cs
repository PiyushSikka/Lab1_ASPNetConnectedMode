using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab1_ASPNetConnectedMode.BLL;
using System.Data.SqlClient;
using Lab1_ASPNetConnectedMode.DAL;
using Lab1_ASPNetConnectedMode.VALIDATOR;

namespace Lab1_ASPNetConnectedMode.GUI
{
    public partial class WebFormEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
           
            Employee emp = new Employee();

            if (Validation.IsValidId(tbEmployeeId.Text) && EmployeeDB.IsDuplicateId(Convert.ToInt32(tbEmployeeId.Text)))
            {
                emp.EmployeeId = Convert.ToInt32(tbEmployeeId.Text);
                emp.FirstName = tbFirstName.Text;
                emp.LastName = tbLastName.Text;
                emp.JobTitle = tbJobType.Text;
                emp.SaveEmployee(emp);
                MessageBox.Show("Data Saved");
            }
            else
            {
                MessageBox.Show("Error, Data is not valid", "Validation error");
            }
         
        }

        protected void btnListAll_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            gvEmployee.DataSource = emp.getEmployeeList();
            gvEmployee.DataBind();
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (!(EmployeeDB.IsDuplicateId(Convert.ToInt32(tbEmployeeId.Text))))
            {
                if (Validation.IsValidName(tbFirstName.Text) && Validation.IsValidName(tbLastName.Text))
                {
                    emp.EmployeeId = Convert.ToInt32(tbEmployeeId.Text);
                    emp.FirstName = tbFirstName.Text;
                    emp.LastName = tbLastName.Text;
                    emp.JobTitle = tbJobType.Text;
                    emp.UpdateEmployee(emp);
                    MessageBox.Show("Data Updated,Thanks", "Confirmation");
                    tbEmployeeId.Text = tbFirstName.Text = tbLastName.Text = tbJobType.Text = null;
                }
                else
                {
                    MessageBox.Show("Enter Valid Name", "Error");
                }
            }
            else
            {
                MessageBox.Show("ID does not exist", "Error");
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (!(EmployeeDB.IsDuplicateId(Convert.ToInt32(tbEmployeeId.Text))))
            {
                if (Validation.IsValidName(tbFirstName.Text) && Validation.IsValidName(tbLastName.Text))
                {
                    emp.EmployeeId = Convert.ToInt32(tbEmployeeId.Text);
                    emp.FirstName = tbFirstName.Text;
                    emp.LastName = tbLastName.Text;
                    emp.JobTitle = tbJobType.Text;
                    emp.DeleteEmployee(emp);
                    MessageBox.Show("Data Deleted,Thanks", "Confirmation");
                    tbEmployeeId.Text = tbFirstName.Text = tbLastName.Text = tbJobType.Text = null;
                }
                else
                {
                    MessageBox.Show("Enter Valid Name", "Error");
                }
            }
            else
            {
                MessageBox.Show("ID does not exist", "Error");
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            gvEmployee.DataSource = emp.getEmployeeInfo(Convert.ToInt32(tbSearchInput.Text));
              
            gvEmployee.DataBind();
           
        }
    }
}