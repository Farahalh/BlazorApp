namespace BlazorApp.Components.Pages
{
    public partial class Todo
    {
        private List<TodoItem> _todos = new();
        private string _newTodo = "";

        void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(_newTodo))
            {
                _todos.Add(new TodoItem { Title = _newTodo });
                _newTodo = string.Empty;
            }
        }
    }
}