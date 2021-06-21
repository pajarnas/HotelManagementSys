Use HotelMS
Go
INSERT INTO RoomTypes([RtDesc],[Rent]) VALUES('Standard','280.00');

INSERT INTO RoomTypes([RtDesc],[Rent]) VALUES('Accessible','380.00');

INSERT INTO RoomTypes([RtDesc],[Rent]) VALUES('Joint','480.00');

INSERT INTO RoomTypes([RtDesc],[Rent]) VALUES('Apartment-style','480.00');

INSERT INTO RoomTypes([RtDesc],[Rent]) VALUES('Connecting','580.00');

INSERT INTO RoomTypes([RtDesc],[Rent]) VALUES('Deluxe','980.00');

INSERT INTO RoomTypes([RtDesc],[Rent]) VALUES('Super Deluxe','1180.00');



INSERT INTO Rooms([RtCode],[Status]) VALUES(6,'False'),(6,'False'),(1,'False'),(6,'True'),(5,'False'),(1,'True'),(1,'True'),(3,'False'),(1,'False'),(4,'False');

INSERT INTO Rooms([RtCode],[Status]) VALUES(2,'True'),(4,'False'),(1,'True'),(2,'True'),(5,'True'),(2,'False'),(1,'True'),(1,'True'),(1,'True'),(4,'True');

INSERT INTO Rooms([RtCode],[Status]) VALUES(1,'False'),(5,'True'),(4,'True'),(5,'True'),(1,'True'),(3,'False'),(1,'True'),(4,'True'),(6,'True'),(4,'True');

INSERT INTO Rooms([RtCode],[Status]) VALUES(5,'False'),(1,'False'),(1,'True'),(3,'True'),(2,'True'),(1,'False'),(6,'False'),(5,'False'),(5,'False'),(2,'True');

INSERT INTO Rooms([RtCode],[Status]) VALUES(3,'True'),(6,'True'),(1,'False'),(2,'False'),(4,'False'),(1,'True'),(2,'False'),(1,'True'),(2,'True'),(3,'False');

INSERT INTO Rooms([RtCode],[Status]) VALUES(1,'False'),(3,'False'),(4,'False'),(1,'False'),(4,'True'),(1,'False'),(1,'True'),(5,'False'),(2,'True'),(5,'True');

INSERT INTO Rooms([RtCode],[Status]) VALUES(1,'True'),(3,'False'),(6,'True'),(4,'False'),(3,'True'),(1,'False'),(3,'True'),(6,'True'),(2,'False'),(6,'False');

INSERT INTO Rooms([RtCode],[Status]) VALUES(2,'True'),(3,'False'),(2,'False'),(5,'True'),(5,'False'),(4,'False'),(4,'True'),(4,'False'),(3,'False'),(5,'True');

INSERT INTO Rooms([RtCode],[Status]) VALUES(4,'False'),(1,'False'),(3,'True'),(2,'False'),(6,'False'),(3,'True'),(1,'False'),(5,'False'),(3,'True'),(4,'False');

INSERT INTO Rooms([RtCode],[Status]) VALUES(2,'True'),(5,'True'),(1,'False'),(5,'False'),(1,'True'),(4,'True'),(3,'False'),(4,'True'),(2,'True'),(4,'False');



INSERT INTO ServiceTypes([SDesc],[Amount]) VALUES('Massages',88);

INSERT INTO ServiceTypes([SDesc],[Amount]) VALUES('Concierge services',58);

INSERT INTO ServiceTypes([SDesc],[Amount]) VALUES('Ironing service',88);

INSERT INTO ServiceTypes([SDesc],[Amount]) VALUES('Room service (24-hour)',118);

INSERT INTO ServiceTypes([SDesc],[Amount]) VALUES('Ironing service',148);

INSERT INTO ServiceTypes([SDesc],[Amount]) VALUES('limousine services',878);


INSERT INTO ServiceTypes([SDesc],[Amount]) VALUES('Laundry and valet service',18);

INSERT INTO ServiceTypes([SDesc],[Amount]) VALUES('Catering services',298);

INSERT INTO ServiceTypes([SDesc],[Amount]) VALUES('Transfer and chauffeur driven',128);

INSERT INTO ServiceTypes([SDesc],[Amount]) VALUES('Shoeshine service',158);

INSERT INTO ServiceTypes([SDesc],[Amount]) VALUES('Transfer and chauffeur driven',118);
INSERT INTO ServiceTypes([SDesc],[Amount]) VALUES('Mail services',18);

