namespace up_larchenko
{
    public class Item
    {
        public string Name { get; set; }           // Например: "Неопознанный артефакт"
        public string RecognizedName { get; set; } // Например: "Амулет силы"
        public int Price { get; set; }             // Цена
        public bool IsRecognized { get; set; }     // Опознан ли?

        public string DisplayName => IsRecognized ? RecognizedName : Name;
        public bool IsJunk => Price < 50;
    }
}