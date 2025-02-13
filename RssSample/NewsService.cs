namespace RssSample
{
    public class NewsService
    {


        public List<NewsItem> GetNews()
        {
            var news = new List<NewsItem>();
            Random random = new Random();
            news.Add(new NewsItem
            {
                Title = $"Кот из Сибири научился играть на пианино и записал альбом",
                Description = $"Мурзик, сибирский кот, стал первым в мире животным, выпустившим собственный музыкальный альбом. Его композиции уже доступны на всех цифровых площадках.",
                Link = $"https://fake-cat-news.com/siberian-piano-cat",
                PubDate = DateTime.Now.AddDays(random.Next(-10, -1)),
                Author = $"Админокот",
                ImageUrl = $"/images/news1.png"
            });

            news.Add(new NewsItem
            {
                Title = $"Кот спас целую семью от пожара, нажав кнопку тревоги",
                Description = $"Барсик из Новосибирска заметил дым и случайно активировал домашнюю систему оповещения, что позволило семье вовремя покинуть квартиру.",
                Link = $"https://fake-cat-news.com/cat-hero-fire",
                PubDate = DateTime.Now.AddDays(random.Next(-10, -1)),
                Author = $"Админокот",
                ImageUrl = $"/images/news2.png"
            });

            news.Add(new NewsItem
            {
                Title = $"Японский кот основал свою IT-компанию",
                Description = $"Кот по имени Тама создал стартап, специализирующийся на разработке приложений для домашних животных. Инвесторы уже вложили миллионы.",
                Link = $"https://fake-cat-news.com/japanese-cat-tech-company",
                PubDate = DateTime.Now.AddDays(random.Next(-10, -1)),
                Author = $"Админокот",
                ImageUrl = $"/images/news3.png"
            });

            news.Add(new NewsItem
            {
                Title = $"Кот установил мировой рекорд по прыжкам в высоту",
                Description = $"Кот по кличке Феликс из Австралии прыгнул на высоту 2,5 метра, побив предыдущий рекорд на 30 сантиметров.",
                Link = $"https://fake-cat-news.com/world-record-cat-jump",
                PubDate = DateTime.Now.AddDays(random.Next(-10, -1)),
                Author = $"Админокот",
                ImageUrl = $"/images/news4.png"
            });

            news.Add(new NewsItem
            {
                Title = $"Кот стал мэром маленького города в США",
                Description = $"Жители городка Тайлера, штат Техас, выбрали кота по имени Уинстон своим мэром. Он обещает улучшить условия жизни для местных животных.",
                Link = $"https://fake-cat-news.com/cat-mayor-usa",
                PubDate = DateTime.Now.AddDays(random.Next(-10, -1)),
                Author = $"Админокот",
                ImageUrl = $"/images/news5.png"
            });

            news.Add(new NewsItem
            {
                Title = $"Кот нашел древний клад в своем дворе",
                Description = $"Пушистик из Великобритании выкопал старинную коробку с золотыми монетами, возраст которых превышает 300 лет.",
                Link = $"https://fake-cat-news.com/cat-treasure-hunter",
                PubDate = DateTime.Now.AddDays(random.Next(-10, -1)),
                Author = $"Админокот",
                ImageUrl = $"/images/news6.png"
            });

            news.Add(new NewsItem
            {
                Title = $"Кот стал звездой TikTok, заработав миллион долларов",
                Description = $"Кот Васька из России набрал более 50 миллионов подписчиков и заработал огромное состояние на рекламе и мерче.",
                Link = $"https://fake-cat-news.com/tiktok-millionaire-cat",
                PubDate = DateTime.Now.AddDays(random.Next(-10, -1)),
                Author = $"Админокот",
                ImageUrl = $"/images/news7.png"
            });

            news.Add(new NewsItem
            {
                Title = $"Кот начал рисовать картины, которые продаются за тысячи долларов",
                Description = $"Кот по имени Пикассо создает абстрактные картины, которые коллекционеры готовы покупать за баснословные суммы.",
                Link = $"https://fake-cat-news.com/painting-cat-artist",
                PubDate = DateTime.Now.AddDays(random.Next(-10, -1)),
                Author = $"Админокот",
                ImageUrl = $"/images/news8.png"
            });

            news.Add(new NewsItem
            {
                Title = $"Кот стал первым животным-космонавтом, отправившимся к Марсу",
                Description = $"Кот по имени Лунтик стал первым живым существом, отправленным на Марс. Его миссия продлится два года.",
                Link = $"https://fake-cat-news.com/painting-cat-artist",
                PubDate = DateTime.Now.AddDays(random.Next(-10, -1)),
                Author = $"Админокот",
                ImageUrl = $"/api/images/news9.png"
            });
            return news;
        }
    }
}
