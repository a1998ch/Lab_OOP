﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLaba2
{
    /// <summary>
    /// Класс Child 
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Мать ребёнка
        /// </summary>
        private Adult _mother;

        /// <summary>
        /// Отец ребёнка
        /// </summary>
        private Adult _father;

        /// <summary>
        /// Название детского сада/школы
        /// </summary>
        private string _nameOfKindergartenOrSchool;

        /// <summary>
        /// Максимальный возраст ребёнка
        /// </summary>
        public const int MaxAgeChild = 17;

        /// <summary>
        /// Минимальный возраст ребёнка для зачисления в детский сад
        /// </summary>
        public const int MinAgeforKindergarten = 2;

        /// <summary>
        /// Минимальный возраст ребёнка для зачисления в школу
        /// </summary>
        public const int MinAgeforSchool = 6;

        /// <summary>
        /// Метод для работы с матерью
        /// </summary>
        public Adult Mother
        {
            set => _mother = value;
            get => _mother;
        }

        /// <summary>
        /// Метод для работы с отцом
        /// </summary>
        public Adult Father
        {
            set => _father = value;
            get => _father;
        }

        /// <summary>
        /// Метод для работы с детским садом/школой
        /// </summary>
        public string NameOfKindergartenOrSchool
        {
            set => _nameOfKindergartenOrSchool = value;
            get => _nameOfKindergartenOrSchool;
        }

        /// <summary>
        /// Констукрутор класса ребёнка
        /// </summary>
        /// <param name="name">Имя персоны</param>
        /// <param name="surname">Фамилия персоны</param>
        /// <param name="age">Возраст персоны</param>
        /// <param name="gender">Пол персоны</param>
        /// <param name="mother">Мать персоны</param>
        /// <param name="father">Отец персоны</param>
        /// <param name="nameOfKindergartenOrSchool">
        /// Название детского сада/школы</param>
        public Child(string name, string surname, int age,
            GenderType gender, Adult mother, Adult father,
            string nameOfKindergartenOrSchool)
            : base(name, surname, age, gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
            Mother = mother;
            Father = father;
            NameOfKindergartenOrSchool = nameOfKindergartenOrSchool;
        }

        /// <summary>
        /// Корректный ввод возраста ребёнка
        /// </summary>
        /// <param name="age">Возраст персоны</param>
        /// <returns>Корректный возраст</returns>
        protected override int AgeEntryRule(int age)
        {
            if (age > MaxAgeChild || age < 0)
            {
                throw new Exception($"Необходимо вводить числа" +
                    $" от \"0\" до \"{MaxAgeChild}\"");
            }
            else
            {
                return age;
            }
        }

        /// <summary>
        /// Информация о ребёнке
        /// </summary>
        public override string FullInfo
        {
            get => $"Имя: {Name}, " +
                   $"Фамилия: {Surname}, " +
                   $"Возраст: {Age}, " +
                   $"Пол: {Gender}, " + "\n" +
                   $"{{ Имя и фамилия матери: {Mother.ShortInfo}" + "\n" +
                   $"  Имя и фамилия отца: {Father.ShortInfo}" + "\n" +
                   $"  Название садика/школы: " +
                   $"{NameOfKindergartenOrSchool} }}" + "\n";
        }

        /// <summary>
        /// Создаёт случайного ребёнка
        /// </summary>
        /// <param name="child">Генератор случайных детей</param>
        /// <returns>Случайный ребёнок</returns>
        public static Child GetRandomChild(Random child)
        {
            GenderType[] genderArray =
                 new GenderType[2] { GenderType.Мужской, GenderType.Женский };
            string[] nameOfKindergartenArray = new string[5]
                                                          { "Детский сад №1",
                                                            "Детский сад №2",
                                                            "Детский сад №3",
                                                            "Детский сад №4",
                                                            "Детский сад №5",};
            string[] nameOfSchoolArray = new string[5]
                                                           {
                                                            "Школа №1",
                                                            "Школа №2",
                                                            "Школа №3",
                                                            "Школа №4",
                                                            "Школа №5" };

            int age = child.Next(0, 17);
            GenderType gender = genderArray[child.Next(genderArray.Length)];

            string nameOfKindergartenOrSchool = "";
            if (age >= MinAgeforKindergarten && age < MinAgeforSchool)
            {
                nameOfKindergartenOrSchool = nameOfKindergartenArray[
                    child.Next(nameOfKindergartenArray.Length)];
            }
            else if(age >= MinAgeforSchool)
            {
                nameOfKindergartenOrSchool = nameOfSchoolArray[
                    child.Next(nameOfSchoolArray.Length)];
            }
            else
            {
                nameOfKindergartenOrSchool = "Не прикреплён";
            }    

            var mother = Adult.GetRandomAdult(child, "m");
            var father = Adult.GetRandomAdult(child, "f");

            return gender == GenderType.Мужской
                ? new Child(GetRandomMen(child), GetRandomMen(child, true),
                      age, GenderType.Мужской, mother, father,
                      nameOfKindergartenOrSchool)
                : new Child(GetRandomWomen(child), GetRandomWomen(child, true),
                      age, GenderType.Женский, mother, father,
                      nameOfKindergartenOrSchool);
        }

        /// <summary>
        /// Метод для идентификации ребёнка
        /// </summary>
        /// <returns>Строку</returns>
        public string TestTypeChild()
        {
            return "↑ Это ребёнок";
        }
    }
}