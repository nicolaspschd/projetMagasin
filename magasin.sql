-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Mer 02 Novembre 2016 à 15:39
-- Version du serveur :  5.6.15-log
-- Version de PHP :  5.5.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `magasin`
--
CREATE DATABASE IF NOT EXISTS `magasin` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `magasin`;

-- --------------------------------------------------------

--
-- Structure de la table `acheter`
--

CREATE TABLE IF NOT EXISTS `acheter` (
  `idUtilisateur` int(10) NOT NULL,
  `idProduit` int(10) NOT NULL,
  `quantite` int(10) NOT NULL,
  PRIMARY KEY (`idUtilisateur`,`idProduit`),
  KEY `idProduit` (`idProduit`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `categories`
--

CREATE TABLE IF NOT EXISTS `categories` (
  `idNomCategorie` varchar(60) NOT NULL,
  PRIMARY KEY (`idNomCategorie`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `categories`
--

INSERT INTO `categories` (`idNomCategorie`) VALUES
('Apero'),
('Biscuits'),
('Boissons'),
('Boucherie'),
('Boulangerie'),
('Fromagerie'),
('Fruits'),
('Gouter'),
('Legumes'),
('Patisseries'),
('Petit Dejeuner'),
('Poissonerie'),
('Produits Bio'),
('Produits Frais'),
('Produits Locaux');

-- --------------------------------------------------------

--
-- Structure de la table `favoris`
--

CREATE TABLE IF NOT EXISTS `favoris` (
  `idUtilisateur` int(10) NOT NULL,
  `idProduit` int(10) NOT NULL,
  PRIMARY KEY (`idUtilisateur`,`idProduit`),
  KEY `idProduit` (`idProduit`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `produits`
--

CREATE TABLE IF NOT EXISTS `produits` (
  `idProduits` int(10) NOT NULL AUTO_INCREMENT,
  `nomProduits` varchar(60) NOT NULL,
  `stock` int(10) NOT NULL,
  `prix` double NOT NULL,
  `idCategorie` varchar(60) NOT NULL,
  PRIMARY KEY (`idProduits`),
  KEY `idCategorie` (`idCategorie`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `utilisateurs`
--

CREATE TABLE IF NOT EXISTS `utilisateurs` (
  `idUtilisateurs` int(10) NOT NULL AUTO_INCREMENT,
  `loginUser` varchar(60) NOT NULL,
  `mdpUser` varchar(60) NOT NULL,
  PRIMARY KEY (`idUtilisateurs`),
  UNIQUE KEY `loginUser` (`loginUser`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=15 ;

--
-- Contenu de la table `utilisateurs`
--

INSERT INTO `utilisateurs` (`idUtilisateurs`, `loginUser`, `mdpUser`) VALUES
(13, 'admin', 'f6889fc97e14b42dec11a8c183ea791c5465b658');

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `acheter`
--
ALTER TABLE `acheter`
  ADD CONSTRAINT `acheter_ibfk_1` FOREIGN KEY (`idUtilisateur`) REFERENCES `utilisateurs` (`idUtilisateurs`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `acheter_ibfk_2` FOREIGN KEY (`idProduit`) REFERENCES `produits` (`idProduits`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `favoris`
--
ALTER TABLE `favoris`
  ADD CONSTRAINT `favoris_ibfk_1` FOREIGN KEY (`idUtilisateur`) REFERENCES `utilisateurs` (`idUtilisateurs`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `favoris_ibfk_2` FOREIGN KEY (`idProduit`) REFERENCES `produits` (`idProduits`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `produits`
--
ALTER TABLE `produits`
  ADD CONSTRAINT `produits_ibfk_1` FOREIGN KEY (`idCategorie`) REFERENCES `categories` (`idNomCategorie`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
