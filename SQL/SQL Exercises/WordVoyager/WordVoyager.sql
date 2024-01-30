-- DB Name :WordVoyager

-- Create the database if it doesn't exist
IF NOT EXISTS (SELECT 1 FROM sys.databases WHERE name = 'WordVoyager')
BEGIN
    CREATE DATABASE WordVoyager;
END
GO 

-- Switch to the database
USE WordVoyager;



/*
User Table: Stores information about users who can be authors and/or readers.

UserId (INT, PK): Unique identifier for the user.
Username (NVARCHAR(100)): User's chosen username.
Email (NVARCHAR(100)): User's email address.
PasswordHash (NVARCHAR(100)): Hash of the user's password.
RegistrationDate (DATETIME): Date and time the user registered.

*/

CREATE TABLE [User] (
    UserId INT PRIMARY KEY,
    Username NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(100) NOT NULL,
    RegistrationDate DATETIME DEFAULT GETDATE() NOT NULL
);


/*
Category Table: Stores different categories for articles.

CategoryId (INT, PK): Unique identifier for the category.
Name (NVARCHAR(100)): Name of the category.
Description (TEXT): Brief description of the category.

*/

CREATE TABLE [Category] (
    CategoryId INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Description TEXT 
);

/*
Article Table : Stores the articles published on the website.

ArticleId (INT, PK): Unique identifier for the article.
Title (NVARCHAR(100)): Title of the article.
Content (TEXT): Full text content of the article.
PublishedDate (DATETIME): Date and time the article was published.
LastModifiedDate (DATETIME): Date and time the article was last modified.
AuthorId (INT, FK): References UserId in the User table.
CategoryId (INT, FK): References CategoryId in the Category table.

*/
CREATE TABLE [Article] (
    ArticleId INT PRIMARY KEY,
    Title NVARCHAR(100) NOT NULL,
    Content TEXT NOT NULL,
    PublishedDate DATETIME DEFAULT GETDATE() NOT NULL,
    LastModifiedDate DATETIME DEFAULT GETDATE() NOT NULL,
    AuthorId INT FOREIGN KEY REFERENCES [User](UserId),
    CategoryId INT FOREIGN KEY REFERENCES [Category](CategoryId)
);

/*
Comment Table : Stores comments made on articles.

CommentId (INT, PK): Unique identifier for the comment.
ArticleId (INT, FK): References ArticleId in the Article table.
UserId (INT, FK): References UserId in the User table.
Content (TEXT): Text content of the comment.
CommentDate (DATETIME): Date and time the comment was posted.

*/

CREATE TABLE [Comment] (
    CommentId INT PRIMARY KEY,
    ArticleId INT FOREIGN KEY REFERENCES [Article](ArticleId),
    UserId INT FOREIGN KEY REFERENCES [User](UserId),
    Content TEXT NOT NULL,
    CommentDate DATETIME DEFAULT GETDATE() NOT NULL
);

/*
Tag Table : Stores tags for articles.

TagId (INT, PK): Unique identifier for the tag.
Name (NVARCHAR(100)): Name of the tag.

*/

CREATE TABLE [Tag] (
    TagId INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
);


/*
ArticleTag Table : Manages the many-to-many relationship between articles and tags.

ArticleId (INT, FK): References ArticleId in the Article table.
TagId (INT, FK): References TagId in the Tag table.

*/

CREATE TABLE [ArticleTag] (
    ArticleId INT FOREIGN KEY REFERENCES [Article](ArticleId),
    TagId INT FOREIGN KEY REFERENCES [Tag](TagId),
    PRIMARY KEY (ArticleId, TagId)
);

/*

Attachment Table : Stores attachments related to articles.

AttachmentId (INT, PK): Unique identifier for the attachment.
ArticleId (INT, FK): References ArticleId in the Article table.
FileName (NVARCHAR(100)): Name of the attachment file.
FileType (NVARCHAR(100)): Type of the attachment (e.g., image, PDF).
FilePath (NVARCHAR(100)): Path to the stored attachment file.
UploadDate (DATETIME): Date and time the attachment was uploaded.

*/

CREATE TABLE [Attachment] (
    AttachmentId INT PRIMARY KEY,
    ArticleId INT FOREIGN KEY REFERENCES [Article](ArticleId),
    FileName NVARCHAR(100) NOT NULL,
    FileType NVARCHAR(100) NOT NULL,
    FilePath NVARCHAR(100) NOT NULL,
    UploadDate DATETIME DEFAULT GETDATE() NOT NULL
);