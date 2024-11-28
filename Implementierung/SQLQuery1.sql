IF DB_ID('BesucherfreundlichesInformationssystem') IS NULL
    CREATE DATABASE BesucherfreundlichesInformationssystem;
GO

USE BesucherfreundlichesInformationssystem;
GO

IF OBJECT_ID('Becken') IS NOT NULL
    DROP TABLE Becken;
GO

IF OBJECT_ID('Kurs') IS NOT NULL
    DROP TABLE Kurs;
GO

IF OBJECT_ID('Event') IS NOT NULL
    DROP TABLE Event;
GO



-- Tabelle für Becken
CREATE TABLE Becken (
    BeckenID INT PRIMARY KEY identity(1,1), -- Primärschlüssel
    Name VARCHAR(100), -- Name des Beckens
    Details TEXT, -- Details zum Becken
    Uhrzeit TIME -- Uhrzeit, die für Becken relevant ist (falls erforderlich)
);

-- Tabelle für Kurszeiten
CREATE TABLE Kurszeiten (
    KursID INT PRIMARY KEY identity(1,1), -- Primärschlüssel
    Text NVARCHAR(100),
    Uhrzeit TIME NOT NULL, -- Uhrzeit des Kurses
    Kursleiter VARCHAR(100) NOT NULL -- Name des Kursleiters
);

-- Tabelle für Events
CREATE TABLE Events (
    EventID INT PRIMARY KEY identity(1,1), -- Primärschlüssel
    Name VARCHAR(100) NOT NULL, -- Name des Events
    Uhrzeit TIME NOT NULL, -- Uhrzeit des Events
    Kursleiter VARCHAR(100) -- Name des Kursleiters, falls vorhanden
);



