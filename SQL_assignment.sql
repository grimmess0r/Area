USE [Mindbox Test]
SELECT C.Name, P.Name
FROM Records as R
LEFT JOIN Category as C
ON R.CategoryID = C.ID
JOIN Product as P
ON R.ProductID = P.ID
