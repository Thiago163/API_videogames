drop database VideoGames;
-- ---------------- --
CREATE DATABASE VideoGames;
USE VideoGames;

CREATE TABLE JOGOS(
ID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
Titulo VARCHAR(255),
Plataforma VARCHAR(255),
Genero VARCHAR(255),
Premios VARCHAR(255),
DataLancamento DateTime
);

select * from JOGOS;