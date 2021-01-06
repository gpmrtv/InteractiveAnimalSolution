using System;
using System.Collections.Generic;
using System.Text;

namespace InteractiveAnimals.Core.Models
{
    public class Snake : Animal
    {
        //Инкапсулируем(скрываем) от клиента "звук" и "как двигается" животного посредством переопределенных методов базового класса
        #region Incapsulation

        private readonly string _say = "ШШШШШШШШШ";
        private readonly string _move = "Шмяк-Шмяк...";

        #endregion

        //"Изменяем" поведение конкретного животного
        #region Polymorphism

        public override string Name => "Змея";
        public override string Description => "Это змея. Она очень ядовитая и опасная!";
        public override int LegCount => 0;

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
