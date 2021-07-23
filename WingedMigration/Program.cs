namespace WingedMigration
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Raven raven = new Raven() {Name = "ворон"};      // ворон
            Pigeon pigeon = new Pigeon() {Name = "голубь"};   // голубь
            Martin martin = new Martin() {Name = "ласточка"};   // ласточка
            Duck duck = new Duck() {Name = "утка"};   // утка
            
            //массив из птиц разного вида
            Bird[] birds = new Bird[] {raven, pigeon, martin, duck};
            foreach (var item in birds)
            {
                item.Say();
            }
            //только перелетные птицы
            IMigrable[] migrables = new IMigrable[] {martin, duck };
            foreach (var item in migrables)
            {
                item.MigrateToSouth();
            }
        }
    }
}