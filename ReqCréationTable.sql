/*- Création BD-*/
CREATE TABLE Joueur
(
id INT NOT NULL IDENTITY(1,1),
nom VARCHAR(50) NOT NULL,

PRIMARY KEY (id)
)

CREATE TABLE Equipe
(
id INT NOT NULL IDENTITY(1,1),
nom VARCHAR(50),

PRIMARY KEY (id)
)

CREATE TABLE Personnage
(
idJoueur INT NOT NULL,
id INT NOT NULL IDENTITY(1,1),
nom VARCHAR(50),
experience INT,
vivant BIT, 

PRIMARY KEY (idJoueur,id),
FOREIGN KEY (idJoueur) REFERENCES Joueur(id)
)

CREATE TABLE FaitParti
(
idEquipe INT NOT NULL,
idJoueur INT NOT NULL,
idPersonnage INT NOT NULL,

PRIMARY KEY (idPersonnage,idJoueur,idEquipe),
FOREIGN KEY (idJoueur,idPersonnage) REFERENCES Personnage(idJoueur,id),
FOREIGN KEY (idEquipe) REFERENCES Equipe(id)
)

CREATE TABLE Monstre
(
id INT NOT NULL IDENTITY(1,1),
nom VARCHAR(50) NOT NULL,
experience INT NOT NULL,
dangerosite FLOAT NOT NULL,
personnalise BIT NOT NULL

PRIMARY KEY (id)
)

CREATE TABLE Niveau
(
niveau int NOT NULL IDENTITY(1,1),
experience int NOT NULL

PRIMARY KEY (niveau)
)
