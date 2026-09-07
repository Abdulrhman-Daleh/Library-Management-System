using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace LibrarySystem.Common
{
    public static class GenericOperations
    {
        public static bool IsEmptyObject<T>(T obj) where T : class
        {
            return obj == null;
        }

        public static bool IsInRange<T>(T value, T min, T max) where T : IComparable<T>
        {
            return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
        }

        public static void BindDataRow<T>(ref DataRow dataRow, T obj)
        {
            foreach (PropertyInfo property in obj.GetType().GetProperties())
            {
                if (!dataRow.Table.Columns.Contains(property.Name))
                    continue;

                if (dataRow.Table.Columns[property.Name].ReadOnly)
                    dataRow.Table.Columns[property.Name].ReadOnly = false;

                object propertyValue = property.GetValue(obj);

                if (property.Name == "Gender")
                {
                    if (propertyValue == null)
                        dataRow[property.Name] = DBNull.Value;
                    else
                        dataRow[property.Name] = propertyValue.ToString() == "0" ? "Male" : "Female";
                }
                else
                {
                    dataRow[property.Name] = propertyValue ?? DBNull.Value;
                }
            }
        }

        public static void MapRecordsToGridView<T>(DataRow dataRow, DataGridView dataGridView, DataTable dataTable, System.Windows.Forms.Label recordLabel, T obj)
        {
            if (dataRow != null)
            {
                BindDataRow(ref dataRow, obj);
            }
            else
            {
                dataRow = dataTable.NewRow();
                BindDataRow(ref dataRow, obj);
                dataTable.Rows.Add(dataRow);
                CommonValidation.UpdateRecordCount(dataGridView, recordLabel);
            }
        }

        public static void DeleteRecord(DataTable dataTable, DataGridView dataGridView, System.Windows.Forms.Label recordLabel, int recordId, string columnName)
        {
            DataRow rowToDelete = dataTable.AsEnumerable().FirstOrDefault(row => row.Field<int>(columnName) == recordId);
            if (rowToDelete != null)
            {
                dataTable.Rows.Remove(rowToDelete);
                CommonValidation.UpdateRecordCount(dataGridView, recordLabel);
            }
        }
    }
}