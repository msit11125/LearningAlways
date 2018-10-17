using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1", Content = "blablabla..." };

            var encoder = new VideoEncoder();
            var mailService = new MailService();
            var messageService = new MessageService();
            encoder.VideoEncoded += mailService.OnVideoEncoded;
            encoder.VideoEncoded += messageService.OnVideoEncoded;


            encoder.Encode(video);


            Console.ReadKey();
        }



    }


   



    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"{this.GetType().Name}: Sending a email... " + args.Video.Title);
        }
    }


    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"{this.GetType().Name}: Sending a text... " + args.Video.Title);
        }
    }







    public class Video
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }


}
