using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Itog
{
    public class Otchgen
    {
        private Dictionary<string, string[]> ms = new Dictionary<string, string[]>
        {
            ["cmpstn"] = new string[] { "Код записи","Наименование","Исполнитель","Альбом","Год","Жанр","Дата записи","Продолжительность","Рейтинг"},
            ["empl"] = new string[] { "Код сотрудника", "ФИО", "Возраст", "Пол", "Адрес", "Номер", "Паспортные данные", "Должность" },
            ["gnrs"] = new string[] { "Код жанра", "Наименование", "О жанре" },
            ["mscn"] = new string[] { "Код исполнителя", "Наименование", "О исполнителе" },
            ["pstions"] = new string[] {"Код должности","Наименование","Зарплата","Обязанности","Требования" },
            ["schdl"] = new string[] { "Дата","Сотрудник","Время 1","Запись 1", "Время 2", "Запись 2", "Время 3", "Запись 3" },
        };
        Excel.Application excelapp;
        Excel.Workbook workbook;
        Excel.Worksheet worksheet;

        void ExcelStart()
        {
            
             excelapp = new Excel.Application();
            workbook = excelapp.Workbooks.Add();
            worksheet = workbook.ActiveSheet;
        }

        void ExcelSaveAndExit(string path)
        {
            excelapp.AlertBeforeOverwriting = false;
            workbook.SaveAs(path);
            excelapp.Quit();

        }


        /// <summary>
        /// Создание отчета
        /// <br></br>в Who передаем названия таблиц
        /// </summary>

        public void GenerateOtchet(DataGridView grid, string who)
        {

            MessageBox.Show("Производится сохранение, не выключайте программу.\n По завершению, появится сообщение 'Готово'","Сохранение");
            string path = System.IO.Directory.GetCurrentDirectory() + @"\" + "Save_"+ who +"_" + DateTime.Now + ".xlsx";

            ExcelStart();


            for (int i = 0; i < grid.RowCount - 1; i++)
            {

                for (int j = 0; j < grid.ColumnCount; j++)
                {
                    worksheet.Rows[1].Columns[j + 1] = ms[who][j] ;
                    worksheet.Rows[i + 2].Columns[j + 1] = grid.Rows[i].Cells[j].Value;

                }
            }
            ExcelSaveAndExit(path);

            MessageBox.Show("Готово", "Сохранено");
            
            
        }

        /// <summary>
        /// Создание отчета
        /// <br></br>C передачей значений в словаре
        /// </summary>
        public void GenerateOtchet(DataGridView grid, string who, Dictionary<int,string> pairs)
        {
            MessageBox.Show("Производится сохранение, не выключайте программу.\n По завершению, появится сообщение 'Готово'", "Сохранение");
            string path = System.IO.Directory.GetCurrentDirectory() + @"\" + "Save_" + who + ".xlsx";

            ExcelStart();


            for (int i = 0; i < grid.RowCount - 1; i++)
            {

                for (int j = 0; j < grid.ColumnCount; j++)
                {
                    worksheet.Rows[1].Columns[j + 1] = ms[who][j];
                    worksheet.Rows[i + 2].Columns[j + 1] = grid.Rows[i].Cells[j].Value;

                }

                foreach (var item in pairs)
                {
                    string[] str = new string[2];
                    str = item.Value.Split(new char[] { ' ' });
                    worksheet.Rows[item.Key+2].Columns[str[1]] = str[0];
                }

            }


            ExcelSaveAndExit(path);
            MessageBox.Show("Готово", "Сохранено");

        }
    }
}
