namespace Maui_Feng37_Bank
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = (Picker)sender;
            string selectedValue = (string)picker.SelectedItem;
            DisplayAlert("選擇結果", $"你選擇了：{selectedValue}", "確定");
        }

        private void Button1_Click1(object sender, EventArgs e)
        {
            DisplayAlert("鋒兄三七","Button1_Click1", "確定");
        }

        private void Button1_Click2(object sender, EventArgs e)
        {
            DisplayAlert("鋒兄三七", "Button1_Click2", "確定");
        }

        private void Button1_Click3(object sender, EventArgs e)
        {
            DisplayAlert("鋒兄三七", "Button1_Click3", "確定");
        }
    }

}
