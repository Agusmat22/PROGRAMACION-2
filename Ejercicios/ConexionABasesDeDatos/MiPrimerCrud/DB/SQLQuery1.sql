CREATE TABLE Persona(
id INT NOT NULL IDENTITY,
nombre VARCHAR(50),
apellido VARCHAR(50)
CONSTRAINT PK_id PRIMARY KEY (id)
)

SELECT * FROM Persona
INSERT INTO Persona (nombre,apellido) VALUES ('juan','benedetto') 
UPDATE Persona SET nombre='Josesito' WHERE nombre = 'juan'
DELETE FROM Persona WHERE nombre = 'Josesito'