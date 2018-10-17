using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Event
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }


    public class VideoEncoder
    {
        // 1. 自訂事件
        // 作法一:

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs e);
        //public event VideoEncodedEventHandler VideoEncoded;


        // 作法二:
        public event EventHandler<VideoEventArgs> VideoEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding the Video....");


            Task t = Task.Run(() => {
                // Just loop.
                int ctr = 0;
                for (ctr = 0; ctr <= 20; ctr++)
                {
                    Console.Write("▇");
                    Thread.Sleep(100);
                }
                Console.WriteLine(" Encoding Finished!");

            });

            t.Wait();

            // 2. 引發事件
            OnVideoEncoded(video);
        }



        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
        }

    }
}
