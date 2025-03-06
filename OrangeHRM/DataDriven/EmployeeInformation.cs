using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.DataDriven
{
    public class EmployeeInformation
    {
        public int Id { get; set; }
        public String FirstName { get; set; }

        public String LastName { get; set; }


        public EmployeeInformation()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }



        public List<EmployeeInformation> GetSetupData()
        {
            List<EmployeeInformation> output = new List<EmployeeInformation>();
            output.Add(new EmployeeInformation { Id = 01, FirstName = "Ab De Villiers", LastName = "Abraham" });
            output.Add(new EmployeeInformation { Id = 02, FirstName = "Faf", LastName = "Du Plessis" });
            output.Add(new EmployeeInformation { Id = 03, FirstName = "Quinton", LastName = "De Kock" });

            return output;

        }

        public async Task<List<EmployeeInformation>> LoadExcelFile(FileInfo File)
        {
            List<EmployeeInformation> output = new List<EmployeeInformation>();
            using (var package = new ExcelPackage(File))
            {

                await package.LoadAsync(File);

                var ws = package.Workbook.Worksheets[0];



                int row = 3;
                int col = 1;

                while (String.IsNullOrEmpty(ws.Cells[row, col].Value?.ToString()) == false)
                {
                    EmployeeInformation emp = new EmployeeInformation();
                    emp.Id = int.Parse(ws.Cells[row, col].Value.ToString());
                    emp.FirstName = (ws.Cells[row, col + 1].Value.ToString());
                    emp.LastName = (ws.Cells[row, col + 2].Value.ToString());
                    output.Add(emp);
                    row += 1;

                }

            }

            return output;

            


        }


    }
}
