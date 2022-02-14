using System;

public class Class1
{
    public Class1()
    {
    }


    string[] cars = { "2013 Tesla Model S 89000", "2020 Lamborghini Huracan 2200000", "2015 Honda Civic 15000" };
    private void addCar()
    {
        string newCar = textBox1.Text;//will be pulled in via textbox
        List<string> list = new List<string>(cars.ToList());
        list.Add(newCar);
        cars = list.ToArray();
        MessageBox.Show("Your new car added is" + newCar);

        MessageBox.Show("Inventory update");

        for (int i = 0; i < cars.Length; i++)
        {
            MessageBox.Show(cars[i]);
        }
    }

    private void removeCar()
    {
        string remove = textBox2.Text;//will be pulled in via textbox
        int result = Int32.Parse(remove);
        List<string> carlist = new List<string>(cars.ToList());
        carlist.RemoveAt(result);
        cars = carlist.ToArray();
        string removedCar = carlist[result];

        Console.WriteLine("All current Inventory");


        for (int i = 0; i < cars.Length; i++)
        {
            MessageBox.Show(cars[i]);
        }

    }

    private void searchbyMake()
    {

        string search = textBox3.Text;
        string Mclaren = "Mclaren";
        string Lambo = "Lamborghini";
        string honda = "honda";
        string tesla = "tesla";

        if (search == Mclaren)
        {
            MessageBox.Show("You were searching for a 2018 Mclaren 720s 600000");
        }
        if (search == Lambo)
        {
            Console.WriteLine("You were searching for a 2020 Lamborghini Huracan 2200000");
        }
        if (search == honda)
        {
            MessageBox.Show("You were searching for a 2015 Honda Civic 15000");
        }
        if (search == tesla)
        {
            MessageBox.Show("2013 Tesla Model S 890000");
        }
    }
    private void searchByPartNum()
    {
        int j = Int16.Parse(textBox4.Text);


        string findByPartNumber = cars[j];

        MessageBox.Show("Searching");
        MessageBox.Show(findByPartNumber);
    }

    private void changeListing()
    {
        string removeCar = textBox5.Text;//will be pulled in via textbox
        string changeCar = textBox6.Text;
        int result = Int32.Parse(removeCar);
        List<string> list = new List<string>(cars.ToList());
        list.RemoveAt(result);
        list.Add(changeCar);
        cars = list.ToArray();
        MessageBox.Show("Chnage has been made listing now reads: " + changeCar);
    }

    private void inventory()
    {
        List<string> list = new List<string>(cars.ToList());
        Console.WriteLine("All current Inventory");


        for (int i = 0; i < cars.Length; i++)
        {
            MessageBox.Show(cars[i]);
        }

    }
}
