using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8Ball
{
    public static class AnswerGenerator
    {
        // Масив строк.
        private static String[] _answers = new String[]
        {
            "Спроси еще раз.",
            "Не могу сразу сказать.",
            "Без сомнений.",
            "Это действительно так.",
            "Сосредоточься и спроси снова.",
            "Нет.",
            "Да, действительно.",
            "Я так не считаю.",
            "Именно так.",
            "Лучше не говори ничего.",
            "Плохая точка зрения.",
            "Вероятно это так.",
            "Очень сомнительно.",
            "Как я вижу, то да.",
            "Мой ответ, нет.",
            "Конечно.",
            "Да.",
            "Можете быть уверены.",
            "Хорошая точка зрения.",
            "Помехи в астрале, попробуйте снова."
        };

        // Метод случайной генерации ответа
        public static string GetRandomAnswer() => _answers[new Random().Next(_answers.Length)];
        
    }
}
