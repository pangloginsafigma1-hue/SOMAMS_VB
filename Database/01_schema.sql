-- =====================================================================
--  SOMAMS - database structure   (run once in MySQL Workbench)
--  Safe to run again: it only creates what is missing.
-- =====================================================================
CREATE DATABASE IF NOT EXISTS somams_db CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE somams_db;

-- Administrators who can log in (passwords are stored as BCrypt hashes, never as plain text)
CREATE TABLE IF NOT EXISTS admins (
    admin_id      INT AUTO_INCREMENT PRIMARY KEY,
    full_name     VARCHAR(100) NOT NULL,
    username      VARCHAR(50)  NOT NULL UNIQUE,
    email         VARCHAR(100) NOT NULL,
    password_hash VARCHAR(255) NOT NULL,
    photo         LONGBLOB NULL
);

-- Student members. member_id is the Student ID / Membership ID.
CREATE TABLE IF NOT EXISTS members (
    member_id    VARCHAR(20)  PRIMARY KEY,
    student_name VARCHAR(100) NOT NULL,
    course       VARCHAR(50)  NOT NULL,
    year_level   VARCHAR(20)  NOT NULL,
    position     VARCHAR(50)  NOT NULL DEFAULT 'Member',
    status       ENUM('Active','Inactive') NOT NULL DEFAULT 'Active',
    date_joined  DATE NOT NULL
);

-- Organization activities / events
CREATE TABLE IF NOT EXISTS activities (
    activity_id   INT AUTO_INCREMENT PRIMARY KEY,
    activity_name VARCHAR(150) NOT NULL,
    location      VARCHAR(150) NOT NULL,
    activity_date DATE NOT NULL,
    status        VARCHAR(20) NOT NULL DEFAULT 'Upcoming',
    description   TEXT NULL
);

-- Who attended which activity (one row per member per activity)
CREATE TABLE IF NOT EXISTS attendance (
    attendance_id INT AUTO_INCREMENT PRIMARY KEY,
    activity_id   INT NOT NULL,
    member_id     VARCHAR(20) NOT NULL,
    is_present    TINYINT(1) NOT NULL DEFAULT 0,
    UNIQUE KEY uq_activity_member (activity_id, member_id),
    CONSTRAINT fk_att_activity FOREIGN KEY (activity_id) REFERENCES activities(activity_id) ON DELETE CASCADE,
    CONSTRAINT fk_att_member   FOREIGN KEY (member_id)   REFERENCES members(member_id)     ON DELETE CASCADE
);

-- The first administrator (username: admin / password: admin123) is created automatically
-- by the program the first time it starts. Change the password in Settings.
