SELECT DISTINCT GameId FROM Stats WHERE PlayerId = 1011 AND StartingXI = 1 AND LeagueId = 1
/*Games, where Jani Bäckman have started*/
SELECT ResultCode FROM Game WHERE Id IN (SELECT DISTINCT GameId FROM Stats WHERE PlayerId = 1011 AND StartingXI = 1 AND LeagueId = 1)




SELECT DISTINCT GameId FROM Stats WHERE GameId NOT IN (SELECT DISTINCT GameId FROM Stats WHERE PlayerId = 1011 AND StartingXI = 1 AND LeagueId = 1) AND LeagueId = 1 AND GameId != 0
/*Games, where Bäckman have not started*/
SELECT ResultCode FROM Game WHERE Id IN (SELECT DISTINCT GameId FROM Stats WHERE GameId NOT IN (SELECT DISTINCT GameId FROM Stats WHERE PlayerId = 1011 AND StartingXI = 1 AND LeagueId = 1) AND LeagueId = 1 AND GameId != 0)

/*BÄRI AVAUKSESSA:*/
SELECT ResultCode, COUNT(ResultCode) FROM (SELECT ResultCode FROM Game WHERE Id IN (SELECT DISTINCT GameId FROM Stats WHERE PlayerId = 1011 AND StartingXI = 1 AND LeagueId = 1)
) AS ResultCode GROUP BY ResultCode
/*BÄRI EI AVAUKSESSa*/
SELECT ResultCode, COUNT(ResultCode) FROM (SELECT ResultCode FROM Game WHERE Id IN (SELECT DISTINCT GameId FROM Stats WHERE GameId NOT IN (SELECT DISTINCT GameId FROM Stats WHERE PlayerId = 1011 AND StartingXI = 1 AND LeagueId = 1) AND LeagueId = 1 AND GameId != 0)) AS ResultCode GROUP BY ResultCode