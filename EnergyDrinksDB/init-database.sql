USE master


-- Create the EnergyDrinksDb database
CREATE DATABASE EnergyDrinksDb;
GO

-- Switch context to the new database
USE EnergyDrinksDb;
GO

-- Create a Brands table to store energy drink brand information
CREATE TABLE EnergyDrinkBrand (
    BrandId INT PRIMARY KEY IDENTITY(1,1),
    BrandName NVARCHAR(100) NOT NULL
);
GO

-- Create an EnergyDrinks table to store energy drink product details
CREATE TABLE EnergyDrinks (
    DrinkId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Price DECIMAL(10,2) NOT NULL CHECK (Price > 0),
    VolumeML INT NOT NULL,  -- Volume in milliliters
    Flavor NVARCHAR(100) NULL,
    BrandId INT NOT NULL,
    CONSTRAINT FK_EnergyDrinks_Brands FOREIGN KEY (BrandId) REFERENCES Brands(BrandId)
);
GO

CREATE TABLE Store (
    StoreId INT PRIMARY KEY IDENTITY(1,1),
    StoreName NVARCHAR(100) NOT NULL,
    InStoreBrands NVARCHAR(100) NOT NULL,
);
GO

-- Insert sample data into the Brands table
INSERT INTO EnergyDrinkBrand (BrandName) VALUES
('Red Bull'),
('Monster'),
('Rockstar');
GO

-- Insert sample data into the EnergyDrinks table, linking each drink to a brand
INSERT INTO EnergyDrinks (Name, Price, VolumeML, Flavor, BrandId) VALUES
('Red Bull Energy Drink', 2.99, 250, 'Original', 1),
('Monster Ultra', 3.49, 473, 'Ultra Blue', 2),
('Rockstar Punched', 2.79, 473, 'Punched', 3),
('Monster Assault', 2.99, 473, 'Assault', 2);
GO
