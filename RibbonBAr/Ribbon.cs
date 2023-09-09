using BussinessLogic.Logic;
using DataBase.Model.Models;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace RibbonBAr
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btn_GetData_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                var dbcontext = new Excel_AddinsContext();
                var logic = new DetailsLogic(dbcontext);
                var result = logic.GetDetails();
                FillExcelCells(result);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void FillExcelCells(IEnumerable<Details> details)
        {
            //  reference to the Excel Application

            Excel.Application excelApp = (Excel.Application)Globals.ThisAddIn.Application;

            //  active worksheet
            Excel.Worksheet worksheet = (Excel.Worksheet)excelApp.ActiveSheet;

            int row = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row + 1;

            foreach (var detail in details)
            {

                excelApp.Cells[row, 1].Value = detail.Id;
                excelApp.Cells[row, 2].Value = detail.Name;
                excelApp.Cells[row, 3].Value = detail.Address;

                row++;
            }
        }
    }
}
