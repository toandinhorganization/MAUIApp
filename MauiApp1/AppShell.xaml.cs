using CommunityToolkit.Mvvm.ComponentModel;
using MauiApp1.ModelViews;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        LoginModelView loginModelView = new LoginModelView();
        public AppShell()
        {
            InitializeComponent();

        }
        
        private bool _isAuthenticated;
        public bool IsAuthenticated
        {
            get => _isAuthenticated;
            set
            {
                if (_isAuthenticated != value)
                {
                    _isAuthenticated = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(IsNotAuthenticated));

                    // Navigate to appropriate section
                    if (value)
                    {
                        GoToAsync("//home"); // Navigate to home after login
                    }
                    else
                    {
                        GoToAsync("//login"); // Navigate to login
                    }
                }
            }
        }
        public bool IsNotAuthenticated => !IsAuthenticated;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        

        private void AuthenticateUser()
        {
            
        }

        //Switching between Login and Main Content
        private void AppContentSwitch()
        {
            
        }
    }
}
