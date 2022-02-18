using System.Windows;

// для DependencyObject, для свойства зависимости

namespace DependencyPropertyDemo.Models
{
    // Model for View   View    Model --- MVVM pattern  ~~~ MVC
    // ---              View    Model Controller
    
    // Это реализация модели для представления объекта в UI
    public class Fox: DependencyObject
    {
        public const int MaxAge = 100;
        public const double MaxWeight = 30d;

        // Правило формирования имени свойства зависимости
        // ИмяProperty
        // тогда свойство-оболочка называется просто и незатейливо: Имя
         
        // свойство зависимости - кличка лисицы
        // свойство зависимости можно привязать к свойствам элементов управления
        public static readonly DependencyProperty TitleProperty;  // хранилище значений
        public string Title {    // свойство-обертка для доступа к хранилищу значений
            get => (string)GetValue(TitleProperty); 
            set => SetValue(TitleProperty, value); 
        } // Title


        // свойство зависимости - возраст лисицы в годах
        public static readonly DependencyProperty AgeProperty;
        public int Age {
            get => (int)GetValue(AgeProperty);
            set => SetValue(AgeProperty, value);
        }  // Age


        // Свойство зависимости - вес лисицы
        public static readonly DependencyProperty WeightProperty;
        public double Weight {
            get => (double)GetValue(WeightProperty);
            set => SetValue(WeightProperty, value);
        } // Weight


        // статический конструктор для реализации статической части свойств зависимостей 
        // т.е. это регистрация хранилища значений свойств 
        static Fox() {
            // регистрация свойства в хранилище методом Register()
            // 1-й параметр метода - имя свойства
            // 2-й параметр метода - тип свойства
            // 3-й параметр метода - тип владельца свойства, т.е. имя нашего класса
            TitleProperty = DependencyProperty.Register(
                "Title", typeof(string), typeof(Fox));

            // регистрация делегата для корректирующей валидации
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata {CoerceValueCallback = CorrectAge};

            // или в полном варианте:
            // metadata.CoerceValueCallback = new CoerceValueCallback(CorrectAge);
            AgeProperty = DependencyProperty.Register("Age", typeof(int), typeof(Fox),
                metadata/*, ValidateAge*/);
            // крайний параметр - делегат ValidateValueCallback для проверяющей валидации
            
            // регистрация делегата для корректирующей валидации
            metadata = new FrameworkPropertyMetadata { CoerceValueCallback = CorrectWeight };
            // или в полном варианте:
            // metadata.CoerceValueCallback = new CoerceValueCallback(CorrectWeight);

            WeightProperty = DependencyProperty.Register("Weight", typeof(double), typeof(Fox),
                metadata/*, ValidateWeight */);
            // крайний параметр - делегат ValidateValueCallback для проверяющей валидации
        } // Fox

        // ---------------------- корректирующие валидаторы ---------------------------------

        // Корректирующая валидация - делегат CoerceValueCallback для веса лисы
        private static object CorrectWeight(DependencyObject d, object baseValue) {
            // получить новое значение веса - то, что будет записано
            double currentValue = (double)baseValue;

            // Если слишком легкая лиса - скорректировать - вернуть минимально допустимый вес 
            if (currentValue <= 0d)
                return 0.3d;
            // Если слишком тяжелая лиса - скорректировать - вернуть максимально допустимый вес
            if (currentValue > MaxWeight)
                return MaxWeight;

            return currentValue; 
        } // CorrectWeight


        // Корректирующая валидация - делегат CoerceValueCallback для возраста лисы
        private static object CorrectAge(DependencyObject d, object baseValue) {
            // получить новое значение возраста - то, что будет записано
            int currentValue = (int)baseValue;

            // Возраст не м.б. отрицательным - скорректировать - вернуть 0, как минимально
            // допустимый возраст 
            if (currentValue <= 0) currentValue = 0;
            // Возраст лисы не м.б. > 100 лет (почему бы и да...) - скорректировать - вернуть максимально 
            // допустимый возраст 
            else if (currentValue > MaxAge) currentValue =  MaxAge;

            return currentValue;
        } // CorrectAge

        // ------------------------------- проверяющие валидаторы -------------------------

        // проверка для веса
        private static bool ValidateWeight(object value)  {
            double currentValue = (double)value;
            return (currentValue >= 0d && currentValue <= MaxWeight);
        } // ValidateWeight

        // проверка для возраста 
        private static bool ValidateAge(object value) {
            int currentValue = (int)value;
            return (currentValue >= 0 && currentValue <= MaxAge);
        } // ValidateAge

        // --------------------------------------------------------------
        public override string ToString() => $"{Title}\n{Age} лет\n{Weight} кг";
    } // class Fox
}
