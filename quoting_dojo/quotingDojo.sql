/* Read function that displays all current users information when the app starts and after every insert*/
SELECT idUsers, FirstName, LastName, FavoriteNumber FROM Users;

/*"create" function that accepts input and creates a new User row*/
INSERT INTO Users (FirstName, LastName, FavoriteNumber) VALUES ("Jamison", "Crowder", "80");


DELETE FROM Users WHERE idUsers = 7;

SELECT idquotes, name, quote, created_at FROM quotes;

INSERT INTO quotes (name, quote, created_at) VALUES ("Rob", "HTTR all the way", now());