using Practical_11.Models;
using System;
using System.Collections.Generic;

namespace Practical_11.Data
{
	public static class DataClass
	{
		private static List<User> _users = new List<User>();

		static DataClass()
		{
			for (int i = 0; i < 10; i++)
			{
				_users.Add(new User()
				{
					Id = i,
					Name = $"Test{i}",
					DOB = DateTime.Today.ToString("yyyy-MM-dd"),//Now.Date.ToString(),
					Address = $"hello this is address! {i * 11232}"
				});
			}
		}

		public static List<User> Users()
		{
			return _users;
		}

		public static void DeleteUser(int id)
		{
			_users.Remove(_users.Find(x => id == x.Id));
		}

		public static User GiveMeUser(int id)
		{
			return _users.Find(x => x.Id == id);
		}

		public static void AddUser(User user)
		{
			user.Id = _users.Count;
			_users.Add(user);
		}

		public static void UpdateUser(User user)
		{
			var temp = _users.Find(x => x.Id == user.Id);
			if (temp != null)
			{
				temp.Name = user.Name;
				temp.Address = user.Address;
				temp.DOB = user.DOB;
			}
		}



	}
}