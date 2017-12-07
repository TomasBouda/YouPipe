﻿using System.Collections.ObjectModel;

namespace PopOut.Player.Players
{
	public interface IVideoPlayer
	{
        string Title { get; }
        ObservableCollection<IVideo> PlayList { get; }

        void PlayOrQueue(string videoUrl);
		void PlayFromQueue(Video video);
		void Pause();
		void Play();
		void Toggle();
		void Stop();
	}
}
