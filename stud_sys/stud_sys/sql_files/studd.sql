USE [first_db]
GO

/****** Object:  StoredProcedure [dbo].[Stud_Proc]    Script Date: 25-02-2018 14:19:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Stud_Procedures]
@STARTDATE  DATETIME,
@ENDDATE    DATETIME,
@User_Id bigint
AS BEGIN
declare @UserId Bigint



--Now generate dates between two dates by Common table expression . and store that values in one temporary table (#TMP_DATES) .
;WITH DATERANGE  AS
(
  SELECT DT =DATEADD(DD,0, @STARTDATE)
  WHERE DATEADD(DD, 1, @STARTDATE) <= @ENDDATE
  UNION ALL
  SELECT DATEADD(DD, 1, DT)
  FROM DATERANGE
  WHERE DATEADD(DD, 1, DT) <= @ENDDATE
)
SELECT * INTO #TMP_DATES
FROM DATERANGE


--As the Report columns (Dates) are dynamic ,  hence Columns (Dates) are concatenated   one by one  from Temporary table (#TMP_DATES) and store the value in a local variable . 
DECLARE @COLUMN VARCHAR(MAX)
SELECT @COLUMN=ISNULL(@COLUMN+',','')+ '['+ CAST(CONVERT(DATE , T.DT) AS VARCHAR) + ']'  FROM #TMP_DATES T

--After Pivot , some columns may be Null as data (here PRESENT_STATUS) not exists in pivot section    .Now  replace the Null values by 'N/A'  .

DECLARE @Columns2 VARCHAR(MAX)
SET @Columns2 = SUBSTRING((SELECT DISTINCT ',ISNULL(['+ CAST(CONVERT(DATE , DT) as varchar )+'],''A'') AS ['+CAST(CONVERT(DATE , DT) as varchar )+']' FROM #TMP_DATES GROUP BY dt FOR XML PATH('')),2,8000)

--Now declare one local variable to write the dynamic sql query .
DECLARE @QUERY VARCHAR(MAX)

--Here Right outer join is done to show the all dates from the temporary table

SET @QUERY = 'SELECT User_Id, ' + @Columns2  +'FROM
            (
                  SELECT  B.DT AS DATE, A.STATUS FROM MarkA A where User_Id=@UserId RIGHT OUTER  JOIN #TMP_DATES B ON A.DATE=B.DT              
           ) X where User_Id=@User_Id 
            PIVOT
            (
                 MIN([STATUS])
                 FOR [DATE] IN (' + @COLUMN + ')
            ) P
            WHERE ISNULL(User_Id,'''')<>''''
            '

 EXEC (@QUERY)

 --Drop the  temporary table
      DROP TABLE #TMP_DATES
     
 END


GO


