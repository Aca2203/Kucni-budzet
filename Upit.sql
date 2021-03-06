-- Креирање базе података
CREATE DATABASE Kucni_budzet;
USE Kucni_budzet;
DROP DATABASE Kucni_budzet;

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

go
CREATE TABLE Novcanik(
  id INT PRIMARY KEY IDENTITY(1, 1),
  naziv NVARCHAR(50) NOT NULL,
  stanje DECIMAL(8, 2) NOT NULL,
  FK_osoba_email VARCHAR(70) FOREIGN KEY REFERENCES Osoba(email) -- Процедура за брисање новчаника када се обришу особе
);
go

go
CREATE TABLE Trosak(
  id INT PRIMARY KEY IDENTITY(1, 1),
  naziv NVARCHAR(50)
);
go

go
CREATE TABLE Organizaciona_jedinica(
  id INT PRIMARY KEY IDENTITY(1, 1),
  naziv NVARCHAR(50)
);
go

go
CREATE TABLE Firma(
  id INT PRIMARY KEY IDENTITY(1, 1),
  naziv NVARCHAR(50)
);
go

go
CREATE TABLE Promet(
  id INT PRIMARY KEY IDENTITY(1, 1),
  datum DATE NOT NULL,
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
go

-- Унос података у табеле
INSERT INTO Uloga (naziv) VALUES (N'Администратор');
INSERT INTO Uloga (naziv) VALUES (N'Корисник');

INSERT INTO Osoba (email, lozinka, ime, prezime, jmbg, FK_uloga_id) VALUES ('aleksandarstefanovic@KB_A.rs', 'coamafija1312', N'Александар', N'Стефановић', '2210003710256', 1);
INSERT INTO Osoba (email, lozinka, ime, prezime, jmbg, FK_uloga_id) VALUES ('tanjamarkovic@KB_K.rs', 'tanja123', N'Тања', N'Марковић', '1712001289564', 2);
INSERT INTO Osoba (email, lozinka, ime, prezime, jmbg, FK_uloga_id) VALUES ('mirkolazic@KB_K.rs', 'miki97', N'Мирко', N'Лазић', NULL, 2);
INSERT INTO Osoba (email, lozinka, ime, prezime, jmbg, FK_uloga_id) VALUES ('mirkolazic@KB_A.rs', 'miki97', N'Мирко', N'Лазић', NULL, 1);
INSERT INTO Osoba (email, lozinka, ime, prezime, jmbg, FK_uloga_id) VALUES ('prvi@KB_A.rs', '1234', N'Тест', N'Тест', NULL, 1);

INSERT INTO Novcanik (naziv, stanje, FK_osoba_email) VALUES (N'Џеп', 300, 'aleksandarstefanovic@KB_A.rs'); -- подразумевани новчаник
INSERT INTO Novcanik (naziv, stanje, FK_osoba_email) VALUES (N'Фиока', 8000, 'aleksandarstefanovic@KB_A.rs');
INSERT INTO Novcanik (naziv, stanje, FK_osoba_email) VALUES (N'Џеп', 150, 'tanjamarkovic@KB_K.rs');
INSERT INTO Novcanik (naziv, stanje, FK_osoba_email) VALUES (N'Полица', 5000, 'tanjamarkovic@KB_K.rs');
INSERT INTO Novcanik (naziv, stanje, FK_osoba_email) VALUES (N'Џеп', 400, 'mirkolazic@KB_K.rs');

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

INSERT INTO Promet (datum, FK_novcanik_id, FK_osoba_email, FK_trosak_id, kolicina, FK_organizaciona_jedinica_id, FK_firma_id, ulaz, izlaz, opis) VALUES
('2022-05-19', 1, 'aleksandarstefanovic@KB_A.rs', NULL, 1, 1, NULL, NULL, 500, N'Паре из фиоке у џеп');

-- Преглед података
SELECT * FROM Uloga;

-- Преглед за администратора
SELECT Osoba.ime, Osoba.prezime, Osoba.email, Osoba.lozinka, Osoba.jmbg, Uloga.naziv FROM Osoba
JOIN Uloga ON Osoba.FK_uloga_id = Uloga.id;

SELECT *
FROM Osoba;

-- Укупно стање
SELECT SUM(stanje)
FROM Novcanik
JOIN Osoba ON Novcanik.FK_osoba_email = Osoba.email
WHERE Osoba.email = 'aleksandarstefanovic@KB_A.rs';

UPDATE Novcanik
SET stanje = 1000
WHERE id = 4;

-- Преглед новчаника
SELECT *
FROM Novcanik;

SELECT 0 AS id, N'Сви новчаници' AS naziv UNION SELECT id, naziv FROM Novcanik WHERE FK_osoba_email = '';

SELECT Novcanik.naziv, Novcanik.stanje, Osoba.ime, Osoba.prezime FROM Novcanik
JOIN Osoba ON Novcanik.FK_osoba_email = Osoba.email;

-- Остали шифарници
SELECT * FROM Trosak;

SELECT * FROM Organizaciona_jedinica;

SELECT * FROM Firma;

-- Главна форма
SELECT Promet.id AS id, Promet.datum AS 'Датум', Novcanik.naziv AS 'Новчаник', Trosak.naziv AS 'Трошак', Organizaciona_jedinica.naziv AS 'Организациона јединица', Firma.naziv AS 'Фирма', Promet.ulaz AS 'Улаз', Promet.izlaz AS 'Излаз', Promet.kolicina AS 'Количина'
FROM Promet
JOIN Osoba ON Promet.FK_osoba_email = Osoba.email
JOIN Novcanik ON Promet.FK_novcanik_id = Novcanik.id
FULL JOIN Trosak ON Promet.FK_trosak_id = Trosak.id
FULL JOIN Organizaciona_jedinica ON Promet.FK_organizaciona_jedinica_id = Organizaciona_jedinica.id
FULL JOIN Firma ON Promet.FK_firma_id = Firma.id
WHERE Osoba.email = 'tanjamarkovic@KB_K.rs'
ORDER BY datum, id;

SELECT *
FROM Promet
WHERE FK_osoba_email = 'tanjamarkovic@KB_K.rs';

DELETE FROM Promet
WHERE id = 22;

SELECT 0 AS id, N'Сви новчаници' AS naziv UNION SELECT id, naziv FROM Novcanik WHERE FK_osoba_email = 'aleksandarstefanovic@KB_A.rs';

-- Окидачи

-- Окидач који мења стање у новчанику приликом уноса трансакције
CREATE TRIGGER Promena_stanja_Insert -- Случај да је корисник отишао у минус?
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

-- Окидач који мења стање у новчанику приликом брисања трансакције
CREATE TRIGGER Promena_stanja_Delete
ON Promet
AFTER DELETE
AS
BEGIN
  DECLARE @staro_stanje DECIMAL(8, 2);
  SET @staro_stanje = (SELECT stanje FROM Novcanik WHERE Novcanik.id = (SELECT FK_novcanik_id FROM deleted));
  
  DECLARE @novac DECIMAL(8, 2);
  DECLARE @ulaz DECIMAL(8, 2);
  SET @ulaz = (SELECT ulaz FROM deleted);
  IF (@ulaz IS NULL) SET @novac = (SELECT kolicina FROM deleted)*(SELECT izlaz FROM deleted)
  ELSE SET @novac = (-1)*(SELECT kolicina FROM deleted)*(SELECT ulaz FROM deleted);
  
  DECLARE @novo_stanje DECIMAL(8, 2);
  SET @novo_stanje = @staro_stanje + @novac;  
  
  UPDATE Novcanik
  SET stanje = @novo_stanje
  WHERE Novcanik.id = (SELECT FK_novcanik_id FROM deleted);
END;

-- Окидач који мења стање у новчанику приликом ажурирања трансакције (промена новчаника?)
CREATE TRIGGER Promena_stanja_Update
ON Promet
AFTER UPDATE
AS
BEGIN
  -- Delete
  DECLARE @staro_stanje DECIMAL(8, 2);
  SET @staro_stanje = (SELECT stanje FROM Novcanik WHERE Novcanik.id = (SELECT FK_novcanik_id FROM deleted));
  
  DECLARE @novac DECIMAL(8, 2);
  DECLARE @ulaz DECIMAL(8, 2);
  SET @ulaz = (SELECT ulaz FROM deleted);
  IF (@ulaz IS NULL) SET @novac = (SELECT kolicina FROM deleted)*(SELECT izlaz FROM deleted)
  ELSE SET @novac = (-1)*(SELECT kolicina FROM deleted)*(SELECT ulaz FROM deleted);
  
  DECLARE @novo_stanje_1 DECIMAL(8, 2);
  SET @novo_stanje_1 = @staro_stanje + @novac;  
  
  UPDATE Novcanik
  SET stanje = @novo_stanje_1
  WHERE Novcanik.id = (SELECT FK_novcanik_id FROM deleted);
  
  -- Insert
  DECLARE @staro_stanje_2 DECIMAL(8, 2);
  SET @staro_stanje_2 = (SELECT stanje FROM Novcanik WHERE Novcanik.id = (SELECT FK_novcanik_id FROM inserted));
    
  SET @ulaz = (SELECT ulaz FROM inserted);
  IF (@ulaz IS NULL) SET @novac = (-1)*(SELECT kolicina FROM inserted)*(SELECT izlaz FROM inserted)
  ELSE SET @novac = (SELECT kolicina FROM inserted)*(SELECT ulaz FROM inserted);
  
  DECLARE @novo_stanje_2 DECIMAL(8, 2);
  SET @novo_stanje_2 = @staro_stanje_2 + @novac;  
  
  UPDATE Novcanik
  SET stanje = @novo_stanje_2
  WHERE Novcanik.id = (SELECT FK_novcanik_id FROM inserted);
END;

-- Стор процедура

CREATE PROCEDURE Provera_Korisnika
@email VARCHAR(70),
@lozinka VARCHAR(30)
AS
SET LOCK_TIMEOUT 3000;
BEGIN TRY
  IF EXISTS(SELECT TOP 1 email FROM Osoba
  WHERE email = @email)
  BEGIN
    IF EXISTS(SELECT TOP 1 email FROM Osoba
    WHERE email = @email AND lozinka = @lozinka)
    BEGIN
      DECLARE @uloga INT;
      SET @uloga = (SELECT TOP 1 FK_uloga_id FROM Osoba
      WHERE email = @email AND lozinka = @lozinka);
  
      IF (@uloga = 1)
      BEGIN
        RETURN 1;
      END
      IF (@uloga = 2)
      BEGIN
        RETURN 2;
      END;
    END;
    RETURN -1;
  END;
  RETURN -2;
END TRY
BEGIN CATCH
  RETURN @@ERROR;
END CATCH;

UPDATE Novcanik
SET stanje = stanje + 200
WHERE id = 1;