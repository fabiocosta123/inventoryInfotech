using CsvHelper;
using OfficeOpenXml;
using System.Globalization;

namespace Inventory.Helper
{
    public class ReadCSVHelper
    {
        public static IEnumerable<T> ReadFromCsv<T>(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                
                return csv.GetRecords<T>().ToList();
            }
        }

        internal static void ExportToExcel(string data, string fileName)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Create a new worksheet
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("inventory");

                // Assuming your API returns JSON data, you might want to deserialize it
                // and iterate through the data to fill in the Excel sheet.
                // For example, if the data is a JSON array of objects:
                // JArray dataArray = JArray.Parse(data);
                // int row = 1;
                // foreach (JObject item in dataArray)
                // {
                //     // Fill in the Excel sheet with data from the JSON objects
                //     // For example: worksheet.Cells[row, 1].Value = item["PropertyName"].ToString();
                //     // Increment the row variable for the next row
                //     // row++;
                // }

                // Save the Excel package to a file
                excelPackage.SaveAs(new System.IO.FileInfo(fileName));
            }
        }
    }
}
