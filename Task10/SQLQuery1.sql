-- 1-Create a new database named "CompanyDB."
create database CompanyDB

--2-Create a schema named "Sales" within the "CompanyDB" database.
create schema Sales

--3-Create a table named "employees" with columns: 
create sequence employeeId as int start with 1 INCREMENT by 1

create Table Sales.employees(
	employee_Id int primary key,
	first_name varchar(50),
	last_name varchar(50),
	slary decimal(8,2)
)

--4-Alter the "employees" table to add a new column named "hire_date" with the data type DATE.
alter table Sales.employees add hire_date Date

--5-Add mock data to this table using Mockaroo

insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Kelly', 'Panichelli', 4.29, '6/26/2024');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Kessia', 'Buckenhill', 9900.99, '12/1/2021');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Wells', 'Temperley', 3.99, '11/25/2024');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Kati', 'Bourhill', 99.99, '5/28/2024');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Vidovic', 'Warrior', 12.99, '3/26/2025');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Lemmie', 'Barti', 2.99, '7/8/2024');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Stevena', 'Avery', 44.99, '7/18/2020');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Myrilla', 'Mardell', 2.29, '12/21/2024');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Albertine', 'Beglin', 79.99, '6/7/2024');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Linnie', 'Pinckard', 7.99, '11/6/2024');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Felipe', 'Coneybeare', 29.99, '8/30/2024');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Chere', 'Mileham', 19.99, '9/30/2024');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Sayers', 'McRobert', 3.99, '2/2/2019');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Ardene', 'Beldom', 3.49, '6/13/2024');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Dorolice', 'Henmarsh', 199.99, '2/9/2025');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Dot', 'Critten', 50000.99, '10/8/2024');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Rosina', 'Zambon', 25000.99, '7/11/2024');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Jillana', 'Downs', 25406.49, '12/26/2024');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Hervey', 'Sidwick', 89.99, '7/1/2024');
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date) values (Next value for employeeId, 'Janette', 'Tynan', 5.29, '6/11/2024');


-------------------------------------------------------------------------------------------
-- DATA MANIPULATION Exercises: --

-- 1-Select all columns from the "employees" table.
select * from sales.employees 

-- 2-Retrieve only the "first_name" and "last_name" columns from the "employees" table.
select first_name, last_name
from sales.employees

-- 3-Retrieve "full name" as a one column from "first_name" and "last_name" columns from the "employees" table.
select first_name + ' ' + last_name as full_Name
from Sales.employees

-- 4-Show the average salary of all employees. (Use AVG() function)
select AVG(slary)
from Sales.employees

-- 5-Select employees whose salary is greater than 50000.
select *
from Sales.employees
where slary > 50000

-- 6-Retrieve employees hired in the year 2020.
select *
from Sales.employees
where YEAR(hire_date) = 2020

-- 7-List employees whose last names start with 'S'.
select *
from Sales.employees
where last_name like 'S%'

-- 8-Display the top 10 highest-paid employees.
select Top 10 *
from Sales.employees

-- 9-Find employees with salaries between 40000 and 60000.
select *
from Sales.employees
where slary between 40000 and 60000

-- 10-Show employees with names containing the substring 'man'.
select *
from  Sales.employees
where (first_name + ' ' + last_name) like '%man%'

-- 11-Display employees with a NULL value in the "hire_date" column
select *
from  Sales.employees
where hire_date is null

-- 12-Select employees with a salary in the set (40000, 45000, 50000)
select *
from  Sales.employees
where slary in (40000, 45000, 50000)

-- 13-Retrieve employees hired between '2020-01-01' and '2021-01-01'.
select *
from Sales.employees
where hire_date between '2020-01-01' and '2021-01-01'

-- 14-List employees with salaries in descending order.
select *
from Sales.employees
order by slary Desc

-- 15-Show the first 5 employees ordered by "last_name" in ascending order.
select Top 5 *
from Sales.employees
order by last_name 
 
select *
from Sales.employees
order by last_name
offset 0 rows
fetch next 5 rows only;

-- 16-Display employees with a salary greater than 55000 and hired in 2020.
select *
from Sales.employees 
where slary > 55000 and YEAR(hire_date) = 2020

