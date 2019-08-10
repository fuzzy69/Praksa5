using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;

namespace Praksa5
{
    public class City
    {
        public int Zip { get; set; }
        public string Name { get; set; }
    }

    public class Employee
    {
        public Int64 JMBG { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ParentName { get; set; }
        public string Address { get; set; }
        public int CityZip { get; set; }
        public string Email { get; set; }
    }

    public class EmployeeAndCity
    {
        public Int64 JMBG { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string ParentName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int CityZip { get; set; }
        public string Email { get; set; }
    }

    static class Helpers
    {
        public static City[] ReadCSVMesto(string filePath)
        {
            return (
                from l in File.ReadAllLines(filePath)
                let cells = l.Split(',').Select(s => s).ToArray()
                where (cells.Length == 2 && Int32.TryParse(cells[0], out _))
                select new City
                {
                    Zip = Int32.Parse(cells[0]),
                    Name = cells[1]
                }
            ).ToArray();
        }

        public static Employee[] ReadCSVZaposleni(string filePath)
        {
            return (
                from l in File.ReadAllLines(filePath)
                let cells = l.Split(',').Select(s => s).ToArray()
                where (cells.Length == 7 && Int64.TryParse(cells[0], out _) && Int32.TryParse(cells[5], out _))
                select new Employee
                {
                    JMBG = Int64.Parse(cells[0]),
                    Name = cells[1],
                    Surname = cells[2],
                    ParentName = cells[3],
                    Address = cells[4],
                    CityZip = Int32.Parse(cells[5]),
                    Email = cells[6]
                }
            ).ToArray();
        }

        public static string OpenFile(string title, string filter = "All files (*.*)|*.*")
        {
            string filePath = null;
            var fileDialog = new OpenFileDialog {
                Title = title,
                Filter = filter
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(fileDialog.FileName))
                    filePath = fileDialog.FileName;
            }

            return filePath;
        }
    }
}
