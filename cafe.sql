-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 25, 2025 at 09:24 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 7.4.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cafe`
--

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `id` int(11) NOT NULL,
  `order_date` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `total_amount` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`id`, `order_date`, `total_amount`) VALUES
(1, '2025-05-21 19:16:34', '3500.00'),
(3, '2025-05-21 19:30:56', '6000.00'),
(4, '2025-05-22 05:10:21', '400.00'),
(5, '2025-05-25 04:41:47', '6900.00'),
(6, '2025-05-25 04:55:34', '1500.00'),
(7, '2025-05-25 04:59:56', '1500.00'),
(8, '2025-05-25 05:08:17', '2000.00'),
(9, '2025-05-25 05:19:46', '800.00'),
(10, '2025-05-25 05:40:36', '5000.00'),
(11, '2025-05-25 05:43:55', '4500.00'),
(12, '2025-05-25 19:06:50', '33000.00');

-- --------------------------------------------------------

--
-- Table structure for table `order_details`
--

CREATE TABLE `order_details` (
  `id` int(11) NOT NULL,
  `order_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `unit_price` decimal(10,2) NOT NULL,
  `total_price` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `order_details`
--

INSERT INTO `order_details` (`id`, `order_id`, `product_id`, `quantity`, `unit_price`, `total_price`) VALUES
(1, 1, 5, 7, '500.00', '3500.00'),
(2, 3, 4, 4, '1500.00', '6000.00'),
(3, 4, 5, 1, '400.00', '400.00'),
(4, 5, 5, 1, '400.00', '400.00'),
(5, 5, 2, 2, '1000.00', '2000.00'),
(9, 8, 2, 2, '1000.00', '2000.00'),
(10, 9, 5, 2, '400.00', '800.00'),
(11, 10, 3, 1, '5000.00', '5000.00'),
(14, 12, 23, 1, '5000.00', '5000.00'),
(15, 12, 26, 3, '4500.00', '13500.00'),
(16, 12, 11, 5, '1500.00', '7500.00'),
(17, 12, 33, 2, '3000.00', '6000.00'),
(18, 12, 20, 1, '1000.00', '1000.00');

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `id` int(11) NOT NULL,
  `name` varchar(250) NOT NULL,
  `categories` varchar(250) NOT NULL,
  `price` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`id`, `name`, `categories`, `price`) VALUES
(2, 'tea', 'hot drinks', 1000),
(3, 'chocolate', 'Cheese Cake', 5000),
(4, 'regular', 'Donut', 1500),
(5, 'cheese ', 'Sandwich', 400),
(7, 'cofee', 'Hot drinks', 2000),
(8, 'lemon juice', 'Juices', 500),
(9, 'Espresso', 'Hot drinks', 2000),
(10, 'Cappuccino', 'Hot drinks', 2500),
(11, 'Iced Coffee', 'Ice drinks', 1500),
(12, 'Iced Latte', 'Ice drinks', 2500),
(13, 'Strawberry Cheesecake', 'Cheese Cake', 3000),
(14, 'Blueberry Cheesecake', 'Cheese Cake', 4000),
(15, 'Chocolate Cheesecake', 'Cheese Cake', 3500),
(16, 'Cheese Croissant', 'Croissant', 2000),
(17, 'Chocolate Croissant', 'Croissant', 1000),
(18, 'Zaatar Croissant', 'Croissant', 1000),
(19, 'Custard-filled Donut', 'Donut', 3000),
(20, 'Strawberry Donut', 'Donut', 1000),
(21, 'Egg & Cheese Sandwich', 'Sandwich', 500),
(22, 'Tuna Sandwich', 'Sandwich', 2000),
(23, 'Grilled Chicken Sandwich', 'Sandwich', 5000),
(24, 'Spinach Pie', 'Pastries', 2000),
(25, 'Cheese Pie', 'Pastries', 2200),
(26, 'Meat Pie', 'Pastries', 4500),
(27, 'Mini Pizza', 'Pastries', 400),
(28, 'Watermelon Juice', 'Juices', 500),
(29, 'Apple Juice', 'Juices', 300),
(30, 'Mango Juice', 'Juices', 700),
(31, 'Orange Juice', 'Juices', 500),
(32, 'Vanilla Cake', 'Cakes', 1000),
(33, 'Chocolate Cake', 'Cakes', 3000),
(34, 'Strawberry cake', 'Cakes', 3000);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `name` varchar(250) NOT NULL,
  `passwrd` varchar(250) NOT NULL,
  `role` enum('Admin','user') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `name`, `passwrd`, `role`) VALUES
(1, 'manar', '123', 'Admin'),
(2, 'huda', '123', 'Admin'),
(3, 'noha', '123', 'Admin'),
(4, 'wala\'a', '123', 'Admin'),
(5, 'Noor', '123', 'user');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `order_details`
--
ALTER TABLE `order_details`
  ADD PRIMARY KEY (`id`),
  ADD KEY `order_details_ibfk_1` (`order_id`),
  ADD KEY `order_details_ibfk_2` (`product_id`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `order_details`
--
ALTER TABLE `order_details`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `order_details`
--
ALTER TABLE `order_details`
  ADD CONSTRAINT `order_details_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `order_details_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `products` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
