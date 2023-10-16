create database VaibhavDb


use VaibhavDb


CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
     Age INT NOT NULL,
    Gender NVARCHAR(10) NOT NULL, 
    Email NVARCHAR(255) NOT NULL,
     PhoneNumber NVARCHAR(10) NOT NULL,
    Country nvarchar(255) Not null,
    State NVARCHAR(255) NOT NULL 
);

CREATE TABLE Country (
    Id INT PRIMARY KEY Identity,
    Name NVARCHAR(255) NOT NULL
);


CREATE TABLE State (
    Id INT PRIMARY KEY Identity,
    Name NVARCHAR(255) NOT NULL,
    CountryId INT NOT NULL,
    FOREIGN KEY (CountryId) REFERENCES Country(Id)
);

INSERT INTO Country (Name) VALUES
('United States'),
('Canada'),
('United Kingdom'),
('Australia'),
('Germany'),
('France'),
('India'),
('Brazil'),
('Japan'),
('South Africa');



INSERT INTO State (Name, CountryId) VALUES

('California', 1),
('New York', 1),
('Texas', 1),
('Florida', 1),

('Ontario', 2),
('Quebec', 2),
('British Columbia', 2),
('Alberta', 2),

('England', 3),
('Scotland', 3),
('Wales', 3),
('Northern Ireland', 3),

('New South Wales', 4),
('Queensland', 4),
('Victoria', 4),
('Western Australia', 4),

('Bavaria', 5),
('North Rhine-Westphalia', 5),
('Baden-Württemberg', 5),
('Lower Saxony', 5),

('Île-de-France', 6),
('Provence-Alpes-Côte d''Azur', 6),
('Auvergne-Rhône-Alpes', 6),
('Nouvelle-Aquitaine', 6),
-- States for India
('Maharashtra', 7),
('Uttar Pradesh', 7),
('Tamil Nadu', 7),
('Karnataka', 7),

('São Paulo', 8),
('Minas Gerais', 8),
('Rio de Janeiro', 8),
('Bahia', 8),
('Tokyo', 9),
('Osaka', 9),
('Kanagawa', 9),
('Aichi', 9),

('Gauteng', 10),
('Western Cape', 10),
('KwaZulu-Natal', 10),
('Eastern Cape', 10);


Drop table State
Drop table Country