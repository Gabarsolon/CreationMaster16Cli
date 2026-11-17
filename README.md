# CreationMaster16Cli (CmCli)

A Command Line Interface (CLI) version of the classic FIFA **Creation Master 16** utility. It allows developers and modders to inspect, export, and import tables in FIFA 16 `.db` database files using a schema XML file, export team kits, crests, and player head models/textures, and regenerate `.bh` archive index files.

Developed on top of the decompiled `FifaLibrary16` library.

---

## Features

- **Regenerate BH Files**: Rebuild FIFA 16 `.bh` big file header indexes with automatic loose file redirection (hash=0) and `.bh.bak` backups.
- **List Tables**: Show all tables in the database and their record counts.
- **Table Info**: Show schema definition (columns and data types) for a specific table.
- **Export Single Table**: Export a table's records to a tab-separated `.txt` / `.tsv` file.
- **Import Single Table**: Load a tab-separated `.txt` / `.tsv` file into a table and rebuild/save the database.
- **Export All Tables**: Batch export all database tables to a target directory.
- **Import All Tables**: Batch import all tables from a directory and save the resulting database.
- **Export Kits**: Export home, away, and goalkeeper kits and minikits for a team from FIFA 16.
- **Export Crests**: Export team crest textures at various resolutions (16x16, 32x32, 50x50, 256x256).
- **Export Player**: Export player head model (`.rx3`), face textures, and hair models.

---

## Building

Build using the .NET CLI:

```powershell
dotnet build -c Debug -p:Platform="AnyCPU"
```

*Note: The project automatically references `Microsoft.NETFramework.ReferenceAssemblies` via `Directory.Build.props` and includes dependencies from `ThirdParty`.*

---

## Usage

Run the executable `CmCli.exe` with one of the following commands:

### 1. Regenerate BH Archive Indexes
Rebuilds `.bh` index files for `.big` archives with automatic `.bh.bak` backup. Scans the root directory and known subdirectories (`data/ui/imgAssets/heads`, `data/ui/imgAssets/youthheads`, etc.). Also supports targeting an individual `.big` file:

```powershell
# Scan entire FIFA 16 installation
.\CmCli.exe regenerate-bh "C:\Program Files (x86)\by Decepticon\FIFA 16"

# Or target a single archive
.\CmCli.exe regenerate-bh "C:\Games\FIFA 16\data\gui\english_us.big"
```

### 2. List Tables
Lists all tables and their row counts:
```powershell
.\CmCli.exe list-tables <db_path> <xml_path>
```

### 3. Print Table Schema Info
```powershell
.\CmCli.exe table-info <db_path> <xml_path> <table_name>
```

### 4. Export a Single Table
```powershell
.\CmCli.exe export-table <db_path> <xml_path> <table_name> <output_tsv_file>
```

### 5. Import a Single Table
```powershell
.\CmCli.exe import-table <db_path> <xml_path> <table_name> <input_tsv_file> <output_db_path>
```

### 6. Export All Tables
```powershell
.\CmCli.exe export-all <db_path> <xml_path> <output_directory>
```

### 7. Import All Tables
```powershell
.\CmCli.exe import-all <db_path> <xml_path> <input_directory> <output_db_path>
```

### 8. Export Team Kits
```powershell
.\CmCli.exe export-kit <fifa_dir> <team_id> <output_dir>
```

### 9. Export Team Crests
```powershell
.\CmCli.exe export-crests <fifa_dir> <team_id> <output_dir>
```

### 10. Export Player Face and Hair Assets
```powershell
.\CmCli.exe export-player <fifa_dir> <player_id> <output_dir>
```
