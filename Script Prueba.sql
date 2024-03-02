create table paymentmethod(
	methodid nvarchar(70) primary key,
	paymentmethod nvarchar(50)
);

create table paymentdetail(
	paymentdetailid nvarchar(70),
	paymentdate date,
	paymentvalue numeric(18,2),
	payment_paymentid nvarchar(70),
	paymentmethod_methodid nvarchar(70),
	constraint paymentdetail_payment_FK foreign key(payment_paymentid) references payment(paymentid),
	constraint paymentdetail_paymentmethod_FK foreign key(paymentmethod_methodid) references paymentmethod(methodId)
);

create table payment(
	paymentid nvarchar(70) primary key,
	maxpaymentdate date,
	client_clientid nvarchar(70)
	constraint payment_client_FK foreign key(client_clientid) references client(clientid)
);

create table client(
	clientid nvarchar(70) primary key,
	users_userid nvarchar(70),
	identification nvarchar(13)
	constraint client_users_FK foreign key(users_userid) references users(userId)
);

create table operations(
	operationid nvarchar(70) primary key,
	operationdate date,
	operation_operationtypeid nvarchar(70),
	cash_cashid nvarchar(70),
	client_clientid nvarchar(70),
	constraint operations_operationtype_FK foreign key(operation_operationtypeid) references operationtype(operationtypeid),
	constraint operations_cash_FK foreign key(cash_cashid) references cash(cashid),
	constraint operations_client_FK foreign key(client_clientid) references client(clientid)
);

create table operationtype(
	operationtypeid nvarchar(70) primary key,
	operationtype nvarchar(50)
);

create table cash(
	cashid nvarchar(70) primary key,
	cashdescription nvarchar(50),
	users_userid nvarchar(70),
	constraint cash_users_FK foreign key(users_userid) references users(userId)
);

create table users(
	userId nvarchar(70) Primary key,
	email nvarchar(150),
	password nvarchar(80),
	person_personid nvarchar(70),
	constraint users_person_Fk Foreign key (person_personid) references person(personid)
);

create table contract(
	contractid nvarchar(70) primary key,
	contractdate date,
	client_clientid nvarchar(70),
	isvigent bit,
	services_serviceid nvarchar(70)
	constraint contract_client_FK foreign key(client_clientid) references client(clientid),
	constraint contract_services_FK foreign key(services_serviceid) references services(serviceid)
);

create table person(
	personid nvarchar(70) primary key,
	firstname nvarchar(50),
	lastname nvarchar(50),
	birthdate date,
	address nvarchar(150)
);

create table services(
	serviceid nvarchar(70) primary key,
	servicename nvarchar(120),
	mbps numeric(18,2)
	price numeric(18,2)
);






