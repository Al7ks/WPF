﻿namespace Fasetto.Word.Core
{ 
    /// <summary>
    /// A view model for a menu item
    /// </summary>
    public class MenuItemViewModel : BaseViewModel
    {
        /// <summary>
        /// The text to disaplay for the menu item
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The icon for this menu item
        /// </summary>
        public IconType Icon { get; set; }

        /// <summary>
        /// The type of this meny item
        /// </summary>
        public MenuItemType Type { get; set; }
    }
}
