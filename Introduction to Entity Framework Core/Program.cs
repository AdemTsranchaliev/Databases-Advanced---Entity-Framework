using System;
using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System.Linq;

namespace P02_DatabaseFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //--------- 02. Database First 
            //Console.WriteLine("Hello World!");

            //using (var context=new SoftUniContext())
            //{
            //    var employees = context.Employees.Select(x => x.FirstName ).ToArray();

            //    foreach (var item in employees)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //--------- 3.	Employees Full Information 

            //var context = new SoftUniContext();

            //var employees = context.Employees.OrderBy(x=>x.EmployeeId).Select(x => new 
            //{
            //    x.FirstName,
            //    x.LastName,
            //    x.MiddleName,
            //    x.JobTitle,
            //    x.Salary
            //}).ToArray();

            //foreach (var item in employees)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} {item.MiddleName} {item.JobTitle} {item.Salary:f2}");
            //}


            //--------- 4.	Employees with Salary Over 50 000 

            //var context = new SoftUniContext();

            //var employeesWithSalaryBiggerThan50000 = context.Employees.Where(x => x.Salary > 50000).OrderBy(x => x.FirstName).Select(x => x.FirstName).ToArray();
            //Console.WriteLine( string.Join(Environment.NewLine, employeesWithSalaryBiggerThan50000));


            //--------- 5. Employees from Research and Development 
            //var context = new SoftUniContext();

            //var employees = context.Employees.Where(x => x.Department.Name == "Research and Development").OrderBy(x => x.Salary).ThenByDescending(x => x.FirstName).Select(x => new { personalName = x.FirstName + " " + x.LastName, depName = x.Department.Name, salary = x.Salary }).ToArray();

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine($"{employee.personalName} from {employee.depName} - ${employee.salary:f2}");
            //}

            //--------- 6.	Adding a New Address and Updating Employee

            //var context = new SoftUniContext();

            //var adress = new Address()
            //{
            //    AddressText="Vitoshka 15",
            //    TownId=4
            //};

            //var employee = context.Employees.Where(x => x.LastName == "Nakov").First();
            //employee.Address = adress;

            //context.SaveChanges();

            //var employees = context.Employees.OrderByDescending(x => x.AddressId).Select(x => x.Address.AddressText).ToArray();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(employees[i]);
            //}


            //--------- 7. Employees and Projects 

            //var context = new SoftUniContext();

            //var employees = context.Employees.Where(x => x.EmployeesProjects.Any(p => p.Project.StartDate.Year >= 2001 && p.Project.StartDate.Year <= 2003)).Take(30).Select(x=>new { name = x.FirstName + " "+ x.LastName,managerName=x.Manager.FirstName+ " " + x.Manager.LastName, projects = x.EmployeesProjects.Select(p=>new { projectName= p.Project.Name,startDate=p.Project.StartDate,endDate=p.Project.EndDate }) });

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine($"{employee.name} – Manager: {employee.managerName}");
            //    foreach (var item in employee.projects)
            //    {
            //        Console.Write($"--{item.projectName} - {item.startDate.ToString("M/d/yyyy h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture)} - ");
            //        Console.WriteLine(item.endDate==null? "not finished": $"{item.endDate.Value.ToString("M/d/yyyy h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture)}");
            //    }
            //}


            //--------- 8. Addresses by Town 

            //var context = new SoftUniContext();

            //var addresses = context.Addresses.OrderByDescending(x => x.Employees.Count()).ThenBy(x => x.Town.Name).ThenBy(p => p.AddressText).Take(10).Select(x=>new { Adress=x.AddressText,townName=x.Town.Name,countt=x.Employees.Count});

            //foreach (var item in addresses)
            //{
            //    Console.WriteLine($"{item.Adress}, {item.townName} - {item.countt} employees");
            //}

            //--------- 9. Employee 147 

            //var context = new SoftUniContext();

            //var employee147 = context.Employees.Where(x => x.EmployeeId == 147).Select(x => new { x.FirstName, x.LastName, x.JobTitle, adem = x.EmployeesProjects.OrderBy(a=>a.Project.Name).Select(p=>p.Project) }).FirstOrDefault();

            //Console.WriteLine(employee147.FirstName+" "+ employee147.LastName + " - "+employee147.JobTitle);
            //foreach (var item in employee147.adem)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //--------- 10.	Departments with More Than 5 Employees 

            //var context = new SoftUniContext();

            //var deps = context.Departments.Where(x => x.Employees.Count > 5).OrderBy(x => x.Employees.Count).ThenBy(x => x.Name).Select(y=>new { depName=y.Name,managerName=y.Manager.FirstName+" "+y.Manager.LastName, employee=y.Employees.OrderBy(p=>p.FirstName).ThenBy(p=>p.LastName).Select(p=>new { p.FirstName,p.LastName,p.JobTitle }) } );

            //foreach (var item in deps)
            //{
            //    Console.WriteLine($"{item.depName} – {item.managerName}");
            //    foreach (var item2 in item.employee)
            //    {
            //        Console.WriteLine($"{item2.FirstName} {item2.LastName} - {item2.JobTitle}");
            //    }
            //    Console.WriteLine(new string('-',10));
            //}


            //--------- 11.	Find Latest 10 Projects 

            //var context = new SoftUniContext();

            //var projects = context.Projects.OrderByDescending(x => x.StartDate).Take(10).OrderBy(x => x.Name).Select(x => new { x.Name, x.Description, x.StartDate });

            //foreach (var item in projects)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Description);
            //    Console.WriteLine(item.StartDate.ToString("M/d/yyyy h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture));
            //}

            //--------- 12.	Increase Salaries 

            //var context = new SoftUniContext();

            //var employees = context.Employees.Where(x => x.Department.Name == "Engineering" || x.Department.Name == "Tool Design" || x.Department.Name == "Marketing" || x.Department.Name == "Information Services");

            //foreach (var item in employees)
            //{
            //    item.Salary= (decimal)item.Salary+(decimal)(item.Salary)* (decimal)0.12;
            //}
            //context.SaveChanges();

            //employees = employees.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            //foreach (var item in employees)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} (${item.Salary:f2})");
            //}


            //--------- 13.	Find Employees by First Name Starting With Sa

            //var context = new SoftUniContext();

            //var empl = context.Employees.Where(x => x.FirstName.StartsWith("Sa")).OrderBy(x=>x.FirstName).ThenBy(x=>x.LastName).Select(x => new { x.FirstName, x.LastName, x.Salary, x.JobTitle });
            //foreach (var item in empl)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} - {item.JobTitle} - (${item.Salary:f2})");
            //}

            //--------- 14.	Delete Project by Id 

            //var context = new SoftUniContext();

            //var project = context.Projects.Find(2);

            //var employeesProjects = context.EmployeesProjects.Where(x => x.ProjectId == 2);
            //foreach (var item in employeesProjects)
            //{
            //    context.EmployeesProjects.Remove(item);
            //}
            //context.Projects.Remove(project);
            //context.SaveChanges();

            //var projects = context.Projects.Take(10);


            //foreach (var item in projects)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //--------- 15.	Delete Project by Id 

            //var context = new SoftUniContext();

            //var townInput = Console.ReadLine();

            //var employees = context.Employees.Where(x => x.Address.Town.Name == townInput);

            //foreach (var item in employees)
            //{
            //    item.AddressId = null;
            //}

            //var addressesWithGivenTown = context.Addresses.Where(x => x.Town.Name==townInput);
            //foreach (var item in addressesWithGivenTown)
            //{
            //    context.Addresses.Remove(item);
            //}
            //context.Towns.Remove(context.Towns.Where(x=>x.Name==townInput).FirstOrDefault());

            //Console.WriteLine($"{addressesWithGivenTown.Count()} address in {townInput} was deleted");
        }
    }
}
