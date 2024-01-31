-- Deleting all user comments by UserId

CREATE PROCEDURE spDeleteCommentByUserID
(
@UserId INT
)

AS
BEGIN
DELETE FROM [Comment] WHERE UserId = @UserId;
END;

-- Executing above stored procedure

EXEC spDeleteCommentByUserID @UserId = 2;


-- View all Comment to check if the comment got deleted

SELECT * FROM [Comment];