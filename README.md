# Electrical Network Billing System

Billing management feature of an accounting automating application for private generator comapny
Built using C# WinForms and SQLite.

## Features

- Save, read, update and delete bills
- Per meter total amount owed calculation
- Visually highlighting past-due bills and paid off bills.
- Filter/prioritize bills of a specific meter.
- Automatic local database initialization
- SQLite local persistence

## Tech Stack

- C#
- Windows Forms
- .NET Framework 4.7.2
- SQLite
- System.Data.SQLite

## Technical Highlights

- Automatically initializes a local SQLite database on first launch instead of relying on machine-specific SQL Server dependencies.
- Stores application data under the Windows user's Local AppData directory.
- Uses parameterized SQLite commands for database operations.
- Embeds the database schema directly into the application.

## Application

![Electrical Network Billing System](screenshots/mainss.png)
