using System;

namespace WingedMigration
{
    public class Martin : Bird, IMigrable
    {
        public override void Say()
        {
            Console.WriteLine("Ласточка говорит ПИ!");
        }

        public void MigrateToSouth()
        {
            Console.WriteLine("Ласточка улетает на юг когда исчезают мошки.");
        }
    }
}