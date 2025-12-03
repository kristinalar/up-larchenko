namespace up_larchenko
{
    public class Player
    {
        public string Nickname { get; set; } = "Безымянный раб";
        public string Class { get; set; } = "Воин";
        public string Backstory { get; set; } = "Просто путник";
        public int Strength { get; set; } = 0;
        public int Dexterity { get; set; } = 0;
        public int Intelligence { get; set; } = 0;

        public int MaxHP { get; set; } = 100;
        public int CurrentHP { get; set; } = 100;
        public string Weapon { get; set; } = "Меч";      // даёт бонус к урону
        public string Armor { get; set; } = "Кожаная";  // снижает урон
        public int Gold { get; set; } = 0;
        public int Experience { get; set; } = 0;
        public int Potions { get; set; } = 0;

        public int GetTotalDamage()
        {
            return Strength + (Weapon switch
            {
                "Меч" => 5,
                "Боевой топор" => 8,
                "Кинжал" => 3,
                _ => 0
            });
        }

        public int ReduceDamage(int incomingDamage)
        {
            int reduction = Armor switch
            {
                "Кожаная" => 2,
                "Стальная" => 5,
                _ => 0
            };
            return Math.Max(0, incomingDamage - reduction);
        }

    }
}
