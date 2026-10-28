-- =====================================================================
--  SOMAMS - sample data for the presentation / defense
--  Run AFTER 01_schema.sql. Safe to run again (it skips rows that already exist).
--  All names are made-up. Dates are relative to today, so "Upcoming" is always upcoming.
-- =====================================================================
USE somams_db;

INSERT IGNORE INTO members (member_id, student_name, course, year_level, position, status, date_joined) VALUES
('2023-0001','Juan Dela Cruz',      'BSIT','3rd Year','President',                  'Active',  CURDATE() - INTERVAL 400 DAY),
('2023-0002','Maria Santos',        'BSCS','3rd Year','Vice President',             'Active',  CURDATE() - INTERVAL 400 DAY),
('2023-0003','Jose Reyes',          'BSIS','3rd Year','Secretary',                  'Active',  CURDATE() - INTERVAL 390 DAY),
('2023-0004','Ana Villanueva',      'BSIT','3rd Year','Treasurer',                  'Active',  CURDATE() - INTERVAL 390 DAY),
('2023-0005','Mark Bautista',       'BSCS','3rd Year','Auditor',                    'Active',  CURDATE() - INTERVAL 385 DAY),
('2024-0006','Grace Mendoza',       'BSIT','2nd Year','Public Information Officer', 'Active',  CURDATE() - INTERVAL 300 DAY),
('2024-0007','Paolo Garcia',        'BSCS','2nd Year','Representative',             'Active',  CURDATE() - INTERVAL 300 DAY),
('2024-0008','Angela Ramos',        'BSIS','2nd Year','Member',                     'Active',  CURDATE() - INTERVAL 290 DAY),
('2024-0009','Carlo Torres',        'BSIT','2nd Year','Member',                     'Active',  CURDATE() - INTERVAL 290 DAY),
('2024-0010','Bianca Flores',       'BSCS','2nd Year','Member',                     'Active',  CURDATE() - INTERVAL 280 DAY),
('2024-0011','Miguel Castillo',     'BSIS','2nd Year','Member',                     'Active',  CURDATE() - INTERVAL 280 DAY),
('2024-0012','Sofia Navarro',       'BSIT','2nd Year','Member',                     'Inactive',CURDATE() - INTERVAL 270 DAY),
('2025-0013','Daniel Aquino',       'BSCS','1st Year','Member',                     'Active',  CURDATE() - INTERVAL 150 DAY),
('2025-0014','Patricia Domingo',    'BSIT','1st Year','Member',                     'Active',  CURDATE() - INTERVAL 150 DAY),
('2025-0015','Kevin Salazar',       'BSIS','1st Year','Member',                     'Active',  CURDATE() - INTERVAL 140 DAY),
('2025-0016','Hannah Pascual',      'BSCS','1st Year','Member',                     'Active',  CURDATE() - INTERVAL 140 DAY),
('2025-0017','Ryan Ocampo',         'BSIT','1st Year','Member',                     'Inactive',CURDATE() - INTERVAL 130 DAY),
('2025-0018','Isabel Cortez',       'BSIS','1st Year','Member',                     'Active',  CURDATE() - INTERVAL 120 DAY),
('2025-0019','Nathan Lim',          'BSCS','1st Year','Member',                     'Active',  CURDATE() - INTERVAL 120 DAY),
('2025-0020','Chloe Fernandez',     'BSIT','1st Year','Member',                     'Inactive',CURDATE() - INTERVAL 110 DAY);

-- Activities (only inserted when the table is empty, so running the script twice does not duplicate them)
INSERT INTO activities (activity_name, location, activity_date, status, description)
SELECT seed.* FROM (
  SELECT 'Orientation and Membership Drive' AS activity_name, 'CCS Audio-Visual Room' AS location, CURDATE() - INTERVAL 60 DAY AS activity_date, 'Completed' AS status, 'Welcome program for new student members.' AS description
  UNION ALL SELECT 'Programming Workshop',      'Computer Laboratory 2',   CURDATE() - INTERVAL 30 DAY, 'Completed', 'Hands-on workshop on VB.NET and MySQL.'
  UNION ALL SELECT 'General Assembly',          'University Gymnasium',    CURDATE() + INTERVAL 7 DAY,  'Upcoming',  'Semester general assembly and election of committee heads.'
  UNION ALL SELECT 'Tech Quiz Bee',             'Lecture Hall 1',          CURDATE() + INTERVAL 21 DAY, 'Upcoming',  'Inter-class quiz bee on programming and IT trivia.'
  UNION ALL SELECT 'Community Outreach',        'Barangay Covered Court',  CURDATE() + INTERVAL 45 DAY, 'Upcoming',  'Free computer basics seminar for the community.'
) AS seed
CROSS JOIN (SELECT COUNT(*) AS c FROM activities) AS chk
WHERE chk.c = 0;

-- Attendance for the two completed activities (about 4 out of 5 active members present)
INSERT IGNORE INTO attendance (activity_id, member_id, is_present)
SELECT a.activity_id, m.member_id, IF(CRC32(CONCAT(m.member_id, a.activity_id)) % 5 = 0, 0, 1)
FROM activities a CROSS JOIN members m
WHERE a.status = 'Completed' AND m.status = 'Active';
