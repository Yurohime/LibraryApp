DROP DATABASE IF EXISTS db_library;
Create database if not exists db_library;

use db_library;

CREATE TABLE `users` (
    `userid` VARCHAR(50) PRIMARY KEY not null,
    `userpassword` varchar(50),
    `username` varchar(50),
    `userphone` varchar(50),
    `userrole` varchar(1),
    `status_del` bool default false
);

-- Condition
-- G = Good
-- U = Unavailable/Out of Commision/Broken

CREATE TABLE `books`(
	`bookid` varchar(50) PRIMARY KEY not null,
    `bookmarker` varchar(30),
    `booktitle` text,
    `bookauthor` text,
    `bookyear` int,
    `bookcondition` varchar(1) default 'G'
);

CREATE TABLE `loanDetail`(
    `userid` varchar(50),
    `bookid` varchar(50),
    `dateborrow` date,
    `datereturn` date,
    CONSTRAINT FK_userid FOREIGN KEY (userid) REFERENCES users(userid)
);

INSERT INTO `users` (userid,userpassword,username,userrole,userphone) VALUES
('admin','admin','admin','S','035778834242'),
('M0000001','john','john','M','098883422'),
('M0000002','bob123','bob','M','0435354353'),
('M0000003','dunno','funniguy','M','0883666482');

INSERT INTO `books` (bookid, bookmarker, booktitle, bookauthor, bookyear, bookcondition) VALUES
(1, 'JC20150001', 'The Silent Forest', 'John Carter', 2015,'G'),
(2, 'SN20180001', 'Echoes of Tomorrow', 'Sarah Nguyen', 2018,'G'),
(3, 'MT20210001', 'Code and Logic', 'Michael Tan', 2021,'G'),
(4, 'ES20120001', 'Midnight Archive', 'Emily Stone', 2012,'G'),
(5, 'RM20200001', 'Beyond the Horizon', 'Robert Miles', 2020,'G'),
(6, 'RM20200002', 'Death from Above', 'Robert Miles', 2020,'U');

INSERT INTO `loanDetail` (userid, bookid, dateborrow, datereturn) VALUES
('M0000001', 1, '2025-01-05', '2025-01-12'),
('M0000003', 2, '2026-01-01', null),
('M0000001', 3, '2026-01-9', null);

-- ////// FOR MY DYSLEXIA //////

DELIMITER $$

CREATE PROCEDURE getBookLoanStatus(
    IN p_title  TEXT,
    IN p_author TEXT,
    IN p_year   INT
)
BEGIN
    SELECT 
        b.booktitle  AS 'Book Title', 
        b.bookauthor AS 'Book Author',
        b.bookyear   AS 'Year',
        CASE
            WHEN ld.bookid IS NULL
                THEN 'Available'
			WHEN ld.datereturn IS NOT NULL
				THEN 'Available'
            WHEN ld.datereturn IS NULL 
                 AND DATEDIFF(CURDATE(), ld.dateborrow) > 7
                THEN 'Missing'
            WHEN ld.datereturn IS NULL
                THEN 'Borrowed'
            ELSE 'Available'
        END AS 'Loan Status'
    FROM books b
    LEFT JOIN loanDetail ld
        ON b.bookid = ld.bookid
    WHERE
		b.bookcondition = 'G'
		AND
        (p_title  IS NULL OR p_title  = '' OR b.booktitle  LIKE CONCAT('%', p_title,  '%'))
        AND
        (p_author IS NULL OR p_author = '' OR b.bookauthor LIKE CONCAT('%', p_author, '%'))
        AND
        (p_year   IS NULL OR b.bookyear = p_year);
END$$

DELIMITER ;

-- ////// FOR MY DYSLEXIA //////

DELIMITER $$

CREATE PROCEDURE getMembersByUsername(
    IN p_username VARCHAR(50)
)
BEGIN
    SELECT 
        userid,
        username,
        userphone,
        status_del AS 'Status'
    FROM users
    WHERE userrole = 'M'
      AND status_del = 0
      AND (
            p_username IS NULL 
            OR p_username = '' 
            OR username LIKE CONCAT('%', p_username, '%')
          );
