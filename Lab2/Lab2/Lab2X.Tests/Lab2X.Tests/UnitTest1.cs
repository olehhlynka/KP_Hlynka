using CPP_Lab2.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Maui.Devices;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using System.Net.Http;
using System.Text.Json;
using System;
using Xunit;


namespace Lab2X.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var viewModel = new MainViewModel();
            var expectedDateTime = DateTime.Now.ToString("F");
            Assert.Equal(expectedDateTime, viewModel.CurrentDateTime);
        }
    }
}