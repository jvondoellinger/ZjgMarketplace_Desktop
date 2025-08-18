namespace FirstAppMAUI.Views;

public partial class LoginPage : ContentPage
{
    private string? _username;
    private readonly string _email = "jorge";
    private readonly string _password = "batata";
	public LoginPage()
	{
        InitializeComponent();
	}

    private async void SendLoginInputViewClicked(object sender, EventArgs e)
    {
        _username = await DisplayPromptAsync("Testing prompt", "Digite seu nome:");
        if (string.IsNullOrWhiteSpace(_username)) {
            await DisplayAlert("Invalid username", "Please, send a valid username!", "OK");
            return;
        }
        if (LoadingIndicator.IsRunning) return;
        
        // Show loading indicator
        LoadingGrid.IsVisible = true;
        LoadingIndicator.IsRunning = true;

        // Simulation a action
        await Task.Delay(2000);  
        
        // Closing loading indicator (indicator and grid)
        LoadingGrid.IsVisible = false;
        LoadingIndicator.IsRunning = false;
        
        //Get credential from view
        var credentials = GetDataFromViews();

        // Sample validate
        if (!credentials.Email.Equals(_email))
            await DisplayAlert("Invalid credential", "Incorrect email is provided!", "Ok");
        else if (!credentials.Password.Equals(_password))
            await DisplayAlert("Invalid credential", "Incorrect password is provided!", "Ok");
        else await DisplayAlert($"User: {_username} authorized!", "Version of tests, please, use a release version (case exists)", "Fechar");
    }

    private (string Email, string Password) GetDataFromViews() 
        => ( EmailInputView.Text, PasswordInputView.Text );
    
}