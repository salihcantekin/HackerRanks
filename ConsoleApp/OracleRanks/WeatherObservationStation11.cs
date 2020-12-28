using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.OracleRanks
{
    public class WeatherObservationStation11
    {
        //https://www.hackerrank.com/challenges/weather-observation-station-11/problem

        /*
        
        select distinct city from station
        where 
            substr(lower(city), 0, 1) not in ('a', 'e', 'i', 'o', 'u') 
        OR  substr(lower(city), -1)   not in ('a', 'e', 'i', 'o', 'u');

        */
    }
}
