using System;

namespace FACADE
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchVideo searchVideo = new SearchVideo();
            OpenVideo openVideo = new OpenVideo();
            PlayVideo playVideo = new PlayVideo();

            VisualStudioFacade ide = new VisualStudioFacade(searchVideo, openVideo, playVideo);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);

            Console.Read();
        }
    }
    class SearchVideo
    {
        public void SearchWordsCreate()
        {
            Console.WriteLine("Ввод того, что ищем");
        }
        public void ExecuteSearch()
        {
            Console.WriteLine("Поиск видео");
        }
    }
    class OpenVideo
    {
        public void Open()
        {
            Console.WriteLine("Открытие видео");
        }
    }
    class PlayVideo
    {
        public void PlayVid()
        {
            Console.WriteLine("Воспроизведение видео");
        }
        public void StopVid()
        {
            Console.WriteLine("Пауза");
        }
    }

    class VisualStudioFacade
    {
        SearchVideo searchVideo;
        OpenVideo openVideo;
        PlayVideo playVideo;
        public VisualStudioFacade(SearchVideo sear, OpenVideo openn, PlayVideo playVideo)
        {
            this.searchVideo = sear;
            this.openVideo = openn;
            this.playVideo = playVideo;
        }
        public void Start()
        {
            searchVideo.SearchWordsCreate();
            searchVideo.ExecuteSearch();
            openVideo.Open();
            playVideo.PlayVid();
        }
        public void Stop()
        {
            playVideo.StopVid();
        }
    }

    class Programmer
    {
        public void CreateApplication(VisualStudioFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}