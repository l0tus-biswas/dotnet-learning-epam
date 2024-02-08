CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100),
    Email NVARCHAR(100)
);

CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100),
    Price DECIMAL(10, 2),
    ProductGST DECIMAL(5,2)
);

CREATE TABLE Invoices (
    InvoiceID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT,
    InvoiceDate DATETIME,
    TotalAmount DECIMAL(10, 2),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE InvoiceItems (
    InvoiceItemID INT IDENTITY(1,1) PRIMARY KEY,
    InvoiceID INT,
    ProductID INT,
    Quantity INT,
    Amount DECIMAL(10, 2),
    FOREIGN KEY (InvoiceID) REFERENCES Invoices(InvoiceID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

CREATE TABLE Admins (
    AdminID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) UNIQUE,
    PasswordHash NVARCHAR(255), 
    FullName NVARCHAR(100),
    Email NVARCHAR(100),
    GlobalSAT DECIMAL(5,2)
);


--  INSERT DATA

-- Insert values into Customers table
INSERT INTO Customers (Name, Email) 
VALUES 
('Rajesh Biswas', 'rajeshbiswas@example.com'),
('Shiva Singh', 'shivasingh@example.com'),
('Vishal Kumar', 'vishalkumar@example.com');

-- Insert values into Products table
INSERT INTO Products (Name, Price, ProductGST) 
VALUES 
('Notebook', 100, 5.00),
('Pencil', 50, 1.50),
('TShirt', 200, 7.00);

-- Insert values into Invoices table
INSERT INTO Invoices (CustomerID, InvoiceDate, TotalAmount) 
VALUES 
(1, '2024-02-08 08:00:00', 50.00),
(2, '2024-02-08 09:00:00', 20.00),
(3, '2024-02-08 10:00:00', 30.00);

-- Insert values into InvoiceItems table
INSERT INTO InvoiceItems (InvoiceID, ProductID, Quantity, Amount) 
VALUES 
(1, 1, 3, 150),
(1, 2, 2, 40),
(2, 3, 5, 150);

-- Insert values into Admins table
INSERT INTO Admins (Username, PasswordHash, FullName, Email, GlobalSAT) 
VALUES 
('admin1', '12345', 'Lotus Biswas', 'lotushotmail111@gmail.com', 3.00);
