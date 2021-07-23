namespace WingedMigration
{
    //Базовый класс ПТИЦА, от которого наследуются все остальные виды птиц
    public abstract class Bird
    {
        public string Name { get; set; }

        public abstract void Say();

    }
}