END$$

DELIMITER ;

-- ////// FOR MY DYSLEXIA //////

DELIMITER $$

CREATE PROCEDURE getAvailableBooks(
    IN p_title TEXT
)
BEGIN
    SELECT 
        b.bookid,
        b.booktitle as 'Book Title',
        b.bookmarker as 'Book Marker'
    FROM books b
    LEFT JOIN loanDetail ld
        ON b.bookid = ld.bookid
       AND NOT EXISTS (
            SELECT 1
            FROM loanDetail ld2
            WHERE ld2.bookid = ld.bookid
              AND ld2.dateborrow > ld.dateborrow
       )
    WHERE
        b.bookcondition = 'G'
        AND (
            ld.bookid IS NULL
            OR ld.datereturn IS NOT NULL
        )
        AND (
            p_title IS NULL
            OR p_title = ''
            OR b.booktitle LIKE CONCAT('%', p_title, '%')
        );
END$$

DELIMITER ;

-- ////// FOR MY DYSLEXIA //////

DELIMITER $$

CREATE PROCEDURE getUserHistory(
    IN p_userid VARCHAR(15)
)
BEGIN
    SELECT 
    b.bookid,
        CASE
            WHEN ld.datereturn IS NOT NULL
            AND DATEDIFF(ld.datereturn, ld.dateborrow) <= 7
                THEN 'Returned'
            WHEN ld.datereturn IS NULL 
                 AND DATEDIFF(CURDATE(), ld.dateborrow) > 7
                THEN 'Overdue'
            WHEN ld.datereturn IS NULL
                THEN 'Borrowed'
			WHEN ld.datereturn IS NOT NULL
				AND DATEDIFF(ld.datereturn, ld.dateborrow) > 7
                THEN 'Returned Late'
            ELSE '-'
        END AS 'Status',
        b.booktitle AS 'Book Title',
        ld.dateborrow AS 'Lend Date',
        IF(ld.datereturn IS NULL, '-', ld.datereturn) AS 'Return Date'
    FROM loanDetail ld
    JOIN books b
        ON ld.bookid = b.bookid
    WHERE ld.userid = p_userid
    ORDER BY ld.dateborrow DESC;
END$$

DELIMITER ;

-- ////// FOR MY DYSLEXIA //////

DELIMITER $$

CREATE PROCEDURE getBooksByMarker(
    IN p_bookmarker VARCHAR(30)
)
BEGIN
    SELECT 
        b.bookid,
        b.bookmarker as "Book Marker",
        b.booktitle as "Book Title",
        b.bookauthor as "Author",
        b.bookyear as "Year",
        CASE
            WHEN ld.bookid IS NULL THEN 'Available'
            WHEN ld.datereturn IS NULL THEN 'Borrowed'
            ELSE 'Available'
        END AS `Status`
    FROM books b
    LEFT JOIN loanDetail ld
        ON b.bookid = ld.bookid
       AND NOT EXISTS (
            SELECT 1
            FROM loanDetail ld2
            WHERE ld2.bookid = ld.bookid
              AND ld2.dateborrow > ld.dateborrow
       )
    WHERE
        b.bookcondition = 'G'
        AND (
            p_bookmarker IS NULL
            OR p_bookmarker = ''
            OR b.bookmarker LIKE CONCAT('%', p_bookmarker, '%')
        );
END$$

DELIMITER ;

-- ////// FOR MY DYSLEXIA //////

DELIMITER $$

CREATE PROCEDURE getUsers(
    IN p_username VARCHAR(50)
)
BEGIN
    SELECT
        userid    AS 'User ID',
        username  AS 'Username',
        userpassword AS 'Password',
        userphone AS 'User Phone',
        CASE
            WHEN userrole = 'S' THEN 'Staff'
            WHEN userrole = 'M' THEN 'Member'
            ELSE 'Unknown'
        END       AS 'Role'
    FROM users
    WHERE status_del = 0
      AND (
            p_username IS NULL
            OR p_username = ''
            OR username LIKE CONCAT('%', p_username, '%')
          );
END$$

DELIMITER ;















