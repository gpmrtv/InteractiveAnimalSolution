using InteractiveAnimals.Core.Interfaces;
using InteractiveAnimals.Core.Models;
using InteractiveAnimals.WPF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractiveAnimals.WPF.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private AnimalItem selectedAnimal;
        private IList<AnimalItem> animalItems = new List<AnimalItem>();

        private readonly IAnimalFactory _factory;

        public MainWindowViewModel(IAnimalFactory factory)
        {
            _factory = factory;

            animalItems.Add(new AnimalItem() { Number = 0, DisplayName = "Заяц" });
            animalItems.Add(new AnimalItem() { Number = 1, DisplayName = "Змея" });
            animalItems.Add(new AnimalItem() { Number = 2, DisplayName = "Волк" });
        }

        public AnimalItem SelectedAnimal
        {
            get => selectedAnimal;
            set
            {
                if (value != selectedAnimal)
                {
                    selectedAnimal = value;

                    OnPropertyChanged("Animal");
                    OnPropertyChanged("AnimalSay");
                    OnPropertyChanged("AnimalMove");
                }
            }
        }
        public IList<AnimalItem> AnimalItems => animalItems;
        public Animal Animal => _factory.GetAnimal(selectedAnimal != null ? selectedAnimal.Number : -1);//Если не выбрано животное из списка ты получим базовое животное
        public string AnimalSay => Animal.Say();
        public string AnimalMove => Animal.Move();
    }
}
