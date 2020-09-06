-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 06, 2020 at 07:07 PM
-- Server version: 10.1.34-MariaDB
-- PHP Version: 7.2.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `class_test`
--

-- --------------------------------------------------------

--
-- Table structure for table `q_paper`
--

CREATE TABLE `q_paper` (
  `id` int(11) NOT NULL,
  `question` varchar(100) NOT NULL,
  `option_a` varchar(100) NOT NULL,
  `option_b` varchar(100) NOT NULL,
  `option_c` varchar(100) NOT NULL,
  `option_d` varchar(100) NOT NULL,
  `ans` enum('A','B','C','D') NOT NULL,
  `student_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `q_paper`
--

INSERT INTO `q_paper` (`id`, `question`, `option_a`, `option_b`, `option_c`, `option_d`, `ans`, `student_id`) VALUES
(133, 'question', 'optiona', 'optionb', 'optionc', 'opiond', 'C', 4),
(134, 'question', 'optiona', 'optionb', 'optionc', 'opiond', 'D', 4),
(135, 'question', 'optiona', 'optionb', 'optionc', 'opiond', 'D', 4),
(136, 'question', 'optiona', 'optionb', 'optionc', 'opiond', 'B', 4),
(137, 'question', 'optiona', 'optionb', 'optionc', 'opiond', 'C', 4),
(138, 'question', 'optiona', 'optionb', 'optionc', 'opiond', 'D', 4),
(139, 'question', 'optiona', 'optionb', 'optionc', 'opiond', 'D', 8),
(140, 'To get to the ‘Symbol’ dialog box, click on the ______ menu and choose ‘Symbol’', 'Insert', 'Format', 'Tools', 'Table', 'A', 8),
(141, '__ option from clipboard is used to move data from one place to another in a', 'Copy & Paste', 'Cut & Paste', 'Bold', 'Justify', 'B', 8),
(142, '__ is an option in Font Group.', 'Strikethrough', 'Find', 'Replace', 'Change Styles', 'A', 8),
(143, 'From which menu you can insert Header and Footer?', 'Insert Menu', 'View Menu', 'Format menu', 'Tools Menu', 'A', 8),
(144, 'To get to the ‘Symbol’ dialog box, click on the ______ menu and choose ‘Symbol’', 'Insert', 'Format', 'Tools', 'Table', 'A', 8),
(145, '__ option from clipboard is used to move data from one place to another in a', 'Copy & Paste', 'Cut & Paste', 'Bold', 'Justify', 'B', 8),
(146, '__ is an option in Font Group.', 'Strikethrough', 'Find', 'Replace', 'Change Styles', 'A', 8),
(147, 'From which menu you can insert Header and Footer?', 'Insert Menu', 'View Menu', 'Format menu', 'Tools Menu', 'A', 8),
(148, 'To get to the ‘Symbol’ dialog box, click on the ______ menu and choose ‘Symbol’', 'Insert', 'Format', 'Tools', 'Table', 'A', 8),
(149, 'Name the button in the picture?', '. Font Colo', 'Fill Color', 'Page Color', 'Highlighter tool', 'D', 9),
(150, 'Shortcut for document views toolbar is situated in ______ bar.', 'Task bar', 'Status bar', 'Tool bar', '. Title bar', 'B', 9),
(151, 'Bullets and Numbering is in _____ tab.', 'Home tab', 'Insert tab', 'Pagelayout tab', 'View tab', 'A', 9),
(152, 'To open a existing document, click on the ________ and then select Open.', 'MS Office button', 'Quick Access Toolbar', 'Document View', 'Ribbon', 'A', 9),
(153, 'To get to the ‘Symbol’ dialog box, click on the ______ menu and choose ‘Symbol’', 'Insert', 'Format', 'Tools', 'Table', 'A', 9),
(154, 'Name the button in the picture?', '. Font Colo', 'Fill Color', 'Page Color', 'Highlighter tool', 'D', 10),
(155, 'Shortcut for document views toolbar is situated in ______ bar.', 'Task bar', 'Status bar', 'Tool bar', '. Title bar', 'B', 10),
(156, 'Bullets and Numbering is in _____ tab.', 'Home tab', 'Insert tab', 'Pagelayout tab', 'View tab', 'A', 10),
(157, 'To open a existing document, click on the ________ and then select Open.', 'MS Office button', 'Quick Access Toolbar', 'Document View', 'Ribbon', 'A', 10),
(158, 'To get to the ‘Symbol’ dialog box, click on the ______ menu and choose ‘Symbol’', 'Insert', 'Format', 'Tools', 'Table', 'A', 10),
(159, 'what is your name..?', 'sanoth', 'dhh', 'dhh', 'duu', 'A', 10),
(160, 'question', 'optiona', 'optionb', 'optionc', 'opiond', 'B', 10),
(161, 'question', 'optiona', 'optionb', 'optionc', 'opiond', 'C', 10),
(162, 'question', 'optiona', 'optionb', 'optionc', 'opiond', 'D', 10),
(163, 'question', 'optiona', 'optionb', 'optionc', 'opiond', 'D', 10);

-- --------------------------------------------------------

--
-- Table structure for table `student_login`
--

CREATE TABLE `student_login` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `marks` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `student_login`
--

INSERT INTO `student_login` (`id`, `username`, `first_name`, `last_name`, `password`, `email`, `marks`) VALUES
(2, 'sakib', 'nazmus', 'sakib', 'sakib', 'sakib@gmail.com', 3),
(3, 'dvsdvs', 'jkgkjg', 'jgjkgkj', 'jkgkjg', 'jgjkgjkg', NULL),
(4, 'sanoth', 'sanoth', 'debnath', 'sanoth', 'sanoth14@cse.pstu.ac.bd', 2),
(5, 'nayon', 'monir', 'nayon', 'nayon', 'monirpstu1@gmai.com', NULL),
(6, 'nayon', 'monir', 'nayon', 'nayon', 'monirpstu1@gmail.com', NULL),
(7, 'niloy', 'suvro', 'niloy', 'niloy', 'suvronilniloy34045@gmail.com', 2),
(8, 'Sir', 'sir', 'sir', '12345678', 'chinmay.cse@gmail.com', 0),
(9, 'M.sir', 'M.sir', 'sir', '12345678', 'murad98csekuet@gmail.com', 0),
(10, 'ab', 'sanoth', 'debnath', '12345', 'sanothdebnath@gmail.com', 0);

-- --------------------------------------------------------

--
-- Table structure for table `teacher_login`
--

CREATE TABLE `teacher_login` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `teacher_login`
--

INSERT INTO `teacher_login` (`id`, `username`, `password`, `name`) VALUES
(1, 'teacher', '12345', 'Teacher');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `q_paper`
--
ALTER TABLE `q_paper`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `student_login`
--
ALTER TABLE `student_login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `teacher_login`
--
ALTER TABLE `teacher_login`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `q_paper`
--
ALTER TABLE `q_paper`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=164;

--
-- AUTO_INCREMENT for table `student_login`
--
ALTER TABLE `student_login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `teacher_login`
--
ALTER TABLE `teacher_login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
