-- Procedure to insert new user
CREATE PROCEDURE spInsertNewUser
@Username NVARCHAR(100),
@Email NVARCHAR(100),
@PasswordHash NVARCHAR(100)
AS
BEGIN
	INSERT INTO [User]
	(Username, Email, PasswordHash, RegistrationDate)
	VALUES(@Username,@Email,@PasswordHash, GETDATE());
END;


-- Executing the above procedure 
EXECUTE spInsertNewUser  'Lotus Biswas', 'lotushotmail111@gmail.com', 'SribasBis@22' ;


-- dropping the above procedure

DROP PROCEDURE spInsertNewUser;