INSERT INTO ServiceTypes([SDesc],[Amount]) VALUES('Turndown service',28);
INSERT INTO ServiceTypes([SDesc],[Amount]) VALUES('Ticket service',28);
INSERT INTO ServiceTypes([SDesc],[Amount]) VALUES('Dry cleaning Excursions and guided tours',28);

INSERT INTO ServiceTypes([SDesc],[Amount]) VALUES('Doctor on call ',428);

INSERT INTO ServiceTypes([SDesc],[Amount]) VALUES('Room service (24-hour)',58);







INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-27-2020',1,22);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-24-2020',2,26);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-13-2020',6,30);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-21-2020',8,34);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-30-2020',15,38);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-10-2020',11,42);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-07-2020',3,46);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-03-2020',11,50);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-13-2020',5,54);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-11-2020',13,58);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-16-2020',3,62);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-10-2020',14,66);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-08-2020',11,70);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-18-2020',6,74);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-14-2020',9,78);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-02-2020',13,82);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-20-2020',3,86);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-01-2020',3,90);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-16-2020',4,94);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-22-2020',13,98);

INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-06-2020',3,22);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-20-2020',17,26);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-29-2020',15,30);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-04-2020',6,34);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-16-2020',13,38);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-03-2020',2,42);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-26-2020',13,46);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-18-2020',12,50);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-10-2020',4,54);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-18-2020',11,58);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-06-2020',3,62);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-28-2020',13,66);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-25-2020',11,70);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-29-2020',2,74);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-31-2020',8,78);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-10-2020',11,82);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-15-2020',16,86);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-26-2020',7,90);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-20-2020',1,94);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-31-2020',10,98);

INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-26-2020',13,22);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-29-2020',9,24);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-18-2020',9,26);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-19-2020',14,28);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-09-2020',2,30);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-12-2020',13,32);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-17-2020',7,34);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-29-2020',10,36);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-09-2020',5,38);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-21-2020',15,40);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-21-2020',5,42);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-20-2020',14,44);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-09-2020',1,46);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-09-2020',7,48);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-26-2020',9,50);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-12-2020',14,52);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-30-2020',6,54);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-10-2020',13,56);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-22-2020',15,58);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-01-2020',12,60);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-19-2020',3,62);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-27-2020',7,64);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-01-2020',1,66);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-18-2020',2,68);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-02-2020',1,70);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-23-2020',10,72);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-16-2020',11,74);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-25-2020',3,76);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-07-2020',6,78);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-11-2020',17,80);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-18-2020',1,82);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-07-2020',11,84);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-05-2020',5,86);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('04-23-2020',10,88);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-05-2020',7,90);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-07-2020',1,92);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-11-2020',16,94);
INSERT INTO Services([ServiceDate],[ServiceTypeId],[RoomId]) VALUES('05-01-2020',9,96);





INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(22,'Oberursel','Larson, Lillian Q.','1-739-659-9442','sed@Quisqueimperdieterat.org','04-11-2020',3,666,1);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(26,'Faisalabad','Noel, Gary H.','1-152-162-2185','vitae@non.org','05-13-2020',4,418,1);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(30,'Prenzlau','Abbott, Carly I.','1-567-704-6417','augue.eu@libero.net','05-04-2020',3,310,2);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(34,'Hines Creek','Hicks, Sophia V.','1-112-608-4376','sem.molestie.sodales@SuspendissesagittisNullam.com','04-02-2020',5,550,1);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(38,'Lustenau','Butler, Drake U.','1-328-494-4527','Proin.vel.nisl@quisdiam.co.uk','04-16-2020',2,671,1);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(42,'Colloredo di Monte Albano','Berg, Caldwell A.','1-580-342-7646','aliquet@dapibusgravida.ca','04-18-2020',3,701,2);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(46,'Langford','Cantrell, Chava J.','1-402-730-1068','Ut.nec@at.co.uk','05-12-2020',1,935,2);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(50,'Helena','Horn, Ifeoma A.','1-680-647-0803','habitant.morbi@ametlorem.net','05-25-2020',3,310,3);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(54,'Alcobendas','Rogers, Raymond B.','1-865-830-4320','Ut@aliquam.edu','05-31-2020',2,322,3);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(58,'Saint-Hilarion','Atkins, Grady F.','1-883-713-5195','Maecenas.ornare.egestas@egestaslacinia.net','05-21-2020',5,542,3);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(62,'Donstiennes','Sampson, Bertha K.','1-306-761-4163','taciti@Cras.org','05-01-2020',2,833,2);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(66,'San Chirico Nuovo','Ellis, Jamal Y.','1-815-626-2779','tincidunt.nunc.ac@Phasellusdolor.net','04-20-2020',1,639,2);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(70,'Chakwal','Kemp, Jillian A.','1-799-205-0429','montes.nascetur@felis.co.uk','04-12-2020',1,983,3);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(74,'Vieux-Genappe','Cline, Katell B.','1-402-429-0112','magnis.dis.parturient@antedictummi.org','04-10-2020',1,317,3);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(78,'Lunel','Puckett, Ezra D.','1-496-969-8061','nec.quam.Curabitur@nisiCumsociis.ca','04-25-2020',3,523,1);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(82,'Bal‰tre','Greer, Travis A.','1-145-303-9000','penatibus.et.magnis@diameu.org','05-02-2020',2,902,1);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(86,'Bahawalnagar','Tanner, Graham R.','1-148-834-4347','Phasellus@eunulla.edu','05-21-2020',4,473,3);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(90,'Jodhpur','Lane, Bevis G.','1-161-791-0383','ac.feugiat.non@Sed.net','05-30-2020',5,526,2);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(94,'Oxford County','Lynn, Inga C.','1-759-210-0209','parturient.montes@Sed.edu','04-09-2020',4,696,2);
INSERT INTO Customers([RoomNo],[Address],[CName],[Phone],[Email],[Checkin],[TotalPersons],[Advance],[BookingDays]) VALUES(98,'Crawley','Harris, Brianna M.','1-637-563-0957','ipsum.primis@Aliquamerat.co.uk','05-28-2020',3,971,3);

