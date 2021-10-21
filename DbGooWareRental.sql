CREATE DATABASE GooWareRental
USE GooWareRental

CREATE TABLE Users
(
UserId INT IDENTITY PRIMARY KEY,
UserFirstName NVARCHAR(30) NOT NULL,
UserLastName NVARCHAR(30) NOT NULL,
UserEMail NVARCHAR(150) UNIQUE NOT NULL,
UserPasswordHash BINARY(500) NOT NULL,
UserPasswordSalt BINARY(500) NOT NULL,
UserState BIT NOT NULL
)

SELECT * FROM Users

CREATE TABLE OperationClaims
(
OperationClaimId INT IDENTITY PRIMARY KEY,
OperationClaimName NVARCHAR(150) NOT NULL
)

CREATE TABLE UserOperationClaims
(
UserOperationClaimId INT IDENTITY PRIMARY KEY,
UserId INT FOREIGN KEY(UserId) REFERENCES Users(UserId) NOT NULL,
OperationClaimId INT FOREIGN KEY (OperationClaimId) REFERENCES OperationClaims(OperationClaimId) NOT NULL
)

CREATE TABLE Colors
(
ColorId SMALLINT IDENTITY PRIMARY KEY,
ColorName NVARCHAR(50) UNIQUE NOT NULL,
ColorState BIT NOT NULL
)

SELECT * FROM Colors

CREATE TABLE Gears
(
GearId SMALLINT IDENTITY PRIMARY KEY,
GearName NVARCHAR(50) UNIQUE NOT NULL,
GearState BIT NOT NULL
)

CREATE TABLE VechileTypes
(
VechileTypeId SMALLINT IDENTITY PRIMARY KEY,
VechileTypeName NVARCHAR(30) UNIQUE NOT NULL,
VechileTypeState BIT NOT NULL
)

CREATE TABLE MotorcycleBrands
(
MotorcycleBrandId INT IDENTITY PRIMARY KEY,
MotorcycleBrandName NVARCHAR(50) UNIQUE NOT NULL,
MotorcycleBrandState BIT NOT NULL
)

CREATE TABLE MotorcycleModels
(
MotorcycleModelId INT IDENTITY PRIMARY KEY,
MotorcycleBrandId INT FOREIGN KEY (MotorcycleBrandId) REFERENCES MotorcycleBrands(MotorcycleBrandId) NOT NULL,
MotorcycleModelName NVARCHAR(50) UNIQUE NOT NULL,
MotorcycleModelState BIT NOT NULL
)

CREATE TABLE MotorcyclePackages
(
MotorcyclePackageId INT IDENTITY PRIMARY KEY,
MotorcycleModelId INT FOREIGN KEY (MotorcycleModelId) REFERENCES MotorcycleModels(MotorcycleModelId) NOT NULL,
MotorcyclePackageName NVARCHAR(50) UNIQUE NOT NULL,
MotorcyclePackageState BIT NOT NULL
)

CREATE TABLE MotorcycleTypes
(
MotorcycleTypeId SMALLINT IDENTITY PRIMARY KEY,
MotorcycleTypeName NVARCHAR(50) UNIQUE NOT NULL,
MotorcycleTypeState BIT NOT NULL
)

CREATE TABLE MotorcycleImages
(
MotorcycleImageId INT IDENTITY PRIMARY KEY,
MotorcycleImagePath NVARCHAR(300) NOT NULL,
)

CREATE TABLE Motorcycles
(
MotorcycleId INT IDENTITY PRIMARY KEY,
ColorId SMALLINT FOREIGN KEY (ColorId) REFERENCES Colors(ColorId) NOT NULL,
GearId SMALLINT FOREIGN KEY (GearId) REFERENCES Gears(GearId) NOT NULL,
MotorcycleBrandId INT FOREIGN KEY (MotorcycleBrandId) REFERENCES MotorcycleBrands(MotorcycleBrandId) NOT NULL,
MotorcycleModelId INT FOREIGN KEY (MotorcycleModelId) REFERENCES MotorcycleModels(MotorcycleModelId) NOT NULL,
MotorcyclePackageId INT FOREIGN KEY (MotorcyclePackageId) REFERENCES MotorcyclePackages(MotorcyclePackageId),
MotorcycleTypeId SMALLINT FOREIGN KEY (MotorcycleTypeId) REFERENCES MotorcycleTypes(MotorcycleTypeId) NOT NULL,
MotorcycleImageId INT FOREIGN KEY (MotorcycleImageId) REFERENCES MotorcycleImages(MotorcycleImageId) NOT NULL
)

DROP TABLE Motorcycles