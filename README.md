# CreationMaster16Cli (CmCli)

A Command Line Interface (CLI) version of the classic FIFA **Creation Master 16** utility. It allows developers and modders to inspect, export, and import tables in FIFA 16 `.db` database files using a schema XML file.

Developed on top of the decompiled `FifaLibrary16` library.

---

## Features

- **List Tables**: Show all tables in the database and their record counts.
- **Table Info**: Show schema definition (columns and data types) for a specific table.
- **Export Single Table**: Export a table's records to a tab-separated `.txt` file.
- **Import Single Table**: Load a tab-separated `.txt` file into a table and rebuild/save the database.
- **Export All Tables**: Batch export all database tables to a target directory.
- **Import All Tables**: Batch import all tables from a directory and save the resulting database.

---

## Building

Open the solution and build using MSBuild:

```powershell
MSBuild.exe CmCli.csproj /p:Configuration=Debug /p:Platform="AnyCPU"
```

*Note: The project automatically copies the required DirectX and zlib.net dependencies from the `ThirdParty` directory during compiling.*

---

## Usage

Run the executable `CmCli.exe` with one of the following commands:

### 1. List Tables
Lists all tables and their row counts:
```powershell
.\CmCli.exe list-tables <db_path> <xml_path>
```

### 2. Print Table Schema Info
```powershell
.\CmCli.exe table-info <db_path> <xml_path> <table_name>
```

### 3. Export a Single Table
```powershell
.\CmCli.exe export-table <db_path> <xml_path> <table_name> <output_txt_file>
```

### 4. Import a Single Table
```powershell
.\CmCli.exe import-table <db_path> <xml_path> <table_name> <input_txt_file> <output_db_path>
```

### 5. Export All Tables
```powershell
.\CmCli.exe export-all <db_path> <xml_path> <output_directory>
```

### 6. Import All Tables
```powershell
.\CmCli.exe import-all <db_path> <xml_path> <input_directory> <output_db_path>
```
