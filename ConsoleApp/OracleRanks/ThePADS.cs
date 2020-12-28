using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.OracleRanks
{
    public class ThePADS
    {
        // https://www.hackerrank.com/challenges/the-pads/problem

        /*
        
        SELECT * FROM (SELECT a.name || '(' || SUBSTR (a.occupation, 0, 1) || ')'
          FROM occupations a ORDER BY a.NAME) a
        UNION ALL
          SELECT * from (SELECT 'There are a total of ' || COUNT (0) || ' ' || LOWER (b.occupation) || 's.'
            FROM occupations b 
        GROUP BY b.occupation ORDER BY 1);

        */
    }
}
