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
				name = "Burrito de Pernil",
				description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc orci eros, vestibulum vel ultrices suscipit, varius in ante. Ut ultrices convallis gravida. Proin eu semper massa. Suspendisse lacinia ullamcorper faucibus.",
				price = 5.00m,
				imageFile = "BurritoPernil.jpg"
			});

			menu.Add (new MenuOption () { 
				name = "Tacos de Lengua",
				description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc orci eros, vestibulum vel ultrices suscipit, varius in ante. Ut ultrices convallis gravida. Proin eu semper massa. Suspendisse lacinia ullamcorper faucibus.",
				price = 7.00m,
				imageFile = "TacosLengua.jpg"
			});

			menu.Add (new MenuOption () { 
				name = "Pasta con Churrasco",
				description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc orci eros, vestibulum vel ultrices suscipit, varius in ante. Ut ultrices convallis gravida. Proin eu semper massa. Suspendisse lacinia ullamcorper faucibus.",
				price = 5.50m,
				imageFile = "PastaChurrasco.jpg"
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

		public MenuOption CurrentMenuOption()
		{
			return menu[currentIndex];
		}



	}
}

