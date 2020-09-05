using CalcLib;
using Microsoft.Win32;
using OfficeOpenXml;
using OfficeOpenXml.Filter;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator.WPF
{

    public interface IFileProvider
    {
        public bool FileExists(string path);
        public IEnumerable<SimpleCalculator> ReadFromExcel(string path);
        public Task<IEnumerable<SimpleCalculator>> ReadFromExcelAsync(string path);
        public void ExportFileToExcel(ObservableCollection<SimpleCalculator> history);
    }
    class FileProvider : IFileProvider
    {
        public bool FileExists(string path) => File.Exists(path);
        public void ExportFileToExcel(ObservableCollection<SimpleCalculator> history)
        {
            var fileName = getFileName();
            
            if(fileName == null)
            {
                return;
            }
            if (File.Exists(fileName))
            {
                var result = MessageBox.Show("File exists, overwrite it?", "Overwrite Exsiting File", MessageBoxButton.YesNo);
                if(result == MessageBoxResult.Yes)
                {
                    File.Delete(fileName);
                }
                else
                {
                    return;
                }
            }

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using(ExcelPackage package = new ExcelPackage(new FileInfo(fileName)))
            {
                var sheet = package.Workbook.Worksheets.Add("Export");
                sheet.Cells[1, 1].Value = "First Number";
                sheet.Cells[1, 2].Value = "Second Number";
                sheet.Cells[1, 3].Value = "Result";

                var row = 1;
                foreach(var calc in history)
                {
                    row++;
                    sheet.Cells[row, 1].Value = calc.firstNumber;
                    sheet.Cells[row, 2].Value = calc.secondNumber;
                    sheet.Cells[row, 3].Value = calc.result;
                }

                sheet.Tables.Add(sheet.Cells[1, 1, row, 3], "ExportTable");

                sheet.Column(1).Style.Numberformat.Format = "0.00";
                sheet.Column(2).Style.Numberformat.Format = "0.00";
                sheet.Column(3).Style.Numberformat.Format = "0.00";

                sheet.Column(1).Width = 20;
                sheet.Column(2).Width = 20;
                sheet.Column(3).Width = 20;

                package.Save();
            }

            new Process
            {
                StartInfo = new ProcessStartInfo(fileName)
                {
                    UseShellExecute = true
                }
            }.Start();
        }

        public IEnumerable<SimpleCalculator> ReadFromExcel(string path)
        {
            var rows = new List<SimpleCalculator>();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using(ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(path)))
            {
                var sheets = package.Workbook.Worksheets.First();
                for (int row = 2; row <= sheets.Dimension.End.Row; row++)
                {
                    rows.Add(new SimpleCalculator
                    {
                        firstNumber = (double)sheets.Cells[row, 1].Value,
                        secondNumber = (double)sheets.Cells[row, 2].Value,
                        result = (double)sheets.Cells[row, 3].Value,

                    });
                }
            }
            return rows;
        }

        public async Task<IEnumerable<SimpleCalculator>> ReadFromExcelAsync(string path)
        {
            return await Task.Run(() =>
            {
                var rows = new List<SimpleCalculator>();
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
                {
                    var sheets = package.Workbook.Worksheets.First();
                    for (int row = 2; row <= sheets.Dimension.End.Row; row++)
                    {
                        rows.Add(new SimpleCalculator
                        {
                            firstNumber = (double)sheets.Cells[row, 1].Value,
                            secondNumber = (double)sheets.Cells[row, 2].Value,

                        });
                    }
                }
                return rows;
            });
        }

        private string getFileName()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            openFileDialog.Title = "Locate your Output File";
            openFileDialog.CheckFileExists = false;
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() ?? false)
            {
                return openFileDialog.FileName;
            }
            return null;
        }
    }
}
