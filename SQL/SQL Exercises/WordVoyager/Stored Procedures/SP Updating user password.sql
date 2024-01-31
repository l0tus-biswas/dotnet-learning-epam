-- Procedure to update user password

CREATE PROCEDURE spUpdateUserPassword
@UserId INT,
@Email NVARCHAR(100),
@PasswordHash NVARCHAR(100)
AS
BEGIN 

UPDATE [User] 
SET PasswordHash = @PasswordHash 
WHERE UserId = @UserId AND Email = @Email;

END

-- Executing the stored procedure

EXECUTE spUpdateUserPassword @UserId = 6, @Email= 'lotushotmail111@gmail.com', @PasswordHash = '1234567';

-- View all users

SELECT * FROM [User];