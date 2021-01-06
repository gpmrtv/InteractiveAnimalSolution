using System;
using System.Collections.Generic;
using System.Text;

namespace InteractiveAnimals.Core.Models
{
    public class Bunny : Animal
    {
        //Инкапсулируем(скрываем) от клиента "звук" и "как двигается" животного посредством переопределенных методов базового класса
        #region Incapsulation

        private readonly string _say = "ТТТТТТТ";
        private readonly string _move = "Прыг-Скок...";

        #endregion

        //"Изменяем" поведение конкретного животного
        #region Polymorphism

        public override string Name => "Заяц";
        public override string Description => "Это заяц. Зимой он белый, а летом серый!";
        public override int LegCount => 4;

        #endregion

        public override string Say()
        {
            return _say;
        }

        public override string Move()
        {
            return _move;
        }
    }
}
