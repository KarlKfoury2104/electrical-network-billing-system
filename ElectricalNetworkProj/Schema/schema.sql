PRAGMA foreign_keys = ON;

CREATE TABLE IF NOT EXISTS Bills (
    BillID INTEGER PRIMARY KEY AUTOINCREMENT,
    MeterID INTEGER,
    Rate REAL,
    IssueDate TEXT,
    DueDate TEXT,
    KilowattHours REAL,
    AmountOwed REAL,
    AmountPaid REAL
);
