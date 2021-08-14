create database QLTHUEBAO
go
use QLTHUEBAO
go
create table region(
	id_region nvarchar(5) primary key not null,
	name_region nvarchar(50) not null
);
create table network(
	id_network nvarchar(5) primary key not null,
	name_network nvarchar(30) not null,
	price_internal bigint not null,
	price_foreign bigint not null,
	mess_internal bigint not null,
	mess_foreign bigint not null,
	max_reg int not null
);

create table customer(
	id_card nvarchar(12) primary key not null,
	name_customer nvarchar(50) not null,
	dob date not null,
	sex nvarchar(3) not null,
	address nvarchar(100) not null,
	avatar image not null,
	pic_front image not null,
	pic_back image not null,
	email nvarchar(50) not null
);

create table phone(
	phone_number nvarchar(11) primary key not null,
	id_network nvarchar(5) not null,
	activation_date datetime not null,
	expiration_date datetime not null,
	id_region nvarchar(5) not null,
	account_balance bigint not null,
	payment bigint not null,
	type nvarchar(50) not null,
	account_promotion bigint not null,
	id_card nvarchar(12) not null,
	status nvarchar(1) not null
);

create table service(
	id_service nvarchar(5) primary key not null,
	name_service nvarchar(50) not null,
	id_network nvarchar(5) not null,
	price_service bigint not null,
	promotion int not null,
	exp_date int not null,
	info nvarchar(200) null
);
create table card(
	code nvarchar(20) not null,
	price int not null,
	id_network nvarchar(5) not null,
	promotion int not null
);

create table account(
	username nvarchar(11) primary key not null,
	password nvarchar(1000) not null,
	permission nvarchar(1) not null
);

create table history_recharge(
	id_recharge int identity(1,1) primary key not null,
	phone_number nvarchar(11) not null,
	code nvarchar(20) not null,
	status nvarchar(1) not null,
	price int not null,
	promotion int not null,
	time datetime not null
);

create table reg_service(
	phone_number nvarchar(11) not null,
	id_service nvarchar(5) not null,
	date_exp date not null
);

create table cookie(
	cookie nvarchar(1000) null
);

create table sended(
	id_send int identity(1,1) primary key not null,
	phone_out nvarchar(11) not null,
	phone_in nvarchar(11) not null,
	contents nvarchar(1000) not null,
	time_send datetime not null,
	status nvarchar(1) not null
);

create table called(
	id_call int identity(1,1) primary key not null,
	phone_out nvarchar(11) not null,
	phone_in nvarchar(11) not null,
	time_start datetime not null,
	time_finish datetime not null,
	minutes int not null,
	status nvarchar(1) not null
);

create table bill(
	id_bill int identity(1,1) primary key not null,
	id_card nvarchar(12) not null,
	name_customer nvarchar(50) not null,
	address nvarchar(200) not null,
	phone_number nvarchar(11) not null,
	type nvarchar(50) not null,
	count_minute_call bigint not null,
	count_mess bigint not null,
	count_service bigint not null,
	payment bigint not null,
	date datetime not null,
	status nvarchar(1) not null
);


create table spending(
	id_spending int identity(1,1) primary key not null,
	phone_number nvarchar(11) not null,
	payment bigint not null,
	date datetime not null,
);

--tao tai khoan admin
-- tai khoan: admin
-- mat khau: truong

insert into account values('admin', '412448232496118222895216122182225191209251', '1');

--them du lieu bang vung
insert into region values('099',N'Bắc Ninh');
insert into region values('029',N'Hà Nội');
insert into region values('019',N'Phú Thọ');
insert into region values('036',N'Thanh Hóa');
--them du lieu bang nha mang
insert into network values('VT','Viettel',200,300,100,200,5);
insert into network values('VN','Vietnamobile',300,400,200,300,10);
insert into network values('MBF','Mobifone',400,500,200,300,7);
insert into network values('VNP','Vinaphone',300,400,200,300,3);
insert into network values('GMB','Gmobile',300,400,100,400,10);

--them du lieu bang dich vu
insert into service values('01',N'Xem phim rạp','VT',50000,20,30,N'xem phim chiếu rạp miễn phí trong 30 ngày');
insert into service values('02',N'Xem bóng đá','VT',100000,10,60,N'xem bóng đá miễn phí trong 60 ngày');

insert into service values('03',N'Xem phim rạp','VN',50000,20,30,N'xem phim chiếu rạp miễn phí trong 30 ngày');
insert into service values('04',N'Xem bóng đá','VN',100000,10,60,N'xem bóng đá miễn phí trong 60 ngày');

insert into service values('05',N'Xem phim rạp','MBF',50000,20,30,N'xem phim chiếu rạp miễn phí trong 30 ngày');
insert into service values('06',N'Xem bóng đá','MBF',100000,10,60,N'xem bóng đá miễn phí trong 60 ngày');

insert into service values('07',N'Xem phim rạp','VNP',50000,20,30,N'xem phim chiếu rạp miễn phí trong 30 ngày');
insert into service values('08',N'Xem bóng đá','VNP',100000,10,60,N'xem bóng đá miễn phí trong 60 ngày');

insert into service values('09',N'Xem phim rạp','GMB',50000,20,30,N'xem phim chiếu rạp miễn phí trong 30 ngày');
insert into service values('10',N'Xem bóng đá','GMB',100000,10,60,N'xem bóng đá miễn phí trong 60 ngày');