using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace IndexRangeTest.Uwp
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly int[] array = new[] { 1, 1, 4, 5, 1, 4 };
        private readonly string originalString =
"Seventeen beats of the drum, representing the trials and tribulations that befell Yumen the past year, both big and small.\r\nThe Catastrophe has passed. The storm has swept away the many colors in the sky.\r\nThe clouds burn bright red, scorched by the setting sun.\r\nHe walks forward, the wind and sand slowly wiping away his footprints. The great city of Yumen grows smaller in the distance.";

        public MainPage()
        {
            this.InitializeComponent();
        }

        public int[] SlicedArray
        {
            get
            {
                // We can't define GetSubArray<T> in UWP projects, use Span<T> instead
                return array.AsSpan()[2..].ToArray();
            }
        }

        public int LastElementInArray
        {
            get
            {
                return array[^1];
            }
        }

        public string LastSentenceOfString { get => originalString[^54..];}
        public string RepersentOfString { get => originalString[124..206];}
    }
}
