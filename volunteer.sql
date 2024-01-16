-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: mysql:3306
-- Generation Time: Nov 15, 2023 at 12:31 PM
-- Server version: 8.2.0
-- PHP Version: 8.2.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `volunteer`
--

-- --------------------------------------------------------

--
-- Table structure for table `favorites`
--

CREATE TABLE `favorites` (
  `id` int NOT NULL,
  `user_id` varchar(255) NOT NULL,
  `favorite_organization_id` int NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `organizations`
--

CREATE TABLE `organizations` (
  `id` int NOT NULL,
  `organization_user_id` int NOT NULL,
  `name` varchar(255) NOT NULL,
  `description` varchar(255) NOT NULL,
  `description_long` text NOT NULL,
  `email` varchar(255) NOT NULL,
  `website` varchar(255) DEFAULT NULL,
  `banner_image` varchar(255) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `organizations`
--

INSERT INTO `organizations` (`id`, `organization_user_id`, `name`, `description`, `description_long`, `email`, `website`, `banner_image`) VALUES
(1, 1, 'Doctors Without Borders', 'Providing medical aid to those in need worldwide.', 'Doctors Without Borders is an international medical humanitarian organization providing assistance to people affected by conflict, epidemics, disasters, or exclusion from healthcare.', 'contact@doctorswithoutborders.org', 'https://www.doctorswithoutborders.org/', 'https://example.com/dwb-banner.jpg'),
(2, 2, 'The Nature Conservancy', 'Conserving lands and waters on which all life depends.', 'The Nature Conservancy is a global environmental nonprofit working to create a world where people and nature can thrive.', 'info@nature.org', 'https://www.nature.org/', 'https://example.com/nature-conservancy-banner.jpg'),
(3, 3, 'Feeding America', 'Helping to end hunger in the U.S.', 'Feeding America is the nation’s largest domestic hunger-relief organization, working to connect people with food and end hunger.', 'info@feedingamerica.org', 'https://www.feedingamerica.org/', 'https://example.com/feeding-america-banner.jpg'),
(4, 4, 'Amnesty International', 'Fighting against human rights abuses worldwide.', 'Amnesty International works to protect people wherever justice, freedom, truth, and dignity are denied.', 'contactus@amnesty.org', 'https://www.amnesty.org/', 'https://example.com/amnesty-international-banner.jpg'),
(5, 5, 'Habitat for Humanity', 'Building homes and communities for those in need.', 'Habitat for Humanity is a nonprofit organization that helps families build and improve places to call home.', 'info@habitat.org', 'https://www.habitat.org/', 'https://example.com/habitat-for-humanity-banner.jpg');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `favorites`
--
ALTER TABLE `favorites`
  ADD PRIMARY KEY (`id`),
  ADD KEY `favorite_organization` (`favorite_organization_id`);

--
-- Indexes for table `organizations`
--
ALTER TABLE `organizations`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `favorites`
--
ALTER TABLE `favorites`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `organizations`
--
ALTER TABLE `organizations`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
