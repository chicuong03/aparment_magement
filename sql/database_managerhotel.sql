		
CREATE DATABASE managerhotel
use managerhotel

-- CREATE TABLE ROOMS
CREATE TABLE rooms (
	roomNo Char(5)  not null PRIMARY KEY, 
	roomStatus VARCHAR(250) NOT NULL,
	Booked VARCHAR(150) DEFAULT 'Trong'
)

-- CREATE TABLE NEW STUDENT
CREATE TABLE newhuman (
	id INT IDENTITY(1, 1) PRIMARY KEY,
	mobile BIGINT NOT NULL,
	name_ NVARCHAR(250) NOT NULL,
	email VARCHAR(250) NOT NULL,
	paddress VARCHAR(250) NOT NULL,
--	college VARCHAR(250) NOT NULL,
	idproof VARCHAR(250) NOT NULL,
	roomNo Char(5) NOT NULL,
	living VARCHAR(250) DEFAULT 'living',
	FOREIGN KEY (roomNo) REFERENCES rooms(roomNo)
)

--create price rooms

CREATE TABLE priceroom (
    id INT IDENTITY(1, 1) PRIMARY KEY,
    roomNo CHAR(5) NOT NULL,
    year INT NOT NULL,
    month INT NOT NULL,
    electric FLOAT NOT NULL,
    unitpriceelectric FLOAT,
    water FLOAT,
    unitpricewater FLOAT,
    autumnday DATE,
    price MONEY,
    moneyelectric MONEY,
    moneywater MONEY,
    summoney MONEY,
    pay BIT DEFAULT 0,
    CONSTRAINT UK_priceroom UNIQUE (roomNo, year, month),
	constraint FK_priceroom foreign key (roomNo) references rooms(roomNo)
)


create table useraccounts
(
	username varchar(100) primary key,
	password varchar(50) not null default '1111',
	role varchar(30) 
)
create table [service]
(
	id_service int identity(1,1) primary key,
	nameservice nvarchar(200),
	priceservice decimal,
	roomNo char(5),
	[choose] bit,
	constraint FK_service foreign key (roomNo) references rooms(roomNo)
)
