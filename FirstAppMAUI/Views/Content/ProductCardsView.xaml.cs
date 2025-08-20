using FirstAppMAUI.ViewModel.Cards;
using System.Collections.ObjectModel;

namespace FirstAppMAUI.Views.Content;

public partial class ProductCardsView : ContentView
{
	public static readonly BindableProperty ViewModelProperty = BindableProperty.Create(
		nameof(ViewModel),
		typeof(ObservableCollection<ProductViewModel>),
		typeof(ProductCardsView),
		new ObservableCollection<ProductViewModel>(),
		propertyChanged: OnViewModelChanged);

    public ObservableCollection<ProductViewModel> ViewModel
	{
		get => (ObservableCollection<ProductViewModel>) GetValue(ViewModelProperty);
		set => SetValue(ViewModelProperty, value);
	}

    public ProductCardsView()
	{
		InitializeComponent();
        this.FlexLayoutBindableLayoutSetup();
    }

    private static void OnViewModelChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (ProductCardsView)bindable;
        control.UpdateItemsSource();
    }

    private void FlexLayoutBindableLayoutSetup()
	{
		BindableLayout.SetItemsSource(FlexLayoutContainer, ViewModel);
	}

    private void UpdateItemsSource()
    {
        if (FlexLayoutContainer != null)
            BindableLayout.SetItemsSource(FlexLayoutContainer, ViewModel);
    }
}