//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using MeetingFriendsPOC;
using System.Spatial;

List<Friend> friendsList = new List<Friend>()
{
    //new Friend("RB", pointOfOrigin: new Location(new CoordinateSystem(), new SpatialImplementation())),
};

List<Candidate> candidatesList = new List<Candidate>()
{

};

Console.WriteLine($"The ideal meeting place is {Helpers.IdealMeetingPlace(friendsList, candidatesList)}");
