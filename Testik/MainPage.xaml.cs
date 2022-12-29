using System.Collections.ObjectModel;
using Testik.Models;
using Testik.ViewModels;

namespace Testik;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();

        List<string> quests = new List<string>()
        {
            "Сколько будет 2+2?",
            "Папа съел первую конфету в 22:00, а последнюю в 22:10. Он ел по две конфеты каждые пять минут",
            "Какого рода слово меломан?"
        };
        
        ObservableCollection<StdQuestion> questions = new ObservableCollection<StdQuestion>()
        {
            new StdQuestion(0, description:quests[0], 
                new ObservableCollection<StdAnswer>()
                {
                    new StdAnswer("2", 0, false, false),
                    new StdAnswer("4", 0, true, false),
                    new StdAnswer("5", 0, false, false),
                },
                @"https://picsum.photos/seed/nine/180/180"),
            new StdQuestion(1, description:quests[1], 
                new ObservableCollection<StdAnswer>()
                {
                    new StdAnswer("6", 1, true, false),
                    new StdAnswer("4", 1, false, false),
                    new StdAnswer("12", 1, false, false)
                },
                @"http://91.210.169.67/B2.png"),
            new StdQuestion(2, description:quests[2], 
                new ObservableCollection<StdAnswer>()
                {
                   new StdAnswer("Мужской", 2, true, false),
                   new StdAnswer("Женский", 2, false, false),
                   new StdAnswer("Средний", 2, false, false),
                },
                @"http://91.210.169.67//B2.png"),

            new StdQuestion(3, "Реши задачу. "
            + "Электрику нужно поменять лампочку на большой высоте. "
            + "У него есть много слонов высотой 2 метра, которых он может поставить друг на друга. "
            + "Сколько слонов ему понадобится, если лампочка висит на высоте 5.5 метров, а он высотой 1.5 метра?",
                new ObservableCollection<StdAnswer>()
                {
                   new StdAnswer("2", 3, true, false),
                   new StdAnswer("3", 3, false, false),
                   new StdAnswer("4", 3, false, false),
                },
                @"https://picsum.photos/seed/eight/180/180"),

            new StdQuestion(4, "Автомобиль едет из точки А в точку Б со скоростью 60 км/ч."
            + "Между точками А и Б - 250 км. А по середине маршрута - разводные мосты, которые будут разведены через 3 часа и больше в этот день не сведутся. "
            + "Успеет ли авто попасть в точку Б сегодня?",
                new ObservableCollection<StdAnswer>()
                {
                   new StdAnswer("Да", 4, true, false),
                   new StdAnswer("Нет", 4, false, false),
                   new StdAnswer("Успеет, если в кафешку за кофе не заскочит", 4, false, false),
                },
                @"https://picsum.photos/seed/sizzz/180/180")
        };

        BindingContext = new MainPageViewModel(questions);
    }

   
}