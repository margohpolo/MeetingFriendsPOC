using System;
using System.Collections.Generic;
using System.Linq;
using System.Spatial;
using System.Text;
using System.Threading.Tasks;

namespace MeetingFriendsPOC
{
    public static class Helpers
    {
        public static Double TheirDistanceToDestination(this Friend friend, Candidate candidate)
        {
            return friend.PointOfOrigin.Distance(candidate.Location) ?? 0;
        }

        public static Double CalculateMeanCandidateScore(Candidate candidate, List<Friend> friends)
        {
            Double candidateScore = 0;

            friends.ForEach(f =>
            {
                candidateScore += f.TheirDistanceToDestination(candidate);
            });

            return candidateScore / friends.Count;
        }

        public static Candidate IdealMeetingPlace(List<Friend> friends, List<Candidate> candidates)
        {
            Dictionary<string, Double> candidateScores = new Dictionary<string, Double>();

            candidates.ForEach(c =>
            {
                candidateScores.Add(c.Name, CalculateMeanCandidateScore(c, friends));
            });

            string bestCandidateName = candidateScores
                .OrderBy(x => x.Value)
                .Select(x => x.Key)
                .First();

            return candidates.Where(c => c.Name.Equals(bestCandidateName)).First();
        }
    }
}
