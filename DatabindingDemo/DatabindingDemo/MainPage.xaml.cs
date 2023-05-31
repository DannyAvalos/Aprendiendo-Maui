//using Android.App;
using DatabindingDemo.Models;
using System.ComponentModel;

namespace DatabindingDemo;

public partial class MainPage : ContentPage
{
	Person person = new Person();

	public MainPage()
	{
		InitializeComponent();

        person = new DatabindingDemo.Models.Person
        {
            Name = "Jhon",
            Phone = "9999",
            Address = "X Address"
        };

        BindingContext = person;

    }

	private void OnCounterClicked(object sender, EventArgs e)
	{

		person.Name = "Peter";
		person.Phone = "0000";
		person.Address = "New Address";

		//person = new Person 
		//{

          //  Name = "Peter",
		//	Phone = "0000",
		//	Address = "New Address"

       // };

		//txtName.BindingContext = person;
		//txtName.SetBinding(Label.TextProperty, "Name");

		//creación del primer enlace
		//para crear un binding se necesitan 3 ingredientes
		//1. Especificar el origen de información
		//2. Especificar cual de todas las propiedades se quiere enlazar especificamente
		//3. Crear la relación entre el control y la propiedad
		//Binding personBinding =
			//new Binding();

		//personBinding.Source = person;
		//personBinding.Path = "Name";

		//txtName.SetBinding(Label.TextProperty, personBinding);

	}
}

