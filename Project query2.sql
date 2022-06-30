use IEYTProject
create table TableLogin(
UserID int identity(1,1) primary key,
Username varchar(30) not null,
UserPassword varchar(30) not null,
);
insert into TableLogin values ('Eiquan','Qwerty123')