Create Sequence ActID ;
Drop table FilmCategory    cascade constraints;
Drop table FilmTitles    cascade constraints;
Drop table Actors    cascade constraints;
Drop table FilmActors    cascade constraints;
Drop table FilmCopies    cascade constraints;
Drop table Members    cascade constraints;
Drop table Rentals    cascade constraints;

Create table FilmCategory
(CategoryID number(3) primary key, CategoryName varchar2 (20));

Create Table FilmTitles
(FilmID number(10)  primary key, FilmTitle varchar2(50), ReleaseDate date, FilmDuration number (3), FilmCategoryID number(3) references FilmCategory (CategoryID) ON Delete cascade);

Create Table Actors
(ActorID number(10) primary key, ActorName varchar2(20) not null, gender varchar2 (1));

Create Table FilmActors
(FilmID number(10) References FilmTitles (FilmID) , ActorID number(10) References Actors (ActorID),      CONSTRAINT Flm_Act_PK  PRIMARY KEY(FilmID, ActorID));

Create Table FilmCopies
(CopyID number (5) primary key, FilmID number(10) References FilmTitles (FilmID), CurrentlyRented char(1));

Create Table Members 
(MemberID number (10) primary key, MemName varchar2(20) not null, JoinDate date, DOB date, Phone number(12));

Create Table Rentals
(RentID number(10) primary key, MemberID number (10) references Members (MemberID), CopyID number (5), DateRented date, DateDueBack date, RentalCost number (5), OverDueCost number(5), ReturnedDate Date);

insert into FilmCategory values
(1, 'Adventure');
insert into FilmCategory values
(2, 'Comedy');
insert into FilmCategory values
(3, 'Action');
insert into FilmCategory values
(4, 'Animation');
insert into FilmCategory values
(5, 'Fantasy');
insert into FilmCategory values
(6, 'Sci-Fi');

Insert into Actors values
(1,'Kristen Stewart','F');
Insert into Actors values
(2,'Robert Pattinson','M');
Insert into Actors values
(3,'Taylor Lautner','M');
Insert into Actors values
(4,'Rupert Grint','M');
Insert into Actors values
(5,'Daniel Radcliffe','M');
Insert into Actors values
(6,'Ralph Fiennes','M');

Insert into Actors values
(7,'Hank Azaria','M');
Insert into Actors values
(8,'Neil Patrick Harris','M');
Insert into Actors values
(9,'Jayma Mays','F');
Insert into Actors values
(10,'Sofia Vergara','F');
Insert into Actors values
(11,'John Cleese','M');
Insert into Actors values
(12,'Jim Cummings','M');
Insert into Actors values
(13,'Bud Luckey','M');
Insert into Actors values
(14,'Tom Hanks','M');
Insert into Actors values
(15,'Tim Allen','M');
Insert into Actors values
(16,'Joan Cusack','F');
Insert into Actors values
(17,'Mike Myers','M');
Insert into Actors values
(18,'Eddie Murphy','M');

Insert into Actors values
(19,'Cameron Diaz','F');
Insert into Actors values
(20,'Kevin James','M');
Insert into Actors values
(21,'Salma Hayek','F');
Insert into Actors values
(22,'Henry Winkler','M');
Insert into Actors values
(23,'Matthew McConaughey','M');
Insert into Actors values
(24,'Anne Hathaway','F');
Insert into Actors values
(25,'Jessica Chastain','F');
Insert into Actors values
(26,'Sandra Bullock','F');
Insert into Actors values
(27,'George Clooney','M');
Insert into Actors values
(28,'Will Smith','M');
Insert into Actors values
(29,'Tommy Lee Jones','M');



insert into FilmTitles values
(1,'The Twilight Saga Breaking Dawn','16-Nov-2012', 116,1);
insert into FilmTitles values
(2,'Harry Potter and the Deathly Hallows','15-Jul-2011',130,5);
insert into FilmTitles values
(3,'The Smurfs','29-Jul-2011',103,4);
insert into FilmTitles values
(4,'Winnie the Pooh','15-Jul-2011',63,4);
insert into FilmTitles values
(5,'The Twilight Saga: Eclipse','30-Jun-2010',124,1);
insert into FilmTitles values
(6,'Toy Story 3','18-Jun-2010',103,4);
insert into FilmTitles values
(7,'Shrek Forever After','21-May-2010',93,4);
insert into FilmTitles values
(8,'Here Comes the Boom','12-Oct-2012',105,2);
insert into FilmTitles values
(9,'Interstellar','7-Nov-2014',169,6);
insert into FilmTitles values
(10,'Gravity','4-Oct-2013',90,6);
insert into FilmTitles values
(11,'Miss Congeniality','22-Dec-2002',109,2);
insert into FilmTitles values
(12,'Men in Black 3','25-May-2012',107,3);

insert into FilmActors values
(1, 1);
insert into FilmActors values
(1, 2);
insert into FilmActors values
(1, 3);
insert into FilmActors values
(2, 4); 
insert into FilmActors values
(2, 5);
insert into FilmActors values
(2, 6);
insert into FilmActors values
(3, 7);
insert into FilmActors values
(3, 8);
insert into FilmActors values
(3, 9);
insert into FilmActors values
(3, 10);
insert into FilmActors values
(4,11);
insert into FilmActors values
(4,12);
insert into FilmActors values
(4,13);
insert into FilmActors values
(5,1);
insert into FilmActors values
(5,2);
insert into FilmActors values
(5,3);
insert into FilmActors values
(6,14);
insert into FilmActors values
(6,15);
insert into FilmActors values
(6,16);
insert into FilmActors values
(7,17);
insert into FilmActors values
(7,18);
insert into FilmActors values
(7,19);
insert into FilmActors values
(8,20);
insert into FilmActors values
(8,21);
insert into FilmActors values
(8,22);
insert into FilmActors values
(9,23);
insert into FilmActors values
(9,24);
insert into FilmActors values
(9,25);
insert into FilmActors values
(10,26);
insert into FilmActors values
(10,27);
insert into FilmActors values
(11,26);
insert into FilmActors values
(12,27);
insert into FilmActors values
(12,28);
Commit;
