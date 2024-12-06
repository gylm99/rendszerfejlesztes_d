-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Dec 06. 07:12
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `real_estate_sale_db`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `advertisements`
--

CREATE TABLE `advertisements` (
  `Id` char(36) NOT NULL,
  `Title` longtext NOT NULL,
  `Price` double NOT NULL,
  `BaseArea` double NOT NULL,
  `RoomNumber` int(11) NOT NULL,
  `Description` longtext NOT NULL,
  `BuiltYear` int(11) NOT NULL,
  `Confort` longtext NOT NULL,
  `FloorLevel` int(11) NOT NULL,
  `MainBuildingFloorLevel` int(11) NOT NULL,
  `HasElevator` tinyint(1) NOT NULL,
  `Orientation` longtext NOT NULL,
  `UserId` char(36) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `advertisements`
--

INSERT INTO `advertisements` (`Id`, `Title`, `Price`, `BaseArea`, `RoomNumber`, `Description`, `BuiltYear`, `Confort`, `FloorLevel`, `MainBuildingFloorLevel`, `HasElevator`, `Orientation`, `UserId`) VALUES
('249f17df-fba1-4c3c-86c0-6f5ccb92dbc2', 'Példa Hirdetés', 15000000, 120, 4, 'Nagy nappali és 2 hálószoba.', 1980, 'Luxus', 4, 4, 1, 'Észak', 'd938ba9e-155d-4190-9e04-0c0e9814a0bc'),
('4b910331-6bd9-46f9-9f9b-7a89eff7fe94', 'Modern lakás a belvárosban', 45000000, 75.5, 3, 'Tágas, világos lakás remek közlekedéssel.', 2010, 'Luxus', 2, 4, 1, 'Dél', NULL),
('70602bc9-41cc-42a7-89cf-3084c5bcd328', 'Felújítandó lakás', 30000000, 50, 2, 'Kiváló befektetési lehetőség a belvárosban.', 1980, 'Alap', 3, 5, 0, 'Észak', NULL),
('7bd112da-6095-4958-a5d8-0658d3acdf71', 'Családi ház kertvárosi övezetben', 85000000, 120, 4, 'Csendes környék, nagy kerttel.', 2005, 'Komfortos', 0, 1, 0, 'Nyugat', NULL),
('a462b0d3-e69b-491f-9c1c-9b582a796e04', 'Új építésű penthouse', 150000000, 200, 5, 'Luxus szintű lakás panorámás kilátással.', 2022, 'Extra luxus', 5, 5, 1, 'Kelet-Dél', NULL);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `aspnetroleclaims`
--

CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `aspnetroles`
--

CREATE TABLE `aspnetroles` (
  `Id` varchar(255) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `aspnetuserlogins`
--

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(255) NOT NULL,
  `ProviderKey` varchar(255) NOT NULL,
  `ProviderDisplayName` longtext DEFAULT NULL,
  `UserId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `aspnetuserroles`
--

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(255) NOT NULL,
  `RoleId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `aspnetusers`
--

CREATE TABLE `aspnetusers` (
  `Id` varchar(255) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext DEFAULT NULL,
  `SecurityStamp` longtext DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL,
  `PhoneNumber` longtext DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` datetime DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `aspnetusertokens`
--

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(255) NOT NULL,
  `LoginProvider` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Value` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `messages`
--

CREATE TABLE `messages` (
  `Id` char(36) NOT NULL,
  `SenderEmailAddress` longtext NOT NULL,
  `Content` longtext NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UserId` char(36) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `messages`
--

INSERT INTO `messages` (`Id`, `SenderEmailAddress`, `Content`, `CreatedAt`, `UserId`) VALUES
('52501155-888a-4236-aa56-be6516992598', 'mirmur@gmail.com', 'Szia Elek! Tetszik a házad, venném', '2024-12-06 06:52:15.705829', 'd938ba9e-155d-4190-9e04-0c0e9814a0bc'),
('9ebcab83-7fca-4db9-ae57-a0b57fbda7bf', 'frakk@gmail.com', 'Szia Eszter!\nÉrdekel a házad!', '2024-12-06 06:44:05.648858', NULL),
('fe0d043f-4b40-41d2-9657-ed703749a946', 'mirmur@gmail.com', 'Szia Elek!\nÉrdekel a házad!', '2024-12-06 06:44:05.648853', NULL);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `photos`
--

CREATE TABLE `photos` (
  `Id` char(36) NOT NULL,
  `ImagePath` longtext NOT NULL,
  `AdvertisementId` char(36) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `photos`
--

INSERT INTO `photos` (`Id`, `ImagePath`, `AdvertisementId`) VALUES
('099ebff5-1200-4059-99b1-cf4c02ae1cda', '/uploads/249f17df-fba1-4c3c-86c0-6f5ccb92dbc2/cc9cea1f-609b-43da-b098-60a1ac75f737.jpg', '249f17df-fba1-4c3c-86c0-6f5ccb92dbc2'),
('1848670b-e3ef-4b3f-a887-10244a98cb03', '/uploads/249f17df-fba1-4c3c-86c0-6f5ccb92dbc2/7cba3a50-6b5d-4c4b-a8dd-496cdec7a224.jpg', '249f17df-fba1-4c3c-86c0-6f5ccb92dbc2'),
('1f3105d0-312c-41a1-8345-ec519ac89bc8', '/uploads/249f17df-fba1-4c3c-86c0-6f5ccb92dbc2/30c2e7cd-34b1-491b-8744-4808526215c3.jpg', '249f17df-fba1-4c3c-86c0-6f5ccb92dbc2'),
('26716e77-147b-4e6a-9143-0ce8c04219aa', '/uploads/249f17df-fba1-4c3c-86c0-6f5ccb92dbc2/98c8f9e5-4538-4f75-93be-eaa01ac6755c.jpg', '249f17df-fba1-4c3c-86c0-6f5ccb92dbc2'),
('27fd0f4d-0fb7-4290-be76-4ecf2f299032', '/uploads/249f17df-fba1-4c3c-86c0-6f5ccb92dbc2/af0baa78-9a2f-47a3-b03b-0dffd92fa4f2.jpg', '249f17df-fba1-4c3c-86c0-6f5ccb92dbc2'),
('638f5220-acc6-4742-8d56-caddffbbdf81', '/uploads/249f17df-fba1-4c3c-86c0-6f5ccb92dbc2/60a0411e-9556-4b8f-b7fe-45177e198c24.jpg', '249f17df-fba1-4c3c-86c0-6f5ccb92dbc2'),
('c1cfc204-5220-4655-a81f-07901532db13', '/uploads/249f17df-fba1-4c3c-86c0-6f5ccb92dbc2/f41ae022-075b-4cd6-8911-743f2b7f335a.jpg', '249f17df-fba1-4c3c-86c0-6f5ccb92dbc2'),
('c3d53182-900c-4041-9e07-f6112f1adcf5', '/uploads/249f17df-fba1-4c3c-86c0-6f5ccb92dbc2/95a3821f-c585-4b33-ba0c-1a899abd2e06.jpg', '249f17df-fba1-4c3c-86c0-6f5ccb92dbc2'),
('f9f5a471-bbcd-4e6f-8a7a-c5ea31a270cd', '/uploads/249f17df-fba1-4c3c-86c0-6f5ccb92dbc2/af2a36ff-4e7d-49d0-9a9d-68b7c76fdaa8.jpg', '249f17df-fba1-4c3c-86c0-6f5ccb92dbc2');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `Id` char(36) NOT NULL,
  `Name` longtext NOT NULL,
  `Email` longtext NOT NULL,
  `Password` longtext NOT NULL,
  `Number` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`Id`, `Name`, `Email`, `Password`, `Number`) VALUES
('d938ba9e-155d-4190-9e04-0c0e9814a0bc', 'Mekk Elek', 'mekk@mek.com', 'mekmek', '+36/309025476'),
('f3c8aef9-4c0c-4786-bc76-85c419dfe39a', 'Teszt Eszter', 'teszt@teszt.com', 'teszt', '+36-20-735-2742');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20241206054405_m2', '8.0.10'),
('20241206061028_m2', '8.0.10');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `advertisements`
--
ALTER TABLE `advertisements`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Advertisements_UserId` (`UserId`);

--
-- A tábla indexei `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- A tábla indexei `aspnetroles`
--
ALTER TABLE `aspnetroles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- A tábla indexei `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- A tábla indexei `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- A tábla indexei `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- A tábla indexei `aspnetusers`
--
ALTER TABLE `aspnetusers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- A tábla indexei `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- A tábla indexei `messages`
--
ALTER TABLE `messages`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Messages_UserId` (`UserId`);

--
-- A tábla indexei `photos`
--
ALTER TABLE `photos`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Photos_AdvertisementId` (`AdvertisementId`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Id`);

--
-- A tábla indexei `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `advertisements`
--
ALTER TABLE `advertisements`
  ADD CONSTRAINT `FK_Advertisements_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE;

--
-- Megkötések a táblához `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE;

--
-- Megkötések a táblához `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Megkötések a táblához `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Megkötések a táblához `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Megkötések a táblához `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Megkötések a táblához `messages`
--
ALTER TABLE `messages`
  ADD CONSTRAINT `FK_Messages_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE;

--
-- Megkötések a táblához `photos`
--
ALTER TABLE `photos`
  ADD CONSTRAINT `FK_Photos_Advertisements_AdvertisementId` FOREIGN KEY (`AdvertisementId`) REFERENCES `advertisements` (`Id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
