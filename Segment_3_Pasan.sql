Create table Person
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	last varchar(20),
	first varchar(20),
	gender bit,
	DoB datetime
)

--drop table Person
select * from Person

insert into Person values ( 'kasun','nishan',1,'09/08/1993' )
insert into Person values ( 'Shalani','Sakya',0,'03/04/1994' )
insert into Person values ( 'kamal','niroshan',1,'08/02/1993' )
insert into Person values ( 'ruwani','kavisha',0,'05/01/1990' )
insert into Person values ( 'ruwan','gunarathna',1,'01/09/1994' )

select * from person
where gender=1 or dob > '1993/03/08'

update Person
  set first = 'Lakmal'
  where Id = 1;

  update Person
  set first = 'Lakmal', last='dilon'
  where Id = 1;