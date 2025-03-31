using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Videos vidoe1 = new Videos();
        vidoe1._author ="Ojeaga Benjamin Clifford";
        vidoe1._title = "Love is beautiful";
        vidoe1._length = 60;

        Comment comment = new Comment();
        Comment comment2 = new Comment();
        Comment comment3 = new Comment();
        Comment comment4 = new Comment();

        comment._name = "John Love";
        comment._personComment="Wow i love this video";
        comment2._name = "Bob Joy";
        comment2._personComment="Wow ";
        comment3._name = "Smith Andrew";
        comment3._personComment="Nice video";
        comment4._name = "Loveth Kath";
        comment4._personComment="i love this video";



        vidoe1.AddComment(comment);
        vidoe1.AddComment(comment2);
        vidoe1.AddComment(comment3);
        vidoe1.AddComment(comment4);

        

        Videos vidoe2 = new Videos();
        vidoe2._author ="Oliver John";
        vidoe2._title = "What a life";
        vidoe2._length = 100;

        Comment comment5 = new Comment();
        Comment comment6 = new Comment();
        Comment comment7 = new Comment();
        Comment comment8 = new Comment();

        comment5._name = "Kath Love";
        comment5._personComment="i love this video";
        comment6._name = "Bob Joy";
        comment6._personComment="best videos of 2025 ";
        comment7._name = "Love Andrew";
        comment7._personComment="Nice video";
        comment8._name = "Loveth Kath";
        comment8._personComment="i love this video";



        vidoe2.AddComment(comment5);
        vidoe2.AddComment(comment6);
        vidoe2.AddComment(comment7);
        vidoe2.AddComment(comment8);

       


        Videos vidoe3 = new Videos();
        vidoe3._author ="Josphe Smith";
        vidoe3._title = "The restoretion";
        vidoe3._length = 100;

        Comment comment9 = new Comment();
        Comment comment10 = new Comment();
        Comment comment11 = new Comment();
        Comment comment12 = new Comment();

        comment9._name = "Kath Love";
        comment9._personComment="i love this video";
        comment10._name = "Bob Joy";
        comment10._personComment="best videos of 2025 ";
        comment11._name = "Love Andrew";
        comment11._personComment="Nice video";
        comment12._name = "Loveth Kath";
        comment12._personComment="i love this video";



        vidoe3.AddComment(comment9);
        vidoe3.AddComment(comment10);
        vidoe3.AddComment(comment11);
        vidoe3.AddComment(comment12);

        

        VideosList videosList = new VideosList();

        videosList.AddVideos(vidoe1);
        videosList.AddVideos(vidoe2);
        videosList.AddVideos(vidoe3);
        videosList.GetVideos();

         



    }
}