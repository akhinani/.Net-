CREATE TABLE EMPLOYEES
(
employee_id int primary key NOT NULL,
first_name nchar(20) NOT NULL,
last_name nchar(20) NOT NULL,
email nchar(20) NOT NULL,
phone_number int NOT NULL,
hire_date date NOT NULL,
job_id int NOT NULL FOREIGN KEY REFERENCES JOBS(job_id) ,
salary money NOT NULL,
commission_pct money NOT NULL,
manager_id int NOT NULL REFERENCES EMPLOYEES(employee_id),
department_id int NOT NULL FOREIGN KEY REFERENCES DEPARTMENTS(department_id)
)