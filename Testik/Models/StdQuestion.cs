using System.Collections.ObjectModel;

namespace Testik.Models;

public class StdQuestion : IQuestion
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public ObservableCollection<StdAnswer> Answers { get; set; }

    public string IdLabel { get => "Вопрос " + Id.ToString(); }

    public StdQuestion(int id, string description,
        ObservableCollection<StdAnswer> answers,
        string imagepath)
    {
        Id = id;
        Description = description;
        Answers = answers;
        ImagePath = imagepath;
    }

   
}