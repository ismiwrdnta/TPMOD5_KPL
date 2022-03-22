using System;

namespace tpmodul5_1302201135
{
	public class SayaTubeVideo
	{
		private int id;
		private string title;
		private int playCount;
		public SayaTubeVideo() { }
		public SayaTubeVideo(string title)
		{
			this.title = title;
			var rand = new Random();
			this.id = rand.Next(10000, 99999);
			this.playCount = 0;
		}

		public void IncreasePlayCount(int a)
		{
			this.playCount = a;
		}

		public void PrintVideoDetails()
		{
			Console.WriteLine("Video ID : " + this.id);
			Console.WriteLine("Video Title : " + this.title);
			Console.WriteLine("Video Playcount : " + this.playCount);
		}


	}
}
