CREATE VIEW  StudentWithDepartmentViewModel
AS

SELECT s.Id AS StudentId, s.RegisterNo, s.Name AS StudentName, s.Email, s.ContactNo, s.Date, s.Address, s.DeptId, d.Code, d.Name AS DepartmentName  
FROM Student AS s
INNER JOIN Department AS d
ON s.DeptId = d.Id;
--------------------------------------------------------------


SELECT * FROM StudentWithDepartmentViewModel;