-- 17-Select employees whose first name is 'John' or 'Jane'.
select *
from Sales.employees 
where first_name = 'John' or first_name = 'Jane'

-- 18-List employees with a salary ≤ 55000 and a hire date after '2022-01-01'.
select *
from Sales.employees 
where slary <= 55000 and  hire_date > '2022-01-01'

-- 19-Retrieve employees with a salary greater than the average salary.
select employee_Id, slary
from Sales.employees 
group by employee_Id, slary
having slary > AVG(slary)

-- 20-Display the 3rd to 7th highest-paid employees. (Use OFFSET and FETCH)
select *
from Sales.employees
order by slary Desc
offset  2 rows
fetch next 4 rows only 

-- 21-list employees hired after '2021-01-01' in alphabetical order.
select *
from Sales.employees
where hire_date > '2021-01-01'
order by first_name, last_name

-- 22-Retrieve employees with a salary > 50000 and last name not starting with 'A'.
select * 
from Sales.employees
where slary > 50000 and last_name not like 'A%'

-- 23-Display employees with a salary that is not NULL.
select *
from Sales.employees
where slary is not null

-- 24-Show employees with names containing 'e' or 'i' and a salary > 45000.
select *
from Sales.employees
where (first_name + ' ' + last_name)  like '%[ei]%' and slary > 45000

----------------------------------------------------------------------------------------------

-- JOIN-RELATED EXERCISES --

-- 25-Create a new table named "departments" with columns:
create table deparments (
	department_id  int Identity primary key,
	department_name varchar(50),
	manager_id int references Sales.employees(employee_id)
)

-- 26-Assign each employee to a department by creating a "department_id" column in "employees" and making it a foreign key referencing "departments".department_id.
alter table Sales.employees add department_id int references deparments(department_id)

insert into deparments (department_name, manager_id) values('dep1', 3)
insert into deparments (department_name, manager_id) values('dep2', 4)
insert into deparments (department_name, manager_id) values('dep3', 15)

update Sales.employees set department_id = 1 where employee_Id <=10
update Sales.employees set department_id = 2 where employee_Id > 10 and employee_Id <=20

-- 27-Retrieve all employees with their department names (Use INNER JOIN).
select em.employee_Id, em.first_name , em.last_name, dep.department_name
from Sales.employees em
join deparments dep on em.department_id = dep.department_id

-- 28-Retrieve employees who don’t belong to any department (Use LEFT JOIN and check for NULL).
select *
from Sales.employees em
left join deparments dep on em.department_id = dep.department_id
where em.department_id is null

-- 29-Show all departments and their employee count (Use JOIN and GROUP BY).
select dep.department_name, count(em.employee_Id)
from deparments dep
left join Sales.employees em on dep.department_id = em.department_id
group by dep.department_name

-- 30-Retrieve the highest-paid employee in each department (Use JOIN and MAX(salary)).
select department_name, max(em.slary), em.first_name
from deparments dep
left join Sales.employees em on dep.department_id = em.department_id
where em.slary = (select MAX(slary) from Sales.employees where department_id is not null and department_id = dep.department_id)  
or (select MAX(slary) from Sales.employees where department_id is not null and department_id = dep.department_id)  is null
group by dep.department_name, em.first_name

-- 31-. Group employees by their department and calculate the average salary for each department.
select department_name, avg(em.slary) aveage
from deparments dep
left join Sales.employees em on dep.department_id = em.department_id
group by dep.department_id, dep.department_name

-- 32- Insert a new employee into the "employees" table with a salary and hire date.
insert into Sales.employees (employee_Id, first_name, last_name, slary, hire_date, department_id) values(next value for employeeId,'basmala', 'ibrahim', 25000, '12/1/2024', 1)

-- 33-Update the salary of employees who earn less than 45000 to 46000.
update Sales.employees set slary = 46000 where slary < 45000

-- 34- Delete employees who have a NULL hire date
delete from Sales.employees where hire_date is null

-- 35-Create an index on the salary column in the "employees" table to optimize queries filtering by salary.
create index ix_salary
on Sales.employees(slary)