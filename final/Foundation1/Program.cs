using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        // video 1
        Video video1 = new Video();
        video1._title = "Best things about Horizon Zero Dawn";
        video1._author = "Aloy Rost";
        video1._length = 330;
        _videos.Add(video1);

        // video 1 - 1 comment
        // comment 1 of video 1 = com1of1
        Comment com1of1 = new Comment();
        com1of1._comment = "Do you think the second game will be just as good?";
        com1of1._commenter = "Ludwig";

        // video 1 - 2 comment
        Comment com2of1 = new Comment();
        com2of1._comment = "This game definitely has a good story line!";
        com2of1._commenter = "Pewdewpie";

        // video 1 - 3 comment
        Comment com3of1 = new Comment();
        com3of1._comment = "Should I play this on the ps5 or ps4?";
        com3of1._commenter = "Beatemups";

        // video 1 - 4 comment
        Comment  com4of1 = new Comment();
        com4of1._comment = "Have you also played the DLC for this game?";
        com4of1._commenter = "Markiplier";


        // add comments to the list
        video1._comments.Add(com1of1);
        video1._comments.Add(com2of1);
        video1._comments.Add(com3of1);
        video1._comments.Add(com4of1);

        video1.listComments();
        Console.WriteLine();

        // video 2
        Video video2 = new Video();
        video2._title = "Get ready with me: Going to Prom";
        video2._author = "Julia Roberts";
        video2._length = 563;
        _videos.Add(video2);

        // video 2 - 1 comment
        Comment com1of2 = new Comment();
        com1of2._comment = "Where did you get your dress?";
        com1of2._commenter = "Jenna Ortega";

        // video 2 - 2 comment
        Comment com2of2 = new Comment();
        com2of2._comment = "I love your eyeshadow!";
        com2of2._commenter = "Sandra Bullock";

        // video 2 - 3 comment
        Comment com3of2 = new Comment();
        com3of2._comment = "You should add a smaller necklace.";
        com3of2._commenter = "Margot Robbie";

        // add comments to the list
        video2._comments.Add(com1of2);
        video2._comments.Add(com2of2);
        video2._comments.Add(com3of2);

        video2.listComments();
        Console.WriteLine();

        // video 3
        Video video3 = new Video();
        video3._title = "Took the sorting hat quiz...I am Gryffindor";
        video3._author = "Harry Potter";
        video3._length = 769;
        _videos.Add(video3);

        // video 3 - 1 comment
        Comment com1of3 = new Comment();
        com1of3._comment = "I wish I got gryffindor";
        com1of3._commenter = "Draco Malfory";

        // video 3 - 2 comment
        Comment com2of3 = new Comment();
        com2of3._comment = "Where did you find this quiz?";
        com2of3._commenter = "Luna Lovegood";

        // video 3 - 3 comment
        Comment com3of3 = new Comment();
        com3of3._comment = "I hope I get gryffindor too!";
        com3of3._commenter = "Ginny Weasley";

        // video 3 - 4 comment
        Comment com4of3 = new Comment();
        com4of3._comment = "Yay! We got the same house";
        com4of3._commenter = "Hermione Granger";


        // add comments to the list
        video3._comments.Add(com1of3);
        video3._comments.Add(com2of3);
        video3._comments.Add(com3of3);
        video3._comments.Add(com4of3);

        video3.listComments();
        Console.WriteLine();

        // video 4
        Video video4 = new Video();
        video4._title = "Storytime of going to a voice coach";
        video4._author = "Billie Eilish";
        video4._length = 483;
        _videos.Add(video4);

        // video 4 - 1 comment
        Comment com1of4 = new Comment();
        com1of4._comment = "I love the story of your growth!";
        com1of4._commenter = "Kelly Clarkson";

        // video 4 - 2 comment
        Comment com2of4 = new Comment();
        com2of4._comment = "Keep up the great work.";
        com2of4._commenter = "Jung Kook";
        
        // video 4 - 3 comment
        Comment com3of4 = new Comment();
        com3of4._comment = "Let everything be an inspiration for your music";
        com3of4._commenter = "Frank Ocean";

        // add comments to the list
        video4._comments.Add(com1of4);
        video4._comments.Add(com2of4);
        video4._comments.Add(com3of4);

        video4.listComments();
        Console.WriteLine();
    }
}