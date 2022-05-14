-- Креирање базе података
CREATE DATABASE Kucni_budzet;
USE Kucni_budzet;

-- Креирање табела
CREATE TABLE Uloga(
  id INT PRIMARY KEY IDENTITY(1, 1),
  naziv NVARCHAR(50) NOT NULL
);

CREATE TABLE Osoba(
  email VARCHAR(70) PRIMARY KEY,
  lozinka VARCHAR(30) NOT NULL,
  ime NVARCHAR(20) NOT NULL,
  prezime NVARCHAR(50) NOT NULL,
  jmbg CHAR(13),
  FK_uloga_id INT FOREIGN KEY REFERENCES Uloga(id)
);

CREATE TABLE Novcanik(
  id INT PRIMARY KEY IDENTITY(1, 1),
  naziv NVARCHAR(50) NOT NULL,
  stanje DECIMAL(8, 2) NOT NULL,
  FK_osoba_email VARCHAR(70) FOREIGN KEY REFERENCES Osoba(email)
);

CREATE TABLE Trosak(
  id INT PRIMARY KEY IDENTITY(1, 1),
  naziv NVARCHAR(50)
);

CREATE TABLE Organizaciona_jedinica(
  id INT PRIMARY KEY IDENTITY(1, 1),
  naziv NVARCHAR(50)
);

CREATE TABLE Firma(
  id INT PRIMARY KEY IDENTITY(1, 1),
  naziv NVARCHAR(50)
);

CREATE TABLE Promet(
  id INT PRIMARY KEY IDENTITY(1, 1),
  datum DATETIME NOT NULL,
  FK_novcanik_id INT FOREIGN KEY REFERENCES Novcanik(id) ON DELETE CASCADE,
  FK_osoba_email VARCHAR(70) FOREIGN KEY REFERENCES Osoba(email) ON DELETE CASCADE,
  FK_trosak_id INT FOREIGN KEY REFERENCES Trosak(id) ON DELETE SET NULL,
  kolicina INT,
  FK_organizaciona_jedinica_id INT FOREIGN KEY REFERENCES Organizaciona_jedinica(id) ON DELETE SET NULL,
  FK_firma_id INT FOREIGN KEY REFERENCES Firma(id) ON DELETE SET NULL,
  ulaz DECIMAL(8, 2),
  izlaz DECIMAL(8, 2),
  opis NVARCHAR(500)
);

-- Унос података у табеле
INSERT INTO Uloga (naziv) VALUES (N'Администратор');
INSERT INTO Uloga (naziv) VALUES (N'Корисник');

INSERT INTO Osoba (email, lozinka, ime, prezime, jmbg, FK_uloga_id) VALUES ('aleksandarstefanovic@KB_A.rs', 'coamafija1312', N'Александар', N'Стефановић', '2210003710256', 1);
INSERT INTO Osoba (email, lozinka, ime, prezime, jmbg, FK_uloga_id) VALUES ('tanjamarkovic@KB_K.rs', 'tanja123', N'Тања', N'Марковић', '1712001289564', 2);
INSERT INTO Osoba (email, lozinka, ime, prezime, jmbg, FK_uloga_id) VALUES ('mirkolazic@KB_K.rs', 'miki97', N'Мирко', N'Лазић', NULL, 2);

INSERT INTO Novcanik (naziv, stanje, FK_osoba_email) VALUES (N'Џеп', 0, 'aleksandarstefanovic@KB_A.rs'); -- подразумевани новчаник
INSERT INTO Novcanik (naziv, stanje, FK_osoba_email) VALUES (N'Фиока', 0, 'aleksandarstefanovic@KB_A.rs');
INSERT INTO Novcanik (naziv, stanje, FK_osoba_email) VALUES (N'Џеп', 0, 'tanjamarkovic@KB_K.rs');
INSERT INTO Novcanik (naziv, stanje, FK_osoba_email) VALUES (N'Полица', 0, 'tanjamarkovic@KB_K.rs');
INSERT INTO Novcanik (naziv, stanje, FK_osoba_email) VALUES (N'Џеп', 0, 'mirkolazic@KB_K.rs');

