-- Procedure to perform various arthmetic operation

CREATE PROCEDURE spPerformingArthmeticOperationOnTwoNumber
(
@value1 INT,
@value2 INT
)

AS
BEGIN
DECLARE @addResult INT, @subResult INT, @multResult INT, @divideResult INT

SET @addResult = @value1 + @value2;
SET @subResult = @value1 - @value2;
SET @multResult = @value1 * @value2;
SET @divideResult = @value1 / @value2;

PRINT 'Addition of 2 numbers is : ' + CAST(@addResult AS VARCHAR);
PRINT 'Substract of 2 numbers is : ' + CAST(@subResult AS VARCHAR);
PRINT 'Multiply of 2 numbers is : ' + CAST(@multResult AS VARCHAR);
PRINT 'Divide of 2 numbers is : ' + CAST(@divideResult AS VARCHAR);

END;

-- Executing the above procedure

EXEC spPerformingArthmeticOperationOnTwoNumber 40, 10;