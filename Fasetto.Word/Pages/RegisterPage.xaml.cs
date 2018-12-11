﻿using System.Security;
using System.Windows.Controls;

namespace Fasetto.Word
{
    /// <summary>
    /// Логика взаимодействия для RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : BasePage<LoginViewModel> , IHavePassword
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The secure password fot this page
        /// </summary>
        public SecureString SecurePassword => PasswordText.SecurePassword;
    }
}
