using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Home","Deyaz",167);
        v1.AddComment("@madman2","I grew up in the UK but emigrated to New Zealand in 2017. I left behind family, friends, the good and the bad of 'home'.");
        v1.AddComment("@Shimmeryzzle","Stunning! 💕 ");
        v1.AddComment("@marinap9737","PLEASE I NEED THIS ON SPOTIFY 😭😭😭");

        Video v2 = new Video("Where's My Love","SYML",240);
        v2.AddComment("@boredkid6998","everybody is talking about how they lost someone. but the only person i lost was myself. i can't find who she used to be...");
        v2.AddComment("@sd3486","Don't forget to breathe while you crying");
        v2.AddComment("@rainahourigan6101","imagine how many people are sitting here, crying, lying in bed, listening to this song. At the same time, i love you all");

        Video v3 = new Video("Male Fantasy","Billie Eilish",228);
        v3.AddComment("@moniquemills01","I got a call from a girl I used to know we were inseparable years ago");
        v3.AddComment("@nowayeralazmi","I’ll always come back to this song no matter what");
        v3.AddComment("@CandyLyrics","THAT'S THE ONE OF THE BESTS SONGS ON THE ALBUM");
        v3.AddComment("@kevintellier8295","Who will be listening to this magnificent song in 2026...? ♥");

        List<Video> videos = new List<Video>();
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach(Video video in videos)
        {
            video.ShowVideo();
        }


    }
}