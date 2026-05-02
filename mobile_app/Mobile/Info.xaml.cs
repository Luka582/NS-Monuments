namespace PrvaApp;

[QueryProperty(nameof(Rez), "info")]
public partial class Info : ContentPage
{
	public Info()
	{
		InitializeComponent();
    }
	RecognitionResult rez;
	public RecognitionResult Rez
	{
		set
		{
			if (MainPage.jezikclicks == 1)
			{

			}
			rez = value;
            this.Title = value.MonumentName;
            slika.Source = ImageSource.FromStream(() => FileSystem.OpenAppPackageFileAsync(Rezultat.NadjiSliku(value.MonumentName)).Result);
            tekst.Text = value.Description;
        }
	}
}