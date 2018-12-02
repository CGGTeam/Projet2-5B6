use BD5B6TP2_ConstantinMenardS

SET ANSI_WARNINGS  OFF;
/**
Supprimer toutes les tables existantes
 */
DECLARE @Sql NVARCHAR(500) DECLARE @Cursor CURSOR

SET @Cursor = CURSOR FAST_FORWARD FOR
SELECT DISTINCT sql = 'ALTER TABLE [' + tc2.TABLE_NAME + '] DROP [' + rc1.CONSTRAINT_NAME + ']'
FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS rc1
LEFT JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc2 ON tc2.CONSTRAINT_NAME =rc1.CONSTRAINT_NAME

OPEN @Cursor FETCH NEXT FROM @Cursor INTO @Sql

WHILE (@@FETCH_STATUS = 0)
BEGIN
Exec sp_executesql @Sql
FETCH NEXT FROM @Cursor INTO @Sql
END

CLOSE @Cursor DEALLOCATE @Cursor
GO

EXEC sp_MSforeachtable 'DROP TABLE ?'
GO


/**
Création de la table Terrains
 */
CREATE TABLE Terrains
(
    No int PRIMARY KEY NOT NULL,
    Nom nvarchar(50) NOT NULL,
    NombreTrous int NOT NULL,
    Description nvarchar(500) NOT NULL,
    Remarque nvarchar(100)
)
CREATE UNIQUE INDEX Terrains_No_uindex ON Terrains (No)
/**
Création de la table TypeAbonnement
 */
CREATE TABLE TypeAbonnement
(
    No int PRIMARY KEY NOT NULL,
    Description nvarchar(50) NOT NULL,
    Remarque nvarchar(100)
)
CREATE UNIQUE INDEX TypeAbonnement_No_uindex ON TypeAbonnement (No)
/**
Création de la table PrixDepenseAbonnements
 */
CREATE TABLE PrixDepenseAbonnements
(
    NoTypeAbonnement int NOT NULL,
    Anne date NOT NULL,
    Prix money NOT NULL,
    DepenseObligatoire money NOT NULL,
    Remarque nvarchar(100),
    CONSTRAINT PrixDepenseAbonnements_TypeAbonnement_No_fk FOREIGN KEY (NoTypeAbonnement) REFERENCES TypeAbonnement (No),
    primary key (NoTypeAbonnement, Anne)
)
/**
Création de la table TypesEmploye
 */
CREATE TABLE TypesEmploye
(
    No int PRIMARY KEY NOT NULL,
    Description nvarchar(50) NOT NULL,
    Remarque nvarchar(100)
)
CREATE UNIQUE INDEX TypesEmploye_No_uindex ON TypesEmploye (No)
/**
Création de la table Provinces
 */
CREATE TABLE Provinces
(
    Id varchar(2) PRIMARY KEY NOT NULL,
    Nom nvarchar(50) NOT NULL,
    Remarque nvarchar(100),
)
CREATE UNIQUE INDEX Province_Id_uindex ON Provinces (Id)
/**
Création de la table Employes
 */
CREATE TABLE Employes
(
    No int PRIMARY KEY NOT NULL,
    MotDePasse nvarchar(50) NOT NULL,
    Nom nvarchar(50) NOT NULL,
    Prenom nvarchar(50) NOT NULL,
    Sexe char NOT NULL,
    Age int NOT NULL,
    NoCivique int NOT NULL,
    Rue nvarchar(50) NOT NULL,
    Ville nvarchar(50) NOT NULL,
    IdProvince varchar(2) NOT NULL,
    CodePostal varchar(6) NOT NULL,
    Telephone numeric(18,0) NOT NULL,
    Cellulaire numeric(18,0),
    Courriel nvarchar(50) NOT NULL,
    SalaireHoraire money NOT NULL,
    NoTypeEmploye int NOT NULL,
    Remarque nvarchar(100),
    CONSTRAINT Employes_Province_Id_fk FOREIGN KEY (IdProvince) REFERENCES Provinces (Id),
    CONSTRAINT Employes_TypesEmploye_No_fk FOREIGN KEY (NoTypeEmploye) REFERENCES TypesEmploye (No)
)
CREATE UNIQUE INDEX Employes_No_uindex ON Employes (No)
/**
Création de la table Services
 */
