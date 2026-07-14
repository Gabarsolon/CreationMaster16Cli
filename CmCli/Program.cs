using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Text;
using FifaLibrary;

namespace CmCli
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                PrintUsage();
                Environment.Exit(1);
            }

            string command = args[0].ToLowerInvariant();
            string dbPath = args[1];
            string xmlPath = args[2];

            if (!File.Exists(dbPath))
            {
                Console.WriteLine($"ERROR: Database file not found: {dbPath}");
                Environment.Exit(1);
            }
            if (!File.Exists(xmlPath))
            {
                Console.WriteLine($"ERROR: Schema XML file not found: {xmlPath}");
                Environment.Exit(1);
            }

            try
            {
                switch (command)
                {
                    case "list-tables":
                        ListTables(dbPath, xmlPath);
                        break;

                    case "table-info":
                        if (args.Length < 4)
                        {
                            Console.WriteLine("Usage: CmCli.exe table-info <db_path> <xml_path> <table_name>");
                            Environment.Exit(1);
                        }
                        TableInfo(dbPath, xmlPath, args[3]);
                        break;

                    case "export-table":
                        if (args.Length < 5)
                        {
                            Console.WriteLine("Usage: CmCli.exe export-table <db_path> <xml_path> <table_name> <output_file>");
                            Environment.Exit(1);
                        }
                        ExportTableCmd(dbPath, xmlPath, args[3], args[4]);
                        break;

                    case "import-table":
                        if (args.Length < 6)
                        {
                            Console.WriteLine("Usage: CmCli.exe import-table <db_path> <xml_path> <table_name> <input_file> <output_db_path>");
                            Environment.Exit(1);
                        }
                        ImportTableCmd(dbPath, xmlPath, args[3], args[4], args[5]);
                        break;

                    case "export-all":
                        if (args.Length < 4)
                        {
                            Console.WriteLine("Usage: CmCli.exe export-all <db_path> <xml_path> <output_dir>");
                            Environment.Exit(1);
                        }
                        ExportAll(dbPath, xmlPath, args[3]);
                        break;

                    case "import-all":
                        if (args.Length < 5)
                        {
                            Console.WriteLine("Usage: CmCli.exe import-all <db_path> <xml_path> <input_dir> <output_db_path>");
                            Environment.Exit(1);
                        }
                        ImportAll(dbPath, xmlPath, args[3], args[4]);
                        break;

                    case "export-kit":
                        if (args.Length < 6)
                        {
                            Console.WriteLine("Usage: CmCli.exe export-kit <db_path> <xml_path> <fifa_dir> <team_id> <output_dir>");
                            Environment.Exit(1);
                        }
                        ExportKit(dbPath, xmlPath, args[3], int.Parse(args[4]), args[5]);
                        break;

                    case "export-crests":
                        if (args.Length < 6)
                        {
                            Console.WriteLine("Usage: CmCli.exe export-crests <db_path> <xml_path> <fifa_dir> <team_id> <output_dir>");
                            Environment.Exit(1);
                        }
                        ExportCrests(dbPath, xmlPath, args[3], int.Parse(args[4]), args[5]);
                        break;

                    default:
                        Console.WriteLine($"ERROR: Unknown command: {command}");
                        PrintUsage();
                        Environment.Exit(1);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: Operation failed: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                Environment.Exit(1);
            }
        }

        static void PrintUsage()
        {
            Console.WriteLine("CmCli - Command Line Interface for FIFA Creation Master 16");
            Console.WriteLine("Usage: CmCli.exe <command> <db_path> <xml_path> [options]");
            Console.WriteLine();
            Console.WriteLine("Commands:");
            Console.WriteLine("  list-tables <db_path> <xml_path>                                     Lists all tables in the database");
            Console.WriteLine("  table-info <db_path> <xml_path> <table_name>                         Prints schema and count details for a table");
            Console.WriteLine("  export-table <db_path> <xml_path> <table_name> <output_file>         Exports a table to a tab-separated text file");
            Console.WriteLine("  import-table <db_path> <xml_path> <table_name> <input_file> <out_db>  Imports a table from a tab-separated text file");
            Console.WriteLine("  export-all <db_path> <xml_path> <output_dir>                         Exports all tables to a directory");
            Console.WriteLine("  import-all <db_path> <xml_path> <input_dir> <output_db_path>          Imports all tables from a directory and saves DB");
            Console.WriteLine("  export-kit <db_path> <xml_path> <fifa_dir> <team_id> <output_dir>    Exports team kits (PNG) from FIFA 16 directory");
            Console.WriteLine("  export-crests <db_path> <xml_path> <fifa_dir> <team_id> <output_dir> Exports team logos/crests (PNG) from FIFA 16 directory");
        }

        static void ListTables(string dbPath, string xmlPath)
        {
            Console.WriteLine("Loading Database...");
            DbFile db = new DbFile(dbPath, xmlPath);
            DataSet ds = db.ConvertToDataSet();
            Console.WriteLine($"Database loaded successfully. Number of tables: {ds.Tables.Count}");
            Console.WriteLine();
            Console.WriteLine("Tables:");
            foreach (DataTable table in ds.Tables)
            {
                Console.WriteLine($"  {table.TableName} ({table.Rows.Count} rows)");
            }
        }

        static void TableInfo(string dbPath, string xmlPath, string tableName)
        {
            Console.WriteLine("Loading Database...");
            DbFile db = new DbFile(dbPath, xmlPath);
            DataSet ds = db.ConvertToDataSet();
            DataTable table = ds.Tables[tableName];
            if (table == null)
            {
                Console.WriteLine($"ERROR: Table '{tableName}' not found in database.");
                return;
            }

            Console.WriteLine($"Table: {table.TableName}");
            Console.WriteLine($"Rows Count: {table.Rows.Count}");
            Console.WriteLine($"Columns Count: {table.Columns.Count}");
            Console.WriteLine();
            Console.WriteLine("Columns:");
            foreach (DataColumn col in table.Columns)
            {
                Console.WriteLine($"  {col.ColumnName} ({col.DataType.Name})");
            }
        }

        static void ExportTableCmd(string dbPath, string xmlPath, string tableName, string outputFile)
        {
            Console.WriteLine("Loading Database...");
            DbFile db = new DbFile(dbPath, xmlPath);
            DataSet ds = db.ConvertToDataSet();
            DataTable table = ds.Tables[tableName];
            if (table == null)
            {
                Console.WriteLine($"ERROR: Table '{tableName}' not found in database.");
                return;
            }

            Console.WriteLine($"Exporting table '{tableName}' to '{outputFile}'...");
            ExportTable(table, outputFile);
            Console.WriteLine("Export completed successfully.");
        }

        static void ImportTableCmd(string dbPath, string xmlPath, string tableName, string inputFile, string outputDbPath)
        {
            if (!File.Exists(inputFile))
            {
                Console.WriteLine($"ERROR: Input file not found: {inputFile}");
                return;
            }

            Console.WriteLine("Loading Database...");
            DbFile db = new DbFile(dbPath, xmlPath);
            DataSet ds = db.ConvertToDataSet();
            DataTable table = ds.Tables[tableName];
            if (table == null)
            {
                Console.WriteLine($"ERROR: Table '{tableName}' not found in database.");
                return;
            }

            Console.WriteLine($"Importing table '{tableName}' from '{inputFile}'...");
            if (!ImportTable(table, inputFile))
            {
                Console.WriteLine("ERROR: Import failed (column structure mismatch or empty file).");
                return;
            }

            Console.WriteLine("Rebuilding database file...");
            db.ConvertFromDataSet(ds);
            
            // Backup
            if (File.Exists(outputDbPath))
            {
                File.Copy(outputDbPath, outputDbPath + ".bak", true);
            }

            db.SaveDb(outputDbPath);
            Console.WriteLine($"Successfully imported table and saved database to: {outputDbPath}");
        }

        static void ExportAll(string dbPath, string xmlPath, string outputDir)
        {
            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }

            Console.WriteLine("Loading Database...");
            DbFile db = new DbFile(dbPath, xmlPath);
            DataSet ds = db.ConvertToDataSet();
            Console.WriteLine($"Exporting all {ds.Tables.Count} tables to directory '{outputDir}'...");

            foreach (DataTable table in ds.Tables)
            {
                string filePath = Path.Combine(outputDir, table.TableName + ".txt");
                ExportTable(table, filePath);
                Console.WriteLine($"  Exported {table.TableName} ({table.Rows.Count} rows)");
            }
            Console.WriteLine("Export completed successfully.");
        }

        static void ImportAll(string dbPath, string xmlPath, string inputDir, string outputDbPath)
        {
            if (!Directory.Exists(inputDir))
            {
                Console.WriteLine($"ERROR: Input directory not found: {inputDir}");
                return;
            }

            Console.WriteLine("Loading Database...");
            DbFile db = new DbFile(dbPath, xmlPath);
            DataSet ds = db.ConvertToDataSet();

            string[] txtFiles = Directory.GetFiles(inputDir, "*.txt");
            Console.WriteLine($"Found {txtFiles.Length} text files in directory. Importing...");

            int successCount = 0;
            foreach (string file in txtFiles)
            {
                string tableName = Path.GetFileNameWithoutExtension(file);
                DataTable table = ds.Tables[tableName];
                if (table != null)
                {
                    Console.WriteLine($"  Importing {tableName}...");
                    if (ImportTable(table, file))
                    {
                        successCount++;
                    }
                    else
                    {
                        Console.WriteLine($"  WARNING: Failed to import table {tableName}");
                    }
                }
            }

            Console.WriteLine($"Successfully imported {successCount} tables. Rebuilding and saving database...");
            db.ConvertFromDataSet(ds);
            
            // Backup
            if (File.Exists(outputDbPath))
            {
                File.Copy(outputDbPath, outputDbPath + ".bak", true);
            }

            db.SaveDb(outputDbPath);
            Console.WriteLine($"Successfully saved database to: {outputDbPath}");
        }

        static void ExportTable(DataTable t, string fileName)
        {
            using (StreamWriter streamWriter = new StreamWriter(fileName, false, Encoding.Unicode))
            {
                for (int i = 0; i < t.Columns.Count; i++)
                {
                    streamWriter.Write(t.Columns[i].ToString());
                    streamWriter.Write(i == t.Columns.Count - 1 ? "\r\n" : "\t");
                }
                for (int j = 0; j < t.Rows.Count; j++)
                {
                    for (int k = 0; k < t.Columns.Count; k++)
                    {
                        string text2 = t.Rows[j].ItemArray[k].ToString();
                        text2 = text2.Replace("\n", "\\n").Replace("\r", "\\r").Replace("\t", "\\t");
                        streamWriter.Write(text2);
                        streamWriter.Write(k == t.Columns.Count - 1 ? "\r\n" : "\t");
                    }
                }
            }
        }

        static bool ImportTable(DataTable t, string fileName)
        {
            using (StreamReader streamReader = new StreamReader(fileName, Encoding.Unicode))
            {
                string text = streamReader.ReadLine();
                if (text == null)
                {
                    return false;
                }
                int num = 1;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text.Substring(i, 1) == "\t")
                    {
                        num++;
                    }
                }
                if (num != t.Columns.Count)
                {
                    return false;
                }
                string[] array = ReadCsv(text, num);
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] != t.Columns[j].ColumnName)
                    {
                        return false;
                    }
                }
                t.Clear();
                t.BeginLoadData();
                while (streamReader.Peek() != -1)
                {
                    text = streamReader.ReadLine();
                    string[] array2 = ReadCsv(text, num);
                    DataRow dataRow = t.NewRow();
                    dataRow.ItemArray = array2;
                    t.Rows.Add(dataRow);
                }
                t.EndLoadData();
            }
            return true;
        }

        static string[] ReadCsv(string line, int nTokens)
        {
            string[] array = new string[nTokens];
            int num = 0;
            string text;
            for (int i = 0; i < nTokens - 1; i++)
            {
                int num2 = line.IndexOf("\t", num);
                int num3 = num2 - num;
                text = line.Substring(num, num3);
                num = num2 + 1;
                text = text.Replace("\\n", "\n").Replace("\\r", "\r").Replace("\\t", "\t");
                array[i] = text;
            }
            text = line.Substring(num);
            text = text.Replace("\\n", "\n").Replace("\\r", "\r").Replace("\\t", "\t");
            array[nTokens - 1] = text;
            return array;
        }

        static void ExportKit(string dbPath, string xmlPath, string fifaDir, int teamId, string outputDir)
        {
            Console.WriteLine("Initializing FifaEnvironment...");
            FifaEnvironment.Initialize(16, fifaDir);
            FifaEnvironment.FifaDbFileName = dbPath;
            FifaEnvironment.FifaXmlFileName = xmlPath;
            
            Console.WriteLine("Opening FAT archives...");
            FifaEnvironment.OpenFat();
            
            Console.WriteLine("Opening Database...");
            if (!FifaEnvironment.OpenFifaDb())
            {
                Console.WriteLine("ERROR: Failed to open FIFA database.");
                return;
            }
            
            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }
            
            Console.WriteLine($"Searching for team {teamId}...");
            Team team = (Team)FifaEnvironment.Teams.SearchId(teamId);
            if (team == null)
            {
                Console.WriteLine($"ERROR: Team with ID {teamId} not found.");
                return;
            }
            
            Console.WriteLine($"Found Team: {team.DatabaseName}");
            // Common kit types: 0 = Home, 1 = Away, 2 = GK, 3 = Third, etc.
            for (int kitType = 0; kitType <= 4; kitType++)
            {
                Kit kit = team.GetKit(kitType);
                if (kit == null) continue;
                
                Console.WriteLine($"Extracting kit type {kitType}...");
                Bitmap[] textures = kit.GetKitTextures();
                if (textures != null)
                {
                    for (int i = 0; i < textures.Length; i++)
                    {
                        if (textures[i] != null)
                        {
                            string file = Path.Combine(outputDir, $"team_{teamId}_kit_{kitType}_tex_{i}.png");
                            textures[i].Save(file, System.Drawing.Imaging.ImageFormat.Png);
                            Console.WriteLine($"Saved texture: {file}");
                        }
                    }
                }
                
                Bitmap minikit = kit.GetMiniKit();
                if (minikit != null)
                {
                    string file = Path.Combine(outputDir, $"team_{teamId}_kit_{kitType}_minikit.png");
                    minikit.Save(file, System.Drawing.Imaging.ImageFormat.Png);
                    Console.WriteLine($"Saved minikit: {file}");
                }
            }
            Console.WriteLine("Kit export completed successfully.");
        }

        static void ExportCrests(string dbPath, string xmlPath, string fifaDir, int teamId, string outputDir)
        {
            Console.WriteLine("Initializing FifaEnvironment...");
            FifaEnvironment.Initialize(16, fifaDir);
            FifaEnvironment.FifaDbFileName = dbPath;
            FifaEnvironment.FifaXmlFileName = xmlPath;
            
            Console.WriteLine("Opening FAT archives...");
            FifaEnvironment.OpenFat();
            
            Console.WriteLine("Opening Database...");
            if (!FifaEnvironment.OpenFifaDb())
            {
                Console.WriteLine("ERROR: Failed to open FIFA database.");
                return;
            }
            
            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }
            
            Console.WriteLine($"Searching for team {teamId}...");
            Team team = (Team)FifaEnvironment.Teams.SearchId(teamId);
            if (team == null)
            {
                Console.WriteLine($"ERROR: Team with ID {teamId} not found.");
                return;
            }
            
            Console.WriteLine($"Found Team: {team.DatabaseName}");
            
            // Extract standard light crests
            ExtractAndSaveCrest(team.GetCrest(), "crest_standard", teamId, outputDir);
            ExtractAndSaveCrest(team.GetCrest50(), "crest_50x50", teamId, outputDir);
            ExtractAndSaveCrest(team.GetCrest32(), "crest_32x32", teamId, outputDir);
            ExtractAndSaveCrest(team.GetCrest16(), "crest_16x16", teamId, outputDir);
            
            // Extract dark crests
            ExtractAndSaveCrest(team.GetCrestDark(), "crest_dark_standard", teamId, outputDir);
            ExtractAndSaveCrest(team.GetCrest50Dark(), "crest_dark_50x50", teamId, outputDir);
            ExtractAndSaveCrest(team.GetCrest32Dark(), "crest_dark_32x32", teamId, outputDir);
            ExtractAndSaveCrest(team.GetCrest16Dark(), "crest_dark_16x16", teamId, outputDir);

            Console.WriteLine("Crests export completed successfully.");
        }

        static void ExtractAndSaveCrest(Bitmap crest, string name, int teamId, string outputDir)
        {
            if (crest != null)
            {
                string file = Path.Combine(outputDir, $"team_{teamId}_{name}.png");
                crest.Save(file, System.Drawing.Imaging.ImageFormat.Png);
                Console.WriteLine($"Saved crest: {file}");
            }
        }
    }
}
