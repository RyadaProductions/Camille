using System;
using System.Linq;
using MingweiSamuel.Camille.Util;

namespace MingweiSamuel.Camille.Entity
{
    public class SummonerMatchlistQuery : IEquatable<SummonerMatchlistQuery>
    {
        public readonly int[] Queue;
        public readonly int[] Champion;
        public readonly int[] Season;
        public readonly long? BeginTime;
        public readonly long? EndTime;
        public readonly int? BeginIndex;

        public SummonerMatchlistQuery(int[] queue = null, int[] champion = null, int[] season = null,
            long? beginTime = null, long? endTime = null, int? beginIndex = null)
        {
            Queue = queue;
            Champion = champion;
            Season = season;
            BeginTime = beginTime;
            EndTime = endTime;
            BeginIndex = beginIndex;
        }

        public bool Equals(SummonerMatchlistQuery other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return SequenceEquality.SequenceEqualNullAsEmpty(Queue, other.Queue)
                   && SequenceEquality.SequenceEqualNullAsEmpty(Champion, other.Champion)
                   && SequenceEquality.SequenceEqualNullAsEmpty(Season, other.Season)
                   && BeginTime == other.BeginTime
                   && EndTime == other.EndTime
                   && BeginIndex == other.BeginIndex;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType()
                   && Equals((SummonerMatchlistQuery) obj);
        }

        public override int GetHashCode()
        {
            const int prime = 397;

            var hashCode = 1;
            hashCode = (hashCode * prime) ^ SequenceEquality.SequenceHashCodeNullAsEmpty(Queue);
            hashCode = (hashCode * prime) ^ SequenceEquality.SequenceHashCodeNullAsEmpty(Champion);
            hashCode = (hashCode * prime) ^ SequenceEquality.SequenceHashCodeNullAsEmpty(Season);
            hashCode = (hashCode * prime) ^ BeginTime.GetHashCode();
            hashCode = (hashCode * prime) ^ EndTime.GetHashCode();
            hashCode = (hashCode * prime) ^ BeginIndex.GetHashCode();
            return hashCode;
        }
    }
}
