using System;
using System.Collections.Generic;
using System.Text;

namespace InteractiveAnimals.Core.Models
{
    public class Animal
    {
        public virtual string Name => "Супер животное";
        public virtual string Description => "Для данного животного описание ещё не подвезли...";
        public virtual int LegCount => 0;

        public virtual string Say()
        {
            return "";
        }

        public virtual string Move()
        {
            return "";
        }
    }
}
