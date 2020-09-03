SELECT COUNT(*) AS 'Kahden maalin ottelut', P.FirstName, P.LastName 
FROM Stats S JOIN Player P ON S.PlayerId = P.Id
WHERE Goals IN (2) AND LeagueId IN (1)
GROUP BY S.PlayerId, P.FirstName, P.LastName
ORDER BY COUNT(*) DESC

SELECT TOP 5 SUM(S.Goals), P.FirstName, P.LastName
FROM Stats S JOIN Player P ON S.PlayerId = P.Id
WHERE S.LeagueId = 1
GROUP BY S.PlayerId, P.FirstName, P.LastName
ORDER BY SUM(S.Goals) DESC
