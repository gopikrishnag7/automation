using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRegistration_Seg1Prospect
{
    public class PersonalInformation1
    {
        public static DataTable ExcelToDataTable(string filename)
        {
            //Open file and return as Stream
            FileStream stream = File.Open(filename, FileMode.Open, FileAccess.Read);
            //Createopenxmlreader via ExcelReaderFactory
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //Set the First row as column name
            excelReader.IsFirstRowAsColumnNames = true;
            //Return as DataSet
            DataSet result = excelReader.AsDataSet();
            //Get all the table
            DataTableCollection table = result.Tables;
            //Store it in DataTable
            DataTable resultTable = table["PersonalInfo1"];
            //return
            return resultTable;
        }


        public static List<Datacollection> dataCol = new List<Datacollection>();
        public static void PopulateInCollection(string filename)
        {
            DataTable table = ExcelToDataTable(filename);

            //Iterate through the rows and column in the table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    //add all the detail for each row
                    dataCol.Add(dtTable);

                }
            }
        }

        public static string ReadData(int RowNumber, string ColumnName)
        {

            //Retrieve Data using LINQ to reduce much of iteration
            string data = (from colData in dataCol
                           where colData.colName == ColumnName && colData.rowNumber == RowNumber
                           select colData.colValue).SingleOrDefault();

            return data.ToString();


        }


        public class Datacollection
        {
            public int rowNumber { get; set; }
            public string colName { get; set; }
            public string colValue { get; set; }
        }


    }
}