CREATE TABLE Services
(
    No int PRIMARY KEY NOT NULL,
    TypeService nvarchar(50) NOT NULL,
    NoEmple int NOT NULL,
    Remarque nvarchar(100),
    CONSTRAINT Services_Employes_No_fk FOREIGN KEY (NoEmple) REFERENCES Employes (No)
)
CREATE UNIQUE INDEX Services_No_uindex ON Services (No)
/**
Création de la table Services
 */
CREATE TABLE Abonnements
(
    Id nvarchar(50) PRIMARY KEY NOT NULL,
    DateAbonnement date NOT NULL,
    Nom nvarchar(50) NOT NULL,
    Prenom nvarchar(50) NOT NULL,
    Sexe char NOT NULL,
    DateNaissance date NOT NULL ,
    NoCivique int NOT NULL,
    Rue nvarchar(50) NOT NULL,
    Ville nvarchar(50) NOT NULL,
    IdProvince varchar(2) NOT NULL,
    CodePostal varchar(6) NOT NULL,
    Telephone numeric(18,0) NOT NULL,
    Cellulaire numeric(18,0),
    Courriel nvarchar(50) NOT NULL,
    NoTypeAbonnement int NOT NULL,
    Remarque nvarchar(100),
    CONSTRAINT Abonnements_Province_Id_fk FOREIGN KEY (IdProvince) REFERENCES Provinces (Id),
    CONSTRAINT Abonnements_TypesAbonnement_No_fk FOREIGN KEY (NoTypeAbonnement) REFERENCES TypeAbonnement (No)
)
CREATE UNIQUE INDEX Abonnements_Id_uindex ON Abonnements (Id)
/**
Création de la table Dependants
 */
CREATE TABLE Dependants
(
    Id nvarchar(50) PRIMARY KEY NOT NULL,
    Nom nvarchar(50) NOT NULL,
    Prenom nvarchar(50) NOT NULL,
    Sexe char NOT NULL,
    DateNaissance date NOT NULL ,
    IdAbonnement nvarchar(50) NOT NULL,
    Remarque nvarchar(100) NOT NULL,
    CONSTRAINT Dependants_Abonnements_Id_fk FOREIGN KEY (IdAbonnement) REFERENCES Abonnements (Id),
)
CREATE UNIQUE INDEX Dependants_No_uindex ON Dependants (Id)
/**
Création de la table Depenses
 */
CREATE TABLE Depenses
(
    No int PRIMARY KEY NOT NULL,
    IdAbonnement nvarchar(50) NOT NULL,
    DateDepense date NOT NULL,
    Montant money NOT NULL,
    NoService int NOT NULL,
    Remarque nvarchar(100),
    CONSTRAINT Depenses_Abonnements_Id_fk FOREIGN KEY (IdAbonnement) REFERENCES Abonnements (Id),
    CONSTRAINT Depenses_Services_No_fk FOREIGN KEY (NoService) REFERENCES Services (No)
)
CREATE UNIQUE INDEX Depenses_No_uindex ON Depenses (No)
/**
Création de la table PartiesJouees
 */
CREATE TABLE PartiesJouees
(
    IdAbbonement nvarchar(50) NOT NULL,
    NoTerrain int NOT NULL,
    DatePartie date NOT NULL,
    Pointage int NOT NULL,
    Remarque nvarchar(100),
    CONSTRAINT PartiesJouees_Terrains_No_fk FOREIGN KEY (NoTerrain) REFERENCES Terrains (No),
    CONSTRAINT PartiesJouees_Abonnements_Id_fk FOREIGN KEY (IdAbbonement) REFERENCES Abonnements (Id),
    primary key (IdAbbonement, NoTerrain,DatePartie)
)
/**
Création de la table Reabonnements
 */
CREATE TABLE Reabonnements
(
    IdAbbonement nvarchar(50) NOT NULL,
    DateRenouvellement date NOT NULL,
    Remarque nvarchar(100),
    CONSTRAINT Reabonnements_Abonnements_Id_fk FOREIGN KEY (IdAbbonement) REFERENCES Abonnements (Id),
    primary key (IdAbbonement, DateRenouvellement)
)
/**
Insertion des type d'employés
 */
