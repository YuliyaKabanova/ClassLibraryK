using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryK;

namespace AppK
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person("Морозова Александра Викторовна", " г. Москва, Озерная ул., д. 13");
			person.Hobby.Add(new Hobbies("Кулинария", "Эксперименты с приготовлением разных блюд, выпечка."));
			person.Hobby.Add(new Hobbies("Каллиграфия", "Навык красивого письма, который развивает внимательность."));
			person.Hobby.Add(new Hobbies("Йога", "Практика, которая сочетает в себе дыхание, растяжку и медитацию."));
			person.Hobby.Add(new Hobbies("Программирование", "Написание программ на языках программирования."));
			person.ShowAll();
			Console.ReadKey();
		}
	}
}
