-- 1-Create a table named "Employees" with columns for ID (integer), Name (varchar), and Salary (decimal).
create table Employees(
	Id int,
	Name Varchar(50),
	Salary decimal(8,2)
)

-- 2-Add a new column named "Department" to the "Employees" table with data type varchar(50).
alter table Employees  add Department varchar(50)

-- 3-Remove the "Salary" column from the "Employees" table
alter table Employees  drop column Salary

-- 4-Rename the "Department" column in the "Employees" table to "DeptName".
exec sp_rename 'Employees.Department' ,'DeptName' ,'column'

-- 5-Create a new table called "Projects" with columns for ProjectID (integer) and ProjectName (varchar).
create table Projects (
	ProjectID int identity primary key,
	ProjectName varchar(50)
)

-- 6-Add a primary key constraint to the "Employees" table for the "ID" column.
alter table Employees alter column Id int not null
alter table Employees add primary key(Id)

--7-Create a foreign key relationship between the "Employees" table (referencing "ID") and the "Projects" table (referencing "ProjectID").
alter table Employees add ProjectID int 
alter table Employees add constraint fk_ProjectID foreign key (ProjectID) references Projects(ProjectID)

-- 8-Remove the foreign key relationship between "Employees" and "Projects."
alter table Employees drop constraint fk_ProjectID 

--9-Add a unique constraint to the "Name" column in the "Employees" table.
alter table Employees add constraint unique_Name UNIQUE(Name)

-- 10-Create a table named "Customers" with columns for CustomerID (integer), FirstName (varchar), LastName (varchar), and Email (varchar), and Status (varchar).
create table Customers (
	CustomerID int,
	FirstName varchar(50),
	LastName varchar(50),
	Email varchar(100),
	status varchar(50)
)

-- 11-Add a unique constraint to the combination of "FirstName" and "LastName" columns in the "Customers" table.
alter table Customers add constraint unique_names unique(FirstName,LastName)

-- 12-Add a default value of 'Active' for the "Status" column in the "Customers" table, where the default value should be applied when a new record is inserted
alter table Customers add constraint df_status default 'Active' for status

-- 13-Create a table named "Orders" with columns for OrderID (integer), CustomerID (integer), OrderDate (datetime), and TotalAmount (decimal).
create table Orders (
	OrderID int,
	CustomerID int,
	OrderDate datetime,
	TotalAmount decimal
)

-- 14-Add a check constraint to the "TotalAmount" column in the "Orders" table to ensure that it is greater than zero.
alter table Orders add constraint check_totalAmount check (TotalAmount > 0)

-- 15-Create a schema named "Sales" and move the "Orders" table into this schema.
create schema Sales

alter schema Sales transfer orders

-- 16-Rename the "Orders" table to "SalesOrders."
exec sp_rename "Sales.Orders" ,"SalesOrders"
