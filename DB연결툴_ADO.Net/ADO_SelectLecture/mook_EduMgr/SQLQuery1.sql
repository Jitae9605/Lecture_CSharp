create table t_login (
  id int identity (1,1) not null,
  userid varchar(30),
  userpwd varchar(30)
)

insert into t_login values ('stu1', 'stu1');
insert into t_login values ('stu2', 'stu2');

create table t_userinfo (
  id int identity (1,1) not null,
  userid varchar(30),
  edunum int,
  name nvarchar(30),
  birth varchar(30),
  email varchar(40),
  phone varchar(30)
)

insert into t_userinfo values ('stu1', 10, '홍길동', '20210323', 'test@test.com', '111-1111-1111');
insert into t_userinfo values ('stu2', 20, '강호동', '20210512', 'kang@kang.com', '222-2222-2222');

create table t_subject (
  id int identity (1,1) not null,
  subject varchar(50)
)

insert into t_subject values ('국어');
insert into t_subject values ('영어');
insert into t_subject values ('수학');

create table t_user_subject (
  id int identity (1,1) not null,
  edunum int,
  subject varchar(50)
)


insert into t_user_subject values (10, '국어');
insert into t_user_subject values (20, '국어');
insert into t_user_subject values (20, '수학');