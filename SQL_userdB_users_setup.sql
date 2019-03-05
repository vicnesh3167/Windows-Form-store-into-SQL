SHOW DATABASES;
CREATE DATABASE userdB;
USE userdB;

CREATE TABLE users (
	userName VARCHAR(100),
    userPhone VARCHAR(10),
    userEmail VARCHAR(100)
);

DESC users;

INSERT INTO users(userName,userPhone,userEmail) VALUES
	('tim','3034542118','tim23@gmail.com'),
    ('jenny','4053125432','jennyg@yahoo.com');
    
SELECT * FROM users;