using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Evntr.Core.Controls
{
    public partial class SpeakerView : ContentView
    {
        public SpeakerView()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty AvatarUrlProperty =
            BindableProperty.Create(nameof(AvatarUrl), typeof(string), typeof(SpeakerView), "");

        public string AvatarUrl
        {
            get => (string)GetValue(AvatarUrlProperty);
            set => SetValue(AvatarUrlProperty, value);
        }

        public static readonly BindableProperty NameProperty =
            BindableProperty.Create(nameof(Name), typeof(string), typeof(SpeakerView), "");
        
        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }

        public static readonly BindableProperty MiniBioProperty =
            BindableProperty.Create(nameof(MiniBio), typeof(string), typeof(SpeakerView), "");

        public string MiniBio
        {
            get => (string)GetValue(MiniBioProperty);
            set => SetValue(MiniBioProperty, value);
        }

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(SpeakerView), Color.Black);

        public Color TextColor
        {
            get => (Color)GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }
    }
}
