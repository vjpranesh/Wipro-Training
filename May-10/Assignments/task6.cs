using System;

class SocialMedia
{
    public virtual void Post()
    {
        Console.WriteLine("Posting on social media");
    }
}

class FacebookPost : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Posting on Facebook");
    }
}

class TwitterPost : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Tweeting on Twitter");
    }
}

class InstagramPost : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Posting on Instagram");
    }
}

class Program
{
    static void Main()
    {
        FacebookPost fb = new FacebookPost();
        TwitterPost tw = new TwitterPost();
        InstagramPost ig = new InstagramPost();

        fb.Post();
        tw.Post();
        ig.Post();

        Console.WriteLine();

        SocialMedia[] posts = { new FacebookPost(), new TwitterPost(), new InstagramPost() };

        foreach (SocialMedia post in posts)
        {
            post.Post();
        }
    }
}

