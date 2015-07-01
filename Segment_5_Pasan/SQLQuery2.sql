create procedure Select_Table
AS
BEGIN
    SELECT * FROM Registration
END

exec Select_Table

CREATE PROCEDURE Insert_Student
	   @std_Name varchar(50),
	   @std_DOB  DateTime,
	   @std_Gread float,
	   @std_active bit             
AS 
BEGIN 
     SET NOCOUNT ON 

     INSERT INTO dbo.Registration
          ( 
            Name,
            DOB,
            GreadePointAverage,
            Active                  
          ) 
     VALUES 
          ( 
            @std_Name ,
			@std_DOB ,
			@std_Gread ,
			@std_active
          ) 

END 

GO

EXEC dbo.Insert_Student 
    @std_Name='kamal',
	@std_DOB='02/03/1999',
	@std_Gread=2.1,
	@std_active=1;