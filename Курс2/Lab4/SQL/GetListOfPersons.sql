USE [AdventureWorks]
GO
/****** Object:  StoredProcedure [dbo].[GetListOfPersons]    Script Date: 15.12.2020 21:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[GetListOfPersons] AS
BEGIN
     SELECT TOP 30 
				  Person.Person.BusinessEntityID AS Id,
	              FirstName + ' ' + LastName AS FIO,
				  BirthDate,
				  PhoneNumber, 
				  JobTitle
    FROM          Person.Person, 
	              Person.PersonPhone,
				  HumanResources.Employee

    WHERE Person.Person.BusinessEntityID = Person.PersonPhone.BusinessEntityID
    AND   Person.Person.BusinessEntityID = HumanResources.Employee.BusinessEntityID

	ORDER BY Id
END;