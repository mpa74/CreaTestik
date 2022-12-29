using System.Collections.ObjectModel;

namespace Testik.Models;

public interface IQuestion
{
    public int Id { get; set; }
    public string Description { get; set; }
    public ObservableCollection<StdAnswer> Answers { get; set; }
   
    
}