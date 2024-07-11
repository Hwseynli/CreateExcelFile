using System;
using System.Collections.Generic;
using System.IO;
using CreateExcelFile.Dal;
using OfficeOpenXml;

namespace CreateExcelFile;

class Program
{
    static void Main(string[] args)
    {
        // DbContext yaratmaq
        DbContext dbContext = new DbContext();

        // EPPlus istifadə edərək Excel faylını yaradaq
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Sheet1");

            // Sütun başlıqlarını əlavə edirik
            worksheet.Cells[1, 1].Value = "ID";
            worksheet.Cells[1, 2].Value = "First Name";
            worksheet.Cells[1, 3].Value = "Last Name";
            worksheet.Cells[1, 4].Value = "Father Name";
            worksheet.Cells[1, 5].Value = "Birthday";

            // Məlumatları əlavə edirik
            int row = 2;
            foreach (var person in dbContext.People)
            {
                worksheet.Cells[row, 1].Value = person.ID;
                worksheet.Cells[row, 2].Value = person.FirstName;
                worksheet.Cells[row, 3].Value = person.LastName;
                worksheet.Cells[row, 4].Value = person.FatherName;
                worksheet.Cells[row, 5].Value = person.Birthday.ToString("dd.MM.yyyy");
                row++;
            }

            // Excel faylını yadda saxlamaq
            string filePath = @"\Users\zeyneb\Projects\CreateExcelFile\files\people.xlsx";
            FileInfo file = new FileInfo(filePath);
            package.SaveAs(file);
        }

        Console.WriteLine($"Excel faylı uğurla yaradıldı!");
    }
}