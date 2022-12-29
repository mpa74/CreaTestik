using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Testik.Models;

namespace Testik.ViewModels;

public partial class MainPageViewModel : ObservableObject
{

   
    [ObservableProperty] private ObservableCollection<StdQuestion> _questions;

    
    
    public MainPageViewModel(ObservableCollection<StdQuestion> iquestion)
    {
        _questions = iquestion;
    }

    [RelayCommand]
    void SendAnswers()
    {

        int rightAnswer = 0;
        int questionsCount = 0;

        foreach (var item in _questions)
        {
            questionsCount++;
            foreach (var stdanswer in item.Answers)
            {
                if (stdanswer.IsChecked && stdanswer.IsAnswer) rightAnswer++;
            }
        }

        string message = "Your results:" +
            "\n All questions: " + questionsCount.ToString() +
            "\n Right answers: " + rightAnswer.ToString();

        App.Current.MainPage.DisplayAlert("Warning", message, "Yes", "No");

    }
}