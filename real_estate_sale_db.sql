-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Dec 06. 00:22
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
('39dd19f3-e486-481d-90a9-bf3e6ec9694b', 'Családi ház kertvárosi övezetben', 85000000, 120, 4, 'Csendes környék, nagy kerttel.', 2005, 'Komfortos', 0, 1, 0, 'Nyugat', NULL),
('5738cfed-8495-413e-97f4-9c642b6a4e53', 'Új építésű penthouse', 150000000, 200, 5, 'Luxus szintű lakás panorámás kilátással.', 2022, 'Extra luxus', 5, 5, 1, 'Kelet-Dél', NULL),
('6e336009-ea37-4d87-9a98-2dffef21f4b6', 'Felújítandó lakás', 30000000, 50, 2, 'Kiváló befektetési lehetőség a belvárosban.', 1980, 'Alap', 3, 5, 0, 'Észak', NULL),
('ef4b28b9-1a17-4c37-b647-7bf18ebd2aba', 'Modern lakás a belvárosban', 45000000, 75.5, 3, 'Tágas, világos lakás remek közlekedéssel.', 2010, 'Luxus', 2, 4, 1, 'Dél', NULL);

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

--
-- A tábla adatainak kiíratása `aspnetusers`
--

INSERT INTO `aspnetusers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
('446a9f6d-a611-4a27-a972-a50d01f503e2', 'gylm99@gmail.com', 'GYLM99@GMAIL.COM', 'gylm99@gmail.com', 'GYLM99@GMAIL.COM', 0, 'AQAAAAIAAYagAAAAECtQRitIPWe5HLMg1WlFMRWwVj3q5DArZA+A3nMdCSDbaTqitxrz0UvkbWgO/A5jlg==', 'XFP7ZWXN7UHFYM3TPVY6SXX5NNBYLBV6', '51ecc685-9494-4d10-84cc-80b5a76dcb76', NULL, 0, 0, NULL, 1, 0);

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
('840a4d02-d98b-41b1-a5d2-85a37e1c8e3f', 'frakk@gmail.com', 'Szia Eszter!\nÉrdekel a házad!', '2024-12-05 22:51:37.056976', NULL),
('c1195499-d33b-46be-a190-b0c9701c2632', 'mirmur@gmail.com', 'Szia Elek!\nÉrdekel a házad!', '2024-12-05 22:51:37.056971', NULL);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `photos`
--

CREATE TABLE `photos` (
  `Id` char(36) NOT NULL,
  `ImagePath` longtext NOT NULL,
  `AdvertisementId` char(36) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

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
('0991eebc-df6a-43c7-9672-fa54b23bb001', 'Teszt Eszter', 'teszt@teszt.com', 'teszt', '+36-20-735-2742'),
('5fab70bd-b457-4da5-ad55-8bb41cb789f4', 'Mekk Elek', 'mekk@mek.com', 'mekmek', '+36/309025476');

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
('20241205215137_m1', '8.0.10'),
('20241205222804_m1', '8.0.10');

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
