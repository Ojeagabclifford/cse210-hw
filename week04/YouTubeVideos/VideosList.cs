public class VideosList()
{
    public List<Videos> _videos = new List<Videos>();


    public void AddVideos( Videos vidoes)
    {
        _videos.Add(vidoes);
    }

    public void GetVideos()
    {


        foreach(Videos videosList in _videos)
        {
            videosList.DisplayVideosDetails();
            Console.WriteLine("");


        }
        Console.WriteLine($"Total Videos: {_videos.Count}");
    }
}