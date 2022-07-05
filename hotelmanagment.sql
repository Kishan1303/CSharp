-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 05, 2022 at 08:47 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.4.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotelmanagment`
--

-- --------------------------------------------------------

--
-- Table structure for table `bookinginfo`
--

CREATE TABLE `bookinginfo` (
  `id` int(255) NOT NULL,
  `c_name` varchar(100) NOT NULL,
  `c_num` int(255) NOT NULL,
  `C_Age` int(255) NOT NULL,
  `C_TotalMember` int(255) NOT NULL,
  `C_AdharCardNumber` int(255) NOT NULL,
  `C_Paid` int(255) NOT NULL,
  `C_Remaining` int(255) NOT NULL,
  `C_TotalBill` int(255) NOT NULL,
  `gst` int(255) NOT NULL,
  `C_DateOfArrival` varchar(100) NOT NULL,
  `C_DateOfCheckOut` varchar(100) NOT NULL,
  `roomno` int(255) NOT NULL,
  `catagory` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bookinginfo`
--

INSERT INTO `bookinginfo` (`id`, `c_name`, `c_num`, `C_Age`, `C_TotalMember`, `C_AdharCardNumber`, `C_Paid`, `C_Remaining`, `C_TotalBill`, `gst`, `C_DateOfArrival`, `C_DateOfCheckOut`, `roomno`, `catagory`) VALUES
(9, 'prakash', 15649825, 18, 1, 1, 0, 4480, 4480, 480, '05-07-2022', '07-07-2022', 301, 'Suite');

-- --------------------------------------------------------

--
-- Table structure for table `catagory`
--

CREATE TABLE `catagory` (
  `id` int(255) NOT NULL,
  `catname` varchar(100) NOT NULL,
  `catimage` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `catagory`
--

INSERT INTO `catagory` (`id`, `catname`, `catimage`) VALUES
(1, 'Single', 'C:\\Users\\erkis\\Pictures\\Cash-Deposit-ATM-Machine-1200x900.jpg'),
(2, 'Double', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg'),
(4, 'Suite', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `income`
--

CREATE TABLE `income` (
  `id` int(255) NOT NULL,
  `name` varchar(100) NOT NULL,
  `date` varchar(100) NOT NULL,
  `amount` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `income`
--

INSERT INTO `income` (`id`, `name`, `date`, `amount`) VALUES
(1, 'a', '27-06-2022', 1000),
(2, 'k', '30-06-2022', 2240),
(5, 'p', '30-06-2022', 2240),
(6, 'm', '03-07-2022', 2800),
(7, 'kishan', '08-07-2022', 8960);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id` int(255) NOT NULL,
  `name` varchar(100) NOT NULL,
  `email` varchar(200) NOT NULL,
  `password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `rooms`
--

CREATE TABLE `rooms` (
  `rno` int(100) NOT NULL,
  `status` varchar(100) NOT NULL,
  `catagory` varchar(100) NOT NULL,
  `doa` varchar(100) NOT NULL,
  `doc` varchar(100) NOT NULL,
  `rtype` varchar(100) NOT NULL,
  `image` varchar(500) NOT NULL,
  `amount` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rooms`
--

INSERT INTO `rooms` (`rno`, `status`, `catagory`, `doa`, `doc`, `rtype`, `image`, `amount`) VALUES
(101, 'Available', 'Single', '', '', 'ac', 'C:\\Users\\erkis\\Pictures\\room.jpg', 1000),
(102, 'Available', 'Single', '', '', 'ac', 'C:\\Users\\erkis\\Pictures\\room.jpg', 1000),
(103, 'Available', 'Single', '', '', 'non-ac', 'C:\\Users\\erkis\\Pictures\\room.jpg', 500),
(104, 'Available', 'Single', '', '', 'non-ac', 'C:\\Users\\erkis\\Pictures\\room.jpg', 500),
(201, 'Available ', 'Double', '', '', 'ac', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg', 1000),
(202, 'Available', 'Double', '', '', 'ac', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg', 1000),
(105, 'Available ', 'Single', '', '', 'non-ac', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg', 500),
(106, 'Available ', 'Single', '', '', 'non-ac', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg', 500),
(107, 'Available ', 'Single', '', '', 'non-ac', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg', 500),
(108, 'Available ', 'Single', '', '', 'ac', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg', 1000),
(109, 'Available', 'Single', '', '', 'ac', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg', 1000),
(110, 'Available ', 'Single', '', '', 'ac', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg', 1000),
(203, 'Available ', 'Double', '', '', 'ac', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg', 1000),
(204, 'Available ', 'Double', '', '', 'ac', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg', 1000),
(205, 'Available ', 'Double', '', '', 'ac', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg', 1000),
(206, 'Available ', 'Double', '', '', 'non-ac', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg', 500),
(207, 'Available ', 'Double', '', '', 'non-ac', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg', 500),
(208, 'Available ', 'Double', '', '', 'non-ac', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg', 500),
(209, 'Available ', 'Double', '', '', 'non-ac', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg', 500),
(210, 'Available ', 'Double', '', '', 'non-ac', 'C:\\\\Users\\\\erkis\\\\Pictures\\\\room.jpg', 500),
(301, 'Unavailable', 'Suite', '05-07-2022', '07-07-2022', 'ac', 'D:\\BCA\\Sem 4\\CSharp\\Project\\Hotel Managment\\Hotel Managment\\bin\\staffimages\\aatman.jpg', 2000),
(302, 'Available', 'Suite', '', '', 'ac', 'D:\\BCA\\Sem 4\\CSharp\\Project\\Hotel Managment\\Hotel Managment\\bin\\staffimages\\aatman.jpg', 2000);

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `id` int(255) NOT NULL,
  `name` varchar(100) NOT NULL,
  `email` varchar(200) NOT NULL,
  `number` int(11) NOT NULL,
  `age` int(255) NOT NULL,
  `designation` varchar(100) NOT NULL,
  `img` varchar(500) NOT NULL,
  `gender` varchar(15) NOT NULL,
  `jod` varchar(50) NOT NULL,
  `salary` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`id`, `name`, `email`, `number`, `age`, `designation`, `img`, `gender`, `jod`, `salary`) VALUES
(2, 'aatman', 'a@gmail.com', 123456789, 20, 'Receptionist', '..\\staffimages\\aatman.jpg', 'male', '05-07-20', 5000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bookinginfo`
--
ALTER TABLE `bookinginfo`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `catagory`
--
ALTER TABLE `catagory`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `income`
--
ALTER TABLE `income`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bookinginfo`
--
ALTER TABLE `bookinginfo`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `catagory`
--
ALTER TABLE `catagory`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `income`
--
ALTER TABLE `income`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
