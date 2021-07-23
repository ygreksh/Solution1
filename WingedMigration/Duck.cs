using System;

namespace WingedMigration
{
    public class Duck : Bird, IMigrable
    {
        
        public override void Say()
        {
            Console.WriteLine("Утка говорит КРЯ!");
        }

        public void MigrateToSouth()
        {
            Console.WriteLine("Утка улетает на юг когда замерзнет вода.");
        }
    }
}