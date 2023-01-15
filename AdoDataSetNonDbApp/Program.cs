using System.Data;

namespace AdoDataSetNonDbApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataSet dset = new DataSet();
            dset.Tables.Add(new DataTable("Users"));

            DataColumn idCol = new DataColumn("id", Type.GetType("System.Int32"));
            idCol.Unique = true;
            idCol.AutoIncrement = true;
            idCol.AutoIncrementSeed = 1;
            idCol.AutoIncrementStep = 1;
            idCol.AllowDBNull = false;

            DataColumn nameCol = new("name", Type.GetType("System.String"));
            DataColumn ageCol = new ("age", Type.GetType("System.Int32"));

            DataTable table = dset.Tables[0];
            table.Columns.Add(idCol);
            table.Columns.Add(nameCol);
            table.Columns.Add(ageCol);
        }
    }
}
