namespace lolekInterfejsy;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Button button = new Button
        {
            Text = "Miłego dnia przycisku 2 :P",
            WidthRequest = 500
        };

        button.Clicked += (sender, e) =>
        {
            button.Text = "Teraz mi milo :3";
        };

        Button button1 = new Button
        {
            Text = "Miłego dnia rownież przycisku 1 :P",
            WidthRequest = 500
        };

        button1.Clicked += (sender, e) =>
        {
            button1.Text = "Teraz mi milo :3";
        };

        Button button2 = new Button
        {
            Text = "Hej! Nie zapominajcie o mnie! O przycisku 3!!! >:(",
            WidthRequest = 500
        };

        button2.Clicked += (sender, e) =>
        {
            button2.Text = "Teraz mi NIE milo :(";
        };

        CheckBox czekbox = new CheckBox
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };

        Label labl = new Label
        {
            Text = "Kocham kotki",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };

        czekbox.CheckedChanged += (sender, e) =>
        {
            if(czekbox.IsChecked == true)
            {
                labl.Text = "Teraz to mozna romzawiac :3";
            }
            else
            {
                labl.Text = "Grrrrrrr";
            }
        };


        Button zgrupowanie1 = new Button
        {
            Text = "Klik1",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };

        Button zgrupowanie2 = new Button
        {
            Text = "Klik2",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };

        zgrupowanie1.Clicked += (sender, e) =>
        {
            zgrupowanie1.Text = "KLIKLES NAS!!!";
            zgrupowanie2.Text = "KLIKLES NAS!!!";
            zgrupowanie1.BackgroundColor = Color.FromRgb(180,180,180);
            zgrupowanie2.BackgroundColor = Color.FromRgb(180,180,180);
        };

        zgrupowanie2.Clicked += (sender, e) =>
        {
            zgrupowanie1.Text = "KLIKLES NAS (Ale w inny sposob :P)!!!";
            zgrupowanie2.Text = "KLIKLES NAS (Ale w inny sposob :P)!!!";
            zgrupowanie1.BackgroundColor = Color.FromRgb(110,110,110);
            zgrupowanie2.BackgroundColor = Color.FromRgb(110,110,110);
        };

        Content = new StackLayout
        {
            Children = { button, button1, button2, czekbox, labl, zgrupowanie1, zgrupowanie2 }
        };
    }

}