INSERT INTO TypesEmploye(No,Description,Remarque)
VALUES (1,'Administration','Il n''y en a qu''un et son numero est 1'),
       (2,'Direction',null),
       (3,'Propriétaire d’un club',null),
       (4,'Employé d’un club',null),
       (5,'Employé Pro-Shop',null),
       (6,'Employé d’un restaurant',null),
       (7,'Professeur de golf',null);

/**
Insertion des type d'abonnements
 */
INSERT INTO TypeAbonnement(No, Description)
VALUES (1,'Personne seule'),
       (2,'Personne seule'),
       (3,'Personne seule'),
       (4,'Personne seule'),
       (5,'Personne seule'),
       (6,'Personne seule');

/**
Insertion des prix et dépense pour un type d'abonnement
 */
INSERT into PrixDepenseAbonnements(NoTypeAbonnement,Anne,Prix,DepenseObligatoire)
VALUES (1,'2018',850,400),
       (2,'2018',500,400),
       (3,'2018',1200,700),
       (4,'2018',1700,700),
       (5,'2018',1900,700),
       (6,'2018',2100,700);
/**
Insertion des provinces
 */
INSERT INTO Provinces(Id, Nom)
VALUES ('AB','Alberta'),
       ('BC','Colombie-Britanique'),
       ('MB','Monitoba'),
       ('NM','Nouveau-Brunswick'),
       ('NL','Terre-Neuve et Labrador'),
       ('NT','Territoires du Nord-Ouest'),
       ('NS','Nouvelle-Écosse'),
       ('NU','Nunavut'),
       ('ON','Ontario'),
       ('PE','Île-du-Prince-Édouard'),
       ('QC','Québec'),
       ('SK','Saskatchewan'),
       ('YT','Territoire du Yukon');
/**
Insertion de l'admin
 */
INSERT INTO Employes (No, MotDePasse, Nom, Prenom, Sexe, Age, NoCivique, Rue, Ville, IdProvince, CodePostal, Telephone, Cellulaire, Courriel, SalaireHoraire, NoTypeEmploye, Remarque)
VALUES (1,'Password1','admin','admin','A',1,1,'A','A','QC','AAAAAA',1111111111,1111111111,'A@A',1,1,'L''admin du logiciel');
/**
Insertion des terrains
 */
INSERT INTO Terrains ("No", Nom, NombreTrous, Description)
VALUES (1,'Golf Bellechasse',18,'Politesse toute naturelle, disant que sa mère le coup terrible frappé sur l''épaule de sa mère lui en eût imposé la crainte, si nouvelle, qu''on doit à ses infirmités ! Au-dessous du sermon, on dit à cette heure de la matinée.'),
       (2,'Golf l''Auberivière',18,'Entendre, c''est radicalement s''écarter des théories classiques. Reprenez donc, je vais commencer tout de suite les wagons se succédèrent, rapides et sans but.'),
       (3,'Golf Deux-Montagnes',18,'Barre à gauche cinq, cap au deux-deux-cinq, et sortait déjà la main se joue sur leurs étonnantes culottes en toile de bâche vert-pomme. Ajoutons à ce que mon maître d''avoir l''occasion d''entendre le coron entier était réveillé, rempli d''espèces.'),
       (4,'Golf La Madeleine - Parcours Le Présidentiel',9,'Décidé à partir tout de suite sans m''y appliquer, sans en demander plus long. Laisser les choses en apparence les rôles et les objets manufacturés relativement chers.'),
       (5,'Prince de Galles',9,'Livrerait-il le secret que son nom... Alentour, le cercle avait fini par s''y ruiner le corps et sur la place déserte et les ruelles étaient désertes.'),
       (6,'	Golf île de Montréal - Parcours de l''Irlande',9,'Haut et court, sans étouffement, goûtant la poésie, les beaux-arts et la littérature. Sale maquereau, tu oserais prendre la moitié de ce que le public en général, mais aussi tous les hommes étant capables d''apprendre.');

INSERT INTO Abonnements (Id, DateAbonnement, Nom, Prenom, Sexe, DateNaissance, NoCivique, Rue, Ville, IdProvince, CodePostal, Telephone, Cellulaire, Courriel, NoTypeAbonnement, Remarque)
VALUES (4,'2018','Ginette','Paul','H','1990-10-10',5,'rue','ville', 'QC','H9X4A8',1111111111,2222222222,'courriel@courriel.com',1,'remarque');
