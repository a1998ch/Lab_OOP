﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ModelLaba2
{
    /// <summary>
    /// Класс PersonBase
    /// </summary>
    public abstract class PersonBase
    {
        /// <summary>
        /// Возраст взрослого
        /// </summary>
        private int _age;

        /// <summary>
        /// Имя
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия
        /// </summary>
        private string _surname;

        /// <summary>
        /// Максимальный возраст
        /// </summary>
        public const int MaxAge = 120;

        /// <summary>
        /// Пол
        /// </summary>
        private GenderType _gender;
        
        /// <summary>
        /// Метод для работы с именем 
        /// </summary>
        public string Name
        {
            set => _name = ValidationNameAndSurname(value);
            get => _name;
        }

        /// <summary>
        /// Метод для работы с фамилией 
        /// </summary>
        public string Surname
        {
            set => _surname = ValidationNameAndSurname(value);
            get => _surname;
        }

        /// <summary>
        /// Метод для работы с возрастом 
        /// </summary>
        public int Age 
        {
            set => _age = AgeEntryRule(value);
            get => _age;
        }

        /// <summary>
        /// Метод для работы с полом 
        /// </summary>
        public GenderType Gender
        {
            set => _gender = value;
            get => _gender;
        }

        /// <summary>
        /// Констукрутор класса
        /// </summary>
        /// <param name="name">Имя персоны</param>
        /// <param name="surname">Фамилия персоны</param>
        /// <param name="age">Возраст персоны</param>
        /// <param name="gender">Пол персоны</param>
        //TODO:
        public PersonBase(string name, string surname,
            int age, GenderType gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Корректный ввод возраста персоны
        /// </summary>
        /// <param name="age">Возраст персоны</param>
        /// <returns>Корректный возраст</returns>
        protected abstract int AgeEntryRule(int age);

        /// <summary>
        /// Проверка правильности ввода имени и фамилии персоны
        /// </summary>
        /// <param name="nameOrSurname">Имя или фамилия для проверки</param>
        /// <returns>Корректное имя или фамилию</returns>
        protected string ValidationNameAndSurname(string nameOrSurname)
        {
            string nameOrSurnameCorrect = CorrectCaseNameAndSurname(
                nameOrSurname);
            SpellingNameAndSurname(nameOrSurnameCorrect);

            if (Name != null)
            {
                NameAndSurnameOnlyRusOrEng(nameOrSurnameCorrect);
            }

            return nameOrSurnameCorrect;
        }

        /// <summary>
        /// Преобразование имени или фамилии персоны в правильные регистры
        /// </summary>
        /// <param name="nameOrSurname">Имя или фамилия персоны</param>
        /// <returns>Корректное имя или фамилию 
        /// с точки зрения правильности регистра</returns>
        private string CorrectCaseNameAndSurname(string nameOrSurname)
        {
            char[] doubleNameOrSurname = { ' ', '-', ',' };
            string[] nameOrSurnameChar = nameOrSurname.Split(
                doubleNameOrSurname, StringSplitOptions.RemoveEmptyEntries);
            switch (nameOrSurnameChar.Length)
            {
                case 1:
                {
                    string capitalName = Convert.ToString(
                        nameOrSurnameChar[0]).Substring(1).ToLower();
                    nameOrSurname = Convert.ToString(
                        nameOrSurnameChar[0])[0].ToString().ToUpper()
                                    + capitalName;
                    return nameOrSurname;
                }
                case 2:
                {
                    string capitalName1 = Convert.ToString(
                        nameOrSurnameChar[0]).Substring(1).ToLower();
                    string capitalName2 = Convert.ToString(
                        nameOrSurnameChar[1]).Substring(1).ToLower();
                    nameOrSurname = Convert.ToString(
                            nameOrSurnameChar[0])[0].ToString().ToUpper() + 
                        capitalName1 + " " + Convert.ToString(
                            nameOrSurnameChar[1])[0].ToString().ToUpper() + 
                        capitalName2;
                    return nameOrSurname;
                }
                default:
                    throw new Exception("Неправильный ввод данных");
            }
        }

        /// <summary>
        /// Проверка имени или фамилии персоны на соответствие одному языку
        /// </summary>
        /// <param name="nameOrSurname">Имя или фамилия для проверки</param>
        private void SpellingNameAndSurname(string nameOrSurname)
        {
            Regex errorAlphabet = new Regex(
                "([a-z])([а-я])|([а-я])([a-z])|" +
                "([a-z]) ([а-я])|([а-я]) ([a-z])|([0-9])");
            if (errorAlphabet.IsMatch(nameOrSurname.ToLower()))
            {
                throw new Exception("Имя и Фамилия должны содержать \n" +
                    "только русские или только английские символы \n" +
                    "и не должны содержать цифры");
            }
        }

        /// <summary>
        /// Проверка фамилии персоны на соответствие языку, введеного имени
        /// </summary>
        /// <param name="surname">Фамилия для проверки</param>
        private void NameAndSurnameOnlyRusOrEng(string surname)
        {
            Regex rusAlphabet = new Regex("^[а-я]");
            
            if (!rusAlphabet.IsMatch(Name.ToLower()) 
                && rusAlphabet.IsMatch(surname.ToLower()) ||
                rusAlphabet.IsMatch(Name.ToLower()) 
                && !rusAlphabet.IsMatch(surname.ToLower()))
            {
                throw new Exception("Фамилия и имя " +
                    "должны быть написаны на одном языке");
            }
        }

        //TODO: Переименовать и сделать свойством
        /// <summary>
        /// Инфомация о персоне
        /// </summary>
        public abstract string Info();

        //TODO: XML
        public string ShortInfo => $"{Name} {Surname}";
    }
}
