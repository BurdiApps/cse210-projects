# Journal Program - Week 2 Assignment

## Overview
A C# console application for writing, displaying, saving, and loading journal entries using object-oriented programming principles.

## Features

### Core Requirements
- Write journal entries with random prompts and automatic date stamping
- Display all journal entries
- Save entries to a text file (pipe-separated format)
- Load entries from a text file
- Random prompt selection from 5+ writing prompts

### Creative Enhancements
- **JSON Save/Load** - Alternative file format for modern data storage
- **Auto-append file extensions** - Adds `.json` automatically if forgotten
- **Full path display** - Shows exact file location after saving
- **List-based storage** - Dynamic entry management

## How to Run

```powershell
dotnet build Journal.csproj
dotnet run --project Journal.csproj
```

## Class Structure

- **Entry.cs** - Represents a single journal entry (date, prompt, response)
- **Journal.cs** - Manages the collection of entries and prompts
- **Program.cs** - Handles user interaction and menu system

## Menu Options

1. Write - Create new entry
2. Display - Show all entries
3. Load (text) - Import from .txt file
4. Save (text) - Export to .txt file
5. Quit - Exit program
6. Save (JSON) - Export to .json file
7. Load (JSON) - Import from .json file

## Technologies Used
- C# (.NET 8.0)
- System.Text.Json for serialization
- List<T> for dynamic collections

---
**Author**: James Burdick | **Course**: CSE 210 | **Date**: November 10, 2025
