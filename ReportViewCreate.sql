USE [Market]
GO

CREATE VIEW ReportView AS 
WITH Return_Sales ([date2],[direction2], [cnt2], [summ2])
AS
(
	SELECT DATEADD(DAY, DATEDIFF(DAY, 0, [datetime]), 0) AS [date], [direction] ,COUNT(*) AS [cnt], SUM([summ]) AS [summ] FROM [Market].[dbo].[check_head]
	GROUP BY direction, DATEADD(DAY, DATEDIFF(DAY, 0, [datetime]), 0) HAVING [direction] < 0
),
Buy_Sales ([date1],[direction1], [cnt1], [summ1])
AS
(
	select DATEADD(DAY, DATEDIFF(DAY, 0, [datetime]), 0) AS [date], [direction] ,COUNT(*) AS [cnt], SUM([summ]) AS [summ] FROM [Market].[dbo].[check_head]
	GROUP BY direction, DATEADD(DAY, DATEDIFF(DAY, 0, [datetime]), 0) HAVING [direction] >= 0
)

select 
	CAST(ROW_NUMBER() OVER(ORDER BY buy.[date1] , ret.[date2]) AS INT) AS [id],
	buy.[date1] AS [dateBuy], 
	buy.[summ1] AS [summBuy], 
	ret.[date2] AS [dateReturn], 
	ret.[summ2] AS [summReturn]
FROM Buy_Sales buy
FULL OUTER JOIN Return_Sales ret ON buy.[date1] = ret.[date2]