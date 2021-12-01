using System.ComponentModel.DataAnnotations;

namespace baltaexperience.Models;

public class TodoList{

    public int Id { get; set; } = 1;

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Title { get; set;}

    public List<TodoItem> Items { get; set; } = new();
}