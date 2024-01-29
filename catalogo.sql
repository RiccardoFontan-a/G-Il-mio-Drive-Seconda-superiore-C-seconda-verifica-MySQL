-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Creato il: Gen 29, 2024 alle 12:03
-- Versione del server: 10.4.22-MariaDB
-- Versione PHP: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `catalogo`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `componenti`
--

CREATE TABLE `componenti` (
  `ID` int(11) NOT NULL,
  `CodFarnell` varchar(30) NOT NULL,
  `Descrizione` varchar(30) NOT NULL,
  `Produttore` varchar(30) NOT NULL,
  `Codproduttore` varchar(30) NOT NULL,
  `Quantita` int(100) NOT NULL,
  `PrezzoUnitario` decimal(25,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `componenti`
--

INSERT INTO `componenti` (`ID`, `CodFarnell`, `Descrizione`, `Produttore`, `Codproduttore`, `Quantita`, `PrezzoUnitario`) VALUES
(1, '4208547', 'Rivelatore', 'CIF', 'AR45', 10, '1.73'),
(2, '2907957', 'USB CABLE', 'MULTICOMP', 'MC002734', 50, '1.29'),
(3, '4148009', 'CLORURO FERRICO', 'CIF', 'AR412', 5, '23.09'),
(4, '1123696', 'Interruttore A 2 POLI', 'LORLIN', 'CK1050', 50, '1.97'),
(6, '3117069', 'IC,OP AMP, DUAL', 'TEXAS INSTRUMENTS', 'LM358AP', 100, '0.24'),
(7, '2627992', 'REGOL. TENS.', 'ON SEMICONDUCTOR', 'NCP7815TG', 50, '0.49'),
(8, '1716993', 'TERMINAL BLOCK 5POS', 'CAMDENBOSS', 'CTB1202/5BK', 20, '0.72'),
(9, '1716993', 'TERMINAL BLOCK 2POS', 'CAMDENBOSS', 'CTB1202/2BK', 30, '0.22'),
(10, '2346522', 'CON. 1000µF', 'RUBYCON', '35PK1000MEFCT810X20', 50, '0.41'),
(11, '2668407', 'Presa DIP', 'CAMDENBOSS', 'CTB1202/5BK', 20, '0.72'),
(12, '9470212', 'RES', 'VISHAY', 'MRS25000C8062FCT00', 100, '0.06'),
(13, '2329641', 'Resistore', 'TE CONNECTIVITY / NEOHM', 'CFR25J20K', 100, '0.01');

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `componenti`
--
ALTER TABLE `componenti`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `componenti`
--
ALTER TABLE `componenti`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