INSERT INTO Trosak (naziv) VALUES (N'Струја');
INSERT INTO Trosak (naziv) VALUES (N'Вода');
INSERT INTO Trosak (naziv) VALUES (N'Сладолед');
INSERT INTO Trosak (naziv) VALUES (N'Патике');

INSERT INTO Organizaciona_jedinica (naziv) VALUES (N'Београд');
INSERT INTO Organizaciona_jedinica (naziv) VALUES (N'Златибор');
INSERT INTO Organizaciona_jedinica (naziv) VALUES (N'Копаоник');
INSERT INTO Organizaciona_jedinica (naziv) VALUES (N'Нови Сад');

INSERT INTO Firma (naziv) VALUES (N'Електропривреда Србије');
INSERT INTO Firma (naziv) VALUES (N'ВодаВода');
INSERT INTO Firma (naziv) VALUES (N'Фриком');
INSERT INTO Firma (naziv) VALUES (N'Адидас');
INSERT INTO Firma (naziv) VALUES (N'Најк');

INSERT INTO Promet (datum, FK_novcanik_id, FK_osoba_email, FK_trosak_id, kolicina, FK_organizaciona_jedinica_id, FK_firma_id, ulaz, izlaz, opis) VALUES
('2022-05-14 10:00', 1, 'aleksandarstefanovic@KB_A.rs', 3, 2, 1, 3, NULL, 110, N'Мачо чоколада');

-- Преглед података
SELECT * FROM Uloga;

-- Преглед за администратора
SELECT Osoba.email, Osoba.ime, Osoba.prezime, Uloga.naziv FROM Osoba
JOIN Uloga ON Osoba.FK_uloga_id = Uloga.id;

SELECT Novcanik.naziv, Novcanik.stanje, Osoba.ime, Osoba.prezime FROM Novcanik
JOIN Osoba ON Novcanik.FK_osoba_email = Osoba.email;

SELECT * FROM Trosak;

SELECT * FROM Organizaciona_jedinica;

SELECT * FROM Firma;

-- Главна форма
SELECT Promet.datum AS 'Датум', Osoba.email AS 'Имејл адреса', Osoba.ime + ' ' + Osoba.prezime AS 'Име и презиме особе', Novcanik.naziv AS 'Новчаник', Trosak.naziv AS 'Трошак', Promet.kolicina AS 'Количина', Organizaciona_jedinica.naziv AS 'Организациона јединица', Firma.naziv AS 'Фирма', Promet.ulaz AS 'Улаз', Promet.izlaz AS 'Излаз', Promet.opis AS 'Опис'
FROM Promet
JOIN Osoba ON Promet.FK_osoba_email = Osoba.email
JOIN Novcanik ON Promet.FK_novcanik_id = Novcanik.id
JOIN Trosak ON Promet.FK_trosak_id = Trosak.id
JOIN Organizaciona_jedinica ON Promet.FK_organizaciona_jedinica_id = Organizaciona_jedinica.id
JOIN Firma ON Promet.FK_firma_id = Firma.id;

-- Окидач
CREATE TRIGGER Promena_stanja_Insert
ON Promet
AFTER INSERT
AS
BEGIN
  DECLARE @staro_stanje DECIMAL(8, 2);
  SET @staro_stanje = (SELECT stanje FROM Novcanik WHERE Novcanik.id = (SELECT FK_novcanik_id FROM inserted));
  
  DECLARE @novac DECIMAL(8, 2);
  DECLARE @ulaz DECIMAL(8, 2);
  SET @ulaz = (SELECT ulaz FROM inserted);
  IF (@ulaz IS NULL) SET @novac = (-1)*(SELECT kolicina FROM inserted)*(SELECT izlaz FROM inserted)
  ELSE SET @novac = (SELECT kolicina FROM inserted)*(SELECT ulaz FROM inserted);
  
  DECLARE @novo_stanje DECIMAL(8, 2);
  SET @novo_stanje = @staro_stanje + @novac;  
  
  UPDATE Novcanik
  SET stanje = @novo_stanje
  WHERE Novcanik.id = (SELECT FK_novcanik_id FROM inserted);
END;