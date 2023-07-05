namespace ClassLibraryK
{
	//Кабанова Ю.А. 31ИС
	//Класс - человек
	public class Person
	{
		// книги данного человека
		public string Name { get; set; }
		public string Address { get; set; }
		public List<Hobby> Hobbies = new List<Hobby>();
		public Person(string nm, string ad)
		{
			Name = nm;
			Address = ad;
		}
		public void ShowAll()
		{
			Console.WriteLine($"Человек: имя - {Name}, адрес - {Address}");
			Console.WriteLine("Список любимых занятий:");
			Hobbies.Sort();
			foreach (Hobby hobby in Hobbies) 
			{
				hobby.Show(); 
			}
		}

	}
}
