namespace exemplo
{
    public partial class MainPage : ContentPage
    {
        string name = "";
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void OnMessageClicked(object sender, EventArgs e)
        {
            name = NameEntry.Text;
            MessageLabel.Text = $"Hello {name}!";
        }
    }
     

}
