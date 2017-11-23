using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Org.W3c.Dom;
using Xamarin.Forms;
[assembly: Dependency(typeof(TicTacToe.Droid.MyMethods))] //Edw kanw to reference gia na enwsw to service me to droid.
namespace TicTacToe.Droid
{
    class MyMethods : ICloseApp{
        public void Close_App()
        {
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }
    }
}