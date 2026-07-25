namespace Assginment07.Models;

public class CarColor
{
    public string Name { get; set; }
    public string Image { get; set; }
    public string ButtonClass { get; set; }

    public CarColor(string name, string image, string buttonClass)
    {
        Name = name;
        Image = image;
        ButtonClass = buttonClass;
    }
}