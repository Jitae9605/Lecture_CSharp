create table tblPeople
(
Name nvarchar(10) primary key,
Age int not null,
Male bit not null
);

insert into tblPeople values('���켺', 36, 1);
insert into tblPeople values('��ҿ�', 32, 0);
insert into tblPeople values('�����', 37, 1);
insert into tblPeople values('������', 29, 0);

go

create table tblSale
(
OrderNo int identity(1,1) primary key,
Customer nvarchar(10) not null references tblPeople(Name),
Item nvarchar(20) not null,
ODate datetime not null
);

insert into tblSale (Customer,Item, ODate) values ('���켺','�鵵��','2008/1/1');
insert into tblSale (Customer,Item, ODate) values ('��ҿ�','ȭ��ǰ','2008/1/2');
insert into tblSale (Customer,Item, ODate) values ('�����','�ڵ���','2008/1/3');
insert into tblSale (Customer,Item, ODate) values ('������','�ֹ���','2008/1/4');

go

select * from tblPeople;
select * from tblSale;
go

CREATE PROCEDURE IncAllAge
AS
UPDATE tblPeople Set Age = Age + 1;
go

CREATE PROCEDURE IncSomeAge
@Name NVARCHAR(10),
@Age INT OUTPUT
AS
UPDATE tblPeople SET Age = Age + 1 WHERE Name = @Name;
SELECT @Age = Age FROM tblPeople WHERE Name = @Name;
go

-- DECLARE @Age INT;
-- EXECUTE IncSomeAge '�����', @Age OUTPUT;
-- SELECT @Age;


--            drop table tblSale;
--            drop table tblPeople;
--            drop procedure IncAllAge;
--            drop procedure IncSomeAge;

