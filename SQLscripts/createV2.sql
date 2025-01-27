set nocount on
go

use master
go

create database Organs
go

set quoted_identifier on
go

set dateformat dmy
go

use Organs
go

if exists(select * from sysobjects where id = object_id('dbo.Bank_info') and sysstat & 0xf = 3)
drop table dbo.Bank_info
go
if exists(select * from sysobjects where id = object_id('dbo.Blood_amount') and sysstat & 0xf = 3)
drop table dbo.Blood_amount
go
if exists(select * from sysobjects where id = object_id('dbo.Blood_donation') and sysstat & 0xf = 3)
drop table dbo.Blood_donation
go
if exists(select * from sysobjects where id = object_id('dbo.Blood_donor_info') and sysstat & 0xf = 3)
drop table dbo.Blood_donor_info
go
if exists(select * from sysobjects where id = object_id('dbo.Donor_info') and sysstat & 0xf = 3)
drop table dbo.Donor_info
go
if exists(select * from sysobjects where id = object_id('dbo.Hospital_info') and sysstat & 0xf = 3)
drop table dbo.Hospital_info
go
if exists(select * from sysobjects where id = object_id('dbo.Organ_donation') and sysstat & 0xf = 3)
drop table dbo.Organ_donation
go
if exists(select * from sysobjects where id = object_id('dbo.Receiver_info') and sysstat & 0xf = 3)
drop table dbo.Receiver_info
go
create table Donor_info
(
	Donor_id int not null,
	First_name nvarchar(10) not null,
	Last_name nvarchar(20) not null,
	Birth_date date not null,
	Blood_type nvarchar(3) not null,
	City nvarchar(15) not null,
	"Address" nvarchar(30) not null,
	constraint "PK_Donor_info" primary key(Donor_id),
	constraint "CK_Birth_date" check (Birth_date < getdate())
);
go
create index "idx_DLast_name" on dbo.Donor_info(Last_name)
create index "idx_DCity" on dbo.Donor_info(City)
create index "idx_DBlood_type" on dbo.Donor_info(Blood_type)
go

create table Blood_donor_info
(
	Bdonor_id int not null,
	First_name nvarchar(10) not null,
	Last_name nvarchar(20) not null,
	Birth_date date not null,
	Blood_type nvarchar(3) not null,
	Donation_count int not null,
	City nvarchar(15) not null,
	"Address" nvarchar(30) not null,
	constraint "PK_Blood_donor_info" primary key (Bdonor_id),
	constraint "CK_Birth_date1" check (Birth_date < getdate())
);
go
create index "idx_BLast_name" on dbo.Blood_donor_info(Last_name)
create index "idx_BCity" on dbo.Blood_donor_info(City)
create index "idx_BBlood_type" on dbo.Blood_donor_info(Blood_type)
go

create table Organ_donation
(
	Organ_id int not null,
	Donor_id int null,
	Organ nvarchar(15) not null,
	Extraction_date date null,
	Place_id int null,
	"Status" nvarchar(15) not null,
	constraint "PK_Organ_donation" primary key (Organ_id),
	constraint "CK_Extraction_date" check (Extraction_date <= getdate()),
	constraint "FK_Donor_Organ" foreign key (Donor_id) 
        references Donor_info(Donor_id) 
        on delete set null
);
go
create index "idx_Donor" on dbo.Organ_donation(Donor_id)
create index "idx_Organ" on dbo.Organ_donation(Organ)
create index "idx_Organ_place" on dbo.Organ_donation(Place_id)
create index "idx_Status" on dbo.Organ_donation("Status")
go

create table Blood_donation
(
	Bdonor_id int not null,
	Donation_date date not null,
	Amount int not null,
	Place_id int not null,
	constraint "PK_Blood_donation" primary key clustered(Bdonor_id, Donation_date),
	constraint "CK_Donation_date" check (Donation_date <= getdate())
);
go
create index "idx_Bdonor" on dbo.Blood_donation(Bdonor_id)
create index "idx_BPlace" on dbo.Blood_donation(Place_id)
go

create table Receiver_info
(
	Receiver_id int not null,
	First_name nvarchar(10) not null,
	Last_name nvarchar(20) not null,
	Birth_date date not null,
	Blood_type nvarchar(3) not null,
	Organ_id int not null,
	City nvarchar(15) not null,
	"Address" nvarchar(20) not null,
	Hospital_id int not null,
	Registration_date date not null,
	Operation_date date null,
	Organ_status nvarchar(15) not null,
	"Priority" nvarchar(15) not null,
	constraint "PK_Receiver_info" primary key clustered(Receiver_id, Organ_id),
	constraint "CK_Birth_date2" check (Birth_date <= getdate()),
	constraint "CK_Registration_date" check (Registration_date < getdate()),
);
go
create index "idx_RLast_name" on dbo.Receiver_info(Last_name)
create index "idx_RBlood_type" on dbo.Receiver_info(Blood_type)
create index "idx_ROrrgan_status" on dbo.Receiver_info(Organ_status)
create index "idx_RPriority" on dbo.Receiver_info("Priority")
create index "idx_RRegistrration" on dbo.Receiver_info(Registration_date)
create index "idx_ROperation" on dbo.Receiver_info(Operation_date)
create index "idx_RCity" on dbo.Receiver_info(City)
go

create table Hospital_info
(
	Hospital_id int not null,
	City nvarchar(15) not null,
	"Address" nvarchar(30) not null,
	Contact_info nvarchar(30) not null,
	constraint "PK_Hospital_info" primary key (Hospital_id)
);
go
create index "idx_HCity" on dbo.Hospital_info(City)
go

create table Bank_info
(
	Place_id int not null,
	City nvarchar(15) not null,
	"Address" nvarchar(30) not null,
	Contact_info nvarchar(30) not null,
	constraint "PK_Bank_info" primary key (Place_id)
);
go
create index "idx_BCity" on dbo.Bank_info(City)
create index "idx_BPlace" on dbo.Bank_info(Place_id)
go

create table Blood_amount
(
	Place_id int not null,
	A_plus int not null,
	A_minus int not null,
	B_plus int not null,
	B_minus int not null,
	AB_plus int not null,
	AB_minus int not null,
	O_plus int not null,
	O_minus int not null,
	constraint "PK_Blood_amount" primary key (Place_id)
);
go
create index "idx_Place" on dbo.Blood_amount(Place_id)
go

alter table Blood_amount
add constraint FK_BloodAmount_Bank
foreign key (Place_id) references Bank_info(Place_id)
go

alter table Organ_donation
add constraint FK_Organ_Bank
foreign key (Place_id) references Bank_info(Place_id)
go

alter table Blood_donation
add constraint FK_Blood_Bank
foreign key (Place_id) references Bank_info(Place_id)
go

alter table Organ_donation
add constraint FK_Organ_Donor
foreign key (Donor_id) references Donor_info(Donor_id)
go

alter table Blood_donation
add constraint FK_Blood_Donor
foreign key (BDonor_id) references Blood_donor_info(BDonor_id)
go

alter table Receiver_info
add constraint FK_Receiver_Organ
foreign key (Organ_id) references Organ_donation(Organ_id)
go

alter table Receiver_info
add constraint FK_Receiver_Hospital
foreign key (Hospital_id) references Hospital_info(Hospital_id)
go