using _07Day_CustomAttribute;
using System.Reflection;

namespace _07Day_MyORM
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string asmPath = @"C:\Users\IET\Desktop\.Net\Solution1\07Day_LyLib\bin\Debug\07Day_LyLib.dll";

            Assembly asm = Assembly.LoadFrom(asmPath);
            Type[] allTypes = asm.GetTypes();
            for (int i = 0; i < allTypes.Length; i++)
            {
                Type type = allTypes[i]; //Emp

                string createTableQuery = "CREATE TABLE ";

                Attribute[] allAttributes = type.GetCustomAttributes().ToArray();

                for (int j = 0; j < allAttributes.Length; j++)
                {
                    Attribute attr = allAttributes[j];
                    if (attr is TableAttribute)
                    {
                        TableAttribute tableAttr = attr as TableAttribute;
                        createTableQuery = createTableQuery + tableAttr.TableName + " ( ";
                        // CREATE TABLE Employee ( 
                    }
                }


                PropertyInfo[] allPeroperties = type.GetProperties();

                for (int k = 0; k < allPeroperties.Length; k++)
                {
                    PropertyInfo prop = allPeroperties[k];
                    Attribute[] propAttr = prop.GetCustomAttributes().ToArray();

                    for (int l = 0; l < propAttr.Length; l++)
                    {
                        Attribute pAttr = propAttr[l];
                        if (pAttr is ColumnAttribute)
                        {
                            ColumnAttribute col = pAttr as ColumnAttribute;
                            // CREATE TABLE Employee ( 
                            createTableQuery = createTableQuery + col.ColumnName + " " + col.ColumnType + ",";
                        }
                        // CREATE TABLE Employee ( EId int, EName varchar(50), EAddress varchar(50) )
                    }
                }
                createTableQuery = createTableQuery.TrimEnd(',') + " )";
                Console.WriteLine(createTableQuery);

                string filePath = @"C:\Users\IET\Desktop\.Net\Solution1\07Day_MyORM\SQLQUERY\CreateTableQuery.sql";

                File.WriteAllText(filePath, createTableQuery);

                Console.WriteLine("Done.");
            }
        }
    }
}
