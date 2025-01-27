use Organs
go

insert into Donor_info (Donor_id, First_name, Last_name, Birth_date, Blood_type, City, "Address") values 
(1, 'Jan', 'Kowalski', '1985-03-12', 'A+', 'Warszawa', 'Ul. Marszałkowska 45'),
(2, 'Anna', 'Nowak', '1990-07-08', 'B+', 'Kraków', 'Ul. Grodzka 12'),
(3, 'Piotr', 'Wiśniewski', '1978-11-20', 'AB-', 'Gdańsk', 'Ul. Długa 25'),
(4, 'Katarzyna', 'Wójcik', '1989-06-15', 'O+', 'Wrocław', 'Ul. Świdnicka 7'),
(5, 'Michał', 'Kamiński', '1983-01-22', 'A-', 'Poznań', 'Ul. Półwiejska 19'),
(6, 'Agnieszka', 'Lewandowska', '1995-12-30', 'B-', 'Łódź', 'Ul. Piotrkowska 38'),
(7, 'Tomasz', 'Zieliński', '1987-09-10', 'O-', 'Lublin', 'Ul. Krakowskie Przedmieście 55'),
(8, 'Magdalena', 'Szymańska', '1992-02-17', 'AB+', 'Katowice', 'Ul. Mariacka 60'),
(9, 'Marcin', 'Dąbrowski', '1976-08-14', 'A+', 'Bydgoszcz', 'Ul. Gdańska 30'),
(10, 'Ewa', 'Pawlak', '1984-04-18', 'B+', 'Szczecin', 'Ul. Wojska Polskiego 75'),
(11, 'Rafał', 'Kozłowski', '1993-03-09', 'O+', 'Rzeszów', 'Ul. 3 Maja 14'),
(12, 'Joanna', 'Krawczyk', '1981-05-01', 'AB-', 'Opole', 'Ul. Krakowska 20'),
(13, 'Andrzej', 'Mazur', '1996-10-23', 'A-', 'Kielce', 'Ul. Sienkiewicza 41'),
(14, 'Beata', 'Kaczmarek', '1991-11-30', 'B-', 'Białystok', 'Ul. Lipowa 50'),
(15, 'Grzegorz', 'Zawadzki', '1980-01-05', 'O-', 'Gdynia', 'Ul. Świętojańska 100'),
(16, 'Paulina', 'Wróbel', '1988-07-28', 'AB+', 'Częstochowa', 'Ul. Maryi Panny 11'),
(17, 'Paweł', 'Król', '1975-12-18', 'A+', 'Toruń', 'Ul. Mostowa 3'),
(18, 'Karolina', 'Czarnecka', '1994-09-02', 'B+', 'Gliwice', 'Ul. Zwycięstwa 44'),
(19, 'Łukasz', 'Jankowski', '1986-02-12', 'O+', 'Radom', 'Ul. Żeromskiego 29'),
(20, 'Natalia', 'Piotrowska', '1990-06-03', 'AB-', 'Sopot', 'Ul. Monte Cassino 15');
go

insert into Bank_info (Place_id, City, "Address", Contact_info) values
(1, 'Warszawa', 'Ul. Marszałkowska 45', '+48 22 123 4567'),
(2, 'Kraków', 'Ul. Grodzka 12', '+48 12 345 6789'),
(3, 'Gdańsk', 'Ul. Długa 25', '+48 58 987 6543'),
(4, 'Wrocław', 'Ul. Świdnicka 7', '+48 71 246 1357'),
(5, 'Poznań', 'Ul. Półwiejska 19', '+48 61 543 2190');
go

