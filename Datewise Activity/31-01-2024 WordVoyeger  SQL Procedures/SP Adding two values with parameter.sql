-- Procedure to add two values

CREATE PROCEDURE spAddingTwoValue
(
@value1 INT,
@value2 INT
)
AS
BEGIN
DECLARE @value3 INT
SET @value3 = @value1 + @value2;
PRINT 'Addition of two Varaible are : ' + CAST(@value3 AS VARCHAR);
END;


-- Executing the above proecdure

EXEC spAddingTwoValue 10,20;