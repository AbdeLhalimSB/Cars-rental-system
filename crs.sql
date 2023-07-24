-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jul 24, 2023 at 10:04 PM
-- Server version: 5.6.15-log
-- PHP Version: 5.4.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `crs`
--

-- --------------------------------------------------------

--
-- Table structure for table `cars`
--

CREATE TABLE IF NOT EXISTS `cars` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Marque` varchar(10000) NOT NULL,
  `Type` varchar(10000) NOT NULL,
  `Model` varchar(10000) NOT NULL,
  `Couleur` varchar(10000) NOT NULL,
  `Matricule` varchar(10000) NOT NULL,
  `Prix` varchar(10000) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `cars`
--

INSERT INTO `cars` (`id`, `Marque`, `Type`, `Model`, `Couleur`, `Matricule`, `Prix`) VALUES
(1, 'Mercedes', 'Diesel', '1994', 'Gold', '125625', '350'),
(3, 'Dacia', 'Diesel', '2017', 'Green', '12525', '399'),
(4, 'Fiat-124', 'Ono', '1999', 'Red', '215465', '100');

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

CREATE TABLE IF NOT EXISTS `clients` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(10000) NOT NULL,
  `Last_Name` varchar(10000) NOT NULL,
  `CIN` varchar(10000) NOT NULL,
  `Tel` varchar(10000) NOT NULL,
  `Email` varchar(10000) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`id`, `Name`, `Last_Name`, `CIN`, `Tel`, `Email`) VALUES
(1, 'Fatima', 'Zahra', 'KB254145', '060606060', 'fatima@zahra.com'),
(3, 'Kars', 'Avdol', 'KB254144', '06060600', 'kars@gmail.com'),
(4, 'Fatima', 'Z', 'KB1544', '060060', 'slm@gmail.com'),
(5, 'Aldov', 'Hetler', 'KB2564156', '00606060', 'Aldov@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE IF NOT EXISTS `reservation` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(10000) NOT NULL,
  `Last_Name` varchar(10000) NOT NULL,
  `CIN` varchar(10000) NOT NULL,
  `Tel` varchar(10000) NOT NULL,
  `Email` varchar(10000) NOT NULL,
  `Permis_conduire` varchar(10000) NOT NULL,
  `From_Date` varchar(1000) NOT NULL,
  `To_Date` varchar(1000) NOT NULL,
  `Car_id` int(110) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `reservation`
--

INSERT INTO `reservation` (`id`, `Name`, `Last_Name`, `CIN`, `Tel`, `Email`, `Permis_conduire`, `From_Date`, `To_Date`, `Car_id`) VALUES
(2, 'Aldov', 'Hetler', 'KB2564156', '00606060', 'Aldov@gmail.com', 'B', 'Monday, July 24, 2023', 'Wednesday, July 26, 2023', 1);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user` varchar(10000) NOT NULL,
  `password` varchar(10000) NOT NULL,
  `perm` varchar(10000) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
