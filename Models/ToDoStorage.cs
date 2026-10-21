using Microsoft.JSInterop; //för att kunna anropa js-fil

namespace todos
{


    public class ToDoStorage(IJSRuntime js) //: ItoDoStorage
    {

        private readonly IJSRuntime _js = js; // primärkonstruktor


        public async Task Save(string value)
        {
            await _js.InvokeVoidAsync("saveData", "test", value); //anropar metod saveData från js-fil
        }

       /* public async Task<List<ToDo>> Load()
        {
            return await _js.InvokeAsync<List<ToDo>>("getData", "test");
        }*/

        public async Task<string?> Load()
        {
            return await _js.InvokeAsync<string?>("getData", "test");
        }

        
    }
}

