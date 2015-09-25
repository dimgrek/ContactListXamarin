﻿using System.Windows.Input;
using ContacListXamarin.Contacts;
using Xamarin.Forms;

namespace ContacListXamarin.Views
{
    public partial class AddContactPage : ContentPage
    {
        readonly IContactService _contactService = new ContactService();

        public AddContactPage()
        {
            InitializeComponent();
            SaveCommand = new Command(Add);
            CancelCommand = new Command(Cancel);
            BindingContext = this;

        }

        public ICommand TransferInfoCommand { get; private set; }

        public ICommand SaveCommand { get; private set; }
        public ICommand CancelCommand { get; private set; }

        async void Cancel()
        {
            await Navigation.PopAsync();
        }


        async void Add()
        {
            _contactService.Add(Name.Text, LastName.Text, Address.Text, Email.Text, Telephone.Text, Company.Text);
            await Navigation.PopAsync();
        }
    }
}
