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
				name = "Burritos",
				description = "Puedes escoger entre pollo, molida, pernil o churrasco. Sale al plato con nachos e incluye bebida. Puedes añadir otra carne por solo 1 dolar más.",
				price = 5.00m,
				imageFile = "burrito1"
			});

		
			menu.Add (new MenuOption () { 
				name = "Quesadillas",
				description = "Una sola carne para escoger entre pollo, molida, pernil o churrasco. Incluye bebida. Puedes añadir otra carne por solo 1 dolar más.",
				price = 6.00m,
				imageFile = "quesadilla1"
			});


			menu.Add (new MenuOption () { 
				name = "Ensalada del dia",
				description = "Ensalada Fresca con . Incluye bebida.",
				price = 6.00m,
				imageFile = "ensalada1"
			});

			menu.Add (new MenuOption () { 
				name = "Crema o Sopa del Dia",
				description = "Rica sopa pa los dias lluviosos. Incluye pan con ajo",
				price = 4.00m,
				imageFile = "sopa1"
			});

			menu.Add (new MenuOption () { 
				name = "Pastas",
				description = "Escoge entre Spaguettis, Penne, Rottini o Fettuccini. Incluye bebida y pan con ajo o amarillos. Ponle albondigas o churrasco por solo 1 dolar más.",
				price = 7.00m,
				imageFile = "pasta1"
			});

	
			menu.Add (new MenuOption () { 
				name = "Lasagna del dia",
				description = "Incluye bebida y pan con ajo o amarillos.",
				price = 7.00m,
				imageFile = "lasagna1"
			}); 


			menu.Add (new MenuOption () { 
				name = "3 Tacos",
				description = "Puedes escoger entre pollo, molida, pernil o churrasco. 2 tacos mas por solo 2 dolares. Cada carne adicional solo 1 dolar mas. Incluye bebida.",
				price = 5.00m,
				imageFile = "tacos1"
			}); 

			menu.Add (new MenuOption () { 
				name = "Nachos",
				description = "Puedes escoger entre pollo, molida, pernil o churrasco. Cada carne adicional solo 1 dolar mas. Incluye bebida.",
				price = 6.00m,
				imageFile = "nachos1"
			});
		}


		public void MoveFirst()
		{
			currentIndex = 0;
		}

		public void MovePrevious()
		{
			if (CanMovePrevious) {
				--currentIndex;
			}
		}

		public bool CanMovePrevious {
			get { 

				if (currentIndex > 0) {
					return true;
				} else {
					return false;
				}
			}

		}

		public void MoveNext()
		{
			if (CanMoveNext) {
				++currentIndex;
			}
		}

		public bool CanMoveNext {
			get { 
			
				if (currentIndex < (menu.Count - 1)) {
					return true;
				} else {
					return false;
				}
			}

		}

		public int Length { get { return menu.Count; } }
	

		public void MoveTo(int position)
		{
			if (position >= 0 && position <= (menu.Count - 1)) {
				currentIndex = position;
			} else
			{
				throw new Exception ("MoveTo Inndex Out of Range " + position);
			}
		}

		public MenuOption CurrentMenuOption()
		{
			return menu[currentIndex];
		}

		public int CurrentPosition
		{
			get { return currentIndex; }
		}



	}
}

