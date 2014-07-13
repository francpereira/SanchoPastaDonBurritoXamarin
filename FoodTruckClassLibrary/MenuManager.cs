using System;
using System.Collections.Generic;

namespace FoodTruckClassLibrary
{
	public class MenuManager
	{
		private List<MenuOption> menu;
		private int currentIndex = 0;

		public MenuManager ()
		{
			menu = new List<MenuOption> ();
		}

		public void GetAllMenuOptions ()
		{

			menu.Add (new MenuOption () { 
				name = "Burrito Sencillo",
				description = "Una sola carne para escoger entre pollo, molida, pernil o churrasco. Sale al plato con nachos e incluye bebida.",
				price = 5.00m,
				imageFile = "burritosmall"
			});

			menu.Add (new MenuOption () { 
				name = "Burrito Mixto",
				description = "Dos carnes para escoger entre pollo, molida, pernil o churrasco. Sale al plato con nachos e incluye bebida.",
				price = 6.00m,
				imageFile = "burritosmall"
			});

			menu.Add (new MenuOption () { 
				name = "Burropleta",
				description = "Tres carnes para escoger entre pollo, molida, pernil o churrasco. Sale al plato con nachos e incluye bebida.",
				price = 7.00m,
				imageFile = "burritosmall"
			});

			menu.Add (new MenuOption () { 
				name = "Don Burrito",
				description = "Burrito con todas las carnes pollo, molida, pernil y churrasco. Sale al plato con nachos e incluye bebida.",
				price = 7.00m,
				imageFile = "burritosmall"
			});

			menu.Add (new MenuOption () { 
				name = "Quesadilla Sencilla",
				description = "Una sola carne para escoger entre pollo, molida, pernil o churrasco. Incluye bebida.",
				price = 6.00m,
				imageFile = "tacosmall"
			});

			menu.Add (new MenuOption () { 
				name = "Quesadilla Mixta",
				description = "Dos carnes para escoger entre pollo, molida, pernil o churrasco. Incluye bebida.",
				price = 7.00m,
				imageFile = "tacosmall"
			});

			menu.Add (new MenuOption () { 
				name = "Ensalada del dia",
				description = "Ensalada Fresca con . Incluye bebida.",
				price = 6.00m,
				imageFile = "ensaladasmall"
			});

			menu.Add (new MenuOption () { 
				name = "Crema o Sopa del Dia",
				description = "Rica sopa pa los dias lluviosos. Incluye pan con ajo",
				price = 4.00m,
				imageFile = "ensaladasmall"
			});

			menu.Add (new MenuOption () { 
				name = "Pasta con Pollo",
				description = "Escoge entre Spaguettis, Penne, Rottini o Fettuccini. Incluye bebida y pan con ajo o amarillos.",
				price = 7.00m,
				imageFile = "pastasmall"
			});

			menu.Add (new MenuOption () { 
				name = "Pasta con Albondiga",
				description = "Escoge entre Spaguettis, Penne, Rottini o Fettuccini. Incluye bebida y pan con ajo o amarillos.",
				price = 8.00m,
				imageFile = "pastasmall"
			});

			menu.Add (new MenuOption () { 
				name = "Pasta con Vegetales",
				description = "Escoge entre Spaguettis, Penne, Rottini o Fettuccini. Incluye bebida y pan con ajo o amarillos.",
				price = 7.00m,
				imageFile = "pastasmall"
			});

			menu.Add (new MenuOption () { 
				name = "Pasta con Churrasco",
				description = "Escoge entre Spaguettis, Penne, Rottini o Fettuccini. Incluye bebida y pan con ajo o amarillos.",
				price = 8.00m,
				imageFile = "pastasmall"
			});

			menu.Add (new MenuOption () { 
				name = "Lasagna del dia",
				description = "Incluye bebida y pan con ajo o amarillos.",
				price = 7.00m,
				imageFile = "burritosmall"
			});

		}


		public void MoveFirst()
		{
			currentIndex = 0;
		}

		public void MovePrevious()
		{
			if (currentIndex > 0) {
				--currentIndex;
			}
		}

		public void MoveNext()
		{
			if (currentIndex < (menu.Count - 1)) {
				++currentIndex;
			}
		}

		public int Length { get { return menu.Count; } }
	

		public void MoveTo(int position)
		{
			if (position >= 0 && position <= (menu.Count - 1)) {
				currentIndex = position;
			}
		}

		public MenuOption CurrentMenuOption()
		{
			return menu[currentIndex];
		}



	}
}

