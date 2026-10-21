namespace todos
{
    public interface ItoDoStorage
    {
        List<ToDo> Load(); // metod för att ladda ToDo's som returnerar en Lista av ToDo

        void Save(List<ToDo> todos); // metod för att spara todos som tar emot lista av ToDo
    }
}