-- Scalar Valued Function to return user password by UserId
CREATE FUNCTION svfReturnUserPasswordById(@UserId INT)
RETURNS NVARCHAR(100)
AS
BEGIN

DECLARE @UserPassword NVARCHAR(100)
SELECT @UserPassword=PasswordHash FROM [User] WHERE UserId = @UserId
RETURN @UserPassword

END;

-- Executing the above SVF
SELECT dbo.svfReturnUserPasswordById(6);

