/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [std_id]
      ,[std_name]
      ,[std_gender]
      ,[std_age]
      ,[std_class]
      ,[t_id]
  FROM [practice].[dbo].[students]

  insert into  students  values(1,'anas','male',22,12,1);
  select*from students;
   insert into  students  values(2,'anum','female',21,11,2);
    insert into  students  values(3,'zain','male',23,12,3);
    insert into  students  values(4,'furaqan','male',21,11,1);
	 insert into  students  values(5,'saba','female',22,12,4);
	  insert into  students  values(6,'amna','female',23,12,3);