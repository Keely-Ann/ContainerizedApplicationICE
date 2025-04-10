USE master;
GO

-- Create the RetailDB database only if it does not already exist
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'RetailDB')
BEGIN
	CREATE DATABASE RetailDB;
END
GO

-- Switch to the RetailDB database
USE RetailDB;
GO

-- Create Product table  
CREATE TABLE Products (
	ID INT PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(50) NOT NULL,
	Price INT NOT NULL
);
GO

-- Insert data into Product table
INSERT INTO Products (Name, Price)
VALUES
('Wii Sport Resort',1300),
('Super Mario Party',1200),
('Astro Bot',1200);
GO


