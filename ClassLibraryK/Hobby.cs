using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryK
{
	//Кабанова Ю.А. 31ИС
	//Класс - хобби
		public class Hobby : IComparable<Hobby>
		{
			public string Name { get; set; }
			public string Description { get; set; }
			public Hobby(string nm, string descr)
			{
				Name = nm;
				Description = descr;
			}
			public void Show()
			{
				Console.WriteLine(
					 $"Название: {Name}, Описание - {Description}");
			}
			public int CompareTo(Hobby? other)
			{
				return Name.CompareTo(other.Name);
			}
		}
	}

