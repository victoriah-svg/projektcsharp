namespace todos
{
    public class ToDo
    {
        /*fält för namn på uppgift, prioritet, klar och kategori 
        med properties för att läsa och sätta värde*/
        public string? Task { get; set; }

        public int? Priority { get; set; }

        public bool? Done { get; set; }

        public string? Category { get; set; }


    }


}