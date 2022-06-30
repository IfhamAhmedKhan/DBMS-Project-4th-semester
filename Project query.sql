create database IEYTProject
use IEYTProject
create table UserInfo(
UserID int identity(1,1) primary key,
Username varchar(30) not null,
UserPassword varchar(30) not null,
Email varchar(30) not null,
Phone varchar(30) not null,
);
select * from UserInfo

create table CheckOut(
UserID int identity(1,1) primary key,
Username varchar(30) not null,
UserPassword varchar(30) not null,
UserAddress varchar(30) not null,
Phone varchar(30) not null,
PaymentMethod varchar(30) not null,
);
use IEYTProject
select * from CheckOut
create table Items(
ItemID int identity(1,1) primary key,
GraphicCard varchar(30) not null,
Monitors varchar(30) not null,
GamingLaptop varchar(30) not null,
Mouse varchar(30) not null,
GamingDesktop varchar(30) not null,
Keyboard varchar(30) not null,
);
insert into Items values ('RTX 3050','ASUS-VP228','EVO15-S','LazerR4','Neuron','K100-RGB_MK')
insert into Items values ('RTX 3080','ASUS-VZ249Z','EVO14-S','LazerK9','Mellinimum','K60-RGB_MK')

use IEYTProject
select * from CheckOut
select * from Items
select * from TableLogin
select * from UserInfo
delete from TableLogin where UserID=4

use IEYTProject
create table TableLogin(
UserID int identity(1,1) primary key,
Username varchar(30) not null,
UserPassword varchar(30) not null,
);
insert into TableLogin values ('Eiquan','Qwerty123')