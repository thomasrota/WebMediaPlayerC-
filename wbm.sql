-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Creato il: Gen 16, 2025 alle 16:31
-- Versione del server: 8.0.26
-- Versione PHP: 8.0.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `my_rotathomas`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `WBM_album`
--

CREATE TABLE `WBM_album` (
  `id` int NOT NULL,
  `titolo` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `anno` int DEFAULT NULL,
  `immagine` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT 'default.jpg'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `WBM_album`
--

INSERT INTO `WBM_album` (`id`, `titolo`, `anno`, `immagine`) VALUES
(4, 'Prisoner 709', 2017, 'pris709.jpg'),
(5, 'My Beautiful Dark Twisted Fantasy', 2010, 'mbdtf.jpg'),
(11, 'VULTURES 2', 2024, 'v2.jpg'),
(12, 'Yandhi', 2018, 'yandhi.jpg'),
(13, 'SWISH', 2016, 'swish.png'),
(14, 'BBL Drizzy', 2024, 'bblDrizzy.jpg'),
(15, 'Graduation', 2007, 'grad.jpg'),
(16, 'VIVA LA MUSICA', 2018, 'john_doe.jpg');

-- --------------------------------------------------------

--
-- Struttura della tabella `WBM_artista`
--

CREATE TABLE `WBM_artista` (
  `id` int NOT NULL,
  `nome` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `immagine` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT 'default.jpg'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `WBM_artista`
--

INSERT INTO `WBM_artista` (`id`, `nome`, `immagine`) VALUES
(3, 'Caparezza', 'capar.jpg'),
(4, 'Kanye West', 'kw.jpg'),
(11, '¥$', '$.jpg'),
(12, 'Ty Dolla $ign', 'tydolla.jpg'),
(13, 'Metro Boomin', 'metro.jpg'),
(14, 'Blasco', 'caparezza.jpg');

-- --------------------------------------------------------

--
-- Struttura della tabella `WBM_artista_album`
--

CREATE TABLE `WBM_artista_album` (
  `id_artista` int NOT NULL,
  `id_album` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `WBM_artista_album`
--

INSERT INTO `WBM_artista_album` (`id_artista`, `id_album`) VALUES
(3, 4),
(4, 5),
(4, 11),
(11, 11),
(12, 11),
(4, 12),
(4, 13),
(13, 14),
(4, 15),
(14, 16);

-- --------------------------------------------------------

--
-- Struttura della tabella `WBM_brano`
--

CREATE TABLE `WBM_brano` (
  `id` int NOT NULL,
  `titolo` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `id_album` int NOT NULL,
  `mp3` varchar(255) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `WBM_brano`
--

INSERT INTO `WBM_brano` (`id`, `titolo`, `id_album`, `mp3`) VALUES
(5, 'Ti fa Stare Bene', 4, 'h.mp3'),
(6, 'See Me Now (feat. Beyoncé & Charlie Wilson) (prod. Kanye West, No I.D. & Lex Luger)', 5, 'See_Me_Now.mp3'),
(10, 'EVERYBODY', 11, 'Everybody.mp3'),
(11, 'Sky City [V19] (feat. Ty Dolla $ign, Ant Clemons, Desiigner, 070 Shake & Kid Cudi)', 12, 'Sky_City_V19.mp3'),
(12, 'Pressure (feat. Travis Scott)', 13, 'Pressure.mp3'),
(13, 'I Feel Like That [V11] (feat. Ty Dolla $ign & Tony Williams)', 13, 'I_Feel_Like_That_V11.mp3'),
(14, 'BBL Drizzy', 14, 'BBL DRIZZY.mp3'),
(15, 'Good Life [V3] (feat. T-Pain)', 15, 'Good_Life_V3.mp3'),
(16, 'Homecoming [V2] (feat. Chris Martin & Tony Williams) (prod. Andrew Dawson)', 15, 'Homecoming_V2.mp3'),
(17, 'Blasco.jpg', 16, 'blasco.mp3.mp3');

-- --------------------------------------------------------

--
-- Struttura della tabella `WBM_utente`
--

CREATE TABLE `WBM_utente` (
  `id` int NOT NULL,
  `username` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `email` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `password` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `immagine` varchar(255) COLLATE utf8mb4_general_ci NOT NULL DEFAULT 'default.jpg'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `WBM_utente`
--

INSERT INTO `WBM_utente` (`id`, `username`, `email`, `password`, `immagine`) VALUES
(1, 'thmsrt', 'rota.thomas.studente@itispaleocapa.it', '$2y$10$1l3.ipcTBuMwZ/.8Q.aYEe2R.oXCTG3NWnnHTQNhpG5VIz5W98UHW', 'logo.jpg'),
(2, 'manuto', 'belotti.manuel.studente@itispaleocapa.it', '$2y$10$5TbQLDaF2gPPS0Y/S2NSe.CDE.XVLL8ookSeXlTzCaG0UYCBmkqgW', 'default.jpg'),
(3, 'ManutoV2', 'manuto@gmail.com', '$2y$10$HLXlHjOVo4RAvImjI9ILqu8Qrl0rAduiIueuFx4EPeP6ayQQ9QDj.', 'blasco.jpg');

-- --------------------------------------------------------

--
-- Struttura della tabella `WBM_utente_brani`
--

CREATE TABLE `WBM_utente_brani` (
  `id_utente` int NOT NULL,
  `id_brano` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `WBM_utente_brani`
--

INSERT INTO `WBM_utente_brani` (`id_utente`, `id_brano`) VALUES
(2, 5),
(1, 6),
(1, 10),
(1, 11),
(1, 12),
(1, 14),
(1, 15),
(1, 16),
(3, 17);

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `WBM_album`
--
ALTER TABLE `WBM_album`
  ADD PRIMARY KEY (`id`);

--
-- Indici per le tabelle `WBM_artista`
--
ALTER TABLE `WBM_artista`
  ADD PRIMARY KEY (`id`);

--
-- Indici per le tabelle `WBM_artista_album`
--
ALTER TABLE `WBM_artista_album`
  ADD PRIMARY KEY (`id_artista`,`id_album`),
  ADD KEY `id_album` (`id_album`);

--
-- Indici per le tabelle `WBM_brano`
--
ALTER TABLE `WBM_brano`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_album` (`id_album`);

--
-- Indici per le tabelle `WBM_utente`
--
ALTER TABLE `WBM_utente`
  ADD PRIMARY KEY (`id`);

--
-- Indici per le tabelle `WBM_utente_brani`
--
ALTER TABLE `WBM_utente_brani`
  ADD PRIMARY KEY (`id_utente`,`id_brano`),
  ADD KEY `id_brano` (`id_brano`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `WBM_album`
--
ALTER TABLE `WBM_album`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT per la tabella `WBM_artista`
--
ALTER TABLE `WBM_artista`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT per la tabella `WBM_brano`
--
ALTER TABLE `WBM_brano`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT per la tabella `WBM_utente`
--
ALTER TABLE `WBM_utente`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `WBM_artista_album`
--
ALTER TABLE `WBM_artista_album`
  ADD CONSTRAINT `WBM_artista_album_ibfk_1` FOREIGN KEY (`id_artista`) REFERENCES `WBM_artista` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `WBM_artista_album_ibfk_2` FOREIGN KEY (`id_album`) REFERENCES `WBM_album` (`id`) ON DELETE CASCADE;

--
-- Limiti per la tabella `WBM_brano`
--
ALTER TABLE `WBM_brano`
  ADD CONSTRAINT `WBM_brano_ibfk_1` FOREIGN KEY (`id_album`) REFERENCES `WBM_album` (`id`) ON DELETE CASCADE;

--
-- Limiti per la tabella `WBM_utente_brani`
--
ALTER TABLE `WBM_utente_brani`
  ADD CONSTRAINT `WBM_utente_brani_ibfk_1` FOREIGN KEY (`id_utente`) REFERENCES `WBM_utente` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `WBM_utente_brani_ibfk_2` FOREIGN KEY (`id_brano`) REFERENCES `WBM_brano` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
