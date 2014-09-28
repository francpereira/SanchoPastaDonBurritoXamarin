using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;
using FoodTruckClassLibrary;

namespace FoodTruckiOS
{
	partial class MenuPagerViewController : UIPageViewController
	{
		MenuManager menuManager;

		public MenuPagerViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.TabBarController.TabBar.TintColor = UIColor.Red;

			menuManager = new MenuManager ();
			menuManager.GetAllMenuOptions ();

			MenuViewController firstMenuViewController = CreateMenuViewController ();

			SetViewControllers (new UIViewController[]{ firstMenuViewController },
				                    UIPageViewControllerNavigationDirection.Forward,
				                    false,
		   		                    null);

			this.GetNextViewController = GetMenuNextViewController;
			this.GetPreviousViewController = GetMenuPreviousViewController;
		}



		private MenuViewController CreateMenuViewController()
		{
			MenuViewController menuViewController = (MenuViewController)this.Storyboard.InstantiateViewController ("MenuViewController");
			menuViewController.menuOption = menuManager.CurrentMenuOption ();
			menuViewController.MenuOptionPosition = menuManager.CurrentPosition;

			return menuViewController;

		}

		public UIViewController GetMenuNextViewController(UIPageViewController pageViewController,
			                                          UIViewController referenceViewController )
		{
			MenuViewController returnViewController = null;

			MenuViewController referencedMenuViewController = referenceViewController as MenuViewController;

			if (referencedMenuViewController != null) {

				menuManager.MoveTo (referencedMenuViewController.MenuOptionPosition);

				if (menuManager.CanMoveNext) {
				   
					menuManager.MoveNext ();
					returnViewController = CreateMenuViewController();
				}
			
			}

			return returnViewController;
		}

		public UIViewController GetMenuPreviousViewController(UIPageViewController pageViewController,
			UIViewController referenceViewController )
		{
			MenuViewController returnViewController = null;

			MenuViewController referencedMenuViewController = referenceViewController as MenuViewController;

			if (referencedMenuViewController != null) {

				menuManager.MoveTo (referencedMenuViewController.MenuOptionPosition);

				if (menuManager.CanMovePrevious) {

					menuManager.MovePrevious ();
					returnViewController = CreateMenuViewController();
				}

			}

			return returnViewController;
		}
	}
}
