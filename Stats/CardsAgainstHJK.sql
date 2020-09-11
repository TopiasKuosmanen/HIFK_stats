SELECT P.LastName, SUM(S.YellowCards) AS 'Yellows', SUM(S.RedCards) AS 'Reds' FROM Stats S JOIN Player p ON S.PlayerId = p.Id
WHERE GameId IN
(SELECT Id FROM Game WHERE OpponentId = 1 AND SERIE = 'Veikkausliiga' AND Result IS NOT NULL)
GROUP BY P.LastName
ORDER BY SUM(YellowCards) DESC, SUM(RedCards) DESC
