using System;
using System.Threading.Tasks;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.SummonerV4;

namespace MingweiSamuel.Camille.Entity
{
    public class SummonerEntity
    {
        private readonly Lazy<Task<string>> _id;
        private readonly Lazy<Task<string>> _id;
        private readonly Lazy<Task<Summoner>> _summoner;


        public struct Key
        {
            public readonly Region Region;
            public readonly string SummonerId;

            public Key(string summonerId, Region region)
            {
                SummonerId = summonerId;
                Region = region;
            }
        }
    }
}