UPDATE [Customers] SET [RoomNo] = 22, [Address] = 'Denver', [CName] = 'Stuart, Neve Y.', [Phone] = '1-935-148-6543', [Email] = 'urna.et.arcu@dolorNullasemper.org', [Checkin] = '04-06-2020', [TotalPersons] = 4, [Advance] = 951, [BookingDays] = 2 WHERE [Id] = 1;
UPDATE [Customers] SET [RoomNo] = 26, [Address] = 'Grantham', [CName] = 'Estes, Kylan Y.', [Phone] = '1-110-356-6731', [Email] = 'non.leo@laoreetposuere.org', [Checkin] = '05-24-2020', [TotalPersons] = 3, [Advance] = 986, [BookingDays] = 1 WHERE [Id] = 2;
UPDATE [Customers] SET [RoomNo] = 30, [Address] = 'Yumbel', [CName] = 'Wade, Echo B.', [Phone] = '1-303-163-4282', [Email] = 'Cum.sociis.natoque@quamPellentesque.com', [Checkin] = '04-14-2020', [TotalPersons] = 1, [Advance] = 834, [BookingDays] = 3 WHERE [Id] = 3;
UPDATE [Customers] SET [RoomNo] = 34, [Address] = 'Gellik', [CName] = 'Lopez, Hunter R.', [Phone] = '1-427-328-2820', [Email] = 'vitae@risusDonec.com', [Checkin] = '05-27-2020', [TotalPersons] = 4, [Advance] = 657, [BookingDays] = 3 WHERE [Id] = 4;
UPDATE [Customers] SET [RoomNo] = 38, [Address] = 'Hampstead', [CName] = 'Washington, Donovan S.', [Phone] = '1-979-862-6839', [Email] = 'lorem.tristique.aliquet@quis.edu', [Checkin] = '05-26-2020', [TotalPersons] = 5, [Advance] = 740, [BookingDays] = 2 WHERE [Id] = 5;
UPDATE [Customers] SET [RoomNo] = 42, [Address] = 'Rotello', [CName] = 'Bailey, Shannon H.', [Phone] = '1-473-985-7582', [Email] = 'eu.tellus@cursusvestibulum.com', [Checkin] = '04-14-2020', [TotalPersons] = 4, [Advance] = 874, [BookingDays] = 1 WHERE [Id] = 6;
UPDATE [Customers] SET [RoomNo] = 46, [Address] = 'Poulseur', [CName] = 'Battle, Sigourney I.', [Phone] = '1-646-905-2724', [Email] = 'consequat.auctor@adipiscingelit.co.uk', [Checkin] = '05-14-2020', [TotalPersons] = 2, [Advance] = 986, [BookingDays] = 1 WHERE [Id] = 7;
UPDATE [Customers] SET [RoomNo] = 50, [Address] = 'Ancud', [CName] = 'Allen, Illiana H.', [Phone] = '1-299-491-2933', [Email] = 'tincidunt@Integer.ca', [Checkin] = '05-21-2020', [TotalPersons] = 4, [Advance] = 711, [BookingDays] = 3 WHERE [Id] = 8;
UPDATE [Customers] SET [RoomNo] = 54, [Address] = 'Maidstone', [CName] = 'Norton, Sylvester W.', [Phone] = '1-255-992-2148', [Email] = 'euismod@Nullam.ca', [Checkin] = '04-19-2020', [TotalPersons] = 1, [Advance] = 701, [BookingDays] = 3 WHERE [Id] = 9;
UPDATE [Customers] SET [RoomNo] = 58, [Address] = 'Cisano Bergamasco', [CName] = 'Kane, Forrest C.', [Phone] = '1-474-326-4034', [Email] = 'dui@consequatdolor.edu', [Checkin] = '04-04-2020', [TotalPersons] = 4, [Advance] = 540, [BookingDays] = 2 WHERE [Id] = 10;
UPDATE [Customers] SET [RoomNo] = 62, [Address] = 'Dewas', [CName] = 'Waters, Ian H.', [Phone] = '1-676-408-5583', [Email] = 'amet.faucibus@aliquetProinvelit.org', [Checkin] = '04-30-2020', [TotalPersons] = 4, [Advance] = 862, [BookingDays] = 1 WHERE [Id] = 11;
UPDATE [Customers] SET [RoomNo] = 66, [Address] = 'Wrigley', [CName] = 'Huffman, Tiger G.', [Phone] = '1-856-180-8778', [Email] = 'diam.vel.arcu@non.edu', [Checkin] = '05-17-2020', [TotalPersons] = 5, [Advance] = 627, [BookingDays] = 3 WHERE [Id] = 12;
UPDATE [Customers] SET [RoomNo] = 70, [Address] = 'Vespolate', [CName] = 'Duran, Xavier S.', [Phone] = '1-381-639-9776', [Email] = 'lectus.a.sollicitudin@interdumSed.edu', [Checkin] = '05-27-2020', [TotalPersons] = 1, [Advance] = 381, [BookingDays] = 1 WHERE [Id] = 13;
UPDATE [Customers] SET [RoomNo] = 74, [Address] = 'Kapfenberg', [CName] = 'Merrill, Jayme C.', [Phone] = '1-660-327-0634', [Email] = 'fringilla.est@odio.edu', [Checkin] = '04-16-2020', [TotalPersons] = 5, [Advance] = 834, [BookingDays] = 2 WHERE [Id] = 14;
UPDATE [Customers] SET [RoomNo] = 78, [Address] = 'San Diego', [CName] = 'Small, Amethyst G.', [Phone] = '1-876-946-6488', [Email] = 'Proin.sed@Duis.ca', [Checkin] = '05-02-2020', [TotalPersons] = 3, [Advance] = 888, [BookingDays] = 1 WHERE [Id] = 15;
UPDATE [Customers] SET [RoomNo] = 82, [Address] = 'Castel San Niccolò', [CName] = 'Rosario, Odette Q.', [Phone] = '1-731-811-3527', [Email] = 'et.magnis@etcommodo.com', [Checkin] = '05-21-2020', [TotalPersons] = 1, [Advance] = 301, [BookingDays] = 1 WHERE [Id] = 16;
UPDATE [Customers] SET [RoomNo] = 86, [Address] = 'Muzaffargarh', [CName] = 'Medina, Mollie N.', [Phone] = '1-700-644-6252', [Email] = 'mattis.velit@mollisnoncursus.net', [Checkin] = '05-25-2020', [TotalPersons] = 4, [Advance] = 787, [BookingDays] = 2 WHERE [Id] = 17;
UPDATE [Customers] SET [RoomNo] = 90, [Address] = 'Ivanovo', [CName] = 'Barron, Brianna J.', [Phone] = '1-638-253-2767', [Email] = 'neque.vitae.semper@pharetra.edu', [Checkin] = '04-07-2020', [TotalPersons] = 2, [Advance] = 711, [BookingDays] = 3 WHERE [Id] = 18;
UPDATE [Customers] SET [RoomNo] = 94, [Address] = 'Auburn', [CName] = 'Stevens, Blake Q.', [Phone] = '1-752-188-7792', [Email] = 'orci.quis@semPellentesque.com', [Checkin] = '04-13-2020', [TotalPersons] = 4, [Advance] = 573, [BookingDays] = 2 WHERE [Id] = 19;
UPDATE [Customers] SET [RoomNo] = 98, [Address] = 'Haverhill', [CName] = 'Reyes, Armand G.', [Phone] = '1-254-549-2910', [Email] = 'nulla@erat.com', [Checkin] = '04-26-2020', [TotalPersons] = 4, [Advance] = 364, [BookingDays] = 2 WHERE [Id] = 20;