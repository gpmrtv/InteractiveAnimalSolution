using System;
using System.Collections.Generic;
using System.Text;

namespace InteractiveAnimals.Core.Models
{
    public class Wolf : Animal
    {
        //Инкапсулируем(скрываем) от клиента "звук" и "как двигается" животного посредством переопределенных методов базового класса
        #region Incapsulation

        private readonly string _say = "Ауфф!";
        private readonly string _move = "Топ-Топ-Топ...";

        #endregion

        #region Polymorphism

        public override string Name => "Волк";
        public override string Description => "Это серый-серый волк! Зубами щёлк!";
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