insert into Organ_donation (Organ_id, Donor_id, Organ, Extraction_date, Place_id, "Status") values
(1, 1, 'Serce', '2023-02-15',1, 'Wykorzystane'),
(2, 2, 'Płuco', '2023-11-01', 2, 'Dostępne'),
(3, 3, 'Wątroba', NULL, NULL, 'Oczekiwane'),
(4, 4, 'Nerka', '2023-01-10', 3, 'Wykorzystane'),
(5, 5, 'Trzustka', '2024-11-29', 4, 'Wykorzystane'),
(6, 6, 'Rogówka', '2023-10-30', 5, 'Dostępne'),
(7, 7, 'Jelito', NULL, NULL, 'Oczekiwane'),
(8, 8, 'Skóra', '2024-02-11', 3, 'W drodze'),
(9, 9, 'Kość', '2023-03-01', 5, 'Wykorzystane'),
(10, 10, 'Serce', NULL, NULL, 'Oczekiwane'),
(11, 11, 'Płuco', NULL, NULL, 'Oczekiwane'),
(12, 12, 'Wątroba', '2023-06-05', 4, 'Dostępne'),
(13, 13, 'Nerka', '2023-05-20', 1, 'W drodze'),
(14, 14, 'Trzustka', NULL, NULL, 'Oczekiwane'),
(15, 15, 'Rogówka', '2023-08-20', 1, 'Dostępne'),
(16, 16, 'Jelito', '2023-10-10', 1, 'Dostępne'),
(17, 17, 'Skóra', NULL, NULL, 'Oczekiwane'),
(18, 18, 'Kość', '2024-01-01', 3, 'Dostępne'),
(19, 19, 'Serce', '2023-11-21', 4, 'Dostępne'),
(20, 20, 'Płuco', '2023-02-17', 2, 'Wykorzystane'),
(21, 1, 'Wątroba', '2023-09-30', 2, 'Dostępne'),
(22, 2, 'Nerka', NULL, NULL, 'Oczekiwane'),
(23, 3, 'Trzustka', '2024-03-10', 1, 'W drodze'),
(24, 4, 'Rogówka', '2023-05-15', 5, 'Dostępne'),
(25, 5, 'Jelito', '2024-01-28', 5, 'Dostępne'),
(26, 6, 'Skóra', NULL, NULL, 'Oczekiwane'),
(27, 7, 'Kość', '2024-02-05', 1, 'Dostępne'),
(28, 8, 'Serce', '2023-07-23', 3, 'W drodze'),
(29, 9, 'Płuco', NULL, NULL, 'Oczekiwane'),
(30, 10, 'Wątroba', '2023-10-01', 4, 'Dostępne');
go

insert into Blood_amount (Place_id, A_plus, A_minus, B_plus, B_minus, AB_plus, AB_minus, O_plus, O_minus) values
(1, 120, 50, 100, 40, 30, 10, 200, 70),
(2, 150, 60, 80, 35, 40, 15, 220, 90),
(3, 110, 45, 90, 50, 25, 12, 180, 60),
(4, 140, 55, 85, 30, 35, 8, 190, 80),
(5, 130, 65, 75, 45, 20, 14, 210, 75);
go

insert into Blood_donor_info (Bdonor_id, First_name, Last_name, Birth_date, Blood_type, Donation_count, City, "Address") values
(1, 'Jan', 'Kowalski', '1985-03-12', 'A+', 5, 'Warszawa', 'Ul. Marszałkowska 45'),
(2, 'Anna', 'Nowak', '1990-07-08', 'B+', 8, 'Kraków', 'Ul. Grodzka 12'),
(3, 'Piotr', 'Wiśniewski', '1978-11-20', 'AB-', 3, 'Gdańsk', 'Ul. Długa 25'),
(4, 'Katarzyna', 'Wójcik', '1989-06-15', 'O+', 6, 'Wrocław', 'Ul. Świdnicka 7'),
(5, 'Marek', 'Górski', '1987-05-12', 'A-', 7, 'Poznań', 'Ul. Wroniecka 32'),
(6, 'Ewa', 'Zawadzka', '1995-02-20', 'B-', 4, 'Łódź', 'Ul. Piotrkowska 120'),
(7, 'Paweł', 'Wiatr', '1980-08-08', 'O+', 10, 'Lublin', 'Ul. Zamkowa 10'),
(8, 'Magdalena', 'Sawicka', '1983-11-17', 'AB+', 2, 'Katowice', 'Ul. Mikołowska 76'),
(9, 'Grzegorz', 'Nowicki', '1991-09-19', 'A+', 5, 'Bydgoszcz', 'Ul. Dworcowa 18'),
(10, 'Natalia', 'Szymczak', '1990-03-05', 'B+', 6, 'Szczecin', 'Ul. Jagiellońska 50'),
(11, 'Rafał', 'Sobczak', '1992-07-28', 'O-', 8, 'Rzeszów', 'Ul. Grunwaldzka 14'),
(12, 'Karolina', 'Chmiel', '1984-12-15', 'AB-', 3, 'Opole', 'Ul. Katedralna 2'),
(13, 'Tomasz', 'Lis', '1993-01-30', 'A-', 9, 'Kielce', 'Ul. Paderewskiego 22'),
(14, 'Agata', 'Mak', '1986-06-14', 'B-', 1, 'Białystok', 'Ul. Sienkiewicza 40'),
(15, 'Michał', 'Urban', '1988-04-10', 'O+', 7, 'Gdynia', 'Ul. Morska 5'),
(16, 'Joanna', 'Olszewska', '1994-11-18', 'AB+', 2, 'Częstochowa', 'Ul. Sobieskiego 8'),
(17, 'Wojciech', 'Lewicki', '1979-03-09', 'A+', 12, 'Toruń', 'Ul. Fosa Staromiejska 11'),
(18, 'Beata', 'Polańska', '1985-02-01', 'B+', 4, 'Gliwice', 'Ul. Zwycięstwa 33'),
(19, 'Andrzej', 'Czajka', '1982-07-23', 'O-', 10, 'Radom', 'Ul. Traugutta 6'),
(20, 'Sylwia', 'Rutkowska', '1997-09-12', 'AB-', 1, 'Sopot', 'Ul. Monte Cassino 10');
go

