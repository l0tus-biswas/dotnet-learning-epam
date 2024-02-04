-- Create a Scalar valued function to rerun the cube of the given value

CREATE FUNCTION svfReturnCube 
(
@value INT
)
RETURNS INT

AS
BEGIN
RETURN @value * @value * @value;
END

-- Executing the above SVF
SELECT dbo.svfReturnCube(10);