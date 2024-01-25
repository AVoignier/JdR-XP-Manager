INSERT INTO Monstre (nom, experience,dangerosite,personnalise)
VALUES 
('Gobelin',50,0.250,0),
('Assassin',3900,8,0),
('Liche',33000,21,0),
('Loup',50,0.25,0),
('Molosse',25,0.125,0)

Insert Into Equipe (nom)
VALUES
('Ildorine'),
('Chtuluh'),
('Initiation'),
('Foret Druide'),
('Chroniques Oubliées'),
('Meurtre d Amarangue')

INSERT INTO Joueur (nom)
VALUES
('Alexandre'),
('Lenny'),
('Coralie'),
('Coline'),
('Quentin'),
('Lisa'),
('Danny');

INSERT INTO Personnage(idJoueur,nom,experience,vivant)
VALUES
(1,'Isidore',1000,1),
(3,'Emi',5000,1),
(4,'Agone',2000,1),
(5,'Ed',2,1),
(1,'Bonjour',20,0),
(4,'Fleur des paquerettes',1,0),
(1,'Ripher',300,1),
(3,'Amaurëa',900,1),
(4,'Eoeni',910,1)

INSERT INTO Niveau(experience)
VALUES
(0),
(300),
(900),
(2700),
(6500),
(14000),
(23000),
(34000),
(48000),
(64000),
(85000),
(100000),
(120000),
(140000),
(165000),
(195000),
(225000),
(265000),
(305000),
(355000)

INSERT INTO FaitParti(idJoueur,idPersonnage,idEquipe)
VALUES
(1,1,5),
(1,1,6),
(1,5,5),
(1,7,1),
(1,7,3),
(3,2,5),
(3,2,6),
(3,8,1),
(3,8,3),
(4,3,5),
(4,3,6),
(4,6,5),
(4,9,1),
(5,4,5),
(5,4,6)
