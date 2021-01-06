# InteractiveAnimalSolution

В данном решении архитектура реализована путем разделения модулей по компонентам.

Компонент InteractiveAnimals.Core - компонент бизнес-логики, который описывает доменную модель бизнеса. Входящие зависимости отсутствуют, как и должно быть для центрального компонента(наша модель ничего не должна знать о механизмах вывода).
Доменная модель реализована согласно принципам ООП. Для управления созданием объектов описан интерфейс IAnimalFactory и реализация SimpleAnimalFactory (одна из имплементаций паттерна "Абстрактная фабрика").

Компонент InteractiveAnimals.WPF - компонент, отвечающий за механизм вывода информации. Реализован с помощью паттерна MVVM. Вью-модель главного окна можно сделать немного по-другому, например, чтобы движение животных и звук осуществлялись через ICommand (но на скорую руку сделал как сделал).

Благодаря "правильной" архитектуре решения открываются возможности бесконечного расширения способов вывода информации, такие как, веб, консоль и т.п., так как самый низкоуровневый компонент не зависит ни от чего. Достаточно в сборку добавить проект другого типа, например консоль, внедрить зависимости и реализовывать "по-другому" вывод информации.

Данный архитектурный дизайн на мой взгляд отлично подходит для внедрения в enterprise-продукты. Т.к. возможно переключать хранилища данных без ущерба бизнес-логике (которая не будет знать и реализации хранилища данных). Поведение доменной модели будет описано на самом низком уровне, что позволит вносить различные изменения централизованно, например изменение валидации при вставке и т.п.

При разработке решения были соблюдены принципы SOLID.