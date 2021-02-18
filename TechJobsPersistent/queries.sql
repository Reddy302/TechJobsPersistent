--Part 1
EmployerId INT,
Id INT,
Name LONGTEXT

--Part 2
SELECT name
FROM employers
WHERE location= "St. Louis City";

--Part 3
SELECT Name, Description
FROM skills
INNER JOIN jobskills ON jobskills.skillid = skills.id
ORDER BY name ASC;
