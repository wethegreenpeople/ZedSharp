using System;
using System.Collections.Generic;
using System.Text;
using ZedSharp.Helpers;
using System.Threading.Tasks;
using RestSharp;
using ZedSharp.Models;
using System.Linq;

namespace ZedSharp.Clients
{
    public class RaceClient
    {
        public async Task<List<Race>> GetLatestRaces(int resultsAmount)
        {
            var query = @"query{
        get_race_results(first:" + resultsAmount + @", input: {only_my_racehorses: false}) {
            edges {
            cursor
            node {
            country
            country_code
            city
            name
            length
            start_time
            fee
            race_id
            weather
            status
            class
            prize_pool {
                first
                second
                third
                total 
                }
            horses {
                horse_id 
                finish_time
                final_position
                name
                gate
                owner_address
                bloodline
                gender
                breed_type
                gen
                races
                coat
                win_rate
                career
                hex_color
                img_url
                class
                stable_name 
                } 
            }
            } 
            page_info {
                end_cursor
                has_next_page
            }
         }
            
        }";

            var client = new RestClient("https://zed-ql.zed.run/graphql");
            var request = new RestRequest(Method.POST);
            request.AddParameter("query", query, "application/json", ParameterType.RequestBody);

            var races = (await client.ExecutePostAsync<Root>(request))
                .Data
                .Data
                .GetRaceResults
                .Edges
                .Select(s => s.Node);

            return races.ToList();
        }
    }
}
