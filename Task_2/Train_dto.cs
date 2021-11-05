namespace Task_2
{
    public struct Train
    {
        private string destination;
        private int number;
        private string time;

        public string Destination { get { return destination; } }
        public int Number { get { return number; } }
        public string Time { get { return time; } }

        // конструктор экземпляра поезда
        public Train(string punkt, int nomer, string time)
        {
            this.destination = punkt;
            this.number = nomer;
            this.time = time;
        }
    }
}
