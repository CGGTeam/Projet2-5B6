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
    Nom nvarchar NOT NULL,
    NombreTrous int NOT NULL,
    Description NVARCHAR NOT NULL,
    Remarque nvarchar
)
CREATE UNIQUE INDEX Terrains_No_uindex ON Terrains (No)
/**
Création de la table TypeAbonnement
 */
CREATE TABLE TypeAbonnement
(
    No int PRIMARY KEY NOT NULL,
    Description nvarchar NOT NULL,
    Remarque nvarchar
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
    DepenseObligatoire tinyint NOT NULL,
    Remarque nvarchar,
    CONSTRAINT PrixDepenseAbonnements_TypeAbonnement_No_fk FOREIGN KEY (NoTypeAbonnement) REFERENCES TypeAbonnement (No),
    primary key (NoTypeAbonnement, Anne)
)
CREATE UNIQUE INDEX PrixDepenseAbonnements_NoTypeAbonnement_uindex ON PrixDepenseAbonnements (NoTypeAbonnement)
/**
Création de la table TypesEmploye
 */
CREATE TABLE TypesEmploye
(
    No int PRIMARY KEY NOT NULL,
    Description nvarchar NOT NULL,
    Remarque nvarchar
)
CREATE UNIQUE INDEX TypesEmploye_No_uindex ON TypesEmploye (No)
/**
Création de la table Provinces
 */
CREATE TABLE Provinces
(
    Id varchar(2) PRIMARY KEY NOT NULL,
    Nom nvarchar NOT NULL,
    Remarque int
)
CREATE UNIQUE INDEX Province_Id_uindex ON Provinces (Id)
/**
Création de la table Employes
 */
CREATE TABLE Employes
(
    No int PRIMARY KEY NOT NULL,
    MotDePasse nvarchar NOT NULL,
    Nom nvarchar NOT NULL,
    Prenom nvarchar NOT NULL,
    Sexe char NOT NULL,
    Age int NOT NULL,
    NoCivique int NOT NULL,
    Rue nvarchar NOT NULL,
    Ville nvarchar NOT NULL,
    IdProvince varchar(2) NOT NULL,
    CodePostal varchar(6) NOT NULL,
    Telephone int,
    Cellulaire int NOT NULL,
    Courriel nvarchar NOT NULL,
    SalaireHoraire money NOT NULL,
    NoTypeEmploye int NOT NULL,
    Remarque nvarchar NOT NULL,
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
    TypeService nvarchar NOT NULL,
    NoEmple int NOT NULL,
    Remarque nvarchar,
    CONSTRAINT Services_Employes_No_fk FOREIGN KEY (NoEmple) REFERENCES Employes (No)
)
CREATE UNIQUE INDEX Services_No_uindex ON Services (No)
/**
Création de la table Services
 */
CREATE TABLE Abonnements
(
    Id varchar(2) PRIMARY KEY NOT NULL,
    DateAbonnement date NOT NULL,
    Nom nvarchar NOT NULL,
    Prenom nvarchar NOT NULL,
    Sexe char NOT NULL,
    DateNaissance date NOT NULL ,
    NoCivique int NOT NULL,
    Rue nvarchar NOT NULL,
    Ville nvarchar NOT NULL,
    IdProvince varchar(2) NOT NULL,
    CodePostal varchar(6) NOT NULL,
    Telephone int,
    Cellulaire int NOT NULL,
    Courriel nvarchar NOT NULL,
    NoTypeAbonnement int NOT NULL,
    Remarque nvarchar NOT NULL,
    CONSTRAINT Abonnements_Province_Id_fk FOREIGN KEY (IdProvince) REFERENCES Provinces (Id),
    CONSTRAINT Abonnements_TypesAbonnement_No_fk FOREIGN KEY (NoTypeAbonnement) REFERENCES TypeAbonnement (No)
)
CREATE UNIQUE INDEX Abonnements_Id_uindex ON Abonnements (Id)
/**
Création de la table Dependants
 */
CREATE TABLE Dependants
(
    Id varchar(2) PRIMARY KEY NOT NULL,
    Nom nvarchar NOT NULL,
    Prenom nvarchar NOT NULL,
    Sexe char NOT NULL,
    DateNaissance date NOT NULL ,
    IdAbonnement varchar(2) NOT NULL,
    Remarque nvarchar NOT NULL,
    CONSTRAINT Dependants_Abonnements_Id_fk FOREIGN KEY (IdAbonnement) REFERENCES Abonnements (Id),
)
CREATE UNIQUE INDEX Dependants_No_uindex ON Dependants (Id)
/**
Création de la table Depenses
 */
CREATE TABLE Depenses
(
    No int PRIMARY KEY NOT NULL,
    IdAbonnement varchar(2) NOT NULL,
    DateDepense date NOT NULL,
    Montant money NOT NULL,
    NoService int NOT NULL,
    Remarque nvarchar NOT NULL,
    CONSTRAINT Depenses_Abonnements_Id_fk FOREIGN KEY (IdAbonnement) REFERENCES Abonnements (Id),
    CONSTRAINT Depenses_Services_No_fk FOREIGN KEY (NoService) REFERENCES Services (No)
)
CREATE UNIQUE INDEX Depenses_No_uindex ON Depenses (No)
/**
Création de la table PartiesJouees
 */
CREATE TABLE PartiesJouees
(
    IdAbbonement varchar(2) NOT NULL,
    NoTerrain int NOT NULL,
    DatePartie date NOT NULL,
    Pointage int NOT NULL,
    Remarque nvarchar,
    CONSTRAINT PartiesJouees_Terrains_No_fk FOREIGN KEY (NoTerrain) REFERENCES Terrains (No),
    CONSTRAINT PartiesJouees_Abonnements_Id_fk FOREIGN KEY (IdAbbonement) REFERENCES Abonnements (Id),
    primary key (IdAbbonement, NoTerrain,DatePartie)
)
/**
Création de la table Reabonnements
 */
CREATE TABLE Reabonnements
(
    IdAbbonement varchar(2) NOT NULL,
    DateRenouvellement date NOT NULL,
    Remarque nvarchar,
    CONSTRAINT Reabonnements_Abonnements_Id_fk FOREIGN KEY (IdAbbonement) REFERENCES Abonnements (Id),
    primary key (IdAbbonement, DateRenouvellement)
)