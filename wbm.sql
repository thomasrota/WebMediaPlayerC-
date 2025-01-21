-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Creato il: Gen 21, 2025 alle 19:30
-- Versione del server: 10.4.32-MariaDB
-- Versione PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `wbm`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `wbm_album`
--

CREATE TABLE `wbm_album` (
  `id` int(11) NOT NULL,
  `titolo` varchar(100) NOT NULL,
  `anno` int(11) DEFAULT NULL,
  `immagine` varchar(255) DEFAULT 'default.jpg'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `wbm_album`
--

INSERT INTO `wbm_album` (`id`, `titolo`, `anno`, `immagine`) VALUES
(4, 'Prisoner 709', 2017, 'pris709.jpg'),
(5, 'My Beautiful Dark Twisted Fantasy', 2010, 'mbdtf.jpg'),
(11, 'VULTURES 2', 2024, 'v2.jpg'),
(12, 'Yandhi', 2018, 'yandhi.jpg'),
(13, 'SWISH', 2016, 'swish.png'),
(14, 'BBL Drizzy', 2024, 'bblDrizzy.jpg'),
(15, 'Graduation', 2007, 'grad.jpg'),
(16, 'VIVA LA MUSICA', 2018, 'john_doe.jpg'),
(17, 'Days Before Rodeo', 2014, 'dbr.jpg'),
(18, 'Owl Pharaoh', 2013, 'op.png');

-- --------------------------------------------------------

--
-- Struttura della tabella `wbm_artista`
--

CREATE TABLE `wbm_artista` (
  `id` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `immagine` varchar(255) DEFAULT 'default.jpg'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `wbm_artista`
--

INSERT INTO `wbm_artista` (`id`, `nome`, `immagine`) VALUES
(3, 'Caparezza', 'capar.jpg'),
(4, 'Kanye West', 'kw.jpg'),
(11, '¥$', '$.jpg'),
(12, 'Ty Dolla $ign', 'tydolla.jpg'),
(13, 'Metro Boomin', 'metro.jpg'),
(14, 'Blasco', 'caparezza.jpg'),
(15, 'Travis Scott', 'trav.jpg');

-- --------------------------------------------------------

--
-- Struttura della tabella `wbm_artista_album`
--

CREATE TABLE `wbm_artista_album` (
  `id_artista` int(11) NOT NULL,
  `id_album` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `wbm_artista_album`
--

INSERT INTO `wbm_artista_album` (`id_artista`, `id_album`) VALUES
(3, 4),
(4, 5),
(4, 11),
(4, 12),
(4, 13),
(4, 15),
(11, 11),
(12, 11),
(13, 14),
(14, 16),
(15, 17),
(15, 18);

-- --------------------------------------------------------

--
-- Struttura della tabella `wbm_brano`
--

CREATE TABLE `wbm_brano` (
  `id` int(11) NOT NULL,
  `titolo` varchar(100) NOT NULL,
  `id_album` int(11) NOT NULL,
  `mp3` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `wbm_brano`
--

INSERT INTO `wbm_brano` (`id`, `titolo`, `id_album`, `mp3`) VALUES
(5, 'Ti fa Stare Bene', 4, 'h.mp3'),
(6, 'See Me Now (feat. Beyoncé & Charlie Wilson) (prod. Kanye West, No I.D. & Lex Luger)', 5, 'See_Me_Now.mp3'),
(10, 'EVERYBODY', 11, 'Everybody.mp3'),
(11, 'Sky City [V19] (feat. Ty Dolla $ign, Ant Clemons, Desiigner, 070 Shake & Kid Cudi)', 12, 'Sky_City_V19.mp3'),
(12, 'Pressure (feat. Travis Scott)', 13, 'Pressure.mp3'),
(13, 'I Feel Like That [V11] (feat. Ty Dolla $ign & Tony Williams)', 13, 'I_Feel_Like_That_V11.mp3'),
(14, 'BBL Drizzy', 14, 'BBL DRIZZY.mp3'),
(15, 'Good Life [V3] (feat. T-Pain)', 15, 'Good_Life_V3.mp3'),
(16, 'Homecoming [V2] (feat. Chris Martin & Tony Williams) (prod. Andrew Dawson)', 15, 'Homecoming_V2.mp3'),
(17, 'Blasco.jpg', 16, 'blasco.mp3.mp3'),
(22, 'Drugs You Should Try It', 17, '04 Drugs You Should Try It.mp3'),
(23, 'Hell of a Night', 18, '06 Hell of a Night.mp3');

-- --------------------------------------------------------

--
-- Struttura della tabella `wbm_utente`
--

CREATE TABLE `wbm_utente` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(255) NOT NULL,
  `immagine` varchar(255) NOT NULL DEFAULT 'default.jpg'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `wbm_utente`
--

INSERT INTO `wbm_utente` (`id`, `username`, `email`, `password`, `immagine`) VALUES
(1, 'thmsrt', 'rota.thomas.studente@itispaleocapa.it', '$2y$10$1l3.ipcTBuMwZ/.8Q.aYEe2R.oXCTG3NWnnHTQNhpG5VIz5W98UHW', 'logo.jpg'),
(2, 'manuto', 'belotti.manuel.studente@itispaleocapa.it', '$2y$10$5TbQLDaF2gPPS0Y/S2NSe.CDE.XVLL8ookSeXlTzCaG0UYCBmkqgW', 'default.jpg'),
(3, 'ManutoV2', 'manuto@gmail.com', '$2y$10$HLXlHjOVo4RAvImjI9ILqu8Qrl0rAduiIueuFx4EPeP6ayQQ9QDj.', 'blasco.jpg'),
(4, 'csharp', 'csharp@csharp.it', '$2a$11$f/17MXars/.hJr962jRHY.8hAzH7CMZrXuJ6c7gasqLUmYFGszVlq', 'default.jpg');

-- --------------------------------------------------------

--
-- Struttura della tabella `wbm_utente_brani`
--

CREATE TABLE `wbm_utente_brani` (
  `id_utente` int(11) NOT NULL,
  `id_brano` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `wbm_utente_brani`
--

INSERT INTO `wbm_utente_brani` (`id_utente`, `id_brano`) VALUES
(1, 6),
(1, 10),
(1, 11),
(1, 12),
(1, 14),
(1, 15),
(1, 16),
(1, 22),
(1, 23),
(2, 5),
(3, 17);

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `wbm_album`
--
ALTER TABLE `wbm_album`
  ADD PRIMARY KEY (`id`);

--
-- Indici per le tabelle `wbm_artista`
--
ALTER TABLE `wbm_artista`
  ADD PRIMARY KEY (`id`);

--
-- Indici per le tabelle `wbm_artista_album`
--
ALTER TABLE `wbm_artista_album`
  ADD PRIMARY KEY (`id_artista`,`id_album`),
  ADD KEY `id_album` (`id_album`);

--
-- Indici per le tabelle `wbm_brano`
--
ALTER TABLE `wbm_brano`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_album` (`id_album`);

--
-- Indici per le tabelle `wbm_utente`
--
ALTER TABLE `wbm_utente`
  ADD PRIMARY KEY (`id`);

--
-- Indici per le tabelle `wbm_utente_brani`
--
ALTER TABLE `wbm_utente_brani`
  ADD PRIMARY KEY (`id_utente`,`id_brano`),
  ADD KEY `id_brano` (`id_brano`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `wbm_album`
--
ALTER TABLE `wbm_album`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT per la tabella `wbm_artista`
--
ALTER TABLE `wbm_artista`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT per la tabella `wbm_brano`
--
ALTER TABLE `wbm_brano`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT per la tabella `wbm_utente`
--
ALTER TABLE `wbm_utente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `wbm_artista_album`
--
ALTER TABLE `wbm_artista_album`
  ADD CONSTRAINT `WBM_artista_album_ibfk_1` FOREIGN KEY (`id_artista`) REFERENCES `wbm_artista` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `WBM_artista_album_ibfk_2` FOREIGN KEY (`id_album`) REFERENCES `wbm_album` (`id`) ON DELETE CASCADE;

--
-- Limiti per la tabella `wbm_brano`
--
ALTER TABLE `wbm_brano`
  ADD CONSTRAINT `WBM_brano_ibfk_1` FOREIGN KEY (`id_album`) REFERENCES `wbm_album` (`id`) ON DELETE CASCADE;

--
-- Limiti per la tabella `wbm_utente_brani`
--
ALTER TABLE `wbm_utente_brani`
  ADD CONSTRAINT `WBM_utente_brani_ibfk_1` FOREIGN KEY (`id_utente`) REFERENCES `wbm_utente` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `WBM_utente_brani_ibfk_2` FOREIGN KEY (`id_brano`) REFERENCES `wbm_brano` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
