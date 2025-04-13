USE master;

-- Create the EnergyDrinksDB database only if it does not already exist
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'EnergyDrinksDB')
BEGIN
    CREATE DATABASE EnergyDrinksDB;
END
GO

-- Switch to the EnergyDrinksDB database
USE EnergyDrinksDB;
GO

-- Create the EnergyDrinkBrand table
CREATE TABLE EnergyDrinkBrand (
    BrandId INT PRIMARY KEY IDENTITY(1,1),
    BrandName NVARCHAR(100) NOT NULL
);
GO

-- Create the EnergyDrink table
CREATE TABLE EnergyDrink (
    DrinkId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Price DECIMAL(10,2) NOT NULL CHECK (Price > 0),
    VolumeML INT NOT NULL,
    Flavour NVARCHAR(100),
    BrandId INT NOT NULL,
    CONSTRAINT FK_Drink_Brand FOREIGN KEY (BrandId) REFERENCES EnergyDrinkBrand(BrandId)
);
GO

-- Create the Store table
CREATE TABLE Store (
    StoreId INT PRIMARY KEY IDENTITY(1,1),
    StoreName NVARCHAR(100) NOT NULL
);
GO

-- Create the StoreDrinks junction table
CREATE TABLE StoreDrinks (
    StoreId INT NOT NULL,
    DrinkId INT NOT NULL,
    CONSTRAINT PK_StoreDrinks PRIMARY KEY (StoreId, DrinkId),
    CONSTRAINT FK_StoreDrinks_Store FOREIGN KEY (StoreId) REFERENCES Store(StoreId),
    CONSTRAINT FK_StoreDrinks_Drink FOREIGN KEY (DrinkId) REFERENCES EnergyDrink(DrinkId)
);
GO

-- Insert sample data into the EnergyDrinkBrand table
INSERT INTO EnergyDrinkBrand (BrandName) VALUES
('Red Bull'),
('Monster'),
('Rockstar');
GO

-- Insert sample data into the EnergyDrink table
INSERT INTO EnergyDrink (Name, Price, VolumeML, Flavour, BrandId) VALUES
('Red Bull Original', 15.99, 250, 'Original', 1),
('Monster Ultra Blue', 16.99, 500, 'Ultra Blue', 2),
('Rockstar Punched', 12.99, 500, 'Punched', 3),
('Monster Assault', 17.99, 500, 'Assault', 2);
GO

-- Insert sample data into the Store table
INSERT INTO Store (StoreName) VALUES
('Spar'),
('Checkers'),
('Pick n Pay');
GO

-- Insert 'Monster Ultra Blue' into 'Spar'
INSERT INTO StoreDrinks (StoreId, DrinkId)
SELECT 
    s.StoreId,
    d.DrinkId
FROM Store s
JOIN EnergyDrink d ON d.Name = 'Monster Ultra Blue'
WHERE s.StoreName = 'Spar';
GO 