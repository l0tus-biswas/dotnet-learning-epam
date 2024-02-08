CREATE PROCEDURE UserLogin
    @UsernameOrEmail NVARCHAR(100),
    @Password NVARCHAR(100)
AS
BEGIN
   
    DECLARE @UserId INT

    -- Check if the provided username/email and password match
    SELECT @UserId = UserId
    FROM [User]
    WHERE (Username = @UsernameOrEmail OR Email = @UsernameOrEmail)
      AND PasswordHash = @Password;

    -- Return UserId if login is successful, otherwise return NULL
    RETURN @UserId
END;

EXEC UserLogin 'lotushotmail111@gmail.com', '1234567';