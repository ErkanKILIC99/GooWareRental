using GooWareRental.BusinessLogicLayer.Abstracts;
using GooWareRental.Core.Utilities.IoC;
using System;
using Microsoft.Extensions.DependencyInjection;

using System.Windows.Forms;
using GooWareRental.BusinessLogicLayer.Concretes;
using DevCarRental.WinFormUI.Modules;
using GooWareRental.Entities.DataTransformationObjects;

namespace GooWareRental.AdministratorWinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*UserForRegisterDto _user = new UserForRegisterDto()
            {
                FirstName = "Erkan",
                LastName = "KILIÇÇ",
                Password = "root1234",
                Email = "erkan@kili1.com"
            };*/
            UserForLoginDto _user = new UserForLoginDto()
            {
                Email = "erkan@kili1.com",
                Password = "root1234"
            };

        MessageBox.Show(PostRequest.PostData(new Uri("https://localhost:44358/api/auth/login"), _user).ToString());
        }
}
}
