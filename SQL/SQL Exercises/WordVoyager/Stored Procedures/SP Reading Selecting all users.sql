-- Procedure to show all user

CREATE PROCEDURE spShowAllUser
AS
BEGIN 
SELECT * FROM [User];
END

-- Executing above stored procedure

EXECUTE spShowAllUser;