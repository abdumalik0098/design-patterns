namespace Iterator.Lib
{
    public class DetalItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public float Massa { get; set; }

        public override string ToString()
        {
            return $"Id: {ID}\n" +
                $"Name: {Name}\n" +
                $"Material: {Material}\n" +
                $"Massa: {Massa}\n";
        }
    }
}