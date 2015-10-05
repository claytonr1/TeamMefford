
CREATE DATABASE `RuffCo_`;

USE RuffCo_;
CREATE TABLE `planes` (
  `plane_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(20) NOT NULL,
  `model` varchar(20) DEFAULT NULL,
  `capacity` int(11) NOT NULL,
  `mile_range` int(11) NOT NULL,
  `current_location` varchar(40) DEFAULT NULL,
  `cruise_speed` float(2) NOT NULL,
  PRIMARY KEY (`plane_id`),
  UNIQUE KEY `plane_id_UNIQUE` (`plane_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `employees` (
  `employee_id` int(11) NOT NULL AUTO_INCREMENT,
  `f_name` varchar(20) NOT NULL,
  `l_name` varchar(45) NOT NULL,
  `email` varchar(254) NOT NULL,
  `phone` varchar(10) DEFAULT NULL,
  `user_name` varchar(45) NOT NULL,
  `password` longtext NOT NULL,
  PRIMARY KEY (`employee_id`),
  UNIQUE KEY `employee_id_UNIQUE` (`employee_id`),
  UNIQUE KEY `email_UNIQUE` (`email`),
  UNIQUE KEY `user_name_UNIQUE` (`user_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `destinations` (
  `dest_id` int(11) NOT NULL AUTO_INCREMENT,
  `location` varchar(40) NOT NULL,
  `distance_from_LR` float(2) DEFAULT NULL,
  PRIMARY KEY (`dest_id`),
  UNIQUE KEY `dest_id_UNIQUE` (`dest_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `reservations` (
  `reservation_id` int(11) NOT NULL AUTO_INCREMENT,
  `plane_id` int(11) NOT NULL REFERENCES planes(plane_id),
  `employee_id` int(11) NOT NULL REFERENCES employees(employee_id),
  `dest_id` int(11) NOT NULL REFERENCES destinations(dest_id),
  `date` dateTime NOT NULL,
  PRIMARY KEY (`reservation_id`),
  UNIQUE KEY `reservation_id_UNIQUE` (`reservation_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `guests` (
  `guest_id` int(11) NOT NULL AUTO_INCREMENT,
  `f_name` varchar(20) NOT NULL,
  `l_name` varchar(45) NOT NULL,
  `email` varchar(254) NOT NULL,
  `phone` varchar(10) DEFAULT NULL,
  `employee_id` int(11) NOT NULL REFERENCES employees(employee_id),
  PRIMARY KEY (`guest_id`),
  UNIQUE KEY `guest_id_UNIQUE` (`guest_id`),
  UNIQUE KEY `email_UNIQUE` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `ReservationGuestXRef` (
  `XRef_id` int(11) NOT NULL AUTO_INCREMENT,
  `reservation_id` int(11) NOT NULL REFERENCES reservations(reservation_id),
  `guest_id` int(11) NOT NULL REFERENCES guests(guest_id),
  PRIMARY KEY (`XRef_id`),
  UNIQUE KEY `XRef_id_UNIQUE` (`XRef_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Inserting some sample data
INSERT INTO `RuffCo_`.`employees`
(`f_name`,
`l_name`,
`email`,
`phone`,
`user_name`,
`password`)
VALUES 
("Timothy",
"Glore",
"tim@glore.com",
"5555555555",
"timoglor",
"123456"), 
("Tim",
"Glore",
"tim@tim.com",
"5555555555",
"timoglor1",
"123456"), 
("Bob",
"Robert",
"bobr@yahoo.com",
"5011234567",
"bobert",
"123456");

INSERT INTO `RuffCo_`.`destinations`
(`location`,
`distance_from_LR`)
VALUES
("Rapid City South Dakota",
775.53), 
("Charlotte, N.C.",
862.27), 
("Greenville, S.C.",
1104.68), 
("Missoula, Montana",
1399.44);

INSERT INTO `RuffCo_`.`planes`
(`name`,
`model`,
`capacity`,
`mile_range`,
`current_location`,
`cruise_speed`)
VALUES
("Beechjet 400A",
"Beechjet 400A",
8,
1450,
"Little Rock, AR",
449), 
("Challenger 600",
"Challenger 600",
10,
2720,
"Little Rock, AR",
458), 
("Challenger 601",
"Challenger 601",
10,
3500,
"Little Rock, AR",
478), 
("Lear 45",
"Lear 45",
8,
2100,
"Little Rock, AR",
459);

INSERT INTO `RuffCo_`.`guests`
(`f_name`,
`l_name`,
`email`,
`phone`,
`employee_id`)
VALUES
("Mark",
"Morton",
"MasterMorty@yahoo.com",
"5554444555",
1);

INSERT INTO `RuffCo_`.`reservations`
(`plane_id`,
`employee_id`,
`dest_id`,
`date`)
VALUES
(1,
1,
1,
"2015-10-10 12:00:00"), 
(3,
2,
3,
"2015-12-05 12:00:00");

INSERT INTO `RuffCo_`.`ReservationGuestXRef`
(`reservation_id`,
`guest_id`)
VALUES
(1,
1);