insert into Blood_donation (Bdonor_id, Donation_date, Amount, Place_id) values
(1, '2023-05-10', 450, 1),
(1, '2023-08-15', 450, 1),
(2, '2023-04-20', 350, 2),
(2, '2023-09-05', 400, 2),
(3, '2023-01-18', 500, 3),
(3, '2023-07-12', 450, 3),
(4, '2023-03-14', 300, 4),
(4, '2023-10-18', 400, 4),
(5, '2023-06-11', 450, 1),
(5, '2023-11-20', 450, 1),
(6, '2023-05-08', 350, 2),
(6, '2023-10-25', 400, 2),
(7, '2023-02-14', 500, 3),
(7, '2023-09-01', 450, 3),
(8, '2023-07-10', 300, 4),
(8, '2023-12-05', 400, 4),
(9, '2023-01-20', 450, 5),
(9, '2023-08-30', 450, 5),
(10, '2023-03-18', 350, 1),
(10, '2023-09-10', 400, 1),
(11, '2023-04-22', 500, 2),
(11, '2023-11-18', 450, 2),
(12, '2023-01-15', 300, 3),
(12, '2023-06-05', 400, 3),
(13, '2023-02-28', 450, 4),
(13, '2023-10-12', 450, 4),
(14, '2023-05-19', 350, 5),
(14, '2023-12-01', 400, 5),
(15, '2023-03-21', 500, 1),
(15, '2023-08-23', 450, 1);
go

insert into Hospital_info (Hospital_id, City, "Address", Contact_info) values
(1, 'Warszawa', 'Ul. Banacha 1a', '+48 22 599 1000'),
(2, 'Kraków', 'Ul. Kopernika 36', '+48 12 424 7000'),
(3, 'Gdańsk', 'Ul. Kliniczna 1', '+48 58 349 3000'),
(4, 'Wrocław', 'Ul. Borowska 213', '+48 71 733 2000'),
(5, 'Poznań', 'Ul. Przybyszewskiego 49', '+48 61 869 1000');
go

insert into Receiver_info (Receiver_id, First_name, Last_name, Birth_date, Blood_type, Organ_id, City, "Address", Hospital_id, Registration_date, Operation_date, Organ_status, "Priority") values
(1, 'Jan', 'Rutkowski', '1975-03-15', 'A+', 1, 'Warszawa', 'Ul. Nowa 10', 1, '2023-01-15', '2023-03-01', 'Przyjęte', 'Wysoki'),
(2, 'Anna', 'Czajka', '1988-07-20', 'B+', 5, 'Kraków', 'Ul. Wiślana 5', 2, '2023-02-10', '2023-05-15', 'Przyjęte', 'Średni'),
(3, 'Piotr', 'Górski', '1990-11-25', 'AB-', 3, 'Gdańsk', 'Ul. Morska 22', 3, '2023-03-05', NULL, 'Oczekiwane', 'Niski'),
(4, 'Maria', 'Sobczak', '1982-06-18', 'O+', 4, 'Wrocław', 'Ul. Zielona 8', 4, '2023-04-12', '2023-07-10', 'Przyjęte', 'Wysoki'),
(5, 'Katarzyna', 'Wójcik', '1995-01-30', 'A-', 17, 'Poznań', 'Ul. Leśna 6', 5, '2023-05-20', NULL, 'Oczekiwane', 'Średni'),
(6, 'Tomasz', 'Kowal', '1985-02-15', 'O-', 20, 'Warszawa', 'Ul. Polna 14', 1, '2023-06-25', '2023-09-01', 'Przyjęte', 'Wysoki'),
(7, 'Agnieszka', 'Zielińska', '1993-10-09', 'AB+', 13, 'Kraków', 'Ul. Długa 19', 2, '2023-07-05', NULL, 'Oczekiwane', 'Niski'),
(8, 'Marek', 'Wiśniewski', '1978-04-18', 'B-', 9, 'Gdańsk', 'Ul. Słoneczna 15', 3, '2023-08-10', '2023-10-20', 'Przyjęte', 'Średni'),
(9, 'Beata', 'Kowalska', '1989-12-05', 'A+', 11, 'Wrocław', 'Ul. Krótka 3', 4, '2023-09-01', '2023-11-15', 'Oczekiwane', 'Wysoki'),
(10, 'Rafał', 'Nowak', '1992-05-12', 'B+', 10, 'Poznań', 'Ul. Dworcowa 9', 5, '2023-10-20', NULL, 'Oczekiwane', 'Średni');
go