create table TB_CAR_INFO (
  id int identity (1,1) not null primary key,
  carName nvarchar(30),
  carYear varchar(4),
  carPrice int,
  carDoor int
)

insert into TB_CAR_INFO values ('K9', '2018', 6300, 5);
insert into TB_CAR_INFO values ('그랜저', '2019', 4300, 5);
insert into TB_CAR_INFO values ('K5', '2017', 2800, 5);
insert into TB_CAR_INFO values ('소나타', '2016', 2200, 5);
insert into TB_CAR_INFO values ('렉스턴', '2018', 4000, 5);